using project.Hubs;
using project.Service;

namespace project;

public class Startup // 애플리케이션의 초기 설정 및 구성을 담당 
{
    public Startup(IConfiguration configuration) // Startup 클래스의 생서자, IConfiguration 인터페이스의 객체를 매개변수로 받음
    {
        // IConfiguration 인터페이스는 애플리케이션의 구성 정보를 로드하고 읽는데 사용됨
        Configuration = configuration; // 이렇게 하면 Configuration을 통해 appsettings.json의 설정 값을 읽을 수 있음 
    }

    public IConfiguration Configuration { get; }

    // ConfigureServices 메소드, 서비스 컨테이너에 서비스를 추가하는 역할
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers(); // 컨트롤러 서비스 등록, 컨트롤러는 API의 엔드포인트 구성하는데 사용
        services.AddScoped<ProjectService>(); // 드론 서비스 등록,
        services.AddCors(options => // CORS 정책을 추가
        {
            options.AddPolicy("CorsPolicy", builder =>
            {
                // 허용할 오리진을 설정 (프론트엔드의 주소)
                builder.WithOrigins("http://localhost:3000", "http://localhost:3001", "http://localhost:3002",
                        "http://localhost:5000", "http://localhost:5050")
                    .AllowAnyMethod() // 모든 HTTP 메서드 허용
                    .AllowAnyHeader() // 모든 헤더 허용
                    .AllowCredentials(); // 모든 인증 정보 허용 
            });
        });
        services.AddSignalR(); // SignalR 추
    }

    // Configure 메소드는 요청 처리 파이프라인 구성하는 역할
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment()) // 개발환경인지 확인
        {
            // 개밸환경이면 개발자 예외 페이지 사용
            app.UseDeveloperExceptionPage();
        }
        else
        {
            // 개발환경이 아니면 예외처리 및 HSTS(HTTP Strict Transport Security) 사용
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection(); // HTTPS 리다이렉션, HTTP 요청을 HTTPS 요청으로 리다이렉션
        app.UseRouting(); // 라우팅, URL 라우팅 활성화, 요청을 적절한 컨트롤러 액션으로 라우팅하는 데 사용
        app.UseAuthorization(); // 인증 및 권한 부여 미들웨어 추가
        app.UseCors("CorsPolicy");
        // app.UseStaticFiles();     // 정적 파일 서비스, 정적파일을 제공하는 미들웨어 추가

        // 엔드포인트 매핑, 컨트롤러 엔드 포인트를 애플리케이션에 매핑, API 요청을 처리하고 컨트롤러 액션을 실행하는데 사용
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapHub<SignalRHub>("/Hub");
        });
    }
}