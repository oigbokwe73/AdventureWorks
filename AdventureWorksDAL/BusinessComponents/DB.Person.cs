using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorksDAL.DataContext;
using System.Configuration;

namespace AdventureWorksDAL.BusinessComponents
{
    public partial class  AdventureWorksDataContext
    {

        public List<Person> PersonList()
        {
            var getPerson = Execute<List<Person>>(dal =>
            {
                var item = dal.Person.Skip(0).Take(100);
                return item.ToList();
            });
            return getPerson;
        }

        public List<Person> PersonListAll()
        {
            var getPerson = Execute<List<Person>>(dal =>
            {
                var item = dal.Person;
                return item.ToList();
            });
            return getPerson;
        }

        public bool PersonUpdate(Person person)
        {
            return Execute<bool>(dal =>
           {
               Person personUpdate = dal.Person.Where(x => x.BusinessEntityID == person.BusinessEntityID).FirstOrDefault();
               if (personUpdate != null)
               {
                   personUpdate.BusinessEntityID = person.BusinessEntityID;
                   personUpdate.PersonType = person.PersonType;
                   personUpdate.NameStyle = person.NameStyle;
                   personUpdate.Title = person.Title;
                   personUpdate.FirstName = person.FirstName;
                   personUpdate.MiddleName = person.MiddleName;
                   personUpdate.LastName = person.LastName;
                   personUpdate.Suffix = person.Suffix;
                   personUpdate.EmailPromotion = person.EmailPromotion;
                   personUpdate.AdditionalContactInfo = person.AdditionalContactInfo;
                   personUpdate.Demographics = person.Demographics;
                   personUpdate.rowguid = person.rowguid;
                   personUpdate.ModifiedDate = person.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool PersonAdd(Person person)
        {
            return Execute<bool>(dal =>
            {
                Person personAdd = dal.Person.Where(x => x.BusinessEntityID == person.BusinessEntityID).FirstOrDefault();
                if (personAdd == null)
                {
                    var personToAdd = dal.Person.OrderByDescending(x => x.BusinessEntityID).FirstOrDefault();
                    person.BusinessEntityID = personToAdd.BusinessEntityID + 1;
                    person.rowguid = Guid.NewGuid();
                    person.Demographics = personToAdd.Demographics;
                    person.ModifiedDate = DateTime.Now;
                    dal.Person.InsertOnSubmit(person);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool PersonDelete(Person person)
        {
            return Execute<bool>(dal =>
            {
                Person personDelete = dal.Person.Where(x => x.BusinessEntityID == person.BusinessEntityID).FirstOrDefault();
                if (personDelete != null)
                {
                    dal.Person.DeleteOnSubmit(personDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}
