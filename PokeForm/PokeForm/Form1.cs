using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PokeAPI;

namespace PokeForm
{
    public partial class Form1 : Form
    {
        //public static string PokeURL = "https://pokeapi.co/api/v2/move/";
        //public static string PokemonNames = "https://pokeapi.co/api/v2/pokemon/?offset=0&limit=1000";

        public Form1()
        {
            InitializeComponent();

            using (var context = new TestEntities())
            {
                var query = context.C__PokemonName
            }


                //GetPokeMonNames();
            }

        //private void GetPokeMonNames()
        //{
        //    DataTable dtPokemonNames = new DataTable();
        //    dtPokemonNames = GenerateDataTable();
        //    WebClient syncClient = new WebClient();
        //    string url = PokemonNames;
        //    string response = syncClient.DownloadString(url);
        //    var ro = JsonConvert.DeserializeObject<PokemonName>(response);

        //    if (ro.results != null)
        //    {
        //        foreach (Name nm in ro.results)
        //        {
        //            dtPokemonNames.Rows.Add(nm.name);
        //        }
        //    }
        //}

        private DataTable GenerateDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Move mv = await DataFetcher.GetNamedApiObject<Move>("lucario");
            //string mvname = mv.Name;
            //MessageBox.Show(mvname);

            //GrabData();
        }

        //private void GrabData()
        //{
        //    WebClient syncClient = new WebClient();
        //    string url = "https://pokeapi.co/api/v2/pokemon/lucario/";
        //    string response = syncClient.DownloadString(url);

        //    var ro = JsonConvert.DeserializeObject<PokeAPI>(response);
        //    if (ro.Moves != null)
        //    {
        //        foreach (MoveInformation mi in ro.Moves)
        //        {
        //            Move mv = mi.Move;
        //            MessageBox.Show(mv.Name);
        //            MessageBox.Show(mv.Url);
        //        }
        //    }

        }

    }
    ////This is capturing the Pokemon Names
    //public class PokemonName
    //{
    //    public List<Name> results { get; set; }
    //}
    //public class Name
    //{
    //    public string name { get; set; }
    //    public string url { get; set; }
    //}
    ////This is capturing the Pokemon moves
    //public class PokeAPI
    //{
    //    public List<MoveInformation> Moves { get; set; }
    //}
    //public class MoveInformation
    //{
    //    public Move Move { get; set; }
    //}
    //public class Move
    //{
    //    public string Name { get; set; }
    //    public string Url { get; set; }
    //}
