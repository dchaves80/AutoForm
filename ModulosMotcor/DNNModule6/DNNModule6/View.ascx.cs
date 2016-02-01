/*
' Copyright (c) 2016  Christoc.com
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Services.Localization;
using System.Net.Mail;

namespace Christoc.Modules.DNNModule6
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The View class displays the content
    /// 
    /// Typically your view control would be used to display content or functionality in your module.
    /// 
    /// View may be the only control you have in your project depending on the complexity of your module
    /// 
    /// Because the control inherits from DNNModule6ModuleBase you have access to any custom properties
    /// defined there, as well as properties from DNN such as PortalId, ModuleId, TabId, UserId and many more.
    /// 
    /// </summary>
    /// -----------------------------------------------------------------------------
    public partial class View : DNNModule6ModuleBase, IActionable
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                fieldbutton.ServerClick += fieldbutton_ServerClick;
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        void fieldbutton_ServerClick(object sender, EventArgs e)
        {
            String Message = "<b>Nombre:</b> " + field_nombre.Value + "<br/>" +
                 "<b>Direccion:</b> " + field_direccion.Value + "<br/>" +
                 "<b>Localidad:</b> " + field_localidad.Value + "<br/>" +
                 "<b>Telefono:</b> " + field_telefono.Value + "<br/>";


            MailMessage MM = new MailMessage("info@oficialfiat.com", "info@oficialfiat.com", "Consulta WEB:", Message);
            MM.IsBodyHtml = true;
            SmtpClient SMTP = new SmtpClient("mail.oficialfiat.com");
            SMTP.SendCompleted += SMTP_SendCompleted;
            try
            {
               
                SMTP.Send(MM);
                msgBox.Visible = true;
                formulario.Visible = false;
                fieldbutton.Visible = false;

            }
            catch { }
        }

        void SMTP_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
           
        }

        

        public ModuleActionCollection ModuleActions
        {
            get
            {
                var actions = new ModuleActionCollection
                    {
                        {
                            GetNextActionID(), Localization.GetString("EditModule", LocalResourceFile), "", "", "",
                            EditUrl(), false, SecurityAccessLevel.Edit, true, false
                        }
                    };
                return actions;
            }
        }
    }
}