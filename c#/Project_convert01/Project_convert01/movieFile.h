#pragma once
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <windows.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>
#include <processthreadsapi.h>
#include "movieFile.h"
#include "movieData.h"
#include "Title.h"

typedef struct _MOVIE {
	char movieName[50];
	char directorName[50];
	char phrase[50];
	char count[50];
} MOVIE;

void enterMovieData();
void movieTop10();
void movieRec();

void enterMovieData()
{
	FILE* movieData = fopen("movieData.bin", "wb");
	MOVIE data[10] = { 0 };
	if (movieData == NULL) {
		printf("���� �˻� ����!\n");
		exit(0);
	}
	for (int i = 0; i < 10; i++) {
		strcpy(data[i].movieName, movieName[i]);
		strcpy(data[i].directorName, directorName[i]);
		strcpy(data[i].phrase, phrase[i]);
		strcpy(data[i].count, count[i]);
		fwrite(&data[i], sizeof(MOVIE), 1, movieData);
	}
	fclose(movieData);
}
void movieTop10()
{
	FILE* movieData = fopen("movieData.bin", "rb");
	MOVIE data = { 0 };
	if (movieData == NULL) {
		printf("���� �˻� ����!\n");
		exit(0);
	}
	int count = 1;
	int x = 12;
	int y = 0;
	system("cls");
	gotoxy(x + 17, y + 2); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
	gotoxy(x + 17, y + 3); printf("��                                                                ��");
	gotoxy(x + 17, y + 4); printf("��                �ڽ����ǽ� ��� �о���� ���Դϴ�!              ��");
	gotoxy(x + 17, y + 5); printf("��                                                                ��");
	gotoxy(x + 17, y + 6); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
	Sleep(1000);
	gotoxy(x + 17, y + 7); printf("��                                                                ��");
	gotoxy(x + 17, y + 8); printf("��- - - - - - - - - - - -[   �ε�  �Ϸ�!  ]- - - - - - - - - - - -��");
	gotoxy(x + 17, y + 9); printf("��                                                                ��");
	gotoxy(x + 17, y + 10); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�\n\n\n\n\t\t\t\t\t");
	system("pause");
	while (fread(&data, sizeof(data), 1, movieData) == 1)
	{
		system("cls");
		gotoxy(x + 17, y + 2); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
		gotoxy(x + 17, y + 3); printf("��                                                                ��");
		gotoxy(x + 17, y + 4); printf("��                                                                ��");
		gotoxy(x + 17, y + 4); printf("��                        <TOP %d>", count++);
		gotoxy(x + 17, y + 5); printf("��                                                                ��");
		gotoxy(x + 17, y + 5); printf("��                 ��ȭ��: %s\n", data.movieName);
		gotoxy(x + 17, y + 6); printf("��                                                                ��");
		gotoxy(x + 17, y + 6); printf("��                 ������: %s\n", data.directorName);
		gotoxy(x + 17, y + 7); printf("��                                                                ��");
		gotoxy(x + 17, y + 7); printf("��                 ������: %s\n\n", data.count);
		gotoxy(x + 17, y + 8); printf("��                                                                ��");
		gotoxy(x + 17, y + 9); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�\n\n\n\t\t\t\t\t\t");
		system("pause");
	}
	system("cls");
	fclose(movieData);
}

void movieRec()
{
	MOVIE data[10] = { 0 };
	for (int i = 0; i < 10; i++) {
		strcpy(data[i].movieName, movieName[i]);
		strcpy(data[i].directorName, directorName[i]);
		strcpy(data[i].phrase, phrase[i]);
		strcpy(data[i].count, count[i]);
	}
	srand(time(0));
	int x = 12;
	int y = 0;
	int ran = 0;
	int ran_ar[10] = { 0 };
	for (int r = 0; r < 10; r++)
	{
		ran_ar[r] = r;
	}
	ran = ran_ar[rand() % 10];
	system("cls");
	gotoxy(x + 17, y + 2); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
	gotoxy(x + 17, y + 3); printf("��                                                                ��");
	gotoxy(x + 17, y + 4); printf("��                   ��õ ��ȭ�� ���� ���Դϴ�!                 ��");
	gotoxy(x + 17, y + 5); printf("��                                                                ��");
	gotoxy(x + 17, y + 6); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
	Sleep(1000);
	gotoxy(x + 17, y + 7); printf("��                                                                ��");
	gotoxy(x + 17, y + 8); printf("��- - - - - - - - - - - -[   �ε�  �Ϸ�!  ]- - - - - - - - - - - -��");
	gotoxy(x + 17, y + 9); printf("��                                                                ��");
	gotoxy(x + 17, y + 10); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�\n\n\n\n\t\t\t\t\t");
	system("pause");
	system("cls");
	gotoxy(x + 17, y + 2); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
	gotoxy(x + 17, y + 3); printf("��                                                                ��");
	gotoxy(x + 17, y + 4); printf("��\t\t\t�ٰ����� ��õ ��ȭ��\t\t\t       ��");
	gotoxy(x + 17, y + 5); printf("��                                                                ��");
	gotoxy(x + 17, y + 6); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
	gotoxy(x + 17, y + 7); printf("��                                                                ��");
	gotoxy(x + 17, y + 8); printf("��                                                                ��");
	gotoxy(x + 17, y + 8); printf("\t\t��ȭ��: %s\n", data[ran].movieName);
	gotoxy(x + 17, y + 9); printf("��                                                                ��");
	gotoxy(x + 17, y + 10); printf("��                                                                ��");
	gotoxy(x + 17, y + 10); printf("\t\t������: %s\n\n", data[ran].directorName);
	gotoxy(x + 17, y + 11); printf("��                                                                ��");
	gotoxy(x + 17, y + 12); printf("��                                                                ��");
	gotoxy(x + 18, y + 12); printf("----------------------��<������ �ڸ�Ʈ>��------------------------");
	gotoxy(x + 17, y + 13); printf("��                                                                ��");
	gotoxy(x + 17, y + 14); printf("��                                                                ��");
	gotoxy(x + 17, y + 14); printf("\t      %s", data[ran].phrase);
	gotoxy(x + 17, y + 15); printf("��                                                                ��");
	gotoxy(x + 17, y + 16); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�\n\n\n\n\t\t\t\t\t");
	system("pause");
	system("cls");
}