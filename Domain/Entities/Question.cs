﻿using Domain.Common;
using Domain.Enums.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Question : BaseEntity
    {
        public float Score { get; set; }
        public string Content { get; set; }
        public ExamTypeEnum ExamType { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public List<QuestionChoice> Choices { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
