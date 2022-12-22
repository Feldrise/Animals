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
            new AnimalNoise { EmitingAnimal = "Chat", Noise = "Maiou" },
            new AnimalNoise { EmitingAnimal = "Chien", Noise = "Ouaf" },
            new AnimalNoise { EmitingAnimal = "Chèvre", Noise = "Beeh" },
            new AnimalNoise { EmitingAnimal = "Vache", Noise = "Meuh" },
            new AnimalNoise { EmitingAnimal = "Oiseau", Noise = "Cuicui" },
            new AnimalNoise { EmitingAnimal = "Loup", Noise = "Ahouu" },
            new AnimalNoise { EmitingAnimal = "Cheval", Noise = "Hiii" },

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
