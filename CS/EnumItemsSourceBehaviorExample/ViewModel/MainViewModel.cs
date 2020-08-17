using System.Collections.ObjectModel;
using DevExpress.Mvvm.POCO;
using EnumItemsSourceBehaviorExample.Common;

namespace EnumItemsSourceBehaviorExample.ViewModel {
    public class MainViewModel {
        protected MainViewModel() {
            Users = new ObservableCollection<User>() {
                User.Create(0, "Jack", UserRole.Administrator),
                User.Create(1, "Ron", UserRole.User),
                User.Create(2, "John", UserRole.User),
                User.Create(3, "Antoni", UserRole.User),
                User.Create(4, "Paul", UserRole.Moderator),
            };
            SelectedRole = UserRole.User;
        }
        public static MainViewModel Create() {
            return ViewModelSource.Create(() => new MainViewModel());
        }

        public virtual ObservableCollection<User> Users { get; set; }
        public virtual UserRole SelectedRole { get; set; }
    }
}
