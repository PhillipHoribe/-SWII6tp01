using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWIITp01
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }
        public void Configure(IApplicationBuilder app)
        {
            var builder = new RouteBuilder(app);
            builder.MapRoute("/nomeLivro", BookNames);
            builder.MapRoute("/TotalToString", TotalToString);
            builder.MapRoute("/NomeDosAutores", AuthorNames);
            builder.MapRoute("/livro/ApresentaLivro", Html);
            var rotas = builder.Build();
            app.UseRouter(rotas);
        }
        public Task BookNames(HttpContext context)
        {
            ArquivoCSV arq = new ArquivoCSV();
            var books = arq.buscarNomes();
            return context.Response.WriteAsync(books[0].Name);
        }
        public Task TotalToString(HttpContext context)
        {
            ArquivoCSV arq = new ArquivoCSV();
            var books = arq.buscarNomes();
            return context.Response.WriteAsync(books[0].ToString());

        }
        public Task AuthorNames(HttpContext context)
        {
            ArquivoCSV arq = new ArquivoCSV();
            var books = arq.buscarNomes();
            return context.Response.WriteAsync(books[0].getAuthorNames());

        }
        public Task Html(HttpContext context)
        {
            ArquivoCSV arq = new ArquivoCSV();
            var books = arq.buscarNomes();
            var html = $"<div><h1>Nome do Livro: </h1><p>{books[0].Name}</p><h1>Autor(es):</h1><p>{books[0].getAuthorNames()}</p></div>";
            return context.Response.WriteAsync(html);
        }
    }
}

