using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;
using System.Text;

namespace Modul9_103022430013
{
    internal class BankTransferConfig
    {
        public Config config;
        private const string filePath = "bank_transfer_config";



        public BankTrasferConfig()
        {
            this.config = new Config();
        }



    }

    internal class Config
    {
        public Config() { }
        public Config(string lang, Transfer transfer, List<string> methods, Confirmation confirmation) { }
    


        public string lang { get; set; }

        public Transfer transfer { get; set; }

        public List<string> methods { get; set; }
        public confirmation Confirmation { get; set; }

    }
    internal class Transfer
    {
        public double threshold { get; set; }
        public double low_fee { get; set; }
        public double high_fee { get; set; }

        public Transfer() { }
        public Transfer(double threshold, double low_fee, double high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }
       
        internal class Confirmation {
            public Confirmation() { }

            public string en;
            public string id;

            public Confirmation(string en, string id)
            {
                this.en = en;
                this.id = id;


            }
        }
    }
}


