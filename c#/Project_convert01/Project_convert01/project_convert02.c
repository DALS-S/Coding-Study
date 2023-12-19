#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <Windows.h>
#include "menu.h"
#include "Title.h"
#include "snake.h"

int main_menu()
{
	int x = 12;
	int y = 0;
	font_color(LIGHT_GREEN);
	gotoxy(x + 17, y + 2); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 3); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 4); printf("▣                            WELCOME                             ▣");
	gotoxy(x + 17, y + 5); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 6); printf("▣                       Multitasking Room                        ▣");
	gotoxy(x + 17, y + 7); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 8); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 9); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 10); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 11); printf("▣                          1. 도서                               ▣");
	gotoxy(x + 17, y + 12); printf("▣                          2. 영화                               ▣");
	gotoxy(x + 17, y + 13); printf("▣                          3. 게임                               ▣");
	gotoxy(x + 17, y + 14); printf("▣                          4. 나가기                             ▣");
	gotoxy(x + 17, y + 15); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 16); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 18); printf("메뉴 선택:");
	int menu;
	scanf("%d", &menu);
	return menu;
}

int bookMenu()
{
	int x = 12;
	int y = 0;
	font_color(LIGHT_YELLOW);
	gotoxy(x + 17, y + 2); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 3); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 4); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 5); printf("▣                             B O O K                            ▣");
	gotoxy(x + 17, y + 6); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 7); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 8); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 9); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 10); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 11); printf("▣                        1. 도서 TOP 10                          ▣");
	gotoxy(x + 17, y + 12); printf("▣                        2. 도서 추천                            ▣");
	gotoxy(x + 17, y + 13); printf("▣                        3. 나가기                               ▣");
	gotoxy(x + 17, y + 14); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 15); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 16); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 18); printf("메뉴 선택:");
	int bookMenu;
	scanf("%d", &bookMenu);
	return bookMenu;
}
int movieMenu()
{
	int x = 12;
	int y = 0;
	font_color(CYAN);
	gotoxy(x + 17, y + 2); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 3); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 4); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 5); printf("▣                            M O V I E                           ▣");
	gotoxy(x + 17, y + 6); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 7); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 8); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 9); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 10); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 11); printf("▣                        1. 영화 TOP 10                          ▣");
	gotoxy(x + 17, y + 12); printf("▣                        2. 영화 추천                            ▣");
	gotoxy(x + 17, y + 13); printf("▣                        3. 나가기                               ▣");
	gotoxy(x + 17, y + 14); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 15); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 16); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 18); printf("메뉴 선택:");
	int movieMenu;
	scanf("%d", &movieMenu);
	return movieMenu;
}
int gameMenu()
{
	int x = 12;
	int y = 0;
	font_color(LIGHT_CYAN);
	gotoxy(x + 17, y + 2); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 3); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 4); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 5); printf("▣                             G A M E                            ▣");
	gotoxy(x + 17, y + 6); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 7); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 8); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 9); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 10); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 11); printf("▣                        1. 뱀 키우기                            ▣");
	gotoxy(x + 17, y + 12); printf("▣                        2. How To Play                          ▣");
	gotoxy(x + 17, y + 13); printf("▣                        3. 나가기                               ▣");
	gotoxy(x + 17, y + 14); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 15); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 16); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 18); printf("메뉴 선택:");
	int gameMenu;
	scanf("%d", &gameMenu);
	return gameMenu;
}
int enterMenu()
{
	char fColor[] = {
	BLUE,
	GREEN,
	CYAN,
	RED,
	PURPLE,
	YELLOW,
	WHITE,
	GRAY,
	LIGHT_BLUE,
	LIGHT_GREEN,
	LIGHT_CYAN,
	LIGHT_RED,
	LIGHT_PURPLE,
	LIGHT_YELLOW,
	LIGHT_GRAY
	};
	int x = 12;
	int y = 0;
	while (1)
	{
		int random = 0;
		random = rand() % 15;
		font_color(fColor[random]);
		gotoxy(x + 17, y + 1); printf("※ q를 눌러 계속 진행");
		gotoxy(x + 17, y + 2); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
		gotoxy(x + 17, y + 3); printf("▣                                                                ▣");
		gotoxy(x + 17, y + 4); printf("▣                                                                ▣");
		gotoxy(x + 17, y + 5); printf("▣                            어서 오세요                         ▣");
		gotoxy(x + 17, y + 6); printf("▣                                                                ▣");
		gotoxy(x + 17, y + 7); printf("▣                                                                ▣");
		gotoxy(x + 17, y + 8); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
		gotoxy(x + 17, y + 9); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
		gotoxy(x + 17, y + 10); printf("▣                                                                ▣");
		gotoxy(x + 17, y + 11); printf("▣                          1. 입장하기                           ▣");
		gotoxy(x + 17, y + 12); printf("▣                          2. 나가기                             ▣");
		gotoxy(x + 17, y + 13); printf("▣                                                                ▣");
		gotoxy(x + 17, y + 14); printf("▣                                                                ▣");
		gotoxy(x + 17, y + 15); printf("▣                                                                ▣");
		gotoxy(x + 17, y + 16); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
		gotoxy(x + 17, y + 18); printf("메뉴 선택:");
		Sleep(100);
		if (_kbhit()) {
			int escape;
			escape = _getch();
			if (escape == 'q')
				break;
		}
	}
	int entMenu;
	scanf("%d", &entMenu);
	return entMenu;
}
void howToPlay()
{
	int x = 12;
	int y = 0;
	font_color(LIGHT_CYAN);
	gotoxy(x + 17, y + 2); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 3); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 4); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 5); printf("▣                           How To Play                          ▣");
	gotoxy(x + 17, y + 6); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 7); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 8); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 9); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
	gotoxy(x + 17, y + 10); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 11); printf("▣               ↑, ↓, ←, → 방향키로 뱀을 움직임              ▣");
	gotoxy(x + 17, y + 12); printf("▣               먹이 * 을 먹으면 점수 +100                       ▣");
	gotoxy(x + 17, y + 13); printf("▣               점수가 3천점이 될 시 게임 클리어                 ▣");
	gotoxy(x + 17, y + 14); printf("▣               벽에 뱀의 머리가 닿으면 게임 오버                ▣");
	gotoxy(x + 17, y + 15); printf("▣               몸체에 닿아도 게임 오버                          ▣");
	gotoxy(x + 17, y + 16); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 17); printf("▣               아무 키나 눌러 메인 홀로 복귀                    ▣");
	gotoxy(x + 17, y + 18); printf("▣                                                                ▣");
	gotoxy(x + 17, y + 19); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣\n\n\n\n\t\t\t\t\t");
	system("pause");
}