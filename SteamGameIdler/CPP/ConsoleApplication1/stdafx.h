#pragma once

#include "targetver.h"

#include <stdio.h>
#include <tchar.h>
#include <windows.h>
#include <stdlib.h>
#include <string.h>
#define BUFLEN 256
typedef short (CALLBACK* dllType)();
void setup(short hight, short width, LPCTSTR title);
char* add(char* origText, char *paste);
