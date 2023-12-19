#ifndef __BOOK_FILE_DATA_H__
#define __BOOK_FILE_DATA_H__

#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>	
#include <time.h>	
#include <string.h>	
#include <windows.h>
#include <conio.h>
#include "book_info.h"
#include "snake.h"
#include "Title.h"

typedef struct BOOK
{
	char book_name[50];
	char book_writer[50];
	char book_category[50];
	char book_count[50];
	char recommend_book[50];
	char recommend_writer[50];
	char recommend_comments[1000];
} BOOK;

void bookTopData();
void bookTopRead();
void bookRecData();
void bookRecRead();

// ���� Top10 ������ ���� �Լ�
void bookTopData()
{
	FILE* book_top10_data = fopen("book_top10_data.bin", "wb");
	BOOK data[10] = { 0 };
	if (book_top10_data == NULL)
	{
		puts("����");
		exit(0);
	}
	for (int i = 0; i < 10; i++)
	{
		strcpy(data[i].book_name, book_name[i]);
		strcpy(data[i].book_writer, book_writer[i]);
		strcpy(data[i].book_category, book_category[i]);
		strcpy(data[i].book_count, book_count[i]);
		fwrite(&data[i], sizeof(BOOK), 1, book_top10_data);
	}
	fclose(book_top10_data);
}

// ���� TOP10 ������ ��� �Լ�
void bookTopRead()
{
	FILE* book_top10_data = fopen("book_top10_data.bin", "rb");
	BOOK data = { 0 };
	if (book_top10_data == NULL)
	{
		printf("���� �б� ����!\n");
		exit(0);
	}
	int count = 10;
	int check = 0;
	int x = 12;
	int y = 0;
	system("cls");
	gotoxy(x + 17, y + 2); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
	gotoxy(x + 17, y + 3); printf("��                                                                ��");
	gotoxy(x + 17, y + 4); printf("��                                                                ��");
	gotoxy(x + 17, y + 4); printf("��                    ����Ʈ���� ��� �о���� ��!");
	gotoxy(x + 17, y + 5); printf("��                                                                ��");
	gotoxy(x + 17, y + 6); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
	Sleep(1000);
	gotoxy(x + 17, y + 7); printf("��                                                                ��");
	gotoxy(x + 17, y + 8); printf("��                                                                ��");
	gotoxy(x + 17, y + 8); printf("��- - - - - - - - - - - -[   �ε�  �Ϸ�!  ]- - - - - - - - - - - -��");
	gotoxy(x + 17, y + 9); printf("��                                                                ��");
	gotoxy(x + 17, y + 10); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�\n\n\n\t\t\t\t\t\t");
	system("pause");
	while (fread(&data, sizeof(data), 1, book_top10_data) == 1)
	{
		system("cls");
		gotoxy(x + 17, y + 2); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
		gotoxy(x + 17, y + 3); printf("��                                                                ��");
		gotoxy(x + 17, y + 4); printf("��                                                                ��");
		gotoxy(x + 17, y + 4); printf("��                           <TOP %d>", count--);
		gotoxy(x + 17, y + 5); printf("��                                                                ��");
		gotoxy(x + 17, y + 5); printf("��                     ������: %s\n", data.book_name);
		gotoxy(x + 17, y + 6); printf("��                                                                ��");
		gotoxy(x + 17, y + 6); printf("��                     ������: %s\n", data.book_writer);
		gotoxy(x + 17, y + 7); printf("��                                                                ��");
		gotoxy(x + 17, y + 7); printf("��                     ī�װ�: %s\n", data.book_category);
		gotoxy(x + 17, y + 8); printf("��                                                                ��");
		gotoxy(x + 17, y + 8); printf("��                     �Ǹŷ�: %s ��\n\n", data.book_count);
		gotoxy(x + 17, y + 9); printf("��                                                                ��");
		gotoxy(x + 17, y + 10); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�\n\n\n\t\t\t\t\t\t");
		system("pause");
		check = 1;
	}
	system("cls");
	fclose(book_top10_data);
}

// ��õ ���� ���� ������ ���� �Լ�
void bookRecData()
{
	FILE* book_recommend_data = fopen("book_recommend_data.bin", "wb");
	BOOK data[5] = { 0 };
	if (book_recommend_data == NULL)
	{
		puts("����");
		exit(0);
	}
	srand(time(0));
	int random = rand() % 5;
	for (int i = 0; i < 5; i++)
	{
		strcpy(data[i].recommend_book, recommend_book[random]);
		strcpy(data[i].recommend_writer, recommend_writer[random]);
		strcpy(data[i].recommend_comments, recommend_comments[random]);
		fwrite(&data[i], sizeof(BOOK), 1, book_recommend_data);
	}
	fclose(book_recommend_data);
}

// ��õ ���� ������ ȣ�� �Լ�
void bookRecRead()
{
	FILE* book_recommend_data = fopen("book_recommend_data.bin", "rb");
	BOOK data = { 0 };
	if (book_recommend_data == NULL)
	{
		printf("���� �б� ����!\n");
		exit(0);
	}
	int x = 12;
	int y = 0;
	system("cls");
	gotoxy(x + 17, y + 2); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
	gotoxy(x + 17, y + 3); printf("��                                                                ��");
	gotoxy(x + 17, y + 4); printf("��                   ��õ ������ ���� ���Դϴ�!                 ��");
	gotoxy(x + 17, y + 5); printf("��                                                                ��");
	gotoxy(x + 17, y + 6); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
	Sleep(1000);
	gotoxy(x + 17, y + 7); printf("��                                                                ��");
	gotoxy(x + 17, y + 8); printf("��- - - - - - - - - - - -[   �ε�  �Ϸ�!  ]- - - - - - - - - - - -��");
	gotoxy(x + 17, y + 9); printf("��                                                                ��");
	gotoxy(x + 17, y + 10); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�\n\n\n\n\t\t\t\t\t");
	system("pause");
	system("cls");
	fread(&data, sizeof(BOOK), 1, book_recommend_data) == 1;
	gotoxy(x + 17, y + 2); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
	gotoxy(x + 17, y + 3); printf("��                                                                ��");
	gotoxy(x + 17, y + 4); printf("��\t\t\t�ٰ����� ��õ ������\t\t\t       ��");
	gotoxy(x + 17, y + 5); printf("��                                                                ��");
	gotoxy(x + 17, y + 6); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�");
	gotoxy(x + 17, y + 7); printf("��                                                                ��");
	gotoxy(x + 17, y + 8); printf("��\t\t������: %s", data.recommend_book);
	gotoxy(x + 83, y + 8); printf("��");
	gotoxy(x + 17, y + 9); printf("��                                                                ��");
	gotoxy(x + 17, y + 10); printf("��\t\t������: %s", data.recommend_writer);
	gotoxy(x + 83, y + 10); printf("��");
	gotoxy(x + 17, y + 11); printf("��                                                                ��");
	gotoxy(x + 17, y + 12); printf("��----------------------��<������ �ڸ�Ʈ>��-----------------------");
	gotoxy(x + 83, y + 12); printf("��");
	gotoxy(x + 17, y + 13); printf("��                                                                ��");
	gotoxy(x + 17, y + 14); printf("��                                                                ��");
	gotoxy(x + 17, y + 15); printf("��                                                                ��");
	gotoxy(x + 17, y + 16); printf("��                                                                ��");
	gotoxy(x + 17, y + 17); printf("��                                                                ��");
	gotoxy(x + 17, y + 14); printf("\t%s", data.recommend_comments);
	gotoxy(x + 17, y + 18); printf("�¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢¢�\n\n\n\n\t\t\t\t\t");
	system("pause");
	system("cls");
	fclose(book_recommend_data);
}

#endif