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
        [Display(Name = "Primär")]
        public int Primary { get; set; }
        [Display(Name = "Sekundär")]
        public int Secondary { get; set; }
        [Display(Name = "Relationstyp")]
        public string Type { get => relation; set => relation = value; } // Relationstyp
    }
}