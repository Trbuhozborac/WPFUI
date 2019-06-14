using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstname = "Nemanja";
        private string _lastName;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _selectedPerson;

        public ShellViewModel()
        {
            People.Add(new PersonModel { FirstName = "Nemanja" ,  LastName = "Pilipovic"});
            People.Add(new PersonModel { FirstName = "Dusan", LastName = "Mihajlovic" });
            People.Add(new PersonModel { FirstName = "Nebojsa", LastName = "Blagojevic" });

        }

        public string FirstName
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);

            }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }

        }

       
        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { _people = value; }
        }

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }


    }
}
