using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Imoveis
{
    class ImoveisDAL
    {
        //Liga DB ao projeto
        Conexao con = new Conexao();
        Imovel cli = new Imovel();

        //Permite cadastrar no DB
        public void CadastrarImovel(Imovel obj)
        {
            SqlCommand cmd = new SqlCommand("Insert into TB_Imovel(Cidade,Rua,Bairro,Estado,Tipo,Foto1,Foto2,Foto3,Foto4,AreaT,Quartos,Banheiros,Matricula,Area,Esp,Valor,Creci,TelefoneCliente,NomeCliente,CpfCliente,NomeFuncionario,TelefoneFuncionario,EmailCliente) values (@Cidade,@Rua,@Bairro,@Estado,@Tipo,@Foto1,@Foto2,@Foto3,@Foto4,@AreaT,@Quartos,@Banheiros,@Matricula,@AreaG,@NumeroG,@Valor,@Creci,@TelCli,@NomeCli,@CpfCli,@NomeF,@TelF,@Email)", con.Conectar());
            cmd.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = obj.Cidade;
            cmd.Parameters.Add("@Rua", SqlDbType.VarChar).Value = obj.Rua;
            cmd.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = obj.Bairro;
            cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = obj.Estado;
            cmd.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = obj.Tipo;
            cmd.Parameters.Add("@Foto1", SqlDbType.VarChar).Value = obj.Foto1;
            cmd.Parameters.Add("@Foto2", SqlDbType.VarChar).Value = obj.Foto2;
            cmd.Parameters.Add("@Foto3", SqlDbType.VarChar).Value = obj.Foto3;
            cmd.Parameters.Add("@Foto4", SqlDbType.VarChar).Value = obj.Foto4;
            cmd.Parameters.Add("@AreaT", SqlDbType.Int).Value = obj.AreaT;
            cmd.Parameters.Add("@Quartos", SqlDbType.Int).Value = obj.Quartos;
            cmd.Parameters.Add("@Banheiro", SqlDbType.Int).Value = obj.Banheiro;
            cmd.Parameters.Add("@Matricula", SqlDbType.Int).Value = obj.Matricula;
            cmd.Parameters.Add("@AreaC", SqlDbType.Int).Value = obj.AreaC;
            cmd.Parameters.Add("@Esp", SqlDbType.Int).Value = obj.Esp;
            cmd.Parameters.Add("@Valor", SqlDbType.Money).Value = obj.Valor;
            cmd.Parameters.Add("@Creci", SqlDbType.Int).Value = obj.Creci;
            cmd.Parameters.Add("@TelCli", SqlDbType.VarChar).Value = obj.Celular;
            cmd.Parameters.Add("@NomeCli", SqlDbType.VarChar).Value = obj.Nome;
            cmd.Parameters.Add("@CpfCli", SqlDbType.VarChar).Value = obj.Cpf;
            cmd.Parameters.Add("@NomeF", SqlDbType.VarChar).Value = obj.NomeF;
            cmd.Parameters.Add("@TelF", SqlDbType.VarChar).Value = obj.CelularF;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = obj.Email;
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        //Permite excluir no DB, usando o codigo como parametro
        public void ExcluirImovel(Imovel excluirImovel)
        {
            SqlCommand cmd = new SqlCommand("delete from TB_Imovel where CodImovel = @Cod", con.Conectar());
            cmd.Parameters.Add("@Cod", SqlDbType.Int).Value = excluirImovel.Cod;
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        //Permite consultar no DB, usando a cidade como parametro
        public DataTable ConsultaCidade(string nome)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TB_Imovel where Cidade like @Nome", con.Conectar());
            da.SelectCommand.Parameters.Add("@Nome", SqlDbType.VarChar).Value = "%" + nome + "%";
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Desconectar();
            return ds.Tables[0];
        }

        //Permite consultar no DB, usando a rua como parametro
        public DataTable ConsultaRua(string nome)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TB_Imovel where Rua like @Nome", con.Conectar());
            da.SelectCommand.Parameters.Add("@Nome", SqlDbType.VarChar).Value = "%" + nome + "%";
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Desconectar();
            return ds.Tables[0];
        }

        //Permite consultar no DB, usando o bairro como parametro
        public DataTable ConsultaBairro(string nome)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TB_Imovel where Bairro like @Nome", con.Conectar());
            da.SelectCommand.Parameters.Add("@Nome", SqlDbType.VarChar).Value = "%" + nome + "%";
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Desconectar();
            return ds.Tables[0];
        }

        //Permite consultar no DB, usando o tipo como parametro
        public DataTable ConsultaTipo(string nome)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TB_Imovel where Tipo like @Nome", con.Conectar());
            da.SelectCommand.Parameters.Add("@Nome", SqlDbType.VarChar).Value = "%" + nome + "%";
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Desconectar();
            return ds.Tables[0];
        }

        //Permite consultar no DB, usando o valor como parametro
        public DataTable ConsultaValor(int obj)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TB_Imovel where Valor like @Obj", con.Conectar());
            da.SelectCommand.Parameters.Add("@Obj", SqlDbType.Money).Value = "%" + obj + "%";
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Desconectar();
            return ds.Tables[0];
        }

        //Permite consultar no DB, usando a area total como parametro
        public DataTable ConsultaArea(int obj)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TB_Imovel where AreaT like @Obj", con.Conectar());
            da.SelectCommand.Parameters.Add("@Obj", SqlDbType.Int).Value = "%" + obj + "%";
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Desconectar();
            return ds.Tables[0];
        }

        //Permite consultar no DB, usando os quartos como parametro
        public DataTable ConsultaQuarto(int obj)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TB_Imovel where Quarto like @Obj", con.Conectar());
            da.SelectCommand.Parameters.Add("@Obj", SqlDbType.Int).Value = "%" + obj + "%";
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Desconectar();
            return ds.Tables[0];
        }

        //Permite consultar no DB, usando os banheiros como parametro
        public DataTable ConsultaBanheiro(int obj)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TB_Imovel where Banheiro like @Obj", con.Conectar());
            da.SelectCommand.Parameters.Add("@Obj", SqlDbType.Int).Value = "%" + obj + "%";
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Desconectar();
            return ds.Tables[0];
        }

        //Permite consultar no DB, usando o numero de Galpões como parametro
        public DataTable ConsultaNumGalp(int obj)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TB_Imovel where NumeroG like @Obj", con.Conectar());
            da.SelectCommand.Parameters.Add("@Obj", SqlDbType.Int).Value = "%" + obj + "%";
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Desconectar();
            return ds.Tables[0];
        }

        //Permite consultar no DB, usando a area dos Galpões como parametro
        public DataTable ConsultaAreaGalp(int obj)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TB_Imovel where AreaG like @Obj", con.Conectar());
            da.SelectCommand.Parameters.Add("@Obj", SqlDbType.Int).Value = "%" + obj + "%";
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Desconectar();
            return ds.Tables[0];
        }
    }
}
