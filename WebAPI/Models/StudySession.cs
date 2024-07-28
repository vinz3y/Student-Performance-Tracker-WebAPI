using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class StudySession
    {
        [Key]
        public int StudySessionId { get; set; }
        public string studyingSubject { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string knowledgeLevel { get; set; }
    }
}
