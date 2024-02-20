using Microsoft.AspNetCore.Components;

namespace Portfolio.App.Components.Projects;

public partial class Projects
{
    [Inject] public NavigationManager NavigationManager { get; set; }
    IEnumerable<Models.Project> ProjectsModel = new HashSet<Models.Project>{
        new Models.Project{
            Content="Application web pour le portfolio",
            Link = "https://github.com/brendanGiraudet/Portfolio",
            Title = "Portfolio"
        },
        new Models.Project{
            Content="Application de recette permettant de gerer des recettes, des ingrédients, des nutrimentsafin de selectionner automatiquement des recettes en fonction d'un profile et de générer la liste des courses associées",
            Link = "https://github.com/brendanGiraudet/baka-chief",
            Title = "Application recette"
        },
        new Models.Project{
            Content="Api permettant d'envoyer des logs dans ELK",
            Link = "https://github.com/brendanGiraudet/ELKApi",
            Title = "ELK Api"
        },
        new Models.Project{
            Content="Login perso pour le SSO, Utilisant le nuget Identity Server 4 pour faire du OIDC",
            Link = "https://github.com/brendanGiraudet/Login",
            Title = "Login"
        },
        new Models.Project{
            Content="Jeu du morpion",
            Link = "https://github.com/brendanGiraudet/Morpion",
            Title = "Application Morpion"
        },
        new Models.Project{
            Content="Nuget permettant d'interagir avec Azure DevOps pour la récupération des WorkiIems par exemple",
            Link = "https://github.com/brendanGiraudet/QueryCommandAzDV",
            Title = "Nuget AzureDevops"
        },
        new Models.Project{
            Content="Projet de renommage de fichier pour les saisons de series utilisé dans Plex",
            Link = "https://github.com/brendanGiraudet/RenameFiles",
            Title = "RenameFiles"
        }
    };

    private void RedirectToProject(string projectLink)
    {
        NavigationManager.NavigateTo(projectLink);
    }
}