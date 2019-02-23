﻿using Microsoft.AspNetCore.Builder; using Microsoft.AspNetCore.Hosting; using Microsoft.Extensions.DependencyInjection; using Microsoft.AspNetCore.SpaServices.Webpack; using Microsoft.AspNetCore.Http; using System.Threading.Tasks;  namespace FileManager {     public class Startup     {         public void ConfigureServices(IServiceCollection services)         {         }                   public void Configure(IApplicationBuilder app, IHostingEnvironment env)         {              if (env.IsDevelopment())             {                 app.UseDeveloperExceptionPage();                   // добавляем сборку через webpack                 app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions                 {                     HotModuleReplacement = true                 });             }             else             {                 // установка обработчика ошибок                 // app.UseExceptionHandler("/Home/Error");             }               app.UseMiddleware<TokenMiddleware>();              app.Run(async (context) =>             {                 await context.Response.WriteAsync("hello");             });              app.UseDefaultFiles();             app.UseStaticFiles();             //app.UseAuthentication();             //app.UseSession();                       }     } }