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

        public async Task<IActionResult> Index(string status = "", string species = "", string sortBy = "name", int page = 1)
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

            var response = await _client.SendQueryAsync<RickAndMortyAPIResponseModel>(request);

            // Përpunimi i të dhënave dhe siguria që të gjitha fushat janë të tipit string
            var characters = response.Data.Characters.Results.Select(c => new CharacterModel
            {
                Name = c.Name?.ToString() ?? "Unknown",
                Status = FormatStatus(c.Status?.ToString() ?? "Unknown"),
                Species = c.Species?.ToString() ?? "Unknown",
                Gender = c.Gender?.ToString() ?? "Unknown",
                Origin = c.Origin?.Name?.ToString() ?? "Unknown"
            }).ToList();

            switch (sortBy.ToLower())
            {
                case "name":
                    characters = characters.OrderBy(c => c.Name).ToList();
                    break;
                case "origin":
                    characters = characters.OrderBy(c => c.Origin).ToList();
                    break;
            }

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
