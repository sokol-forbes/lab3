#pragma once

#ifdef MATHLIBRARY_EXPORTS
#define MATHLIBRARY_API __declspec(dllexport)
#else
#define MATHLIBRARY_API __declspec(dllimport)
#endif

extern "C" 
{ 
	MATHLIBRARY_API int sum();
	MATHLIBRARY_API int difference();
	MATHLIBRARY_API int multiplication();
	MATHLIBRARY_API double division();
	MATHLIBRARY_API double average();
	MATHLIBRARY_API int Hello(); 
}