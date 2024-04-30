from flask import jsonify, Blueprint, request

# from .models import MongoDB, MySQL, Oracle

api_blueprint = Blueprint('api', __name__)

@api_blueprint.route('/', methods=['GET'])
def index():
    ip = request.remote_addr    # 클라이언트 ip

    return '<h1> Welcome Flask Legacy </h1>'

# @api_blueprint.route('/api/mongodb', methods=['GET', 'POST'])
# def read_monogdb():
#     if request.method == 'GET':
#         requset.get_json()
#         fieldName1 = request.args['fieldName1']
#         fieldName2 = request.args['fieldName2']
#         fieldData = MongoDB.get_and(fieldName1, fieldName2)
#         return jsonify({"fieldName1": fieldName1, "fieldName2": fieldName2})
#
#     elif request.method == 'POST':
#         form_data = request.form
#         parsed_data = dict(form_data)
#         periodFrom, periodTo = (parsed_data['periodFrom'], parsed_data['periodTo'])
#         period = Drone.get_period(periodFrom, periodTo)
#         return jsonify({"period": period})












