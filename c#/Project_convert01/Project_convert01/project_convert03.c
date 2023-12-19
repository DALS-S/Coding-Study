#include <stdio.h>
#include <Windows.h>
#include <conio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <time.h>
#include "snake.h"
#include "Title.h"

int snake[18][18] =
{
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1}
};

int map[20][20] =
{
    {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
};

void Map()
{
    for (int i = 0; i < MAPHEIGHT; i++)
    {
        for (int j = 0; j < MAPWIDTH; j++)
        {
            if (map[i][j] == 1)
                printf("▣");
            else
                printf("  ");
        }
        printf("\n");
    }
}

void Init()
{
    l.Up = false;
    l.Down = false;
    l.Right = false;
    l.Left = false;

    body[17][17].x = 14;
    body[17][17].y = 18;

    body[17][16].x = 12;
    body[17][16].y = 18;

    body[17][15].x = 10;
    body[17][15].y = 18;

}

void TempToBody()
{
    bool ExitOutLoop = false;

    for (int i = 17; i >= 0; i--)
    {
        for (int j = 17; j >= 0; j--)
        {
            if (snake[i][j] == 1)
            {
                Temp[i][j].x = body[i][j].x;
                Temp[i][j].y = body[i][j].y;
            }

            if (snake[i][j] == 0)
            {
                ExitOutLoop = true;
                break;
            }
        }

        if (ExitOutLoop == true)
        {
            ExitOutLoop = false;
            break;
        }
    }
}

void MoveCoor()
{
    if (l.Up == true)
    {
        TempToBody();
        body[17][17].y--;
        BodyToTemp();
    }

    if (l.Down == true)
    {
        TempToBody();
        body[17][17].y++;
        BodyToTemp();
    }

    if (l.Right == true)
    {
        TempToBody();
        body[17][17].x += 2;
        BodyToTemp();
    }

    if (l.Left == true)
    {
        TempToBody();
        body[17][17].x -= 2;
        BodyToTemp();
    }
}

void BodyToTemp()
{
    bool ExitOutLoop = false;

    for (int i = 17; i > 0; i--)
    {
        for (int j = 17; j >= 0; j--)
        {
            if (snake[i][j] == 0 && j == 0)
            {
                body[i - 1][17].x = Temp[i][j].x;
                body[i - 1][17].y = Temp[i][j].y;
                ExitOutLoop = true;
                break;
            }

            body[i][j - 1].x = Temp[i][j].x;
            body[i][j - 1].y = Temp[i][j].y;
        }

        if (ExitOutLoop == true)
        {
            ExitOutLoop = false;
            break;
        }
    }
}

void Delete()
{
    bool ExitOutLoop = false;

    for (int i = 17; i >= 0; i--)
    {
        for (int j = 17; j >= 0; j--)
        {
            if (snake[i][j] == 1)
            {
                gotoxy(body[i][j].x, body[i][j].y);
                printf("  ");
            }

            else
            {
                ExitOutLoop = true;
                break;
            }
        }

        if (ExitOutLoop == true)
        {
            ExitOutLoop = false;
            break;
        }
    }
}

void Output()
{
    bool ExitOutLoop = false;

    for (int i = 17; i >= 0; i--)
    {
        for (int j = 17; j >= 0; j--)
        {
            if (snake[i][j] == 1)
            {
                gotoxy(body[i][j].x, body[i][j].y);
                printf("■");
            }

            else
            {
                ExitOutLoop = true;
                break;
            }
        }

        if (ExitOutLoop == true)
        {
            ExitOutLoop = false;
            break;
        }
    }
}

void Move()
{
    int Time = 150;
    while (1)
    {
        Sleep(Time);
        Delete();
        MoveCoor();
        Output();
        Eat();
        GameOver();
        if (_kbhit())
            break;
    }


}

void FoodOutput()
{
    bool ExitOutLoop = false;

    srand(time(NULL));

    food.x = (rand() % 18 + 1) * 2;
    food.y = rand() % 18 + 1;

    for (int i = 17; i >= 0; i--)
    {
        for (int j = 17; j >= 0; j--)
        {
            if (body[i][j].x == food.x && body[i][j].y == food.y)
            {
                food.x = (rand() % 18 + 1) * 2;
                food.y = rand() % 18 + 1;
            }
        }
    }

    gotoxy(food.x, food.y);
    printf("＊");
}

void Eat()
{
    if (body[17][17].x == food.x && body[17][17].y == food.y)
    {
        Score();
        BodyPlus();
        FoodOutput();
    }
}

void BodyPlus()
{
    bool ExitOutLoop = false;

    for (int i = 17; i >= 0; i--)
    {
        for (int j = 17; j >= 0; j--)
        {
            if (snake[i][j] == 0)
            {
                snake[i][j] = 1;
                ExitOutLoop = true;
                break;
            }
        }

        if (ExitOutLoop == true)
        {
            ExitOutLoop = false;
            break;
        }
    }
}

void Score()
{
    static int score = 0;
    score += 100;
    gotoxy(70, 20);
    printf("점수 : %d", score);
    if (score == 3000)
        Clear();
}

void GameOver()
{
    if (body[17][17].x >= 38 || body[17][17].x <= 0)
    {
        int x = 10;
        int y = 0;
        system("cls");
        font_color(LIGHT_RED);
        gotoxy(x + 17, y + 2); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈");
        gotoxy(x + 17, y + 3); printf("◈                                                          ◈");
        gotoxy(x + 17, y + 4); printf("◈                                                          ◈");
        gotoxy(x + 40, y + 4); printf("게임 오버!");
        gotoxy(x + 17, y + 5); printf("◈                                                          ◈");
        gotoxy(x + 40, y + 5); printf("입구로 돌아갑니다.\n");
        gotoxy(x + 17, y + 6); printf("◈                                                          ◈");
        gotoxy(x + 17, y + 7); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈\n\n\n\t\t\t\t\t");
        system("pause");
        main();
    }

    if (body[17][17].y >= 19 || body[17][17].y <= 0)
    {
        int x = 10;
        int y = 0;
        system("cls");
        font_color(LIGHT_RED);
        gotoxy(x + 17, y + 2); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈");
        gotoxy(x + 17, y + 3); printf("◈                                                          ◈");
        gotoxy(x + 17, y + 4); printf("◈                                                          ◈");
        gotoxy(x + 40, y + 4); printf("게임 오버!");
        gotoxy(x + 17, y + 5); printf("◈                                                          ◈");
        gotoxy(x + 40, y + 5); printf("입구로 돌아갑니다.\n");
        gotoxy(x + 17, y + 6); printf("◈                                                          ◈");
        gotoxy(x + 17, y + 7); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈\n\n\n\t\t\t\t\t");
        system("pause");
        main();
    }

    for (int i = 17; i >= 0; i--)
    {
        for (int j = 16; j >= 0; j--)
        {
            if (body[17][17].x == body[i][j].x &&
                body[17][17].y == body[i][j].y)
            {
                system("cls");
                printf("게임 오버");
                printf("입구로 돌아갑니다.\n");
                system("pause");
                main();
            }
        }
    }
}

void GameExplain()
{
    gotoxy(70, 10);
    puts("상/하/우 중 아무키나 입력해 시작");

    gotoxy(70, 11);
    puts("이동 : 방향키");

    gotoxy(70, 12);
    puts("머리가 몸이나 벽에 닿을시 게임오버");

    gotoxy(70, 13);
    puts("별을 먹으면 점수 +100");

    gotoxy(70, 14);
    puts("q누르면 게임종료");

    gotoxy(70, 15);
    puts("점수가 3천점시 클리어");
}

void Clear()
{
    system("cls");
    printf("클리어\n");
    printf("입구로 돌아갑니다.\n");
    system("pause");
    main();
}

int snakegame()
{
    int key;

    Map();
    CursorView(0);
    Init();
    Output();
    FoodOutput();

    while (1)
    {
        GameExplain();

        if (_kbhit())
        {
            key = _getch();

            if (key == 'q')
                break;

            switch (key)
            {
            case UP:
                if (l.Down == true)
                    l.Up = false;
                else
                {
                    l.Up = true;
                    l.Down = false;
                    l.Right = false;
                    l.Left = false;
                }
                Move();
                break;
            case DOWN:
                if (l.Up == true)
                    l.Down = false;
                else
                {
                    l.Down = true;
                    l.Up = false;
                    l.Right = false;
                    l.Left = false;
                }
                Move();
                break;
            case LEFT:
                if (body[17][17].x == 14 && body[17][17].y == 14)
                    l.Left = false;
                else if (l.Right == true)
                    l.Left = false;
                else
                {
                    l.Left = true;
                    l.Down = false;
                    l.Right = false;
                    l.Up = false;
                }
                Move();
                break;
            case RIGHT:
                if (l.Left == true)
                    l.Right = false;
                else
                {
                    l.Right = true;
                    l.Down = false;
                    l.Up = false;
                    l.Left = false;
                }
                Move();
                break;
            default:
                break;
            }
        }
    }
    return 0;
}


void gotoxy(int x, int y)
{
    COORD Pos = { x, y };
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), Pos);
}
void CursorView(char show)//커서숨기기
{
    HANDLE hConsole;
    CONSOLE_CURSOR_INFO ConsoleCursor;

    hConsole = GetStdHandle(STD_OUTPUT_HANDLE);

    ConsoleCursor.bVisible = show;
    ConsoleCursor.dwSize = 1;

    SetConsoleCursorInfo(hConsole, &ConsoleCursor);
}