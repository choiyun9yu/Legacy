from flask_pymongo import PyMongo
import pymysql as ps
import cx_Oracle 

mongo = PyMongo()

class MongoDB:
    @staticmethod
    def get_datas():
        cursor = mongo.db.collectionName.find()
        data_list = list(cursor)

        return data_list

    @staticmethod
    def get_distinct():
        cursor = mongo.db.collectionName.distinct('id')
        distinct_list = list(cursor)

        return distinct_list

    @staticmethod
    def get_sort():
        sort_order = [("FieldName", 1)]    # 1 오름차순, -1 내림차순
        cursor = mongo.db.collectionName.find().sourt(sort_order)
        sort_list = list(cursor)

        return sort_list

    @staticmethod
    def get_period(periodFrom, periodTo):
        query = {"timestampFieldName": {
                    "$gte": periodFrom,
                    "$lte": periodTo
                }}
        cursor = mongo.db.ai_drone.find(query)
        time_list = list(cursor)

        return time_list

    @staticmethod
    def get_and(fieldName1, fieldName2):
        query = {
            "$and": [
                {"fieldName1": fieldName1},
                {"fieldName2": fieldName2}
            ]
        }
        sort_order = [("server_response_timestamp", -1)]
        cursor = mongo.db.ai_drone.find(query).sort(sort_order)
        logdata_list = list(cursor)

        return logdata_list

class MySQL:
    @staticmethod
    def con():
        conn = ps.connect(host='localhost', user='root', passwd='0000', db='databaseName')
    return conn
    
    @staticmethod
    def select_db(calumn,table, where):
        conn = con()
        curs = conn.cursor()
        sql = f"selet {calumn} from {table} where {where} "
        curs.execute(sql)
        result = curs.fetchall()    # fetchall() : 모든 데이터를 한 번에 가져올 때 사용
                                    # fetchone() : 한 번 호출에 하나의 행만 가져올 때 사용
                                    # fetchmany(n) : n개만큼의 데이터를 가져올 때 사용
        curs.close()
        conn.close()

        return result

    @staticmethod  
    def insert_db(table, calumns, values):
        conn = con()
        curs = conn.cursor()
        sql = f"insert into {table} {calumns} values {values};"
        curs.execute(sql)
        conn.commit()
        curs.close()
        conn.close()

        return result

class Oracle:
    @staticmethod
    def conn_db():
        conn = cx_Oracle.connect('user_id', 'user_pw', '127.0.0.1:1521/xe')
        curs = conn.cursor()

        return conn, curs

    @staticmethod
    def select_db(calumn,table):
        conn, curs = self.conn_db()
        sql = f'select {calumn} from {table}'
        result = curs.execute(sql)
        result = result.fetchall()
        if curs != None:curs.close()
        if conn != None:conn.close()
        return result

    @staticmethod
    def insert_db():

