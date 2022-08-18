using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace probarbearia.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        public TesteController()
        {
           
        }

        [HttpGet]
        public string Get()
        {
            return "Retorno via get";
        }
        
        [HttpPost]
        public string post()
        {
            return "Retorno via post";
        }

        
        [HttpPut("{id}")]
        public string put(int id)
        {
            return $"Retorno atualiza id ={id}";
        }

        [HttpDelete("{id}")]
        public string delete(int id)
        {
            return $"Retorno delete id ={id}";
        }
    }



}
