﻿using System;

namespace poprawa_kolokwium_S18288.Entities
{
    public class Membership
    {
        public Member Member { get; set; }
        public Team Team { get; set; }
        public DateTime MembershipDate { get; set; }
    }
}
