using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Animals.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoisesController : ControllerBase
    {
        private static readonly List<AnimalNoise> _noises = new List<AnimalNoise>()
        {
            new AnimalNoise { EmitingAnimal = "Chat", Noise = "Maiou", Gif = "https://media.tenor.com/w0Rv_cu3bJAAAAAC/kitty-cute.gif" },
            new AnimalNoise { EmitingAnimal = "Chien", Noise = "Woof", Gif = "https://media.tenor.com/Ap-ir05SOYoAAAAd/kratu-woof.gif" },
            new AnimalNoise { EmitingAnimal = "Chèvre", Noise = "Meeh", Gif = "https://media.tenor.com/b49RbivGBtMAAAAC/meh-goat.gif" },
            new AnimalNoise { EmitingAnimal = "Vache", Noise = "Mooo", Gif = "https://media.tenor.com/HrQjb0uaON8AAAAC/cow-wig.gif"},
            new AnimalNoise { EmitingAnimal = "Oiseau", Noise = "Ca-caw", Gif = "https://media.tenor.com/AGK60H059oIAAAAC/crow-bird.gif" },
/*            new AnimalNoise { EmitingAnimal = "Loup", Noise = "Ahouu" },
            new AnimalNoise { EmitingAnimal = "Cheval", Noise = "Hiii" },
*/
        };

        /// <summary>
        /// Récupère tous les bruits d'animaux
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IList<AnimalNoise>> GetAll()
        {
            return Ok(_noises);
        }

        /// <summary>
        /// Récupère un bruit d'animal aléatoirement
        /// </summary>
        /// <returns></returns>
        [HttpGet("random")]
        public ActionResult<AnimalNoise> GetRandomNoise()
        {
            Random rnd = new();
            int r = rnd.Next(_noises.Count);

            return Ok(_noises[r]);
        }
    }
}
