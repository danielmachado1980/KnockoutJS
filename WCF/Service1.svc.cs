using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        //public UserDetail GetAllUserById(int id)
        //{

        //    TestDBEntities tstDb = new TestDBEntities();
        //    var lstUsr = from k in tstDb.UserDetails where k.Id == id select k;
        //    UserDetail usr = new UserDetail();
        //    foreach (var item in lstUsr)
        //    {

        //        usr.Id = item.Id;
        //        usr.Name = item.Name;
        //        usr.Email = item.Email;


        //    }

        //    return usr;
        //}

        //[WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        //public List<Models.Conta> GetAllContas()
        //{
        //    List<Models.Conta> lstContas = new List<Models.Conta>();
        //    using (var db = new ProvaEntities())
        //    {
        //        lstContas = db.Conta.ToList();
        //        return lstContas;
        //    }
        //}

        public int AddUser(string Name, string Email)
        {
            throw new NotImplementedException();
        }

        Contato IService1.GetAllUserById(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateUser(int Id, string Name, string Email)
        {
            throw new NotImplementedException();
        }

        public int DeleteUserById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Contato> GetAllContatos()
        {
            throw new NotImplementedException();
        }
    }
}
