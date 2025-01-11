README për Projektin "ProjectRickAndMorty"
Përshkrimi i Projektit:
Ky projekt është një aplikacion ASP.NET Core MVC që përdor API-në "Rick and Morty" për të shfaqur informacione mbi personazhet e serialit. Gjithashtu mbështet lokalizimin për dy gjuhë: anglisht (en) dhe gjermanisht (de).

Struktura e Projektit:
Controllers

CharactersController.cs: Menaxhon logjikën për shfaqjen e personazheve nga API-ja.
HomeController.cs: Përmban veprime për faqet kryesore dhe ndryshimin e gjuhës.
Models

CharacterModel.cs: Përfaqëson modelin e një personazhi.
RickAndMortyAPIResponseModel.cs: Përdoret për strukturimin e të dhënave nga API.
ErrorViewModel.cs: Përdoret për menaxhimin e gabimeve.
Resources

Resources.resx: Përmban përkthime për anglisht.
Resources.de.resx: Përmban përkthime për gjermanisht.
Views

Home:
Index.cshtml: Faqja kryesore me opsione për filtrimin e personazheve.
Privacy.cshtml: Faqja për privatësinë.
Shared:
_Layout.cshtml: Struktura kryesore e layout-it.
_ValidationScriptsPartial.cshtml dhe Error.cshtml: Menaxhimi i validimeve dhe gabimeve.
Konfigurime të tjera

Program.cs: Përfshin konfigurimin e lokalizimit dhe inicializimin e projektit.
appsettings.json: Mbështet konfigurime për projektin.
