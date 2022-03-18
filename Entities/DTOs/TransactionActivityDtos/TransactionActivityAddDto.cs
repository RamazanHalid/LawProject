﻿using Core.Entities;
using System;

namespace Entities.DTOs.TransactionActivityDtos
{
    public class TransactionActivityAddDto : IDto
    {
        public int TransactionActivitySubTypeId { get; set; }
        public string Info { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsItExpense { get; set; }
    }
}
