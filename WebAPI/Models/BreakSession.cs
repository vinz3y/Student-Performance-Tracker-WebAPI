using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class BreakSession
    {
        [Key]
        public int BreakSessionId { get; set; }
        public string studyingSubject { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
    }
}
