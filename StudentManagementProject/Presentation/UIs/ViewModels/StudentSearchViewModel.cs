using StudentManagementProject.Domain.Callbacks;
using StudentManagementProject.Domain.Entities;
using StudentManagementProject.Domain.Usecases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Presentation.UIs.ViewModels
{
    public class StudentSearchViewModel : StudentUseCaseCallback, INotifyPropertyChanged
    {
        public ObservableCollection<Student> Students { get; set; }

        private SearchMode searchMode = SearchMode.BY_NAME;

        private StudentSearchUseCase studentSearchUseCase;

        private StudentPageViewSurface studentPageViewCallback;

        public StudentSearchViewModel(StudentPageViewSurface callback)
        {
            studentSearchUseCase = new StudentSearchUseCase(this);
            studentPageViewCallback = callback;
            Students = new ObservableCollection<Student>();
        }

        public void queryStudent(String key)
        {
            if (key == "")
            {
                queryStudentAll();
            }
            else
            {
                if (searchMode == SearchMode.BY_NAME)
                {
                    queryStudentByName(key);
                }
                else if (searchMode == SearchMode.BY_CLASS_NAME)
                {
                    queryStudentByClassName(key);
                }
            }
        }

        public void changeSearch(SearchMode newSearchMode)
        {
            this.searchMode = newSearchMode;
        }

        private void queryStudentAll()
        {
            studentSearchUseCase.searchAll();
        }

        private void queryStudentByName(String key)
        {
            studentSearchUseCase.searchByName(key);
        }

        private void queryStudentByClassName(String key)
        {
            studentSearchUseCase.searchByClassName(key);
        }

        public void notifyUpdateStudentList(List<Student> resultStudent)
        {
            Students.Clear();
            foreach (Student student in resultStudent)
            {
                Students.Add(student);
            }
        }

        public void notifyUpdateFail()
        {
            studentPageViewCallback.onQueryFail();
        }

        public enum SearchMode{
            BY_NAME,
            BY_CLASS_NAME
        }

        public interface StudentPageViewSurface
        {
            void onQueryFail();
        }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
