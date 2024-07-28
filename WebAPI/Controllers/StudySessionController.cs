using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudySessionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudySessionController(ApplicationDbContext context)
        {
            _context = context;

        }

        //Create/Edit
        [HttpPost]
        public JsonResult CreateEdit(StudySession studySession) {
            if (studySession.StudySessionId == null)
            {
                _context.StudySessions.Add(studySession);
            }
            else {
                var studySessionInDb = _context.StudySessions.Find(studySession.StudySessionId);

                if (studySessionInDb == null) { 
                    return new JsonResult(NotFound());
                }

                studySessionInDb = studySession;
            }

            _context.SaveChanges();     //save changes to database after modification

            return new JsonResult(Ok(studySession));

        }
    }
}
