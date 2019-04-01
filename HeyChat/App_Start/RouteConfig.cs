using System.Web.Mvc;
using System.Web.Routing;

namespace HeyChat
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
                );

            routes.MapRoute(
            name: "Login",
            url: "login",
            defaults: new { controller = "Home", action = "Index" }
            );


            routes.MapRoute(
            name: "ChatRoom",
            url: "chat",
            defaults: new { controller = "Home", action = "Index" }
        );


           routes.MapRoute(
           name: "UserTyping",
           url: "cbat/typing",
           defaults: new { controller = "Chat", action = "Typing" }
           );


        routes.MapRoute(
        name: "SendMessage",
        url: "chat/@{user}",
        defaults: new { controller = "Chat", action = "SendMessage", user = "" }
        );

        }
    }
}
