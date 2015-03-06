using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using Twilio;

public partial class vista_envioInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cargarClientes();
    }

    public void cargarClientes() {
        MostrarDatos datos = new MostrarDatos();
        List<Clientes> clientes = datos.mostrarClientes();
        Clientes cliente;
        //String[] nombres = { "Juan Alberto Gonzáles Figueroa", "Rosario Sepulveda Gonzáles", "Alberto Beltran Orozco", "Jonathan Morales Luna", "Matías Romero Garza" };
        String htmlDiv = "";
        for (int i = 0; i < clientes.Count; i++)
        {
            cliente = clientes.ElementAt(i);
            htmlDiv += "<div class='div_content_opc_cte'>";
            htmlDiv += "    <div class='div_opc_cte div_opc_num'><label class='lbl-nom-cte'> "+ cliente.Nombre +" "+cliente.AMaterno+" "+cliente.APaterno+"</label></div>";
            //htmlDiv += "    <div class='div_opc_cte div_opc_tel'><label class='lbl-nom-tel'> " + cliente.Tel_celular + "</label></div>";
            htmlDiv += "    <div class='div_opc_cte div_opc_sms'><input class='bttn-info' id='input_sms' type='button' value='Enviar SMS' onClick='mostrarEnviarSms()' /></div>";
            htmlDiv += "    <div class='div_opc_cte div_opc_mail'><input class='bttn-info id='input_email' type='button' value='Enviar e-mail' onClick='mostrarEnviarEmail()' /></div>";
            htmlDiv += "</div>";
        }
        Panel1.Controls.Add(new LiteralControl(htmlDiv));
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try {

            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress("alulpema87@gmail.com");

            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("alulpema87@gmail.com", "moloradio");
            smtp.Host = "smtp.gmail.com";

            mail.To.Add(new MailAddress("aldo1404@hotmail.com"));
            
            mail.IsBodyHtml = true;
            string st = Texto_email.Text;

            mail.Body = st;
            smtp.Send(mail);
        }
        catch (SmtpException ex)
        {
            Console.WriteLine("Error "+ex.Message);
        }
        
    }

    protected void Button2_Click(object sender, EventArgs e) {
        try
        {
            string AccountSid = "ACd917df6422a1d943c1ec9faaa163be10";
            string AuthToken = "2839c1aefe1789fde4f9b4cf09841659";
            String mensaje = texto_sms.Text;

            TwilioRestClient twilio = new TwilioRestClient(AccountSid, AuthToken);
            var message = twilio.SendMessage("+12566485097", "+528120302455", mensaje);
            //twilio.SendSmsMessage("+12566485097", "+528120302455", mensaje);
            //twilio.SendSmsMessage("+12566485097", "+528120291145", "This is a test message, please don't anwser");

            if (message.RestException != null)
            {
                var error = message.RestException.Message;
                Console.WriteLine(error);
            }
        }
        catch (Exception ex) {
            Console.WriteLine("Error: "+ex);
        }
    }
}