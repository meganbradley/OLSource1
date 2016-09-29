---
title: "_mbsnbcmp, _mbsnbcmp_l"
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
  - "_mbsnbcmp"
  - "_mbsnbcmp_l"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsnbcmp"
  - "tcsnbmp"
  - "_mbsnbcmp_l"
  - "mbsnbcmp_l"
  - "_mbsnbcmp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbsnbcmp_l function"
  - "mbsnbcmp function"
  - "tcsncmp function"
  - "_mbsnbcmp_l function"
  - "_tcsncmp function"
  - "_mbsnbcmp function"
ms.assetid: dbc99e50-cf85-4e57-a13f-067591f18ac8
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbsnbcmp, _mbsnbcmp_l
Compares the first `n` bytes of two multibyte-character strings.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
int _mbsnbcmp(  
   const unsigned char *string1,  
   const unsigned char *string2,  
   size_t count   
);  
int _mbsnbcmp_l(  
   const unsigned char *string1,  
   const unsigned char *string2,  
   size_t count,  
   _locale_t locale  
);  
```  
  
#### Parameters  
 `string1, string2`  
 The strings to compare.  
  
 `count`  
 The number of bytes to compare.  
  
 `locale`  
 The locale to use.  
  
## Return Value  
 The return value indicates the ordinal relationship between the substrings of `string1` and `string`.  
  
|Return value|Description|  
|------------------|-----------------|  
|< 0|`string1` substring is less than `string2` substring.|  
|0|`string1` substring is identical to `string2` substring.|  
|> 0|`string1` substring is greater than `string2` substring.|  
  
 On a parameter validation error, `_mbsnbcmp` and `_mbsnbcmp_l` return `_NLSCMPERROR`, which is defined in <string.h> and <mbstring.h>.  
  
## Remarks  
 The `_mbsnbcmp` functions compare at most the first `count` bytes in `string1` and `string2` and return a value that indicates the relationship between the substrings. `_mbsnbcmp` is a case-sensitive version of `_mbsnbicmp`. Unlike `_mbsnbcoll`, `_mbsnbcmp` is not affected by the collation order of the locale. `_mbsnbcmp` recognizes multibyte-character sequences according to the current multibyte [code page](../VS_csharp/code-pages.md).  
  
 `_mbsnbcmp` resembles `_mbsncmp`, except that `_mbsncmp` compares strings by characters rather than by bytes.  
  
 The output value is affected by the `LC_CTYPE` category setting of the locale, which specifies the lead bytes and trailing bytes of multibyte characters. For more information, see [setlocale](../VS_csharp/setlocale--_wsetlocale.md). The `_mbsnbcmp` function uses the current locale for this locale-dependent behavior. The `_mbsnbcmp_l` function is identical except that it uses the `locale` parameter instead. For more information, see [Locale](../VS_csharp/locale.md).  
  
 If either `string1` or `string2` is a null pointer, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../VS_csharp/parameter-validation.md). If execution is allowed to continue, the functions return `_NLSCMPERROR` and `errno` is set to `EINVAL`.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and  _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|---------------------------------------|--------------------|-----------------------|  
|`_tcsncmp`|[strncmp](../VS_csharp/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)|`_mbsnbcmp`|[wcsncmp](../VS_csharp/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)|  
|`_tcsncmp_l`|[strncmp](../VS_csharp/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)|`_mbsnbcml`|[wcsncmp](../VS_csharp/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_mbsnbcmp`|<mbstring.h>|  
|`_mbsnbcmp_l`|<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## Example  
  
```  
// crt_mbsnbcmp.c  
#include <mbstring.h>  
#include <stdio.h>  
  
char string1[] = "The quick brown dog jumps over the lazy fox";  
char string2[] = "The QUICK brown fox jumps over the lazy dog";  
  
int main( void )  
{  
   char tmp[20];  
   int result;  
   printf( "Compare strings:\n          %s\n", string1 );  
   printf( "          %s\n\n", string2 );  
   printf( "Function: _mbsnbcmp (first 10 characters only)\n" );  
   result = _mbsncmp( string1, string2 , 10 );  
   if( result > 0 )  
      _mbscpy_s( tmp, sizeof(tmp), "greater than" );  
   else if( result < 0 )  
      _mbscpy_s( tmp, sizeof(tmp), "less than" );  
   else  
      _mbscpy_s( tmp, sizeof(tmp), "equal to" );  
   printf( "Result:   String 1 is %s string 2\n\n", tmp );  
   printf( "Function: _mbsnicmp _mbsnicmp (first 10 characters only)\n" );  
   result = _mbsnicmp( string1, string2, 10 );  
   if( result > 0 )  
      _mbscpy_s( tmp, sizeof(tmp), "greater than" );  
   else if( result < 0 )  
      _mbscpy_s( tmp, sizeof(tmp), "less than" );  
   else  
      _mbscpy_s( tmp, sizeof(tmp), "equal to" );  
   printf( "Result:   String 1 is %s string 2\n\n", tmp );  
}  
```  
  
## Output  
  
```  
Compare strings:  
          The quick brown dog jumps over the lazy fox  
          The QUICK brown fox jumps over the lazy dog  
  
Function: _mbsnbcmp (first 10 characters only)  
Result:   String 1 is greater than string 2  
  
Function: _mbsnicmp _mbsnicmp (first 10 characters only)  
Result:   String 1 is equal to string 2  
```  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../VS_csharp/string-manipulation--crt-.md)   
 [_mbsnbcat, _mbsnbcat_l](../VS_csharp/_mbsnbcat--_mbsnbcat_l.md)   
 [_mbsnbicmp, _mbsnbicmp_l](../VS_csharp/_mbsnbicmp--_mbsnbicmp_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../VS_csharp/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../VS_csharp/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [Locale](../VS_csharp/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../VS_csharp/interpretation-of-multibyte-character-sequences.md)