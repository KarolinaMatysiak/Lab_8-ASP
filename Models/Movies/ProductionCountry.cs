﻿using System;
using System.Collections.Generic;

namespace Lab8_ASP.Models.Movies;

public partial class ProductionCountry
{
    public int? MovieId { get; set; }

    public int? CountryId { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Movie? Movie { get; set; }
}
