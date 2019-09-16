﻿using System;
using System.Collections.Generic;

namespace Persistencia_NetCore.Entities
{
    public partial class Actor
    {
        public Actor()
        {
            FilmActor = new HashSet<FilmActor>();
        }

        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<FilmActor> FilmActor { get; set; }
    }
}
