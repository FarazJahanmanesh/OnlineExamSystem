using Application.Services;
using Database.Repository.Academy;
using Database.Repository.Answer;
using Database.Repository.Exam;
using Database.Repository.Question;
using Database.Repository.QuestionChoice;
using Database.Repository.User;
using Domain.Contracts.Repository;
using Domain.Contracts.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies.Dependencies
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            #region add Dependencies

            services.AddScoped<IExamServices,ExamServices>();
            services.AddScoped<IExamRepository,ExamRepository>();

            services.AddScoped<IUserServices , UserServices> ();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IAcademyServices, AcademyServices>();
            services.AddScoped<IAcademyRepository, AcademyRepository>();

            services.AddScoped<IAnswerServices, AnswerServices>();
            services.AddScoped<IAnswerRepository, AnswerRepository>();

            services.AddScoped<IQuestionChoiceServices, QuestionChoiceServices>();
            services.AddScoped<IQuestionChoiceRepository, QuestionChoiceRepository>();

            services.AddScoped<IQuestionServices, QuestionServices>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();

            #endregion
        }
    }
}
