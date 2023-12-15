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

#### Poetry 사용
    % poetry init                   // pyproject.toml 파일 생성
        Package name: {패키지명}
        Version: {이 프로젝트의 버전}
        Description: {설명}
        Author: {작성자}
        License: {라이센스}
        Compatible Python versions: >=3.9
        Package to add or search for: django, djangorestframework

    % poetry shell                  // Poetry 쉘 활성화
    % exit                          // Poetry 쉘 비활성화

    % python manage.py runserver ip:8000  // 개발 서버 실행

#### Pyenv 사용
    % mkdir proejct-name                
    % cd project-name           

    % pyenv install 3.9.11                  # 파이썬 3.9.11 버전 설치
    % pyenv virtualenv 3.9.11 proejct-name  # venv라는 가상 환경 생성
    % pyenv local proejct-name              # venv 가상 환경 적용

    % pip install django==4.0 djangorestframework==3.13.1

### 1-2. 프로젝트 생성 

    % django-admin startproject project-name # 프로젝트 생성  
    % python mange.py runserver              # 프로젝트 실행

    % django-admin runserver {ip:port}      # 개발 서버(디버깅 모드, 기본 포트 8000)
    % python manage.py runserver {ip:port}

### 1-3. 앱 생성 및 설정

    % python manage.py startapp app-name    # 앱 생성

#### project-name/settings.py
    INSTALLED_APPS = [
     ...
    'app-name'
    'rest_framework',   # 장고를 DRF로 사용하기 위해 추가
    ]

    # mongodb 데이터베이스 연결을 아직 성공 못함, Djagno는 NoSQL과 호환이 좋은 편은 아닌듯, NoSQL을 메인으로 쓰려면 Flask 또는 fastAPI를 쓰는게 좋아보임
    DATABASES = {
        'default': {
            'ENGINE': 'djongo',
            'NAME': 'my_mongodb_database_name',
        }
    }

    TIME_ZONE = 'Asia/Seoul'

    DEBUG = True

### 1-5. 모델 생성

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


<br>
<br>

## 2. 어플리케이션 개발

### 2-1. urls 작성

### 2-2. views 작성