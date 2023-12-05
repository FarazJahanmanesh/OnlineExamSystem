using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public static class StaticStrings
    {
        //S==>Successful
        //F==>Failed

        #region User

        public const string UserNotFound = "کاربر مورد نظر یافت نشد";
        public const string S_CreateUser = "کاربر با موفقیت ایجاد شد";
        public const string F_CreateUser = "کاربر ایجاد نشد";
        public const string S_DeleteUser = "کاربر با موفقیت حذف شد";
        public const string F_DeleteUser = "عملیات حذف کاربر انجام نشد";
        public const string S_UpdateUser = "کاربر با موفقیت تغییر یافت شد";
        public const string F_UpdateUser = "عملیات تغییر کاربر انجام نشد";

        #endregion

        #region Academy

        public const string AcademyNotFound = "مؤسسه مورد نظر یافت نشد";
        public const string S_CreateAcademy = "مؤسسه با موفقیت ایجاد شد";
        public const string F_CreateAcademy = "مؤسسه ایجاد نشد";
        public const string S_DeleteAcademy = "مؤسسه با موفقیت حذف شد";
        public const string F_DeleteAcademy = "عملیات حذف مؤسسه انجام نشد";
        public const string S_UpdateAcademy = "مؤسسه با موفقیت تغییر یافت شد";
        public const string F_UpdateAcademy = "عملیات تغییر مؤسسه انجام نشد";

        #endregion

        #region Shared

        public const string S_Calling= "فراخوانی با موفقیت انجام شد";
        public const string F_Calling = "امکان فراخوانی وجود ندارد";
        public const string ErrorInSystem = "خطای داخلی سیستم";
        public const string S_Login = "ورود موفقیت آمیز بود";
        public const string F_Login = "رمز عبور یا نام کاربری درست نمی باشد";
        public const string F_ChangePassword = "عملیات تغییر رمز عبور دچار مشکل شد";
        public const string S_ChangePassword = "رمز عبور با موفقیت تغییر کرد";
        public const string NotFound = "موردی یافت نشد";
        
        #endregion

    }
}
