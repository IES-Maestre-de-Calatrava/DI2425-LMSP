using ApiRestLucas.domain;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ApiRestLucas.persistence
{
    internal class ApiobjectManage
    {
        public async void cargarObjeto(MainWindow mainWindow)
        {
            // Cargamos link de la api: https://api.restful-api.dev/objects
            string urlApi = "https://api.restful-api.dev/objects";
            mainWindow.listDatos.Items.Clear();
            mainWindow.listDatos.Items.Add("Loading data...");

            try
            {
                // Realizamos solicitud HTTP
                HttpClient cliente = new HttpClient();
                HttpResponseMessage response = await cliente.GetAsync(urlApi);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var objetos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ApiObject>>(jsonResponse);

                    // Limpiamos y cargamos los datos en el listbox
                    mainWindow.listDatos.Items.Clear();
                    foreach (var objeto in objetos)
                    {
                        if (objeto.data != null)
                        {
                            mainWindow.listDatos.Items.Add($"ID: {objeto.id}, Name: {objeto.name}, Color: {objeto.data.color}, Capacity: {objeto.data.capacity}, CPU Model: {objeto.data.cpuModel}, Hard Disk: {objeto.data.hardDiskSize}, Year: {objeto.data.year}, Price: {objeto.data.price}");
                        }
                        else
                        {
                            mainWindow.listDatos.Items.Add($"ID: {objeto.id}, Name: {objeto.name}, Data: no data");
                        }
                    }
                }
                else
                {
                    mainWindow.listDatos.Items.Clear();
                    mainWindow.listDatos.Items.Add("Error loading data");
                }
            }
            catch (Exception ex)
            {
                mainWindow.listDatos.Items.Clear();
                mainWindow.listDatos.Items.Add($"Error: {ex.Message}");
            }
        }

        public async void addObject(MainWindow mainWindow, AddObject ab)
        {
            ab.btnAdd.IsEnabled = false;
            ab.btnAdd.Content = "Adding object...";

            try
            {
                // Creamos objeto para enviar a la API
                ApiObject objeto = new ApiObject();
                objeto.name = ab.txtName.Text;
                objeto.data = new Data();
                objeto.data.color = ab.txtColor.Text;
                objeto.data.capacity = ab.txtCapacity.Text;
                objeto.data.hardDiskSize = int.Parse(ab.txtHardDisk.Text);
                objeto.data.cpuModel = ab.txtCpuModel.Text;
                objeto.data.year = int.Parse(ab.txtYear.Text);
                objeto.data.price = int.Parse(ab.txtPrice.Text);

                // Enviamos Objeto a la API
                string urlApi = "https://api.restful-api.dev/objects";
                HttpClient cliente = new HttpClient();
                StringContent str = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(objeto), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await cliente.PostAsync(urlApi, str);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Object added successfully");
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var addedObject = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiObject>(jsonResponse);

                    mainWindow.txtPost.Text = $"Object successfully added: \n {jsonResponse}";

                    ab.Close();
                }
                else
                {
                    MessageBox.Show("Error adding object");
                    mainWindow.txtPost.Text = "Error adding object";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                mainWindow.txtPost.Text = $"Error: {ex.Message}";
            }
            finally
            {
                ab.btnAdd.IsEnabled = true;
                ab.btnAdd.Content = "Add object";
            }
        }

        public async void listByid(MainWindow mainWindow, ListById lb)
        {
            try
            {
                string apiUrl = "https://api.restful-api.dev/objects/" + lb.txtId.Text;
                HttpClient cliente = new HttpClient();
                HttpResponseMessage response = await cliente.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var objeto = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiObject>(jsonResponse);
                    mainWindow.listDatos.Items.Clear();
                    if (objeto.data != null)
                    {
                        mainWindow.listDatos.Items.Add($"ID: {objeto.id}, Name: {objeto.name}, Color: {objeto.data.color}, Capacity: {objeto.data.capacity}, CPU Model: {objeto.data.cpuModel}, Hard Disk: {objeto.data.hardDiskSize}, Year: {objeto.data.year}, Price: {objeto.data.price}");
                    }
                    else
                    {
                        mainWindow.listDatos.Items.Add($"ID: {objeto.id}, Name: {objeto.name}, Data: no data");
                    }
                    lb.Close();
                }
                else
                {
                    mainWindow.listDatos.Items.Clear();
                    mainWindow.listDatos.Items.Add("Error loading data");
                }
            }
            catch (Exception ex)
            {
                mainWindow.listDatos.Items.Clear();
                mainWindow.listDatos.Items.Add($"Error: {ex.Message}");
            }
        }



        public async void deleteObject(MainWindow mainWindow)
        {
            if (mainWindow.listDatos.SelectedItem == null)
            {
                MessageBox.Show("Plesae, choose an object to delete.");
                return;
            }

            try
            {
                string selectedItem = mainWindow.listDatos.SelectedItem.ToString();
                string id = selectedItem.Split(',')[0].Split(':')[1].Trim();

                // URL de la api
                string urlApi = "https://api.restful-api.dev/objects/" + id;
                HttpClient cliente = new HttpClient();
                HttpResponseMessage response = await cliente.DeleteAsync(urlApi);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    mainWindow.txtPost.Text = $"Object deleted:{jsonResponse}";
                    mainWindow.listDatos.Items.Remove(mainWindow.listDatos.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Error deleting the object");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


    }
}

