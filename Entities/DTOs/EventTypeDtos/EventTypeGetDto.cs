﻿using Core.Entities;

namespace Entities.DTOs.EventTypeDtos
{
    public class EventTypeGetDto : IDto
    {
        public int EventTypeId { get; set; }
        public string EventTypeName { get; set; }
    }
}
