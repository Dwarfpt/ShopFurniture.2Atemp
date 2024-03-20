using ShopFurniture._2.Domain.Entities.GeneralResponce;
using ShopFurniture._2.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopFurniture._2.Domain.Entities.Auth;
using ShopFurniture._2.Domain.Entities.User.DbModel;

namespace ShopFurniture._2.BusinessLogic.Core
{
    public class UserApi
    {
        internal RResponceData ULASessionChech(ULoginData data)
        {
            //db connection
            //SELECT USER FROM DB>User WHERE Username=data.Credential and Pawword = data.Password

            //if SELECT VALID OR TRUE

            //RETURN STATUS = true

            return new RResponceData
            {
                Status = false,
                CurrentUser = new User
                {
                    UserName = "Canion"
                }
            };

        }
        internal UCoockieData UserCoockieGenerationAlg(User user)
        {
            //HERE WILL BE THE LOGIC TO COOCKIE GENERATION PROCESS

            return new UCoockieData
            { 
                MaxAge = 1710894, 
                Coockie = "My not Unique id for this session" 
            };
        }
    }
}
