#ifndef __TITLE_H__
#define __TITLE_H__

typedef enum {
	NOCURSOR,
	SOLID_CURSOR,
	NORMAL_CURSOR
} CURSOR_TYPE;
typedef enum {
	BLACK,
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
} FONT_COLOR;

void title();
void titlegotoxy(int x, int y);
void set_cursor_type(CURSOR_TYPE type);
void font_color(FONT_COLOR color);
#endif