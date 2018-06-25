using LastFM;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace LastFM
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable datatable = new DataTable();
            StreamReader streamreader = new StreamReader(@"C:\Users\Jeremy\Desktop\hetrec2011-lastfm-2k\artists.dat");
            char[] delimiter = new char[] { '\t' };
            string[] columnheaders = streamreader.ReadLine().Split(delimiter);
            foreach (string columnheader in columnheaders)
            {
                datatable.Columns.Add(columnheader); // I've added the column headers here.
            }

            while (streamreader.Peek() > 0)
            {
                DataRow datarow = datatable.NewRow();
                datarow.ItemArray = streamreader.ReadLine().Split(delimiter);
                datatable.Rows.Add(datarow);
            }
            String name="";
            String url;
            String[] urlArray= { };
            String tab = "\t";
            String artistID = "";
            String filePath = "C:\\Users\\Jeremy\\Desktop\\top50TracksByArtist.tsv";
            foreach (DataRow row in datatable.Rows)
            {
                Console.WriteLine("----Row No: " + datatable.Rows.IndexOf(row) + "----");
                foreach (DataColumn column in datatable.Columns)
                {
                    if (column.ColumnName=="url")
                    {
                        url = (String)row[column];
                        urlArray = url.Split('/');
                    }
                    if (column.ColumnName == "id")
                        artistID = (String)row[column];
                }
                name = urlArray[urlArray.Length-1];
                byte[] bytes = Encoding.Default.GetBytes(name);
                name = Encoding.UTF8.GetString(bytes);
                name = name.Replace("%2B", "%20");
                /*name = name.Replace("%2526", "%26");
                name = name.Replace("%2527", "%27");
                name = name.Replace("%252F", "%2F");
                name = name.Replace("%25C3", "%C3");
                name = name.Replace("%25A9", "%A9");
                name = name.Replace("%252C", "%2C");
                name = name.Replace("%2523", "%23");*/
                name = name.Replace("%25", "%");
                //name = name.Replace("%25", "%26");

                using (var client = new WebClient())
                {
                    //var json = client.DownloadString("http://ws.audioscrobbler.com/2.0/?method=artist.gettopalbums&artist="+name+"&api_key=63c72dab50883717ce7f43ae709acc6f&autocorrect=1&limit=30&format=json");
                    var json = client.DownloadString("http://ws.audioscrobbler.com/2.0/?method=artist.gettoptracks&artist=" + name + "&api_key=63c72dab50883717ce7f43ae709acc6f&autocorrect=1&format=json");
                    var serializer = new JavaScriptSerializer();
                    var topalbums = serializer.Deserialize<RootObject>(json);
                    //ShowAlbum(topalbums.topalbums.album[0]);
                    //Console.ReadLine();

                    using (StreamWriter writer = new StreamWriter(filePath,true))
                    {
                        var line = "";
                        if (topalbums.toptracks != null)
                        {
                            foreach (Track track in topalbums.toptracks.track)
                            {
                                line = string.Join(tab, artistID, track.mbid, track.name, track.playcount, track.url);
                                writer.WriteLine(line);
                            }
                        }
                        else
                            writer.WriteLine("Could not find: " + artistID);
                        
                    }
                }
                

            }
            Console.ReadLine();
            
            

        }
        static HttpClient client = new HttpClient();
        static void ShowAlbum(Album album)
        {
            Console.WriteLine("Album: " + album.name);
        }

    }


public class Track
    {
        public string name { get; set; }
        public string playcount { get; set; }
        public string listeners { get; set; }
        public string mbid { get; set; }
        public string url { get; set; }
        public string streamable { get; set; }
        public Artist artist { get; set; }
        public List<Image> image { get; set; }
}

public class Attr2
{
    public string artist { get; set; }
    public string page { get; set; }
    public string perPage { get; set; }
    public string totalPages { get; set; }
    public string total { get; set; }
}

public class Toptracks
{
    public List<Track> track { get; set; }
    public Attr2 __invalid_name__Attr { get; set; }
}


}
