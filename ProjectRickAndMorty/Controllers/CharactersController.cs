using ProjectRickAndMorty.Models;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRickAndMorty.Controllers
{
    public class CharactersController : Controller
    {
        private readonly GraphQLHttpClient _client;

        public CharactersController()
        {
            // Vendos linkun e saktë për Rick and Morty GraphQL API
            _client = new GraphQLHttpClient("https://rickandmortyapi.com/graphql", new NewtonsoftJsonSerializer());
        }

        public async Task<IActionResult> Index(string status = null, string species = null, string sortBy = "name", int page = 1)
        {
            var query = @"
            query ($page: Int, $status: String, $species: String) {
                characters(page: $page, filter: {status: $status, species: $species}) {
                    results {
                        name
                        status
                        species
                        gender
                        origin {
                            name
                        }
                    }
                }
            }";

            var variables = new { page, status, species };
            var request = new GraphQLRequest
            {
                Query = query,
                Variables = variables
            };

            var response = await _client.SendQueryAsync<dynamic>(request);
            var charactersData = response.Data.characters.results;

            // Përpunimi i të dhënave dhe siguria që të gjitha fushat janë të tipit string
            var characters = ((IEnumerable<dynamic>)charactersData).Select(c => new Character
            {
                Name = c.name?.ToString() ?? "Unknown",
                Status = FormatStatus(c.status?.ToString() ?? "Unknown"),
                Species = c.species?.ToString() ?? "Unknown",
                Gender = c.gender?.ToString() ?? "Unknown",
                Origin = c.origin?.name?.ToString() ?? "Unknown"
            }).ToList();


            // Renditja sipas kërkesës
            switch (sortBy.ToLower())
            {
                case "name":
                    characters = characters.OrderBy(c => c.Name).ToList();
                    break;
                case "origin":
                    characters = characters.OrderBy(c => c.Origin).ToList();
                    break;
            }

            // Dërgimi i variablave në pamjen (View)
            ViewBag.Status = status;
            ViewBag.Species = species;
            ViewBag.SortBy = sortBy;
            ViewBag.Page = page;

            return View(characters);
        }

        private string FormatStatus(string status)
        {
            return status switch
            {
                "Alive" => "🟢 Alive",
                "Dead" => "🔴 Dead",
                _ => "⚪ Unknown"
            };
        }
    }
}
