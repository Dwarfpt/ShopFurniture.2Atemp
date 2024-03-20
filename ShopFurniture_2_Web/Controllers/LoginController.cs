using ShopFurniture._2.BusinessLogic.Interfaces;
using ShopFurniture._2.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopFurniture_2_Web.Models;
using ShopFurniture._2.Domain;
using ShopFurniture._2.Domain.Entities.GeneralResponce;
using ShopFurniture._2.Domain.Entities.User;
using ShopFurniture._2.Domain.Entities.Auth;

//C:\GitProjects\ShopFurniture.2.Domain\Entities\User\ULoginData.cs
using System.Net;

namespace ShopFurniture_2_Web.Controllers
{
    public class LoginController : Controller
    {
        internal ISession _session;

        public LoginController()
        {
            var logicBL = new ShopFurniture._2.BusinessLogic.BussinesLogic();
            _session = logicBL.GetSessionBL();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(LoginData data)
        {
            var uLoginData = new ULoginData
            {
                Credential = data.Username,
                Password = data.Password,
                LoginIp = "",
                LoginDateTime = DateTime.Now
            };

            RResponceData responce = _session.UserLoginAction(uLoginData);
            if (responce != null && responce.Status)
            {
                //here will be the logic to Cookie Generation
                UCoockieData cData = _session.GenCoockieAlgo(responce.CurrentUser);

                if (cData != null)
                {
                    //SET COOCKIE TO USER BROWSER
                }
            }

            return View();
        }

    }
}