﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.V1.TodoItemOperation
{
    public class TodoItemDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
