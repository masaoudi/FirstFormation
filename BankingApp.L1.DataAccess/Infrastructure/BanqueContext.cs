﻿using BankingApp.L0.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L1.DataAccess.Infrastructure
{
    class BanqueContext : DbContext // l'equivalent en NHibernate est sessionFactory
    {
        public virtual DbSet<Compte> Comptes { get; set; }
        public BanqueContext() : base("name=MaBanqueDB")
        {

        }
    }
}
