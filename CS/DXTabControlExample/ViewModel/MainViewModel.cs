﻿using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DXTabControlExample.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DXTabControlExample.ViewModel {
    public class MainViewModel : ViewModelBase {
        public virtual ObservableCollection<ContactViewModel> Contacts { get; set; }

        public MainViewModel() {
            Contacts = new ObservableCollection<ContactViewModel>() {
                ViewModelSource.Create(()=> new ContactViewModel() {
                    FirstName = "Carolyn", LastName = "Baker", Gender = Gender.Female, Email = "carolyn.baker@example.com", 
                    Phone = "(555)349-3010", Address = "1198 Theresa Cir", City = "Whitinsville", State = "MA", Zip = "01582", LastUpdate = DateTime.Now.AddDays(-2)
                }),
                ViewModelSource.Create(()=> new ContactViewModel() {
                    FirstName = "Amber", LastName = "Seaman", Gender = Gender.Female, Phone = "(555)698-4285",
                    Address = "28700 S Main St", City = "Wilsonville", State = "AL", Zip = "35188", LastUpdate = DateTime.Now.AddDays(-2)
                }),
                ViewModelSource.Create(()=> new ContactViewModel() {
                    FirstName = "Annie", LastName = "Vicars", Gender = Gender.Female, Email = "annie.vicars@example.com", 
                    Phone = "(555)922-1349", Address = "7267 New York Ave", City = "Jersey City", State = "NJ", Zip = "07306", LastUpdate = DateTime.Now.AddDays(-2)
                }),
                ViewModelSource.Create(()=> new ContactViewModel() {
                    FirstName = "Darlene", LastName = "Catto", Gender = Gender.Female, Email = "darlene.catto@example.com", 
                    Phone = "(555)752-0582", Address = "32125 4th St NW #210", City = "Washington", State = "DC", Zip = "20001", LastUpdate = DateTime.Now.AddDays(-2)
                }),
                ViewModelSource.Create(()=> new ContactViewModel() {
                    FirstName = "Angela", LastName = "Gross", Gender = Gender.Female, Email = "angela.gross@example.com", 
                    Phone = "(555)247-1252", Address = "8723 Chicago Ave", City = "Nederland", State = "TX", Zip = "77620", LastUpdate = DateTime.Now.AddDays(-2)
                }),
                ViewModelSource.Create(()=> new ContactViewModel() {
                    FirstName = "Edward", LastName = "Keck", Gender = Gender.Male, Email = "edward.keck@example.com", 
                    Phone = "410-7042", Address = "38202 Greens Rd", City = "Humble", State = "TX", Zip = "77397", LastUpdate = DateTime.Now.AddDays(-2)
                }),
                ViewModelSource.Create(()=> new ContactViewModel() {
                    FirstName = "Angela", LastName = "Walker", Gender = Gender.Female, Email = "angela.walker@example.com", Phone = "555",
                    Address = "8913 Lakeshore Dr", City = "Jacksons Gap", State = "AL", Zip = "36863", LastUpdate = DateTime.Now.AddDays(-2)
                }),
                ViewModelSource.Create(()=> new ContactViewModel() {
                    FirstName = "Alice", LastName = "Martin", Gender = Gender.Female, Email = "alice.martin@example.com", 
                    Phone = "(555)493-8440", Address = "652 Avonwick Gate", City = "Toronto", State = "ON", Zip = "33125", LastUpdate = DateTime.Now.AddDays(-2)
                }),
                ViewModelSource.Create(()=> new ContactViewModel() {
                    FirstName = "Andrew", LastName = "Carter", Gender = Gender.Male, Email = "andrew.carter@example.com", 
                    Phone = "(555)578-3946", Address = "7121 Bailey St", City = "Worcester", State = "MA", Zip = "01605", LastUpdate = DateTime.Now.AddDays(-2)
                }),
                ViewModelSource.Create(()=> new ContactViewModel() {
                    FirstName = "George", LastName = "Morrison", Email = "george.morrison@example.com", Phone = "(555)468-3668",
                    Address = "7716 Country Woods Cir", City = "Kissimmee", State = "FL", Zip = "34747", LastUpdate = DateTime.Now.AddDays(-2)
                }),
            };
            InitializePhotos(Contacts);
        }

        #region InitializePhotos
        void InitializePhotos(IList<ContactViewModel> contacts) {
            foreach (ContactViewModel contact in contacts)
                contact.Photo = GetPhoto(contact);
        }

        ImageSource GetPhoto(string name){
            //return null;
            return new BitmapImage(new Uri("pack://application:,,,/DXTabControlExample;component/Images/" + name, UriKind.Absolute));
        }

        ImageSource GetPhoto(ContactViewModel contact) {
            //return null;
            return GetPhoto(contact.FirstName + contact.LastName + ".jpg");
        } 
        #endregion


        public void UpdateAll() {
            MessageBox.Show("Updated");
        }

        public void Analize()
        {
            MessageBox.Show("Analize");
        }
        public void ShowStatistics()
        {
            MessageBox.Show("Show Statistics");
        }
    }
}
