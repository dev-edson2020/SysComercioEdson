using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
   public class NProdutoProblema
    {

        //Método Inserir
        public static string Inserir(string codigo, string nome, string descricao, byte[] imagem, int idcategoria, int idapresentacao )
        {
            DProdutoProblema Obj = new CamadaDados.DProdutoProblema();
            Obj.Codigo = codigo;
            Obj.Nome = nome;
            Obj.Descricao = descricao;
            Obj.Imagem = imagem;
            Obj.IdCategoria = idcategoria;
            Obj.IdApresentacao = idapresentacao;

            return Obj.Inserir(Obj);
        }


        //Método Editar
        public static string Editar(int id, string codigo, string nome, string descricao, byte[] imagem, int idcategoria, int idapresentacao)
        {
            DProdutoProblema Obj = new CamadaDados.DProdutoProblema();
            Obj.Id = id;
            Obj.Codigo = codigo;
            Obj.Nome = nome;
            Obj.Descricao = descricao;
            Obj.Imagem = imagem;
            Obj.IdCategoria = idcategoria;
            Obj.IdApresentacao = idapresentacao;

            return Obj.Editar(Obj);
        }



        //Método Deletar
        public static string Excluir(int id)
        {
            DProdutoProblema Obj = new CamadaDados.DProdutoProblema();
            Obj.Id = id;

            return Obj.Excluir(Obj);
        }


        //Método Mostrar
        public static DataTable Mostrar()
        {
            return new DProdutoProblema().Mostrar();


        }


        //Método Buscar Nome
        public static DataTable BuscarNome(string textobuscar)
        {
            DProdutoProblema Obj = new DProdutoProblema();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNome(Obj);
        }

    }
}
