using System;
using System.Collections.Generic;
using System.Text;

namespace encuestadatab
{
    class datos
    {
        #region
        private string nombre;
        private DateTime fechanacimiento;
        private string equipofavorito;

        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (nombre == value)
                {
                    return;
                }
                nombre = value;
                OnPropertyChanged();

            }
        }
        public String FechaNacimiento
        {
            get
            {
                return fechanacimiento;
            }
            set
            {
                if (fechanacimiento == value)
                {
                    return;
                }
                fechanacimiento = value;
                OnPropertyChanged();

            }


        }
        public String Equipofavorito
        {
            get
            {
                return equipofavorito;
            }
            set
            {
                if (equipofavorito == value)
                {
                    return;
                }
                equipofavorito = value;
                OnPropertyChanged();

            }


        }

        #endregion
        #region Metodos
        public override string ToString()
        {
            return $"{Nombre} | {FechaNacimiento}|{Equipofavorito}";
        }
        #endregion
    }

}
    

