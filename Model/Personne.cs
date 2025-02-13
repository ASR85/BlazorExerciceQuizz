using System.ComponentModel.DataAnnotations;

namespace BlazorExerciceQuizz.Model
{
    public class Personne
    {
        [Required]
        public string Nom { get; set; }


        [Required]
        public string Prenom { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }


        public string TypePersonne { get; set; }


        public string Couleur { get; set; }
    }


    public enum TypePersonne
    {
    }
}
