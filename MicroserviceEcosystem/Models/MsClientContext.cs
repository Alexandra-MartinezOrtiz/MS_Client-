using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MicroserviceEcosystem.Models;

public partial class MsClientContext : DbContext
{
    public MsClientContext()
    {
    }

    public MsClientContext(DbContextOptions<MsClientContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ClientEvent> ClientEvents { get; set; }

}
