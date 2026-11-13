using Newtonsoft.Json;
using RestSharp;
using System;
using System.IO;
using System.Net;
using System.Web;
using System.Windows.Forms;

namespace LaQuiebra.Logica
{
    //Clase de propósito general para conectar con el API (similar a la clase Conexion para la B de D)
    public class DBApi
    {
        //URL donde corre el API
        public static string urlApi = "https://ca-laquiebra.lemonsmoke-c1e3a539.australiaeast.azurecontainerapps.io/api/";

        public static dynamic Get(string urlApi)
        {
            HttpWebRequest objPedido = (HttpWebRequest)WebRequest.Create(urlApi);
            objPedido.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            objPedido.Credentials = CredentialCache.DefaultCredentials;
            objPedido.Proxy = null;
            HttpWebResponse objRespuesta = (HttpWebResponse)objPedido.GetResponse();
            Stream objFlujo = objRespuesta.GetResponseStream();
            StreamReader objFlujoLectura = new StreamReader(objFlujo);
            //Leemos los datos
            string datosJson = HttpUtility.HtmlDecode(objFlujoLectura.ReadToEnd());
            dynamic datos = JsonConvert.DeserializeObject(datosJson);
            return datos;
        }

        public static dynamic Post(string urlApi, string json, string autorizacion = null)
        {
            Method op = Method.Post;
            return operaciones(urlApi, json, autorizacion, op);
        }

        public static dynamic Put(string urlApi, string json, string autorizacion = null)
        {
            Method op = Method.Put;
            return operaciones(urlApi, json, autorizacion, op);
        }

        public static dynamic Delete(string urlApi, string json, string autorizacion = null)
        {
            Method op = Method.Delete;
            return operaciones(urlApi, json, autorizacion, op);
        }

        private static dynamic operaciones(string urlApi, string json, string autorizacion, Method op)
        {
            try
            {
                var objCliente = new RestClient(urlApi);
                var objPedido = new RestRequest();
                objPedido.Method = op;
                //En las versiones nuevas de RestSharp el json se envía con AddStringBody
                objPedido.AddStringBody(json, ContentType.Json);
                if (autorizacion != null)
                {
                    objPedido.AddHeader("Authorization", autorizacion);
                }
                RestResponse objRespuesta = objCliente.Execute(objPedido);
                dynamic datos = JsonConvert.DeserializeObject(objRespuesta.Content);
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
