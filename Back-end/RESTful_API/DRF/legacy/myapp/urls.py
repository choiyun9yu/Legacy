from django.urls import path
from . import views

urlpatterns = [
    # 작성된 뷰를 URL과 연결하려면 .as_view()함수 사용
    path('', views.index, name='index'),
    path('api/realtime', views.realtime, name='realtime'),
]