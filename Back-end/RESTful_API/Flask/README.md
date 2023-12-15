# Prediction Service

## 1. Project Architecture

    % apt install tree
    % tree -L 2

    service
    ├── app
    │   ├── __init__.py
    │   ├── routes.py
    │   └── models.py
    ├── config.py
    ├── run.py
    └── requirements.txt

## 2. Dependency management

    % pip install pipreqs
    % pipreqs [경로]

    % pip freeze > requirements.txt

    % pip install -r requirements.txt
