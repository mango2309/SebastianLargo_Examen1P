using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SebastianLargo_Examen1P.Models;

namespace SebastianLargo_Examen1P.Data
{
    public class SebastianLargo_Examen1PContext : DbContext
    {
        public SebastianLargo_Examen1PContext (DbContextOptions<SebastianLargo_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<SebastianLargo_Examen1P.Models.SL_modelo1> SL_modelo1 { get; set; } = default!;
    }
}
