using Domain.Contracts.Repository;
using Domain.Entities;
using Domain.Enums.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository.Exam
{
    public class ExamRepository : IExamRepository
    {
        private readonly SystemDbContext dbContext;
        public ExamRepository(SystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task CreateExam()
        {
            await dbContext.AddAsync(new Domain.Entities.Exam
            {
                AcademyId = 1,
                IsActice = true,
                Price = 20000,
                FinallScore = 100,
                Questions = new List<Question>
                    {
                        new Question
                        {
                            ExamType = ExamTypeEnum.Testi,
                            Score=100,
                            Content="test1?",
                            ExamId=1,
                            Choices = new List<QuestionChoice>
                            {
                                new QuestionChoice
                                {
                                    QuestionId = 1,
                                    Content="faraz",
                                    IsTrue=true,
                                },
                                new QuestionChoice
                                {
                                    QuestionId = 1,
                                    Content="ehsan",
                                    IsTrue=false,
                                },
                                 new QuestionChoice
                                {
                                    QuestionId = 1,
                                    Content="mahan",
                                    IsTrue=false,
                                }
                            },
                            Answers= new List<Answer>
                            {
                                new Answer
                                {
                                    IsTrue=true,
                                    QuestionChoiceId=1,
                                    QuestionId=1,
                                    AnswerContent="faraz",
                                }
                            }
                        },
                    }
            });
            await SaveChanges();
        }
        private async Task SaveChanges()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
