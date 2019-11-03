using System;
using System.Collections.Generic;
using System.Web.UI;

//Added references
using System.Web.Script.Serialization;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;


namespace WebFormApiCallExample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //this.PopulateGridView();
                CallWebAPIAsync().Wait();

                
            }

        }

        static async Task CallWebAPIAsync()
        {

           
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:6497/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync("api/products");
                if (response.IsSuccessStatusCode)
                {
                    Product product = await response.Content.ReadAsAsync<Product>();

                    string v = product.Id.ToString() + ' ' + product.Name;

                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
        }





        //protected void Search(object sender, EventArgs e)
        //{
        //    this.PopulateGridView();
        //}

 


        //private void PopulateGridView()
        //{
        //    string apiUrl = "http://localhost:6497/api";
        //    object input = new
        //    {
        //        Name = txtName.Text.Trim(),
        //    };
        //    string inputJson = (new JavaScriptSerializer()).Serialize(input);
        //    WebClient client = new WebClient();
        //    client.Headers["Content-type"] = "application/json";
        //    client.Encoding = Encoding.UTF8;
        //    string json = client.UploadString(apiUrl + "/products/", inputJson);

        //    gvProducts.DataSource = (new JavaScriptSerializer()).Deserialize<List<Product>>(json);
        //    gvProducts.DataBind();
        //}

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }
        }
    }
}