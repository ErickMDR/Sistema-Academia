using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Data;
using System.IO;

namespace Sistema_Academia.Datos
{
    public class TablaNotas : TablaBase<TablaNotas>
    {
        protected override string NombreTabla => "Notas";
        // M�todos personalizados si se requieren
    }
}
