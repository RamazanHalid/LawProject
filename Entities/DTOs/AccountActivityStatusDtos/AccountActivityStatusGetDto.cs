﻿using Core.Entities;

namespace Entities.DTOs.AccountActivityStatusDtos
{
    public class AccountActivityStatusGetDto : IDto
    {
        public int AccountActivityStatusId { get; set; }
        public string Name { get; set; }
    }
}
