using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;

namespace FruitTracker {
    internal class WebServer {
        public void Configuration(IAppBuilder app) {
            app.UseFileServer(new FileServerOptions() { FileSystem = new PhysicalFileSystem("Assets") });
            app.RunSignalR();
            app.Run(async context => {
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
