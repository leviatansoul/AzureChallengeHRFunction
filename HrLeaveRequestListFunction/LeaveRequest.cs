using System;
using Newtonsoft.Json;

namespace HrLeaveRequestListFunction
{
    public class LeaveRequest
    {
        [JsonProperty(PropertyName = "employeeId")]
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}

