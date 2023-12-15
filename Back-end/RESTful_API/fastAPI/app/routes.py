from fastapi import APIRouter
from app.controller import say_hi

router = APIRouter()

@router.get("/")
async def root():
    message = say_hi()
    return {"message": message}