﻿namespace Domain.Models
{
    public class Service
    {
        public Service()
        {
            Id = Guid.NewGuid();
            Appointments = new List<Appointment>();
            Evaluations = new List<Evaluation>();
            Reservations = new List<Reservation>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Guid ServiceOwnerId { get; set; }
        public ServiceOwner ServiceOwner { get; set; }
        public Guid CategoryServiceId { get; set; }
        public CategoryService CategoryService { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Evaluation> Evaluations { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
        public Guid SectorId { get; set; }
        public Sector Sector { get; set; }
    }
}