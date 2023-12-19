#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <Windows.h>
#include <conio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <time.h>
#include "Title.h"
#include "menu.h"
#include "snake.h"
#include "book_file_data.h"
#include "book_info.h"
#include "movieData.h"
#include "movieFile.h"
#include "pch.h"

int main()
{
	CursorView(NOCURSOR);
	font_color(LIGHT_RED);
	title();
	system("pause");
	system("cls");
	font_color(WHITE);
	switch (enterMenu()) {
	case 1: {
		while (1) {
			system("cls");
			switch (main_menu()) {
			case 1: {
				bookTopData();
				bookRecData();
				system("cls");
				switch (bookMenu()) {
				case 1: {
					font_color(LIGHT_YELLOW);
					bookTopRead();
					break;
				}
				case 2: {
					font_color(LIGHT_YELLOW);
					bookRecRead();
					break;
				}
				case 3: {
					break;
				}
				default: {
					printf("\t\t\t\t보기 내에서 선택해 주십시요.\n\t\t\t\t");
					system("pause");
					break;
				}
				}
				break;
			}
			case 2: {
				system("cls");
				enterMovieData();
				switch (movieMenu()) {
				case 1: {
					font_color(CYAN);
					movieTop10();
					break;
				}
				case 2: {
					font_color(CYAN);
					movieRec();
					break;
				}
				case 3: {
					break;
				}
				default: {
					printf("\t\t\t\t보기 내에서 선택해 주십시요.\n\t\t\t\t");
					system("pause");
					break;
				}
				}
				break;
			}
			case 3: {
				system("cls");
				switch (gameMenu()) {
				case 1: {
					system("cls");
					font_color(LIGHT_CYAN);
					snakegame();
					system("cls");
					break;
				}
				case 2: {
					system("cls");
					howToPlay();
					system("cls");
				}
				case 3: {
					system("cls");
					break;
				}
				default: {
					printf("\t\t\t\t보기 내에서 선택해 주십시요.\n\t\t\t\t");
					system("pause");
					break;
				}
				}
				break;
			}
			case 4: {
				int x = 12;
				int y = 0;
				system("cls");
				gotoxy(x + 17, y + 9); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
				gotoxy(x + 17, y + 10); printf("▣                                                                ▣");
				gotoxy(x + 17, y + 11); printf("▣                                                                ▣");
				gotoxy(x + 17, y + 12); printf("▣                          안녕히가세요                          ▣");
				gotoxy(x + 17, y + 13); printf("▣                                                                ▣");
				gotoxy(x + 17, y + 14); printf("▣                                                                ▣");
				gotoxy(x + 17, y + 15); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣\n\n\n\n\n\n\n\t\t\t\t\t");
				exit(0);
			}
			default: {
				printf("\t\t\t\t보기 내에서 선택해 주십시요.\n\t\t\t\t");
				system("pause");
				break;
			}
			}
		}
	}
	case 2: {
		int x = 12;
		int y = 0;
		system("cls");
		gotoxy(x + 17, y + 9); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣");
		gotoxy(x + 17, y + 10); printf("▣                                                                ▣");
		gotoxy(x + 17, y + 11); printf("▣                                                                ▣");
		gotoxy(x + 17, y + 12); printf("▣                          안녕히가세요                          ▣");
		gotoxy(x + 17, y + 13); printf("▣                                                                ▣");
		gotoxy(x + 17, y + 14); printf("▣                                                                ▣");
		gotoxy(x + 17, y + 15); printf("▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣▣\n\n\n\n\n\n\n\t\t\t\t\t");
		exit(0);
	}
	default: {
		printf("\t\t\t\t보기 내에서 선택해 주십시요.\n\t\t\t\t");
		system("pause");
		break;
	}
	}
}