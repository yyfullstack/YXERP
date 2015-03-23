﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YXManage.Controllers
{
    [YXManage.Common.UserAuthorize]
    public class ClientController : Controller
    {
        //
        // GET: /Client/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

    }
}