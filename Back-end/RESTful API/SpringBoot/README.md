# Spring boot

## 1. 프로젝트 시작하기

### [이니셜라이져](https://start.spring.io)

### 스프링 부트 프로젝트 시작하기

    % sdk install springboot           // 스프링 부트 설치

    % spring init                      // default 값으로 프로젝트 시작 
    % unzip demo.zip -d demo            


    % spring init -a demo -l java --build maven demo    // 설정 값으로 프로젝트 시작
        -a demo : 프로젝트의 아티팩트 ID 설정
        -l java : 프로젝트 기본 언어 (java, kotlin, groovy)
        --build : 빌드 시스템 (maven, gradle)
        -x demo : 이니셜라이저로 만든 프로젝트의 .zip 파일을 'demo' 디렉터리에 압축해제

        --target https://스프링 부트-프로젝트-생성에-사용할-url

### 빌드 도구 설치

    % brew install maven

    % sdk install gradle

### 프로젝트 실행

    % mvn spring-boot:run

    % ./gradlew bootRun