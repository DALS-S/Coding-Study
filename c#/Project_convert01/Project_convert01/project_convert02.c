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
	gotoxy(x + 17, y + 2); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 3); printf("��                                                                ��");
	gotoxy(x + 17, y + 4); printf("��                            WELCOME                             ��");
	gotoxy(x + 17, y + 5); printf("��                                                                ��");
	gotoxy(x + 17, y + 6); printf("��                       Multitasking Room                        ��");
	gotoxy(x + 17, y + 7); printf("��                                                                ��");
	gotoxy(x + 17, y + 8); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 9); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 10); printf("��                                                                ��");
	gotoxy(x + 17, y + 11); printf("��                          1. ����                               ��");
	gotoxy(x + 17, y + 12); printf("��                          2. ��ȭ                               ��");
	gotoxy(x + 17, y + 13); printf("��                          3. ����                               ��");
	gotoxy(x + 17, y + 14); printf("��                          4. ������                             ��");
	gotoxy(x + 17, y + 15); printf("��                                                                ��");
	gotoxy(x + 17, y + 16); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 18); printf("�޴� ����:");
	int menu;
	scanf("%d", &menu);
	return menu;
}

int bookMenu()
{
	int x = 12;
	int y = 0;
	font_color(LIGHT_YELLOW);
	gotoxy(x + 17, y + 2); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 3); printf("��                                                                ��");
	gotoxy(x + 17, y + 4); printf("��                                                                ��");
	gotoxy(x + 17, y + 5); printf("��                             B O O K                            ��");
	gotoxy(x + 17, y + 6); printf("��                                                                ��");
	gotoxy(x + 17, y + 7); printf("��                                                                ��");
	gotoxy(x + 17, y + 8); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 9); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 10); printf("��                                                                ��");
	gotoxy(x + 17, y + 11); printf("��                        1. ���� TOP 10                          ��");
	gotoxy(x + 17, y + 12); printf("��                        2. ���� ��õ                            ��");
	gotoxy(x + 17, y + 13); printf("��                        3. ������                               ��");
	gotoxy(x + 17, y + 14); printf("��                                                                ��");
	gotoxy(x + 17, y + 15); printf("��                                                                ��");
	gotoxy(x + 17, y + 16); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 18); printf("�޴� ����:");
	int bookMenu;
	scanf("%d", &bookMenu);
	return bookMenu;
}
int movieMenu()
{
	int x = 12;
	int y = 0;
	font_color(CYAN);
	gotoxy(x + 17, y + 2); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 3); printf("��                                                                ��");
	gotoxy(x + 17, y + 4); printf("��                                                                ��");
	gotoxy(x + 17, y + 5); printf("��                            M O V I E                           ��");
	gotoxy(x + 17, y + 6); printf("��                                                                ��");
	gotoxy(x + 17, y + 7); printf("��                                                                ��");
	gotoxy(x + 17, y + 8); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 9); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 10); printf("��                                                                ��");
	gotoxy(x + 17, y + 11); printf("��                        1. ��ȭ TOP 10                          ��");
	gotoxy(x + 17, y + 12); printf("��                        2. ��ȭ ��õ                            ��");
	gotoxy(x + 17, y + 13); printf("��                        3. ������                               ��");
	gotoxy(x + 17, y + 14); printf("��                                                                ��");
	gotoxy(x + 17, y + 15); printf("��                                                                ��");
	gotoxy(x + 17, y + 16); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 18); printf("�޴� ����:");
	int movieMenu;
	scanf("%d", &movieMenu);
	return movieMenu;
}
int gameMenu()
{
	int x = 12;
	int y = 0;
	font_color(LIGHT_CYAN);
	gotoxy(x + 17, y + 2); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 3); printf("��                                                                ��");
	gotoxy(x + 17, y + 4); printf("��                                                                ��");
	gotoxy(x + 17, y + 5); printf("��                             G A M E                            ��");
	gotoxy(x + 17, y + 6); printf("��                                                                ��");
	gotoxy(x + 17, y + 7); printf("��                                                                ��");
	gotoxy(x + 17, y + 8); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 9); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 10); printf("��                                                                ��");
	gotoxy(x + 17, y + 11); printf("��                        1. �� Ű���                            ��");
	gotoxy(x + 17, y + 12); printf("��                        2. How To Play                          ��");
	gotoxy(x + 17, y + 13); printf("��                        3. ������                               ��");
	gotoxy(x + 17, y + 14); printf("��                                                                ��");
	gotoxy(x + 17, y + 15); printf("��                                                                ��");
	gotoxy(x + 17, y + 16); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 18); printf("�޴� ����:");
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
		gotoxy(x + 17, y + 1); printf("�� q�� ���� ��� ����");
		gotoxy(x + 17, y + 2); printf("�âââââââââââââââââââââââââââââââââ�");
		gotoxy(x + 17, y + 3); printf("��                                                                ��");
		gotoxy(x + 17, y + 4); printf("��                                                                ��");
		gotoxy(x + 17, y + 5); printf("��                            � ������                         ��");
		gotoxy(x + 17, y + 6); printf("��                                                                ��");
		gotoxy(x + 17, y + 7); printf("��                                                                ��");
		gotoxy(x + 17, y + 8); printf("�âââââââââââââââââââââââââââââââââ�");
		gotoxy(x + 17, y + 9); printf("�âââââââââââââââââââââââââââââââââ�");
		gotoxy(x + 17, y + 10); printf("��                                                                ��");
		gotoxy(x + 17, y + 11); printf("��                          1. �����ϱ�                           ��");
		gotoxy(x + 17, y + 12); printf("��                          2. ������                             ��");
		gotoxy(x + 17, y + 13); printf("��                                                                ��");
		gotoxy(x + 17, y + 14); printf("��                                                                ��");
		gotoxy(x + 17, y + 15); printf("��                                                                ��");
		gotoxy(x + 17, y + 16); printf("�âââââââââââââââââââââââââââââââââ�");
		gotoxy(x + 17, y + 18); printf("�޴� ����:");
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
	gotoxy(x + 17, y + 2); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 3); printf("��                                                                ��");
	gotoxy(x + 17, y + 4); printf("��                                                                ��");
	gotoxy(x + 17, y + 5); printf("��                           How To Play                          ��");
	gotoxy(x + 17, y + 6); printf("��                                                                ��");
	gotoxy(x + 17, y + 7); printf("��                                                                ��");
	gotoxy(x + 17, y + 8); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 9); printf("�âââââââââââââââââââââââââââââââââ�");
	gotoxy(x + 17, y + 10); printf("��                                                                ��");
	gotoxy(x + 17, y + 11); printf("��               ��, ��, ��, �� ����Ű�� ���� ������              ��");
	gotoxy(x + 17, y + 12); printf("��               ���� * �� ������ ���� +100                       ��");
	gotoxy(x + 17, y + 13); printf("��               ������ 3õ���� �� �� ���� Ŭ����                 ��");
	gotoxy(x + 17, y + 14); printf("��               ���� ���� �Ӹ��� ������ ���� ����                ��");
	gotoxy(x + 17, y + 15); printf("��               ��ü�� ��Ƶ� ���� ����                          ��");
	gotoxy(x + 17, y + 16); printf("��                                                                ��");
	gotoxy(x + 17, y + 17); printf("��               �ƹ� Ű�� ���� ���� Ȧ�� ����                    ��");
	gotoxy(x + 17, y + 18); printf("��                                                                ��");
	gotoxy(x + 17, y + 19); printf("�âââââââââââââââââââââââââââââââââ�\n\n\n\n\t\t\t\t\t");
	system("pause");
}