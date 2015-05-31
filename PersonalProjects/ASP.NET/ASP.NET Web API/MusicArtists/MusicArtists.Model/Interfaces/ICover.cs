using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicArtists.Model.Interfaces
{
    public interface ICover
    {
        int Id { get; set; }
        string Name { get; set; }
        string ImageUrl { get; set; }
    }
}
