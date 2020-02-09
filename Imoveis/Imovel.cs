using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Imoveis
{
    class Imovel
    {
        //Codigo do imovel
        private int cod;
        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        //Cidade
        private string cidade;
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        //Rua
        private string rua;
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        //Bairro
        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        //Estado
        private string estado;
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        //Tipo
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        //Foto1
        private string foto1;
        public string Foto1
        {
            get { return foto1; }
            set { foto1 = value; }
        }

        //Foto2
        private string foto2;
        public string Foto2
        {
            get { return foto2; }
            set { foto2 = value; }
        }

        //Foto3
        private string foto3;
        public string Foto3
        {
            get { return foto3; }
            set { foto3 = value; }
        }

        //Foto4
        private string foto4;
        public string Foto4
        {
            get { return foto4; }
            set { foto4 = value; }
        }

        //Area Total
        private int areaT;
        public int AreaT
        {
            get { return areaT; }
            set { areaT = value; }
        }

        //Quartos
        private int quartos;
        public int Quartos
        {
            get { return quartos; }
            set { quartos = value; }
        }

        //Banheiro
        private int banheiro;
        public int Banheiro
        {
            get { return banheiro; }
            set { banheiro = value; }
        }

        //Matricula
        private int matricula;
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        //Area Construida
        private int areaC;
        public int AreaC
        {
            get { return areaC; }
            set { areaC = value; }
        }

        //Especificação
        private string esp;
        public string Esp
        {
            get { return esp; }
            set { esp = value; }
        }

        //Valor
        private int valor;
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        //Nome do cliente
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //Celular do cliente
        private string celular;
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        //Email do cliente
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //Cpf do cliente
        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        //Codigo do funcionario
        private int creci;
        public int Creci
        {
            get { return creci; }
            set { creci = value; }
        }

        //Nome do funcionario
        private string nomeF;
        public string NomeF
        {
            get { return nomeF; }
            set { nomeF = value; }
        }

        //Celular do funcionario
        private string celularF;
        public string CelularF
        {
            get { return celularF; }
            set { celularF = value; }
        }
    }
}
