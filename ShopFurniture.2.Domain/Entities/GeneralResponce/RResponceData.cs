using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopFurniture._2.Domain.Entities.User.DbModel;


namespace ShopFurniture._2.Domain.Entities.GeneralResponce
{
    public class RResponceData
    {
        public bool Status { get; set; }

        public string ResponceMessage {  get; set; }

        public User.DbModel.User CurrentUser { get; set; }


    }
}
