from flask import Flask
from flask_cors import CORS
from .routes import api_blueprint

# from config import Config
# from .models import mongo

def create_app():
    app = Flask(__name__)
    CORS(app)
    app.register_blueprint(api_blueprint)
    # app.config.from_object(Config)
    # mongo.init_app(app)

    return app

app = create_app()