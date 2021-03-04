using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class PersonaService
    {
        PersonaRepository personaRepository = new PersonaRepository();
        public String Guardar(Persona persona)
        {
            try
            {
                personaRepository.Guarda(persona);
                return "TODO SE GUARDO CORRECTAMENTE";
            }
            catch (Exception exception)
            {
                return "SE PRESENTARON ERRORES "+ exception.Message;
            }
            
            
        }

    }
}
