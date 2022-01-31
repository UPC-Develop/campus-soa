using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Campus.Entity;
using Campus.Repository;

namespace Campus
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CampusService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CampusService.svc o CampusService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CampusService : ICampusService
    {
        public void DoWork()
        {
        }

        public ResponseCampusEntity ListCampus(int Active)
        {
            CampusRepository campusRepository = new CampusRepository();
            ResponseCampusEntity responseCampusEntity = new ResponseCampusEntity();

            try{
                responseCampusEntity.data = campusRepository.ListCampus(Active);
                responseCampusEntity.errorCode = string.Empty;
                responseCampusEntity.errorMessage = string.Empty;
                responseCampusEntity.isSuccess = true;
           
            }
            catch(Exception ex)
            {
                responseCampusEntity.data = null;
                responseCampusEntity.errorCode = "ER01";
                responseCampusEntity.errorMessage = "Error no controlado" + ex.Message;
                responseCampusEntity.isSuccess = false;
            }
            return responseCampusEntity;
        }
    }
}
