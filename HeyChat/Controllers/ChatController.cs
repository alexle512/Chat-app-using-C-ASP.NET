using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PusherServer;

namespace HeyChat.Controllers
{
    public class ChatController : Controller
    {
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                return Redirect("/");
            }

            ViewBag.currentUser = Session["user"];

            return View();
        }

        [HttpPost]
        public ActionResult Typing()
        {
            string typer = Request.Form["typer"];
            string socket_id = Request.Form["socket_id"];
         

            var options = new PusherOptions();
            options.Cluster = "Pusher_APP_CLUSTER";

            var pusher = new Pusher(
              "749662",
              "e04ac7f428b64a8d05fc",
              "30a8ef6697dbb7c507b2",
              options);

            pusher.TriggerAsync(
            "chat",
            "typing",
            new { typer = typer },
            new TriggerOptions() { SocketId = socket_id });

            return new HttpStatusCodeResult(200);
        }

        public JsonResult SendMessage( string user) {

            return Json("");
        }
    }
}
