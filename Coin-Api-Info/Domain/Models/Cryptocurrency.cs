﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models;

public class Cryptocurrency
{
    public Guid Id { get; set; }

    public string Symbol { get; set; }

    public string Name { get; set; }

    public virtual CryptocurrencyPrice Price { get; set; }
}
