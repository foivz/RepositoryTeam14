using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace evideoteka
{
    class baza
    {
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    
    public baza()
    {
        Initialize();
    }

  
    private void Initialize()
    {
        server = "localhost";
        database = "evideoteka";
        uid = "root";
        password = "";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
		database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

       /* server = "pi.fsabalic.com";
        database = "pi";
        uid = "pi";
        password = "foijezakon2014";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";*/

        connection = new MySqlConnection(connectionString);
    }

    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
          
            switch (ex.Number)
            {
                case 0:
                    MessageBox.Show("Nemoze se spojit");
                    break;

                case 1045:
                    MessageBox.Show("Nema prava");
                    break;
            }
            return false;
        }
    }

    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }

    /// <summary>
    /// Vraca popis korisnika iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<korisnik> Select()
    {
        string query = "SELECT * FROM korisnik";
        List<korisnik> list = new List<korisnik>();
        //String name, surname, phone, email, userName, password;
        //int idKor, status, tip, address;
        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {  
                var korisnici1 = new korisnik();
                string pret = dataReader[0] + "";
                korisnici1.idKorisnik = Int32.Parse(pret);
                korisnici1.ime = dataReader[1] + "";
                korisnici1.prezime = dataReader[2] + "";
                korisnici1.telefon = dataReader[3] + "";
                korisnici1.email = dataReader[4] + "";
                string bStatus = dataReader[5] + "";
                korisnici1.status = Int32.Parse(bStatus);
                string bTip = dataReader[6] + "";
                korisnici1.tip = Int32.Parse(bTip);
                korisnici1.korisnickoIme = dataReader[7] + "";
                korisnici1.sifra = dataReader[8] + "";
                string bAddress = dataReader[9] + "";
                korisnici1.adresa = Int32.Parse(bAddress);
           
                
                list.Add(korisnici1);
               
             

            }
          
            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return list;
        }
        else
        {
            return list;
        }
    }

    /// <summary>
    /// Zapisivanje podataka u bazu
    /// </summary>
    /// <param name="query"></param>
    public void insert(string query)
    {
        string queryInsert = query;
        if (this.OpenConnection() == true)
        {
            MySqlCommand cmd1 = new MySqlCommand(queryInsert, connection);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Uspjesno dodano");
            this.CloseConnection();
        }

    }

    /// <summary>
    /// Vraca popis filmova i distributera iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<distributer> SelectMovieDistributor()
    {
        string query = "SELECT idDistributer, naziv FROM distributer";
        List<distributer> list = new List<distributer>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var distributer1 = new distributer();
                string pret = dataReader[0] + "";
                distributer1.idDistributer = Int32.Parse(pret);
                distributer1.naziv = dataReader[1] + "";
                list.Add(distributer1);

            }

       
            dataReader.Close();

            
            this.CloseConnection();

            
            return list;
        }
        else
        {
            return list;
        }
    }

 

    /// <summary>
    /// Vraca popis modela iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<model> SelectModel()
    {
        string query = "SELECT * FROM model";
        List<model> list = new List<model>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var model1 = new model();
                string bModelId = dataReader[0] + "";
                model1.idKorisnik = Int32.Parse(bModelId);
                model1.naziv = dataReader[1] + "";
                model1.opis = dataReader[2] + "";
                string bCijena = dataReader[3] + "";
                model1.cijena = float.Parse(bCijena);
                string cTrajanje = dataReader[4] + "";
                model1.trajanje = Int32.Parse(cTrajanje);
                list.Add(model1);

            }


            dataReader.Close();


            this.CloseConnection();


            return list;
        }
        else
        {
            return list;
        }
    }

    /// <summary>
    /// Vraca popis glumaca iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<glumac> SelectActor()
    {
        string query = "SELECT * FROM glumac";
        List<glumac> list = new List<glumac>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var model1 = new glumac();
                string bModelId = dataReader[0] + "";
                model1.idGlumac = Int32.Parse(bModelId);
                model1.ime = dataReader[1] + "";
                model1.prezime = dataReader[2] + "";
                list.Add(model1);
            }

            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }

    /// <summary>
    /// Vraca popis mjesta iz baze u obliku vezane liste
    /// </summary>
    /// <returns></returns>
    public List<adresa> SelectAddress()
    {
        string query = "SELECT * FROM adresa";
        List<adresa> list = new List<adresa>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var model1 = new adresa();
                string bModelId = dataReader[0] + "";
                model1.idAdresa = Int32.Parse(bModelId);
                model1.postanskiBroj = dataReader[1] + "";
                model1.mjesto = dataReader[2] + "";
                model1.ulica = dataReader[3] + "";
                list.Add(model1);
            }

            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }

    /// <summary>
    /// Vraca popis distirbutera iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<distributer> SelectDistributor()
    {
        string query = "SELECT * FROM distributer";
        List<distributer> list = new List<distributer>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var distributer1 = new distributer();
                string pret = dataReader[0] + "";
                distributer1.idDistributer = Int32.Parse(pret);
                distributer1.naziv = dataReader[1] + "";
                distributer1.adresa = dataReader[2] + "";
                distributer1.telefon = dataReader[3] + "";
                distributer1.faks = dataReader[4] + "";
                distributer1.email = dataReader[5] + "";
                distributer1.oib = dataReader[6] + "";
                list.Add(distributer1);

            }
            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }

    /// <summary>
    /// Vraca popis filmova iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<film> SelectMovie()
    {
        string query = "SELECT * FROM film";
        List<film> list = new List<film>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var distributer1 = new film();
                string pret = dataReader[0] + "";
                distributer1.idFilm = Int32.Parse(pret);
                distributer1.naziv = dataReader[1] + "";
                
                //date1 = dt.ToString("yyyy-MM-dd HH:mm:ss");
                distributer1.godina = dataReader[2] + "";
                
                //distributer1.godina = dataReader.GetDateTime(dataReader.GetOrdinal("datumPosudbe"));
                distributer1.trajanje = dataReader[3] + "";
                distributer1.jezik = dataReader[4] + "";
                distributer1.zemlja = dataReader[5] + "";
                distributer1.putanja = dataReader[6] + "";
                string pret2 = dataReader[7] + "";
                distributer1.distributer = Int32.Parse(pret2);
                list.Add(distributer1);

            }
            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }

    /// <summary>
    /// Vraca popis nacionalnosti iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<nacionalnost> SelectNationality()
    {
        string query = "SELECT * FROM nacionalnost";
        List<nacionalnost> list = new List<nacionalnost>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var distributer1 = new nacionalnost();
                string pret = dataReader[0] + "";
                distributer1.idNacionalnost = Int32.Parse(pret);
                distributer1.naziv = dataReader[1] + "";
                list.Add(distributer1);

            }
            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }

    /// <summary>
    /// Vraca popis redatelja iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<redatelj> SelectDirector()
    {
        string query = "SELECT * FROM redatelj";
        List<redatelj> list = new List<redatelj>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var distributer1 = new redatelj();
                string pret = dataReader[0] + "";
                distributer1.idRedatelj = Int32.Parse(pret);
                distributer1.ime = dataReader[1] + "";
                distributer1.prezime = dataReader[2] + "";
                string pret1 = dataReader[3] + "";
                distributer1.datumRodenja = DateTime.Parse(pret1);
                list.Add(distributer1);

            }
            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }

    /// <summary>
    /// Vraca popis zanrova iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<zanr> SelectGenre()
    {
        string query = "SELECT * FROM zanr";
        List<zanr> list = new List<zanr>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var distributer1 = new zanr();
                string pret = dataReader[0] + "";
                distributer1.idZanr = Int32.Parse(pret);
                distributer1.naziv = dataReader[1] + "";
                distributer1.opis = dataReader[2] + "";
                
                list.Add(distributer1);

            }
            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }

    /// <summary>
    /// Vraca popis titlva iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<titl> SelectTitle()
    {
        string query = "SELECT * FROM titl";
        List<titl> list = new List<titl>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var distributer1 = new titl();
                string pret = dataReader[0] + "";
                distributer1.idTitl = Int32.Parse(pret);
                distributer1.jezik = dataReader[1] + "";
                distributer1.putanja = dataReader[2] + "";

                list.Add(distributer1);

            }
            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }

    /// <summary>
    /// Vraca popis clanarina iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<clanarina> SelectMembership()
    {
        string query = "SELECT * FROM clanarina";
        List<clanarina> list = new List<clanarina>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var model1 = new clanarina();
                string bModelId = dataReader[0] + "";
                model1.idClanarina = Int32.Parse(bModelId);
                string prt1 = dataReader[1] + "";
                model1.model = Int32.Parse(prt1);
                string prt2 = dataReader[2] + "";
                model1.korisnik = Int32.Parse(prt2);
                string prt3 = dataReader[3] + "";
                model1.datumAktivacije = prt3;
                string prt4 = dataReader[4] + "";
                model1.datumDeaktivacije = prt4;
                list.Add(model1);

            }
            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }

    /// <summary>
    /// Vraca popis glumaca i filmova iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<filmglumac> SelectMovieActor()
    {
        string query = "SELECT * FROM filmglumac";
        List<filmglumac> list = new List<filmglumac>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var model1 = new filmglumac();
                string pret1 = dataReader[0] + "";
                model1.idFilm = Int32.Parse(pret1);
                string pret2 = dataReader[1] + "";
                model1.idGlumac = Int32.Parse(pret2);
                list.Add(model1);

            }
            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }

    /// <summary>
    /// Vraca popis filmova i redatelja iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<filmredatelj> SelectMovieDirector()
    {
        string query = "SELECT * FROM filmredatelj";
        List<filmredatelj> list = new List<filmredatelj>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var model1 = new filmredatelj();
                string pret1 = dataReader[0] + "";
                model1.idFilm = Int32.Parse(pret1);
                string pret2 = dataReader[1] + "";
                model1.idRedatelj = Int32.Parse(pret2);
                list.Add(model1);

            }
            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }

    /// <summary>
    /// Vraca popis filmova i tilova iz baze u obliku liste objekata
    /// </summary>
    /// <returns></returns>
    public List<filmtitl> SelectMovieTitle()
    {
        string query = "SELECT * FROM filmtitl";
        List<filmtitl> list = new List<filmtitl>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var model1 = new filmtitl();
                string pret1 = dataReader[0] + "";
                model1.idFilm = Int32.Parse(pret1);
                string pret2 = dataReader[1] + "";
                model1.idTitl = Int32.Parse(pret2);
                list.Add(model1);

            }
            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }

   /// <summary>
    /// Vraca popis filmova i zanrova iz baze u obliku liste objekata
   /// </summary>
   /// <returns></returns>
    public List<filmzanr> SelectMovieGenre()
    {
        string query = "SELECT * FROM filmzanr";
        List<filmzanr> list = new List<filmzanr>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var model1 = new filmzanr();
                string pret1 = dataReader[0] + "";
                model1.idFilm = Int32.Parse(pret1);
                string pret2 = dataReader[1] + "";
                model1.idZanr = Int32.Parse(pret2);
                list.Add(model1);

            }
            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }

    public List<glumacnacionalnost> SelectActorNationality()
    {
        string query = "SELECT * FROM filmredatelj";
        List<glumacnacionalnost> list = new List<glumacnacionalnost>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var model1 = new glumacnacionalnost();
                string pret1 = dataReader[0] + "";
                model1.idGlumac = Int32.Parse(pret1);
                string pret2 = dataReader[1] + "";
                model1.idNacionalnost = Int32.Parse(pret2);
                list.Add(model1);

            }
            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }
    /// <summary>
    /// Vraca popis posudbi iz baze u obliku vezane liste objekata
    /// </summary>
    /// <returns></returns>
    public List<posudba> SelectLoan()
    {
        string query = "SELECT * FROM posudba";
        List<posudba> list = new List<posudba>();
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var model1 = new posudba();
                string pret1 = dataReader[0] + "";
                model1.idKorisnik = Int32.Parse(pret1);
                string pret2 = dataReader[1] + "";
                model1.idFilm = Int32.Parse(pret2);
                string prt3 = dataReader[2] + "";
                model1.datumPosudbe = prt3;
                list.Add(model1);

            }
            dataReader.Close();
            this.CloseConnection();
            return list;
        }
        else
        {
            return list;
        }
    }
    }
    
}
