namespace Portfolio.App.Components.Experiences;

public partial class Experiences
{
    private IEnumerable<Models.Experience> _experiences = new HashSet<Models.Experience>{
        new Models.Experience{
            Title="Développeur Full Stack .Net(C#) - Ebp Informatique",
            Date="Mar 2020 À Jan 2024",
            ExperienceDetails = new HashSet<Models.ExperienceDetail>{
                new Models.ExperienceDetail{
                    Title = "Portail d'espace utilisateur permettant la gestion des informations utilisateurs (informations personnelles, factures, collaborateurs...)",
                    Details = new HashSet<string> {
                        "Portail web en Blazor wasm",
                        "Interface API Rest en .Net 7 agrégeant les informations pour le portail",
                        "Tests unitaire utilisant xUnit, Moq et Bogus",
                        "Tests d'intégration via collection Postman",
                        "Mise en place du CICD pour le déploiement sur AKS avec Helm"
                    }
                },
                new Models.ExperienceDetail{
                    Title = "Portail d'authentification utilisé pour connecter les utilisateurs aux applications d'EBP avec une authentification unique (SSO)",
                    Details = new HashSet<string> {
                        "Portail web en Asp.Net Razor utilisant le nuget Identity Server 4 pour appliquer l'OpenID Connect (OIDC)",
                        "Interface API Rest en .Net 6 permettant de manager les informations utilisateurs",
                        "Tests unitaire en xUnit avec Moq et Bogus",
                        "Tests d'intégration via collection Postman",
                        "Monitoring avec Rancher, grafana et ELK",
                        "Mise en place du CICD pour le déploiement sur AKS avec Helm"
                    }
                },
                new Models.ExperienceDetail{
                    Title = "Outils Associés",
                    Details = new HashSet<string> {
                        "Minimal API d'envoi de SMS utilisé pour la double authentification (2FA)",
                        "Console d'administration en Blazor wasm pour la gestion des clients lié à l'OIDC",
                        "Interface API Rest en .Net 6 utilisé par la console d'administration"
                    }
                },
                new Models.ExperienceDetail{
                    Title = "Collaborations",
                    Details = new HashSet<string> {
                        "Nuget pour la récupération des informations utilisateurs provenant d'un token JWT",
                        "Accompagnement à l'utilisation de l'OIDC",
                        "Documentation sur des wiki",
                        "Pair progamming avec plusieurs collègues"
                    }
                }
            }
        },
        new Models.Experience{
            Title="Développeur Full Stack .Net(C#) - Ausy",
            Date="Oct 2019 - Fév 2020",
            ExperienceDetails = new HashSet<Models.ExperienceDetail>{
                new Models.ExperienceDetail{
                    Title = "Talon est l'outil permettant de faire des calculs de distance pour le raccordement électrique d'un habitat",
                    Details = new HashSet<string> {
                        "Service windows en .Net Framework 4.8",
                        "Tests Unitaire en xUnit"
                    }
                },
                new Models.ExperienceDetail{
                    Title = "Outil de traduction",
                    Details = new HashSet<string> {
                        "Librairies python"
                    }
                }
            }
        },
        new Models.Experience{
            Title="Développeur Full Stack .Net(C#) (Alternance) - Ebp Informatique",
            Date="Nov 2016 À Oct 2019",
            ExperienceDetails = new HashSet<Models.ExperienceDetail>{
                new Models.ExperienceDetail{
                    Title = "Licence, outil permettant la gestion des licences des logiciels EBP",
                    Details = new HashSet<string> {
                        "Correction de bug de l'outil en .Net Framework 4.8",
                        "Intervention en base de donnée pour correction des informations"
                    }
                },
                new Models.ExperienceDetail{
                    Title = "WCF Dev, outil mettant à disposition des informations auprès des logiciels EBP",
                    Details = new HashSet<string> {
                        "Correction de bug de l'outil en .Net Framework 4.8",
                        "Script SQL pour correction des informations en base de données",
                        "Ajout de fonctionnalité"
                    }
                },
                new Models.ExperienceDetail{
                    Title = "Migration",
                    Details = new HashSet<string> {
                        "Création d'API en .Net 6",
                        "Utilisation de Git",
                        "Mise en place du CICD pour le déploiement depuis Azure DevOps"
                    }
                },
                new Models.ExperienceDetail{
                    Title = "Collaborations",
                    Details = new HashSet<string> {
                        "Accompagnement des membres de l'équipe à l'utilisation d'Azure DevOps",
                        "Pair programming"
                    }
                }
            }
        },
        new Models.Experience{
            Title="Développeur Full Stack .Net(C#) - Geser Best",
            Date="Oct 2015 À Sep 2016",
            ExperienceDetails = new HashSet<Models.ExperienceDetail>{
                new Models.ExperienceDetail{
                    Title = "Outil de traduction",
                    Details = new HashSet<string> {
                        "Ajout de fonctionnalité en .Net Framework 4.8 pour la traduction de programme d'un langage vers un autre"
                    }
                },
                new Models.ExperienceDetail{
                    Title = "Portail utilisateur utilisé pour l'affichage des informations utilisateurs",
                    Details = new HashSet<string> {
                        "Maintenance du portail en Php"
                    }
                }
            }
        },
        new Models.Experience{
            Title="Développeur Full Stack .Net(C#)/ Php - Atlimate",
            Date="Févr 2015 À Août 2015",
            ExperienceDetails = new HashSet<Models.ExperienceDetail>{
                new Models.ExperienceDetail{
                    Title = "Boutique",
                    Details = new HashSet<string> {
                        "Nouvelles fonctionnalités en Php"
                    }
                }
            }
        },
        new Models.Experience{
            Title="Développeur Web Php (Alternance) - ECPIM Dometech",
            Date="Févr 2015 À Août 2015",
            ExperienceDetails = new HashSet<Models.ExperienceDetail>{
                new Models.ExperienceDetail{
                    Title = "Dometech",
                    Details = new HashSet<string> {
                        "Ajout de fonctionnalités en Php"
                    }
                }
            }
        }
    };
}