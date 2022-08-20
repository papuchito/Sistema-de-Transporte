using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaentidad
{
    public class E_tbfinal
    {
        private int _idtbfinal;
        private string _Nombre;
        private string _Apellido;
        private string _Carrera;
        private string _Correo;
        private string _Edificio;
        private string _Entrada;
        private string _Salida;
        private string _Motivo;
        private string _Aula;

        public int Idtbfinal { get => _idtbfinal; set => _idtbfinal = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Edificio { get => _Edificio; set => _Edificio = value; }
        public string Entrada { get => _Entrada; set => _Entrada = value; }
        public string Salida { get => _Salida; set => _Salida = value; }
        public string Motivo { get => _Motivo; set => _Motivo = value; }
        public string Aula { get => _Aula; set => _Aula = value; }
    }
}


