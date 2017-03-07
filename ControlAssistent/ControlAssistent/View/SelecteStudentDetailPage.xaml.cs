using ControlAssistent.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ControlAssistent.View
{
    public partial class SelecteStudentDetailPage : ContentPage
    {
        public SelecteStudentDetailPage(Student SelectStudent)
        {
            InitializeComponent();
            this.BindingContext = SelectStudent;
        }
    }
}
