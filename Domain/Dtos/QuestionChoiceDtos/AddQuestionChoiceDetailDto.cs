﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.QuestionChoice
{
    public class AddQuestionChoiceDetailDto
    {
        public string Content { get; set; }
        public bool IsTrue { get; set; }
        public int QuestionId { get; set; }
    }
}
