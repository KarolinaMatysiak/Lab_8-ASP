﻿using System;
using System.Collections.Generic;

namespace Lab8_ASP.Models.Movies;

public partial class MovieCompany
{
    public int? MovieId { get; set; }

    public int? CompanyId { get; set; }

    public virtual ProductionCompany? Company { get; set; }

    public virtual Movie? Movie { get; set; }
}
