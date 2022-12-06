using System;
namespace GenealogySite.Models
{
    public class Relation
    {
        public Relation()
        {
            public int PrimaryId { get; set; }
            public int SecondaryId { get; set; }
            public string? RelationType { get; set; } // Parent, Child, Partner
        }
    }
}

