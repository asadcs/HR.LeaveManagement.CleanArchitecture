﻿using HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailsRequest:IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
