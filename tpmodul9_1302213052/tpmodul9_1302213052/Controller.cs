using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302213052.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> dataMH = new List<Mahasiswa>
        {
            new Mahasiswa("Nurul pratiwi", "1302213052"),
            new Mahasiswa("Afny latifa", "1302210071"),
            new Mahasiswa("Muhammad zulfadly", "1302210046"),
            new Mahasiswa("Syahran syaputra", "1302210021"),
            new Mahasiswa("Herlin priatna", "1302213018")
        };

        [HttpGet]

        public IEnumerable<Mahasiswa> Get()
        {
            return dataMH;
        }

        [HttpGet("{id}")]

        public Mahasiswa Get(int id)
        {
            return dataMH[id];
        }

        [HttpPost]

        public void Post([FromBody] Mahasiswa newMH)
        {
            dataMH.Add(newMH);
        }

        [HttpPut("{id}")]

        public void Put(int id, [FromBody] Mahasiswa updateMH)
        {
            dataMH[id] = updateMH;
        }

        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            dataMH.RemoveAt(id);
        }
    }
}

