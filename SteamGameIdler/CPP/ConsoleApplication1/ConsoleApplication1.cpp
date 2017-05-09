#include "stdafx.h"

int setenv(const char *envname, const char *envval, int overwrite);
int main(int argc, char *argv[])
{
	if (strlen(argv[1]) > 1)
	{
		char *appID = add("SteamAppId=", argv[1]);
		setup(2, 50, _T("Steam Game Faker Idler"));
		HINSTANCE dllHandle = LoadLibrary(_T("steam_api.dll"));
		dllType SteamAPIPtr = NULL;
		BOOL runTimeLinkSuccess = FALSE;
		if (NULL != dllHandle)
		{
			SteamAPIPtr = (dllType)GetProcAddress(dllHandle, "SteamAPI_Init");
			if (runTimeLinkSuccess = (NULL != SteamAPIPtr))
			{
				_putenv(appID);
				if (SteamAPIPtr())
				{
					system("cls");
					system("color 2A");
					SetConsoleTitle(_T("Steam Game Faker Idler [CONNECTED]"));
					printf("%s started successfully!\n", appID);
				}
				else
				{
					system("cls");
					system("color 4C");
					SetConsoleTitle(_T("Steam Game Faker Idler [NOT ACTIVE]"));
					printf("%s failed! Connection failed!\n", appID);
				}
			}
			FreeLibrary(dllHandle);
		}
		if (!runTimeLinkSuccess)
			printf("steam_api not found!\n");
	}
	else
		printf("Please use SteamGameFaker.exe to start the bot!\n");
	printf("Idling now..\n");
	char buffer[BUFLEN];
	fflush(stdout);
	fgets(buffer, BUFLEN, stdin);
	return 0;
}

void setup(short height, short width, LPCTSTR title) {
	HANDLE hCon = GetStdHandle(STD_OUTPUT_HANDLE);
	SMALL_RECT size;
	COORD b_size;
	size.Left = 0;
	size.Top = 0;
	size.Right = width;
	size.Bottom = height;
	b_size.X = width + 1;
	b_size.Y = height + 1;
	SetConsoleWindowInfo(hCon, true, &size);
	SetConsoleScreenBufferSize(hCon, b_size);
	SetConsoleTitle(title);
}

char* add(char* origText, char* paste)
{
	int newLength = strlen(origText) + strlen(paste) + 1;
	char* newText = new char[newLength];
	char* pointerToNewText = newText;
	char* helpPointer = origText;
	while (*helpPointer != '\0')
	{
		*pointerToNewText = *helpPointer;
		pointerToNewText++; helpPointer++;
	}
	while (*paste != '\0')
	{
		*pointerToNewText = *paste;
		pointerToNewText++; paste++;
	}
	*pointerToNewText = '\0';
	return newText;
}

