#pragma once

#ifdef FIBONACHIDLL_EXPORTS
#define FIBONACHILIBRARY_API __declspec(dllexport)
#else
#define FIBONACHILIBRARY_API __declspec(dllimport)
#endif

extern "C"
{
    FIBONACHILIBRARY_API int _cdecl ValueOfIndex(int index);
    FIBONACHILIBRARY_API  int _cdecl Find(int value);
    FIBONACHILIBRARY_API int _cdecl SumOfNumbers(int index);
}
