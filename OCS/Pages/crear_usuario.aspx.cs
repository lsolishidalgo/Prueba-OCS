﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OCS.Pages
{
    public partial class crear_usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void cvnombre_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                args.IsValid = false;

                if (args.Value != null)
                {
                    string str = args.Value;
                    int length = str.Length;

                    if (length <= 50)
                    {
                        args.IsValid = true;
                    }
                }
            }

            catch (Exception ex)
            {
                args.IsValid = false;
            }
        }

        protected void cvcedula_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                args.IsValid = false;

                if (args.Value != null)
                {
                    string str = args.Value;
                    int length = str.Length;

                    if (length <= 25)
                    {
                        args.IsValid = true;
                    }
                }
            }

            catch (Exception ex)
            {
                args.IsValid = false;
            }
        }

        protected void cvcelular_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                args.IsValid = false;

                if (args.Value != null)
                {
                    string str = args.Value;
                    int length = str.Length;

                    if (length <= 8)
                    {
                        args.IsValid = true;
                    }
                }
            }

            catch (Exception ex)
            {
                args.IsValid = false;
            }
        }

        protected void cvemail_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                args.IsValid = false;

                if (args.Value != null)
                {
                    string str = args.Value;
                    int length = str.Length;

                    if (length <= 50)
                    {
                        args.IsValid = true;
                    }
                }
            }

            catch (Exception ex)
            {
                args.IsValid = false;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {


            }

            catch (Exception ex)
            {

            }
        }

        protected void bntCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/menu_admin_usuarios.aspx", false);
           
        }
    }
}