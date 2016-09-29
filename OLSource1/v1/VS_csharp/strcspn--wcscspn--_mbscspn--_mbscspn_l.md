---
title: "strcspn, wcscspn, _mbscspn, _mbscspn_l"
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
  - "_mbscspn_l"
  - "wcscspn"
  - "_mbscspn"
  - "strcspn"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "strcspn"
  - "_mbscspn"
  - "wcscspn"
  - "_ftcscspn"
  - "_tcscspn"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "strings [C++], searching"
  - "ftcscspn function"
  - "strcspn function"
  - "_mbscspn function"
  - "mbscspn_l function"
  - "wcscspn function"
  - "tcscspn function"
  - "_ftcscspn function"
  - "_mbscspn_l function"
  - "mbscspn function"
  - "_tcscspn function"
ms.assetid: f73f51dd-b533-4e46-ba29-d05c553708a6
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strcspn, wcscspn, _mbscspn, _mbscspn_l
Returns the index of the first occurrence in a string, of a character that belongs to a set of characters.  
  
> [!IMPORTANT]
>  `_mbschr` and `_mbschr_l`cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
size_t strcspn(  
   const char *str,  
   const char *strCharSet   
);  
size_t wcscspn(  
   const wchar_t *str,  
   const wchar_t *strCharSet   
);  
size_t _mbscspn(  
   const unsigned char *str,  
   const unsigned char *strCharSet   
);  
size_t _mbscspn_l(  
   const unsigned char *str,  
   const unsigned char *strCharSet,  
   _locale_t locale  
);  
```  
  
#### Parameters  
 `str`  
 Null-terminated searched string.  
  
 `strCharSet`  
 Null-terminated character set.  
  
 `locale`  
 Locale to use.  
  
## Return Value  
 These functions return the index of the first character in `str` that is in `strCharSet`. If none of the characters in `str` is in `strCharSet`, then the return value is the length of `str`.  
  
 No return value is reserved to indicate an error.  
  
## Remarks  
 `wcscspn` and `_mbscspn` are wide-character and multibyte-character versions of `strcspn`. The arguments of `wcscspn` are wide-character strings; those of `_mbscspn` are multibyte-character strings.  
  
 `_mbscspn` validates its parameters. If either `str` or `strCharSet` is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../VS_csharp/parameter-validation.md). If execution is allowed to continue, the function returns 0 and sets `errno` to `EINVAL`. `strcspn` and `wcscspn` do not validate their parameters. These three functions behave identically otherwise.  
  
 The output value is affected by the setting of the `LC_CTYPE` category setting of the locale; see [setlocale](../VS_csharp/setlocale--_wsetlocale.md) for more information. The versions of these functions without the `_l` suffix use the current locale for this locale-dependent behavior; the versions with the `_l` suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../VS_csharp/locale.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_tcscspn`|`strcspn`|`_mbscspn`|`wcscspn`|  
|`n/a`|`n/a`|`_mbscspn_l`|`n/a`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`strcspn`|<string.h>|  
|`wcscspn`|<string.h> or <wchar.h>|  
|`_mbscspn`, `_mbscspn_l`|<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## Example  
  
```  
// crt_strcspn.c  
  
#include <string.h>  
#include <stdio.h>  
  
void test( const char * str, const char * strCharSet )  
{  
   int pos = strcspn( str, strCharSet );  
   printf( "strcspn( \"%s\", \"%s\" ) = %d\n", str, strCharSet, pos );      
}  
  
int main( void )  
{  
   test( "xyzbxz", "abc" );  
   test( "xyzbxz", "xyz" );  
   test( "xyzbxz", "no match" );  
   test( "xyzbxz", "" );  
   test( "", "abc" );  
   test( "", "" );  
}  
```  
  
 **strcspn( "xyzbxz", "abc" ) = 3**  
**strcspn( "xyzbxz", "xyz" ) = 0**  
**strcspn( "xyzbxz", "no match" ) = 6**  
**strcspn( "xyzbxz", "" ) = 6**  
**strcspn( "", "abc" ) = 0**  
**strcspn( "", "" ) = 0**   
## .NET Framework Equivalent  
 [System::String::Substring](https://msdn.microsoft.com/en-us/library/system.string.substring.aspx)  
  
## See Also  
 [String Manipulation](../VS_csharp/string-manipulation--crt-.md)   
 [Locale](../VS_csharp/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../VS_csharp/interpretation-of-multibyte-character-sequences.md)   
 [strncat, _strncat_l, wcsncat, _wcsncat_l, _mbsncat _mbsncat_l](../VS_csharp/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../VS_csharp/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../VS_csharp/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../VS_csharp/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../VS_csharp/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../VS_csharp/strspn--wcsspn--_mbsspn--_mbsspn_l.md)