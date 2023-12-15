from flask import Flask
from flask_cors import CORS

from config import Config
from .models import mongo
from .routes import api_blueprint

def create_app():
    app = Flask(__name__)
    CORS(app)
    app.config.from_object(Config)
    mongo.init_app(app)
    app.register_blueprint(api_blueprint)

    return app

app = create_app()