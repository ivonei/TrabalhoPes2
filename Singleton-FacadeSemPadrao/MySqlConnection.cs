﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_FacadeSemPadrao {
    public class MySqlConnection : DatabaseConnection{
        public void Connect() {
            Console.WriteLine("Conectando com Mysql");
        }
    }
}