using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteArgo.Data;
using TesteArgo.Entities;

namespace TesteArgo
{
    /// <summary>
    /// Nessa classe deve ser feito o acesso a banco de dados
    /// Dados de conexao do banco de dados
    /// host: den1.mssql6.gear.host
    /// base: testecore
    /// user:testecore
    /// senha : Dz2iI~!U1Edq
    /// 
    /// Tabela Destino
    /// 
    /// Colunas:
    /// DestinoId inteiro 
    /// Nome texto nulavel
    /// Dia data nulavel
    /// 
    /// </summary>
    public class Teste5
    {
		public Repository<Destino> Repository { get; set; }

		public Teste5()
		{
			Repository = new Repository<Destino>(new TestContext());
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filtro"></param>
		/// <returns></returns>
		public List<object> ListarDestino()
        {
			var Destinos = Repository.GetAll();
			return Destinos.Cast<object>().ToList();
        }

        public object BuscarPorId(int id)
        {
			return Repository.GetById(id);
		}
    }
}
