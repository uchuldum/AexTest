using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cinema.BLL.DTObjects;

namespace Cinema.BLL.Interfaces
{
    public interface IMovieService: IService<MovieDTO>
    {
        Task<IEnumerable<MovieDTO>> GetMovieDTOs(int actors, int[] genre);
        Task<IEnumerable<MovieDTO>> GetMovieDTOs(string name);
    }
}
