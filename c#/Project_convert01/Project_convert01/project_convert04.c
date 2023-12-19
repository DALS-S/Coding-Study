#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>	
#include <windows.h>
#include <conio.h>
#include <stdbool.h>
#include "menu.h"
#include "Title.h"
#include "snake.h"

void titlegotoxy(int x, int y)
{
	COORD pos = { x, y };
	// 윈도우 콘솔에서 커서 위치 이동
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), pos);
}
void title()
{
	int x = 20;
	int y = 50;
	gotoxy(x + 2, y - 8); printf("※ q를 눌러 계속 진행");
	gotoxy(x, y - 7); printf("▲■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■▲");
	font_color(RED);
	gotoxy(x - 2, y - 6); printf("▲■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■▲");
	font_color(YELLOW);
	gotoxy(x - 4, y - 5); printf("▲■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■▲");
	font_color(LIGHT_GREEN);
	gotoxy(x - 6, y - 4); printf("▲■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■▲");
	font_color(LIGHT_BLUE);
	gotoxy(x - 8, y - 3); printf("▲■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■▲");
	font_color(BLUE);
	gotoxy(x - 10, y - 2); printf("▲■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■▲");
	font_color(LIGHT_PURPLE);
	gotoxy(x - 12, y - 1); printf("▲■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■▲");
	font_color(WHITE);
	gotoxy(x - 5, y + 0); printf("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
	gotoxy(x - 5, y + 1); printf("■									     ■");
	gotoxy(x - 5, y + 2); printf("■									     ■");
	gotoxy(x - 5, y + 3); printf("■									     ■");
	gotoxy(x - 5, y + 4); printf("■									     ■");
	gotoxy(x - 5, y + 5); printf("■									     ■");
	gotoxy(x - 5, y + 6); printf("■									     ■");
	gotoxy(x - 5, y + 7); printf("■									     ■");
	gotoxy(x - 5, y + 8); printf("■									     ■");
	gotoxy(x - 5, y + 9); printf("■									     ■");
	gotoxy(x - 5, y + 10); printf("■									     ■");
	gotoxy(x - 5, y + 11); printf("■									     ■");
	gotoxy(x - 5, y + 12); printf("■									     ■");
	gotoxy(x - 7, y + 13); printf("■■									     ■■");
	gotoxy(x - 9, y + 14); printf("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
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
	srand(time(NULL));
	while (1)
	{
		int random = 0;
		random = rand() % 15;
		font_color(fColor[random]);
		gotoxy(x + 17, y + 2); printf("★====================================★");
		gotoxy(x + 16, y + 3); printf(" § Welcome To Our Multi Tasking Room  §");
		gotoxy(x + 17, y + 4); printf("☆====================================☆");
		gotoxy(x + 23, y + 6); printf("□□□□□□□□□□□□□□");
		gotoxy(x + 23, y + 7); printf("□	         |   	     □");
		gotoxy(x + 23, y + 8); printf("□	         |  	     □");
		gotoxy(x + 23, y + 9); printf("□	         |  	     □");
		gotoxy(x + 23, y + 10); printf("□	       ◎|◎  	     □");
		gotoxy(x + 23, y + 11); printf("□		 |  	     □");
		gotoxy(x + 23, y + 12); printf("□		 |  	     □");
		gotoxy(x + 23, y + 13); printf("□		 |  	     □");
		Sleep(100);
		font_color(LIGHT_GREEN);
		gotoxy(x + 50, y + 16); printf("「 Multi Room v1.0 」");
		gotoxy(x + 50, y + 17); printf("개발자 : 『 이경민 』, 『 권병진 』, 『 유지웅 』");
		gotoxy(x + 50, y + 18); printf("문의 사항  : ☎ 010 - 6344 - 5483\n\t\t\t\t\t");
		if (_kbhit()) {
			int escape;
			escape = _getch();
			if (escape == 'q')
				break;
		}
	}
}
void set_cursor_type(CURSOR_TYPE type)
{
	CONSOLE_CURSOR_INFO info = { 0 };
	switch (type) {
	case NOCURSOR:
		info.dwSize = 1;
		info.bVisible = FALSE;
		break;
	case SOLID_CURSOR:
		info.dwSize = 100;
		info.bVisible = TRUE;
		break;
	case NORMAL_CURSOR:
		info.dwSize = 20;
		info.bVisible = TRUE;
		break;
	}
	// 커서 타입을 설정
	SetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &info);
}
void font_color(FONT_COLOR color)
{
	// 폰트에 색생 적용
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), color);
}