﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsi.Template.Core.Abstractions;

namespace Tsi.Template.Domain.Grh
{
    public class Departement : BaseEntity
    {
        public String code { get; set; }
        public String Libelle { get; set; }
    }
}
