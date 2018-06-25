using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastFM
{
    [XmlRpcUrl("http://ws.audioscrobbler.com/2.0/")]
    public interface FlRPC : IXmlRpcProxy
    {
        [XmlRpcMethod("artist.getTopAlbums")]//endpoint name
        Album Album(request request);
    }
}
