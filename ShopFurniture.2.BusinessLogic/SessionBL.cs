using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopFurniture._2.BusinessLogic.Interfaces;
using ShopFurniture._2.BusinessLogic.Core;
using ShopFurniture._2.Domain.Entities.GeneralResponce;
using ShopFurniture._2.Domain.Entities.User;
using ShopFurniture._2.Domain.Entities.Auth;
using ShopFurniture._2.Domain.Entities.User.DbModel;


namespace ShopFurniture._2.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public RResponceData UserLoginAction(ULoginData data)
        {
            return ULASessionChech(data);
        }

        public UCoockieData GenCoockieAlgo(User dataUser)
        {
            return new UCoockieData(); // Создание нового объекта класса UCoockieData
        }

    }
}
