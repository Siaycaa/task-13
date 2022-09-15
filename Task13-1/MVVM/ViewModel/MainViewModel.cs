using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Task13_1.MVVM.Core;
using Task13_1.MVVM.Model.Data;

namespace Task13_1.MVVM.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Свойства

        #region Отдел
        public static string? DepartmentName { get; set; }
        #endregion
        #region Должность 
        public static string? PositionName { get; set; }
        public static decimal PositionSalary { get; set; }
        public static int PositionMaxCountOfEmp { get; set; }
        public static Department? PositionDepartment { get; set; }
        #endregion

        #region Сотрудники

        public static string? EmployeeName { get; set; }
        public static string? EmployeeSurname { get; set; }
        public static string? EmployeePhone { get; set; }
        public static Position? EmployeePosition { get; set; }
        #endregion
        #region Выделенный элемент

        public TabItem? SelectedTabItem { get; set; }
        public static Employee? SelectedEmployee { get; set; }
        public static Position? SelectedPosition { get; set; }
        public static Department? SelectedDepartment { get; set; }
        #endregion

        #region Все отделы 
        private List<Department> _allDepartments = DataWorker.GetAllDepartments();
        public List<Department> AllDepartments
        {
            get { return _allDepartments; }
            set
            {
                _allDepartments = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Все должности

        private List<Employee> _allEmployees = DataWorker.GetAllEmployees();
        public List<Employee> AllEmployees
        {
            get { return _allEmployees; }
            set {
                _allEmployees = value;
                OnPropertyChanged();
            }
        }
        #endregion


        #region Открытие и центрирование окон

        #region Окна добавления 


        public void OpenAddNewDepartmentWindow()
        {
            AddNewDepartmentWindow addNewDepartmentWindow = new AddNewDepartmentWindow();
            SetCenterPositionAndOpenWindow(addNewDepartmentWindow);
        }
        public void OpenAddNewPositionWindow()
        {
            AddNewPositionWindow addNewPositionWindow = new AddNewPositionWindow();
            SetCenterPositionAndOpenWindow(addNewPositionWindow);
        }
        public void OpenAddEmployeeWindow()
        {
            AddNewEmployeeWindow addNewEmployeeWindow = new AddNewEmployeeWindow();
            SetCenterPositionAndOpenWindow(addNewEmployeeWindow);
        }
        #endregion

        #region Окна редактирования
        public void OpenEditDepartmentWindow(Department department)
        {
            EditDepartmentWindow editDepartmentWindow = new EditDepartmentWindow(department);
            SetCenterPositionAndOpenWindow(editDepartmentWindow);
        }
        public void OpenEditPositionWindow(Position position)
        {
            EditPositionWindow editDepartmentWindow = new EditPositionWindow(position);
            SetCenterPositionAndOpenWindow(editPositionWindow);
        }

        public void OpenEditEmployeeWindow(Employee employee)
        {
            EditEmployeeWindow editEmployeeWindow = new EdiEmployeeWindow(employee);
            SetCenterPositionAndOpenWindow(editEmployeeWindow);
        }
        #endregion

        #region Центрирование окон

        private void SetCenterPositionAndOpenWindow(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }
        #endregion

        #region Команды открытия окно
        #region Окна добавления

        private readonly RelayCommand? _openAddDepartmentWindow;

        public RelayCommand OpenAddNewEmployeeWindow
        {
            get 
            {
                return _openAddDepartmentWindow ?? new RelayCommand(e=> { OpenAddNewDepartmentWindow(); })

            }
        }






    }
}
