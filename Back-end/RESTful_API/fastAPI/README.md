# fastAPI

## 1. 프로젝트 시작하기

    % poetry init                   // pyproject.toml 파일 생성
        Package name: {패키지명}
        Version: {이 프로젝트의 버전}
        Description: {설명}
        Author: {작성자}
        License: {라이센스}
        Compatible Python versions: >=3.9
        Package to add or search for: fastapi, uvicorn

    % poetry shell                  // Poetry 쉘 활성화
    % exit

    % uvicorn main:app --reload     // 프로젝트 실행
    

## 2. 프로젝트 구조

        fastAPI/
        ├── app/
        │   ├── __init__.py
        │   ├── main.py         # FastAPI 애플리케이션 인스턴스 생성 및 라우터 통합
        │   ├── routes/
        │   │   ├── __init__.py
        │   │   ├── user.py     # 사용자 관련 라우트 및 연산
        │   │   └── item.py     # 아이템 관련 라우트 및 연산
        │   ├── controllers/
        │   │   ├── __init__.py
        │   │   ├── user.py     # 사용자 관련 비즈니스 로직
        │   │   └── item.py     # 아이템 관련 비즈니스 로직
        │   └── models/
        │       ├── __init__.py
        │       ├── user.py     # 사용자 데이터 모델 및 데이터베이스 연동
        │       └── item.py     # 아이템 데이터 모델 및 데이터베이스 연동
        ├── tests/
        │   ├── __init__.py
        │   ├── test_main.py   # 테스트 코드
        │   ├── test_user.py   # 사용자 관련 테스트 코드
        │   └── test_item.py   # 아이템 관련 테스트 코드
        ├── .gitignore
        ├── pyproject.toml
        ├── poetry.lock
        └── README.md
