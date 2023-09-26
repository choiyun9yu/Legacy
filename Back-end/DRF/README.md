# DRF(Django REST Framework)

## 1. 프로젝트 시작하기

### 1-4. 프로젝트 구조 

    proejct-name
    ├── db.sqlite3          # 프로젝트에서 사용하는 데이터베이스 파일
    ├── manage.py
    ├── project-name        # Project App이라서 이름 변경 불가
    │   ├── __init__.py     # 디렉토리를 파이썬 패키지로 인식하게끔 하는 역할
    │   ├── __pycache__     
    │   ├── asgi.py
    │   ├── settings.py     # 프로젝트 설정 파일
    │   ├── urls.py         # 요청이 들어오면 어떻게 처리할지 결정
    │   └── wsgi.py         # 위스키, 웹 서버와 장고가 소통하는데 필요한 프로토콜
    └── app-name
        ├── __init__.py
        ├── __pycache__
        ├── admin.py        # 앱을 장고 관리자와 연도하기 위해 필요한 설정 파일
        ├── apps.py         # 앱 설정 파일
        ├── migrations      # 데이터베이스의 변경 사항 히스토리 누적
        ├── models.py       # 앱에서 사용할 데이터 모델 정의
        ├── serializers.py
        ├── tests.py        # 테스트 코드 적어두는 파일
        ├── urls.py 
        └── views.py        # 앱의 메인 로직 처리와 관련된 파일

### 1-2. 프로젝트 생성

    % mkdir proejct-name                
    % cd project-name           

    % pyenv install 3.9.11                  # 파이썬 3.9.11 버전 설치
    % pyenv virtualenv 3.9.11 proejct-name  # venv라는 가상 환경 생성
    % pyenv local proejct-name              # venv 가상 환경 적용

    % pip install django==4.0 djangorestframework==3.13.1  

    % django-admin startproject proejct-name # 프로젝트 생성  
    % python mange.py runserver              # 프로젝트 실행

    % django-admin runserver {ip:port}      # 개발 서버(디버깅 모드, 기본 포트 8000)
    % python manage.py runserver {ip:port}

### 1-2. 앱 생성

    % python manage.py startapp app-name    # 앱 생성

#### project-name/settings.py
    INSTALLED_APPS = [
     ...
    'app-name'
    'rest_framework',   # 장고를 DRF로 사용하기 위해 추가

    ]

### 1-3. 모델 생성

#### projectName/appName/models.py

    from django.db import models

    class ModelName(models.Model):
        char_data = models.CharField(max_length=30)
        text_data = models.TextField()
        int_data = models.IntegerField()
        date_data = models.DateField()
        
#### 테스트 데이터 넣고(movies.json) 마이그레이션

    % python manage.py makemigrations
    % python manage.py migrate
    % python manage.py loaddata test_data.json