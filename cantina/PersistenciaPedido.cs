using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace cantina
{
    internal class PersistenciaPedido
    {      
        private static string caminho = @"C:\Temp\pedidos.json";
        public static List<Venda> Pedidos = new List<Venda>();

        //public class DadosPersistidos
        //{
        //    public List<Venda> Pedidos { get; set; } = new();
        //    public int NumeroPedido { get; set; }
        //}
        public static void saveToFile()
        {
            try
            {
                //var dados = new DadosPersistidos
                //{
                //    Pedidos = PersistenciaPedido.Pedidos,
                //};
                
                    // Serialize the list to a JSON string
                    string json = JsonConvert.SerializeObject(Pedidos, Formatting.Indented); // Formatting.Indented makes it human-readable

                    // Write the JSON string to the selected file
                    File.WriteAllText(caminho, json);
                }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void LoadFromFile()
        {
            try
            {
                if (File.Exists(caminho))
                {
                    string json = File.ReadAllText(caminho);
                    List<Venda> loadedDataList = JsonConvert.DeserializeObject<List<Venda>>(json);


                    // You might want to assign this loaded list to your application's main data list
                    Pedidos = loadedDataList;
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado. Um novo será criado ao salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

     
    }
