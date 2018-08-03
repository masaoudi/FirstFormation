﻿using BankingApp.L2.Business.Facade;
using BankingApp.L2.Business.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BankingApp.L3.Service.wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceconsultationImpl : IServiceConsultation
    {
        private ICompteBusiness business = new ComptesBusinessImpl();
        public decimal GetSolde(string numero)
        {
            return business.ConsulterCompte(numero);
        }
    }
}
