using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace cantina
{
    internal class PersistenciaEstoque
    {
        public static List<Estoque> ListaEstoque = new List<Estoque>();
        private static string caminho = @"C:\Temp\estoque.json";
        public static void IniciarEstoque()
        {
            foreach (var produto in PersistenciaProduto.ProdutosEstoque) 
            {
                Estoque estoque = new Estoque
                {
                    produto = produto,
                    Quantidade = 0 // Inicializa a quantidade como zero
                };
                ListaEstoque.Add(estoque);
            }
        }


        public static void saveToFile()
        {
            try
            {
                //var dados = new DadosPersistidos
                //{
                //    Pedidos = PersistenciaPedido.Pedidos,
                //};

                // Serialize the list to a JSON string
                string json = JsonConvert.SerializeObject(ListaEstoque, Formatting.Indented); // Formatting.Indented makes it human-readable

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
                    List<Estoque> loadedDataList = JsonConvert.DeserializeObject<List<Estoque>>(json);


                    // You might want to assign this loaded list to your application's main data list
                    ListaEstoque = loadedDataList;
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

