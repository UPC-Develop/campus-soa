using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Campus.Entity;

namespace Campus
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICampusService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICampusService
    {
        [OperationContract]
        ResponseCampusEntity ListCampus(Int32 Active);
    }
}
