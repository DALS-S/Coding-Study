#ifndef SNAKE_H
#define SNAKE_H

#include <stdbool.h>

#define DOWN 80
#define LEFT 75
#define RIGHT 77
#define UP 72

#define MAPWIDTH 20
#define MAPHEIGHT 20
#define SNAKELENGTH 17

typedef struct _body
{
    int x;
    int y;
} Body;
Body body[18][18];
Body Temp[18][18];

typedef struct _food
{
    int x;
    int y;
} Food;
Food food;

typedef struct _logic
{
    bool Up;
    bool Down;
    bool Right;
    bool Left;
} Logic;
Logic l;

void Map();
void Init();
void TempToBody();
void MoveCoor();
void BodyToTemp();
void Delete();
void Output();
void Move();
void FoodOutput();
void Eat();
void BodyPlus();
void Score();
void Clear();
void GameOver();
void GameExplain();
void gotoxy(int x, int y);
void CursorView(char show);
int snakegame();

#endif // SNAKE_H