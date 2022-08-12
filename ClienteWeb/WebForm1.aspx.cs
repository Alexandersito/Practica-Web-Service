using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSuma_Click(object sender, EventArgs e)
        {
            SW.WebService1SoapClient Servicio = new SW.WebService1SoapClient();
            btnResultado.Text = Servicio.suma(Double.Parse(txtNro1.Text), Double.Parse(txtNro2.Text)).ToString();
        }

        protected void btnResta_Click(object sender, EventArgs e)
        {
            SW.WebService1SoapClient Servicio = new SW.WebService1SoapClient();
            btnResultado.Text = Servicio.resta(Double.Parse(txtNro1.Text), Double.Parse(txtNro2.Text)).ToString();
        }

        protected void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            SW.WebService1SoapClient Servicio = new SW.WebService1SoapClient();
            btnResultado.Text = Servicio.multiplicacion(Double.Parse(txtNro1.Text), Double.Parse(txtNro2.Text)).ToString();
        }

        protected void btnDivision_Click(object sender, EventArgs e)
        {
            SW.WebService1SoapClient Servicio = new SW.WebService1SoapClient();
            btnResultado.Text = Servicio.divicion(Double.Parse(txtNro1.Text), Double.Parse(txtNro2.Text)).ToString();
        }

        protected void btnRaiz_Click(object sender, EventArgs e)
        {
            SW.WebService1SoapClient Servicio = new SW.WebService1SoapClient();
            btnResultado.Text = Servicio.raiz(Double.Parse(txtNro1.Text)).ToString();
        }

        protected void btnPotencia_Click(object sender, EventArgs e)
        {
            SW.WebService1SoapClient Servicio = new SW.WebService1SoapClient();
            btnResultado.Text = Servicio.exponente(Double.Parse(txtNro1.Text), Double.Parse(txtNro2.Text)).ToString();
        }

        protected void btnInversa_Click(object sender, EventArgs e)
        {
            SW.WebService1SoapClient Servicio = new SW.WebService1SoapClient();
            btnResultado.Text = Servicio.inversa(Double.Parse(txtNro1.Text)).ToString();
        }

        protected void btnFactorial_Click(object sender, EventArgs e)
        {
            SW.WebService1SoapClient Servicio = new SW.WebService1SoapClient();
            btnResultado.Text = Servicio.factorial(Double.Parse(txtNro1.Text)).ToString();
        }

        protected void btnLogaritmo_Click(object sender, EventArgs e)
        {
            SW.WebService1SoapClient Servicio = new SW.WebService1SoapClient();
            btnResultado.Text = Servicio.logaritmo(Double.Parse(txtNro1.Text)).ToString();
        }

        protected void btnValorAbsoluto_Click(object sender, EventArgs e)
        {
            SW.WebService1SoapClient Servicio = new SW.WebService1SoapClient();
            btnResultado.Text = Servicio.valorAbsoluto(Double.Parse(txtNro1.Text)).ToString();
        }
    }
}