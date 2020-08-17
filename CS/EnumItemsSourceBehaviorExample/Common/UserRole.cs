using DevExpress.Mvvm.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EnumItemsSourceBehaviorExample.Common {
    public enum UserRole {
        [Image("pack://application:,,,/Images/Admin.png"), Display(Name = "Admin", Description = "High level of access")]
        Administrator,
        [Image("pack://application:,,,/Images/Moderator.png"), Display(Name = "Moderator", Description = "Average level of access")]
        Moderator,
        [Image("pack://application:,,,/Images/User.png"), Display(Name = "User", Description = "Low level of access")]
        User
    }
}
