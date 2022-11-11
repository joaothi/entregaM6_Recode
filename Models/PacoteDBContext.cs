using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace JTViagens.Models
{
	public class PacoteDBContext : DbContext
	{
		public PacoteDBContext(DbContextOptions<PacoteDBContext> options)
:			base(options)
			{ }

		public DbSet<Pacote> Pacote { get; set; }
	}
}
