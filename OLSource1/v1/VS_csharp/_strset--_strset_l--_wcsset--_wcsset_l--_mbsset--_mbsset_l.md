---
title: "_strset, _strset_l, _wcsset, _wcsset_l, _mbsset, _mbsset_l"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_wcsset"
  - "_mbsset"
  - "_strset_l"
  - "_strset"
  - "_wcsset_l"
  - "_mbsset_l"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsset"
  - "_strset_l"
  - "_mbsset"
  - "_strset"
  - "mbsset_l"
  - "strset_l"
  - "_wcsset"
  - "_ftcsset"
  - "wcsset_l"
  - "_tcsset_l"
  - "_mbsset_l"
  - "_wcsset_l"
  - "_fstrset"
  - "_tcsset"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wcsset_l function"
  - "_tcsset function"
  - "wcsset_l function"
  - "_ftcsset function"
  - "characters [C++], setting"
  - "_strset function"
  - "ftcsset function"
  - "strings [C++], setting characters"
  - "mbsset function"
  - "tcsset_l function"
  - "_fstrset function"
  - "mbsset_l function"
  - "strset_l function"
  - "_wcsset function"
  - "_mbsset function"
  - "_mbsset_l function"
  - "tcsset function"
  - "_strset_l function"
  - "fstrset function"
  - "_tcsset_l function"
ms.assetid: c42ded42-2ed9-4f06-a0a9-247ba305473a
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strset, _strset_l, _wcsset, _wcsset_l, _mbsset, _mbsset_l
Sets characters of a string to a character. More secure versions of these functions are available; see [_strset_s, _strset_s_l, _wcsset_s, _wcsset_s_l, _mbsset_s, _mbsset_s_l](../VS_csharp/_strset_s--_strset_s_l--_wcsset_s--_wcsset_s_l--_mbsset_s--_mbsset_s_l.md).  
  
> [!IMPORTANT]
>  `_mbsset` and `_mbsset_l` cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
char *_strset(  
   char *str,  
   int c   
);  
char *_strset_l(  
   char *str,  
   int c,  
   locale_t locale  
);  
wchar_t *_wcsset(  
   wchar_t *str,  
   wchar_t c   
);  
wchar_t *_wcsset_l(  
   wchar_t *str,  
   wchar_t c,  
   locale_t locale  
);  
unsigned char *_mbsset(  
   unsigned char *str,  
   unsigned int c   
);  
unsigned char *_mbsset_l(  
   unsigned char *str,  
   unsigned int c,  
   _locale_t locale  
);  
```  
  
#### Parameters  
 `str`  
 Null-terminated string to be set.  
  
 `c`  
 Character setting.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 Returns a pointer to the altered string.  
  
## Remarks  
 The `_strset` function sets all characters (except the terminating null character) of `str` to `c`, converted to `char`. `_wcsset` and `_mbsset_l` are wide-character and multibyte-character versions of `_strset`, and the data types of the arguments and return values vary accordingly. These functions behave identically otherwise.  
  
 `_mbsset` validates its parameters. If `str` is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../VS_csharp/parameter-validation.md). If execution is allowed to continue,`_mbsset` returns `NULL` and sets `errno` to `EINVAL`. `_strset` and `_wcsset` do not validate their parameters.  
  
 The output value is affected by the setting of the `LC_CTYPE` category setting of the locale; see [setlocale, _wsetlocale](../VS_csharp/setlocale--_wsetlocale.md) for more information. The versions of these functions are identical, except that the ones that don't have the `_l` suffix use the current locale and the ones that do have the `_l` suffix instead use the locale parameter that's passed in. For more information, see [Locale](../VS_csharp/locale.md).  
  
> [!IMPORTANT]
>  These functions might be vulnerable to buffer overrun threats. Buffer overruns can be used for system attacks because they can cause an unwarranted elevation of privilege. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_tcsset`|`_strset`|`_mbsset`|`_wcsset`|  
|`_tcsset_l`|`_strset_l`|`_mbsset_l`|`_wcsset_l`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_strset`|<string.h>|  
|`_strset_l`|<tchar.h>|  
|`_wcsset`|<string.h> or <wchar.h>|  
|`_wcsset_l`|<tchar.h>|  
|`_mbsset`, `_mbsset_l`|<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## Example  
  
```  
// crt_strset.c  
// compile with: /W3  
  
#include <string.h>  
#include <stdio.h>  
  
int main( void )  
{  
   char string[] = "Fill the string with something.";  
   printf( "Before: %s\n", string );  
   _strset( string, '*' ); // C4996  
   // Note: _strset is deprecated; consider using _strset_s instead  
   printf( "After:  %s\n", string );  
}  
```  
  
 **Before: Fill the string with something.**  
**After:  \*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\***   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../VS_csharp/string-manipulation--crt-.md)   
 [Locale](../VS_csharp/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../VS_csharp/interpretation-of-multibyte-character-sequences.md)   
 [_mbsnbset, _mbsnbset_l](../VS_csharp/_mbsnbset--_mbsnbset_l.md)   
 [memset, wmemset](../VS_csharp/memset--wmemset.md)   
 [strcat, wcscat, _mbscat](../VS_csharp/strcat--wcscat--_mbscat.md)   
 [strcmp, wcscmp, _mbscmp](../VS_csharp/strcmp--wcscmp--_mbscmp.md)   
 [strcpy, wcscpy, _mbscpy](../VS_csharp/strcpy--wcscpy--_mbscpy.md)   
 [_strnset, _wcsnset, _mbsnset, _mbsnset_l](../VS_csharp/_strnset--_strnset_l--_wcsnset--_wcsnset_l--_mbsnset--_mbsnset_l.md)