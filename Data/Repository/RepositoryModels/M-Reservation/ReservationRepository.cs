﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels.M_Reservation
{
    public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        private readonly DatabaseContext DatabaseContext;

        public ReservationRepository(DatabaseContext DatabaseContext) : base(DatabaseContext)
        {
            this.DatabaseContext = DatabaseContext;
        }
        public void CreateReservation(Reservation Reservation)
        {
            Add(Reservation);
            SaveChange();
        }

        public void DeleteReservation(Guid ReservationId)
        {
            var respone = DatabaseContext.Reservations.FirstOrDefault(e => e.Id == ReservationId);
            respone.IsDeleted = true;
            SaveChange();
        }

        public Reservation GetReservation(Guid ReservationId)
        {
            var response = Get(e => e.Id == ReservationId &&!e.IsDeleted, new[]
            {
              "Service",
              "Appointment",
              "User"
            });
            return response;
        }

        public List<Reservation> GetReservations()
        {
            var respone = All(new[]
            {
              "Service",
              "Appointment",
              "User"
            })
                         .Where(e => e.IsDeleted == false)
                         .ToList();
            return respone;
        }

        public void UpdateReservation(Guid ReservationId)
        {
            
        }
    }
}