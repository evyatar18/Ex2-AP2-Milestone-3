﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Model.Server
{
    public delegate void UpdateHandler();
    public delegate void ConnectionEvent();

    public interface IVariablesServer
    {
        uint Port { get; set; }

        bool IsOpen { get; }

        char LineSep { get; set; }
        char VarSep { get; set; }
        double this[int propertyIndex] { get; }

        event UpdateHandler PropertyUpdate;
        event ConnectionEvent OnConnection;

        void Open();
        void Close();
    }
}
