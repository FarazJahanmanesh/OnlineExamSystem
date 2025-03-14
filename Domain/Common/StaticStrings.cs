﻿using System;
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

        #region QuestionChoice

        public const string QuestionChoiceNotFound = "جواب مورد نظر یافت نشد";
        public const string S_CreateQuestionChoice = "جواب با موفقیت ایجاد شد";
        public const string F_CreateQuestionChoice = "جواب ایجاد نشد";
        public const string S_DeleteQuestionChoice = "جواب با موفقیت حذف شد";
        public const string F_DeleteQuestionChoice = "عملیات حذف جواب انجام نشد";
        public const string S_UpdateQuestionChoice = "جواب با موفقیت تغییر یافت شد";
        public const string F_UpdateQuestionChoice = "عملیات تغییر جواب انجام نشد";

        #endregion

        #region Answer

        public const string AnswerNotFound = "جواب مورد نظر یافت نشد";
        public const string S_CreateAnswer = "جواب با موفقیت ایجاد شد";
        public const string F_CreateAnswer = "جواب ایجاد نشد";
        public const string S_DeleteAnswer = "جواب با موفقیت حذف شد";
        public const string F_DeleteAnswer = "عملیات حذف جواب انجام نشد";
        public const string S_UpdateAnswer = "جواب با موفقیت تغییر یافت شد";
        public const string F_UpdateAnswer = "عملیات تغییر جواب انجام نشد";

        #endregion
        
        #region Question

        public const string QuestionNotFound = "سوال مورد نظر یافت نشد";
        public const string S_CreateQuestion = "سوال با موفقیت ایجاد شد";
        public const string F_CreateQuestion = "سوال ایجاد نشد";
        public const string S_DeleteQuestion = "سوال با موفقیت حذف شد";
        public const string F_DeleteQuestion = "عملیات حذف سوال انجام نشد";
        public const string S_UpdateQuestion = "سوال با موفقیت تغییر یافت شد";
        public const string F_UpdateQuestion = "عملیات تغییر سوال انجام نشد";

        #endregion

        #region Exam

        public const string ExamNotFound = "امتحان مورد نظر یافت نشد";
        public const string S_CreateExam = "امتحان با موفقیت ایجاد شد";
        public const string F_CreateExam = "امتحان ایجاد نشد";
        public const string S_DeleteExam = "امتحان با موفقیت حذف شد";
        public const string F_DeleteExam = "عملیات حذف امتحان انجام نشد";
        public const string S_UpdateExam = "امتحان با موفقیت تغییر یافت شد";
        public const string F_UpdateExam = "عملیات تغییر امتحان انجام نشد";

        #endregion

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
