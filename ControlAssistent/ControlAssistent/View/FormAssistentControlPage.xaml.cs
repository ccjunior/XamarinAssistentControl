using ControlAssistent.Model.Entities;
using ControlAssistent.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ControlAssistent.View
{
    public partial class FormAssistentControlPage : ContentPage
    {
        public FormAssistentControlPage()
        {
            InitializeComponent();
            this.BindingContext = new StudentDirectoryVM();
            lvStudents.ItemSelected += LvStudents_ItemSelected;
        }

        private void LvStudents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Student SelectStudent = (Student)e.SelectedItem;
            if (SelectStudent == null)
                return;
            Navigation.PushAsync(new SelecteStudentDetailPage(SelectStudent));
            lvStudents.SelectedItem = null;
        }
    }
}
