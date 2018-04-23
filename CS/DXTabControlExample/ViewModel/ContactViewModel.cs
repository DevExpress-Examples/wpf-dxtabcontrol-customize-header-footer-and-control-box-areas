using DevExpress.Mvvm.DataAnnotations;
using DXTabControlExample.Common;
using System;
using System.Windows.Media;

namespace DXTabControlExample.ViewModel {
    [POCOViewModel]
    public class ContactViewModel {
        public virtual int Id { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string CreditCardNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Zip { get; set; }
        public virtual ImageSource Photo { get; set; }
        public virtual DateTime LastUpdate { get; set; }

        public ContactViewModel() { }

        public void Update() {
            LastUpdate = DateTime.Now;
        }
    }
}
