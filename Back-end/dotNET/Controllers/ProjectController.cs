using project.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace project.Controllers;

[ApiController]
[EnableCors("CorsPolicy")] // CORS 정책을 컨트롤러에 적용
[Route("/api")]
public class ProjectController : ControllerBase
{
    private readonly ProjectService _projectService; // ProjectService를 사용하기 위한 멤버 변수

    public ProjectController(ILogger<ProjectController> logger, IConfiguration configuration, ProjectService projectService)
    {
        _projectService = projectService; // ProjectService 주입
    }
    

    [HttpGet("example")]
    public IActionResult Get() // 동기 메서드, 메서드가 실행되면 결과를 즉시 반환
    {
        try
        {
            var res = _projectService.Get(); // ProjectService를 사용하여 데이터 가져오기

            if (res.Count == 0) return NotFound();
            return Ok(res);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, "Internal Server Error");
        }
    }

    [HttpPost("example")] // 비동기 메서드, 메서드가 비동기 작업 수행이 완료될 때까지 기다리지 않음 
    public IActionResult GetById()
    {
        try
        {
            var form = Request.Form;
            string? Id = form["Id"];
            if (Id == null) return BadRequest("Invalid request data");
            var res = _projectService.GetById(Id);

            if (Id != null)
                // var response = new { monitorPage = drone }; // JSON 형식의 응답을 생성
                // return Ok(response);
                return Ok(res);
            return NotFound();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }
}