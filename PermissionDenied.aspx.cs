using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoleTest
{
    public partial class PermissionDenied : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblRoleAndUser.Text = Context.User.Identity.Name+ "With Role "+ Roles.GetRolesForUser(Context.User.Identity.Name)[0];
            }
        }
    }
}