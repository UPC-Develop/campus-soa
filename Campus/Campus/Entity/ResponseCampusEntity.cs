using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Campus.Entity
{
    public class ResponseCampusEntity
    {
        public bool isSuccess { get; set; }
        public string errorCode { get; set; }
        public string errorMessage { get; set; }

        public List<CampusEntity> data;

    }
}