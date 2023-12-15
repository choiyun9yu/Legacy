from django.http import HttpResponse, JsonResponse
from django.views.decorators.http import require_http_methods
from pymongo import MongoClient
# Create your views here.

def index(request):
    return HttpResponse('Hello, world!')

@require_http_methods(["GET"])
def realtime(request):
    # MongoDB 연결 설정
    client = MongoClient('localhost', 27017)

    # MongoDB의 컬렉 가져오기
    db = client.get_database()
    collections = db.ai_drone

    # Distinct field 값 가져오기
    distinct_items = collections.distinct('device_id')

    # MongoDB 연결 닫기
    client.close()

    # Json 응답 변환
    response_data = {
        'distinct_items': distinct_items
    }
    return JsonResponse(response_data)