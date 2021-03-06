#pragma checksum "D:\Biblioteca\Views\Usuario\ListarUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "799fc6b8bdba2f18d40ec64ab36f426d4d7c29a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListarUsuario), @"mvc.1.0.view", @"/Views/Usuario/ListarUsuario.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"799fc6b8bdba2f18d40ec64ab36f426d4d7c29a0", @"/Views/Usuario/ListarUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListarUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"text-center\">Lista de usuários</h1>\r\n\r\n<h2 class=\"text-center  text-danger\">ATENÇÃO</h2>\r\n<h5 class=\"text-center  text-danger\">A exclusão de usuários é um processo irreversível!</h5>\r\n\r\n<p class=\"text-danger\"> ");
#nullable restore
#line 8 "D:\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
                   Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-bordered border-primary"">
            <thead>
                <tr>
                    <th scope=""row"">ID</th>
                    <th scope=""row"">Nome</th>
                    <th scope=""row"">Login</th>
                    <th scope=""row"">Tipo</th>
                    <th scope=""row"">Ação I</th>
                    <th scope=""row"">Ação II</th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 25 "D:\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
                 foreach (Usuario u in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 28 "D:\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
                       Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
                       Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "D:\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
                       Write(u.login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "D:\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
                         if (u.tipo == Usuario.ADMIN)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Administrador</td>\r\n");
#nullable restore
#line 34 "D:\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Padrão</td>\r\n");
#nullable restore
#line 38 "D:\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1317, "\"", 1346, 2);
            WriteAttributeValue("", 1324, "editarUsuario?id=", 1324, 17, true);
#nullable restore
#line 39 "D:\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
WriteAttributeValue("", 1341, u.Id, 1341, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-edit\" style=\"font-size: 30px; color: #000;\"></i></a></td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1454, "\"", 1484, 2);
            WriteAttributeValue("", 1461, "ExcluirUsuario?id=", 1461, 18, true);
#nullable restore
#line 40 "D:\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
WriteAttributeValue("", 1479, u.Id, 1479, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-trash-alt\" style=\"font-size: 30px; color: #000;\"></i></a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 42 "D:\Biblioteca\Views\Usuario\ListarUsuario.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
