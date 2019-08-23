using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLibros.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace WebApiBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Libro>> Get()
        {
            var Autor1 = new Autor() { id = 1, Nombre = "Pedro", Apellido = "Garcia" };
            var Autor2 = new Autor() { id = 2, Nombre = "Carlos", Apellido = "Ortega" };
            var Autor3 = new Autor() { id = 3, Nombre = "Adollfo", Apellido = "Lopez" };
            var Autor4 = new Autor() { id = 4, Nombre = "Gedrald", Apellido = "Gonzalez" };

            var Libros = new List<Libro>()
            {
                new Libro(){id=1, Titulo = "El Silencio de la Ciudad Blanca", Descripcion="Una Novel de la Policial de intriga y trajedia", Portada="https://www.planetadelibros.com/usuaris/libros/fotos/212/m_libros/portada_el-silencio-de-la-ciudad-blanca_eva-garcia-saenz-de-urturi_201704051340.jpg", Fecha=DateTime.Now, Autor= Autor1 },
                new Libro(){id=2, Titulo = "El Principito", Descripcion="Es el relato corto mas conocido, el hombre puede ser nuevamente niño", Portada="https://http2.mlstatic.com/el-principito-y-yo-cuento-personalizado-tapa-dura-19x26-cm-D_NQ_NP_639471-MLM31682862307_082019-F.jpg", Fecha=DateTime.Now, Autor= Autor2},
                new Libro(){id=3, Titulo = "La Leccion de August", Descripcion="Su cara lo hace distinto y el solo quiere ser uno mas", Portada="https://images-na.ssl-images-amazon.com/images/I/41AJDeR1ARL._SX328_BO1,204,203,200_.jpg", Fecha=DateTime.Now , Autor= Autor3},
                new Libro(){id=4, Titulo = "Steve Jobs", Descripcion="La muerte de Steve Jobs conmociono al mundo", Portada="https://imagessl1.casadellibro.com/a/l/t5/81/9788499921181.jpg", Fecha=DateTime.Now , Autor= Autor4}
            };


            return Libros;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
