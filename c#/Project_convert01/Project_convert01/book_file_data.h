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

// 도서 Top10 데이터 저장 함수
void bookTopData()
{
	FILE* book_top10_data = fopen("book_top10_data.bin", "wb");
	BOOK data[10] = { 0 };
	if (book_top10_data == NULL)
	{
		puts("오류");
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

// 도서 TOP10 데이터 출력 함수
void bookTopRead()
{
	FILE* book_top10_data = fopen("book_top10_data.bin", "rb");
	BOOK data = { 0 };
	if (book_top10_data == NULL)
	{
		printf("파일 읽기 오류!\n");
		exit(0);
	}
	int count = 10;
	int check = 0;
	int x = 12;
	int y = 0;
	system("cls");
	gotoxy(x + 17, y + 2); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈");
	gotoxy(x + 17, y + 3); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 4); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 4); printf("◈                    베스트셀러 목록 읽어오는 중!");
	gotoxy(x + 17, y + 5); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 6); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈");
	Sleep(1000);
	gotoxy(x + 17, y + 7); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 8); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 8); printf("◈- - - - - - - - - - - -[   로딩  완료!  ]- - - - - - - - - - - -◈");
	gotoxy(x + 17, y + 9); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 10); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈\n\n\n\t\t\t\t\t\t");
	system("pause");
	while (fread(&data, sizeof(data), 1, book_top10_data) == 1)
	{
		system("cls");
		gotoxy(x + 17, y + 2); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈");
		gotoxy(x + 17, y + 3); printf("◈                                                                ◈");
		gotoxy(x + 17, y + 4); printf("◈                                                                ◈");
		gotoxy(x + 17, y + 4); printf("◈                           <TOP %d>", count--);
		gotoxy(x + 17, y + 5); printf("◈                                                                ◈");
		gotoxy(x + 17, y + 5); printf("◈                     도서명: %s\n", data.book_name);
		gotoxy(x + 17, y + 6); printf("◈                                                                ◈");
		gotoxy(x + 17, y + 6); printf("◈                     저서명: %s\n", data.book_writer);
		gotoxy(x + 17, y + 7); printf("◈                                                                ◈");
		gotoxy(x + 17, y + 7); printf("◈                     카테고리: %s\n", data.book_category);
		gotoxy(x + 17, y + 8); printf("◈                                                                ◈");
		gotoxy(x + 17, y + 8); printf("◈                     판매량: %s 부\n\n", data.book_count);
		gotoxy(x + 17, y + 9); printf("◈                                                                ◈");
		gotoxy(x + 17, y + 10); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈\n\n\n\t\t\t\t\t\t");
		system("pause");
		check = 1;
	}
	system("cls");
	fclose(book_top10_data);
}

// 추천 도서 랜덤 데이터 저장 함수
void bookRecData()
{
	FILE* book_recommend_data = fopen("book_recommend_data.bin", "wb");
	BOOK data[5] = { 0 };
	if (book_recommend_data == NULL)
	{
		puts("오류");
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

// 추천 도서 데이터 호출 함수
void bookRecRead()
{
	FILE* book_recommend_data = fopen("book_recommend_data.bin", "rb");
	BOOK data = { 0 };
	if (book_recommend_data == NULL)
	{
		printf("파일 읽기 오류!\n");
		exit(0);
	}
	int x = 12;
	int y = 0;
	system("cls");
	gotoxy(x + 17, y + 2); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈");
	gotoxy(x + 17, y + 3); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 4); printf("◈                   추천 도서를 고르는 중입니다!                 ◈");
	gotoxy(x + 17, y + 5); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 6); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈");
	Sleep(1000);
	gotoxy(x + 17, y + 7); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 8); printf("◈- - - - - - - - - - - -[   로딩  완료!  ]- - - - - - - - - - - -◈");
	gotoxy(x + 17, y + 9); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 10); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈\n\n\n\n\t\t\t\t\t");
	system("pause");
	system("cls");
	fread(&data, sizeof(BOOK), 1, book_recommend_data) == 1;
	gotoxy(x + 17, y + 2); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈");
	gotoxy(x + 17, y + 3); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 4); printf("◈\t\t\t☆개발자 추천 도서☆\t\t\t       ◈");
	gotoxy(x + 17, y + 5); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 6); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈");
	gotoxy(x + 17, y + 7); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 8); printf("◈\t\t도서명: %s", data.recommend_book);
	gotoxy(x + 83, y + 8); printf("◈");
	gotoxy(x + 17, y + 9); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 10); printf("◈\t\t저서명: %s", data.recommend_writer);
	gotoxy(x + 83, y + 10); printf("◈");
	gotoxy(x + 17, y + 11); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 12); printf("◈----------------------♣<개발자 코멘트>♣-----------------------");
	gotoxy(x + 83, y + 12); printf("◈");
	gotoxy(x + 17, y + 13); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 14); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 15); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 16); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 17); printf("◈                                                                ◈");
	gotoxy(x + 17, y + 14); printf("\t%s", data.recommend_comments);
	gotoxy(x + 17, y + 18); printf("◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈◈\n\n\n\n\t\t\t\t\t");
	system("pause");
	system("cls");
	fclose(book_recommend_data);
}

#endif