using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Campus.Entity;
using Dapper;
using System.Data;

namespace Campus.Repository
{
    public class CampusRepository: BaseRepository
    {
        public List<CampusEntity> ListCampus(Int32 active)
        {
            var campusEntity = new List<CampusEntity>();


            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"Usp_List_Campus";

                    var p = new DynamicParameters();
                    
                    p.Add(name: "@Active", value: active, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    campusEntity = db.Query<CampusEntity>(sql: sql, param: p, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }

            return campusEntity;
          }
    }
}