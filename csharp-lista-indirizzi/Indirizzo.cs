﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Indirizzo
    {
        //Name,Surname,Street,City,Province,ZIP
        public string? Nome { get; }
        public string? Cognome { get; }
        public string Via { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }
        public string Zip { get; set; }

        public Indirizzo(string? nome, string? cognome, string via, string citta, string provincia, string zip)
        {
            Nome = nome;
            Cognome = cognome;
            Via = via;
            Citta = citta;
            Provincia = provincia;
            Zip = zip;
        }

        //Costruttore della classe

    }
}
