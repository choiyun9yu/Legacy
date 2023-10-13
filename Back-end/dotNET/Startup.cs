using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    // ConfigureServices 메소드, 서비스 컨테이너에 서비스를 추가하는 역할
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();  // 컨트롤러 서비스 등록, 컨트롤러는 API의 엔드포인트 구성하는데 사용
    }

    // Configure 메소드는 요청 처리 파이프라인 구성하는 역할
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())    // 개발환경인지 확인
        {   // 개밸환경이면 개발자 예외 페이지 사용
            app.UseDeveloperExceptionPage();
        }
        else
        {   // 개발환경이 아니면 예외처리 및 HSTS(HTTP Strict Transport Security) 사용
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }


        app.UseHttpsRedirection();  // HTTPS 리다이렉션, HTTP 요청을 HTTPS 요청으로 리다이렉션
//        app.UseStaticFiles();     // 정적 파일 서비스, 정적파일을 제공하는 미들웨어 추가
        app.UseRouting();           // 라우팅, URL 라우팅 활성화, 요청을 적절한 컨트롤러 액션으로 라우팅하는 데 사용
        app.UseAuthorization();     // 인증 및 권한 부여 미들웨어 추가

        // 엔드포인트 매핑, 컨트롤러 엔드 포인트를 애플리케이션에 매핑, API 요청을 처리하고 컨트롤러 액션을 실행하는데 사용
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
