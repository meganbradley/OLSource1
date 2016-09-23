---
title: "_strdec, _wcsdec, _mbsdec, _mbsdec_l"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
apiname: 
  - _wcsdec
  - _strdec
  - _mbsdec
  - _mbsdec_l
apilocation: 
  - msvcrt.dll
  - msvcr110.dll
  - msvcr100.dll
  - msvcr80.dll
  - msvcr120.dll
  - msvcr90.dll
  - msvcr110_clr0400.dll
apitype: DLLExport
f1_keywords: 
  - _strdec
  - mbsdec_l
  - strdec
  - _mbsdec
  - _mbsdec_l
  - mbsdec
  - wcsdec
  - _wcsdec
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - mbsdec_l function
  - mbsdec function
  - tcsdec function
  - _tcsdec function
  - _strdec function
  - _wcsdec function
  - _mbsdec_l function
  - strdec function
  - wcsdec function
  - _mbsdec function
ms.assetid: ae37c223-800f-48a9-ae8e-38c8d20af2dd
caps.latest.revision: 28
translation.priority.ht: 
  - de-de
  - ja-jp
---
# _strdec, _wcsdec, _mbsdec, _mbsdec_l
Moves a string pointer back one character.  
  
> [!IMPORTANT]
>  `mbsdec` and `mbsdec_l` cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
unsigned char *_strdec(  
   const unsigned char *start,  
   const unsigned char *current   
);  
unsigned wchar_t *_wcsdec(  
   const unsigned wchar_t *start,  
   const unsigned wchar_t *current   
);  
unsigned char *_mbsdec(  
   const unsigned char *start,  
   const unsigned char *current   
);  
unsigned char *_mbsdec_l(  
   const unsigned char *start,  
   const unsigned char *current,  
   _locale_t locale  
);  
```  
  
#### Parameters  
 `start`  
 Pointer to any character (or for `_mbsdec` and _`mbsdec_l`, the first byte of any multibyte character) in the source string; `start` must precede `current` in the source string.  
  
 `current`  
 Pointer to any character (or for `_mbsdec` and _`mbsdec_l`, the first byte of any multibyte character) in the source string; `current` must follow `start` in the source string.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 `_mbsdec`, _`mbsdec_l`, `_strdec`, and `_wcsdec` each return a pointer to the character that immediately precedes `current`; `_mbsdec` returns `NULL` if the value of `start` is greater than or equal to that of `current`. `_tcsdec` maps to one of these functions and its return value depends on the mapping.  
  
## Remarks  
 The `_mbsdec` and `_mbsdec_l` functions return a pointer to the first byte of the multibyte character that immediately precedes `current` in the string that contains `start`.  
  
 The output value is affected by the setting of the `LC_CTYPE` category setting of the locale; see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md) for more information.  `_mbsdec` recognizes multibyte-character sequences according to the locale that's currently in use, while `_mbsdec_l` is identical except that it instead uses the locale parameter that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
 If `start` or `current` is `NULL`, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns `EINVAL` and sets `errno` to `EINVAL`.  
  
> [!IMPORTANT]
>  These functions might be vulnerable to buffer overrun threats. Buffer overruns can be used for system attacks because they can cause an unwarranted elevation of privilege. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|`_tcsdec`|`_strdec`|`_mbsdec`|`_wcsdec`|  
  
 `_strdec` and `_wcsdec` are single-byte-character and wide-character versions of `_mbsdec` and `_mbsdec_l`. `_strdec` and `_wcsdec` are provided only for this mapping and should not be used otherwise.  
  
 For more information, see [Using Generic-Text Mappings](../vs140/using-generic-text-mappings.md) and [Generic-Text Mappings](../vs140/generic-text-mappings.md).  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|`_mbsdec`|<mbstring.h>|<mbctype.h>|  
|`_mbsdec_l`|<mbstring.h>|<mbctype.h>|  
|`_strdec`|<tchar.h>||  
|`_wcsdec`|<tchar.h>||  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 The following example shows a use of `_tcsdec`.  
  
```  
  
      #include <iostream>  
#include <tchar.h>  
using namespace std;  
  
int main()  
{  
   const TCHAR *str = _T("12345");  
   cout << "str: " << str << endl;  
  
   const TCHAR *str2;  
   str2 = str + 2;  
   cout << "str2: " << str2 << endl;  
  
   TCHAR *answer;  
   answer = _tcsdec( str, str2 );  
   cout << "answer: " << answer << endl;  
  
   return (0);   
}  
  
```  
  
 The following example shows a use of `_mbsdec`.  
  
```  
#include <iostream>  
#include <mbstring.h>  
using namespace std;  
  
int main()   
{   
   char *str = "12345";  
   cout << "str: " << str << endl;  
  
   char *str2;  
   str2 = str + 2;   
   cout << "str2: " << str2 << endl;  
  
   unsigned char *answer;  
   answer = _mbsdec( reinterpret_cast<unsigned char *>( str ), reinterpret_cast<unsigned char *>( str2 ));  
  
   cout << "answer: " << answer << endl;  
  
   return (0);   
}  
  
```  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_mbsinc, _mbsinc_l, _strinc, _wcsinc](../vs140/_strinc--_wcsinc--_mbsinc--_mbsinc_l.md)   
 [_mbsnextc, _mbsnextc_l, _strnextc, _wcsnextc](../vs140/_strnextc--_wcsnextc--_mbsnextc--_mbsnextc_l.md)   
 [_mbsninc, _mbsninc_l, _strninc, _wcsninc](../vs140/_strninc--_wcsninc--_mbsninc--_mbsninc_l.md)