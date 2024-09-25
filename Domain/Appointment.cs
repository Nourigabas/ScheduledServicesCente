﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    //مواعيد
    public class Appointment
    {
        public Guid Id { get; set; }
        public DateTime TheAppointment { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsBooked { get; set; } = false;
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        public Guid? ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
    }
}