using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RekrutmenTNI
{
    public class JsClass
    {
        public static void MessageBox(string message)
        {
            System.IO.TextWriter txtWriter = null;
            HttpResponse oResponse = new HttpResponse(txtWriter);

            //oResponse.Write(string.Format("<script>alert('{0}');</script>",message));
        }
    }
}