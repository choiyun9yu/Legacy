# .NET

## Proejct init

        % dotnet --version

        % dotnet add package [package name] <--version x.y.z>

        % dotnet restore
        % dotnet run

## Project Structure

       ProejctRoot/
        │
        ├── ProjectName.csproj          // 프로젝트 환경 설정 파일
        ├── Controllers/                // 클라이언트 요청을 처리하고 응답을 생용성, 엔드포인트
        │   ├── ...
        ├── Models/                     // 데이터베이스 구조와 비즈니스 엔티티 정의
        │   ├── ...                     // DB 테이블과 일치 or API 요청, 응답과 일치
        ├── Services/                   // Model과 Controller의 중간, 비즈니스 로직 및 데이터 접근 처
        │   ├── ...
        ├── Hubs/                  
        │   ├── SignalRHub.cs           // SignalR 사용하기 위한 모듈 
        ├── Startup.cs                  // 애플리케이션 구성 및 미들웨어 설정
        └── Program.cs                  // main 메소드 정의

### process

- 클라이언트의 요청은 Controller에서 라우팅
- Controller는 필요한 비즈니스 로직을 수행하기 위해 Service를 호출
- Service는 데이터베이스와 상호 작용하거나 다른 데이터 소스와 연동하여 데이터 로드
- 데이터는 Model 객체로 표현되며, Controller는 이 모델을 뷰에 전달하여 응답을 생성
