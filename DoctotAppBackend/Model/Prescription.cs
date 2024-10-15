using System.ComponentModel.DataAnnotations;
using DoctotAppBackend.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;


namespace DoctotAppBackend.Model
{
    public class Prescription
    {
        [Key]
        [Required]
        public int PrescriptionId { get; set; }

        public int PatientId { get; set; }

        [Required]
        [StringLength(500)]
        public string Medication { get; set; } = "";

        [Required]
        public string? Date { get; set; }
        [Required]
        public string? dosage { get; set; }
    }


}