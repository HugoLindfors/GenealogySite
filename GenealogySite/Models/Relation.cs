using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

// dotnet-aspnet-codegenerator controller -name RelationsController -m Relation -dc GenealogySiteContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite -f

namespace GenealogySite.Models
{
    public class Relation
    {
        private string relation = "";

        public int Id { get; set; }
        public int Primary { get; set; }
        public int Secondary { get; set; }
        [Display(Name = "Relation")]
        public string Type { get => relation; set => relation = value; } // Relationstyp
    }
}