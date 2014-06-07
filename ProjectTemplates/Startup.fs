namespace $safeprojectname$

open Owin
open Microsoft.Owin

type Startup() =
    member x.Configuration(app: Owin.IAppBuilder) =
        app.MapSignalR().Run(fun ctx ->
            ctx.Response.ContentType <- "text/plain"
            ctx.Response.WriteAsync("Web Application Server with F#, Owin, ASP.NET Identity, SignalR...")
        ) |> ignore

[<assembly: OwinStartup(typeof<Startup>)>]
do ()