using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteArgo.Entities;
using TesteArgo.Utils;

namespace TesteArgo
{
    public class Teste4
    {
        ///www.omdbapi.com/
        const string ApiKey = "18693fd6";
		const string ApiUrl = "http://www.omdbapi.com/";
		
        /// <summary>
        /// By Search
        /// www.omdbapi.com/?s=titulo&apikey=18693fd6
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<Filme> ListarFilmes(string filtro)
        {
			var HttpHelper = new HttpHelper<OmdResult>();

			var Parametros = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("s", filtro),
				new KeyValuePair<string, string>("apikey", ApiKey),
			};

			var GetTask = Task.Run(async () => await HttpHelper.Get(ApiUrl, Parametros.ToArray()));
			GetTask.Wait();
			var Result = GetTask.Result;

			if (!(Result is Result<OmdResult>))
				return null;

			if (Result.ContainError())
				throw new Exception(string.Join(",", Result.Errors.Select(x => x.Text)));

			return Result.Data.Search.Select(x => new Filme(x)).ToList();
        }

        /// <summary>
        /// By ID or Title
        /// www.omdbapi.com/?i=tt0372784&apikey=18693fd6
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Filme ListarPorId(string id)
        {
			var HttpHelper = new HttpHelper<Movie>();

			var Parametros = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("i", id),
				new KeyValuePair<string, string>("apikey", ApiKey),
			};

			var GetTask = Task.Run(async () => await HttpHelper.Get(ApiUrl, Parametros.ToArray()));
			GetTask.Wait();
			var Result = GetTask.Result;

			if (!(Result is Result<Movie>))
				return null;

			if (Result.ContainError())
				throw new Exception(string.Join(",", Result.Errors.Select(x => x.Text)));

			return new Filme(Result.Data);
		}
    }

    
}
