---
title: "_strdup, _wcsdup, _mbsdup"
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
  - "_strdup"
  - "_mbsdup"
  - "_wcsdup"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tcsdup"
  - "mbsdup"
  - "_mbsdup"
  - "_strdup"
  - "_ftcsdup"
  - "_wcsdup"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wcsdup function"
  - "ftcsdup function"
  - "_ftcsdup function"
  - "mbsdup function"
  - "strdup function"
  - "_strdup function"
  - "_wcsdup function"
  - "copying strings"
  - "duplicating strings"
  - "strings [C++], copying"
  - "_mbsdup function"
  - "strings [C++], duplicating"
  - "tcsdup function"
  - "_tcsdup function"
ms.assetid: 8604f8bb-95e9-45d3-93ef-20397ebf247a
caps.latest.revision: 23
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _strdup, _wcsdup, _mbsdup
Duplicates strings.  
  
> [!IMPORTANT]
>  `_mbsdup` cannot be used in applications that execute in the                  [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)]. For more information, see                  [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
char *_strdup(  
   const char *strSource   
);  
wchar_t *_wcsdup(  
   const wchar_t *strSource   
);  
unsigned char *_mbsdup(  
   const unsigned char *strSource   
);  
```  
  
#### Parameters  
 `strSource`  
 Null-terminated source string.  
  
## Return Value  
 Each of these functions returns a pointer to the storage location for the copied string or `NULL` if storage cannot be allocated.  
  
## Remarks  
 The `_strdup` function calls [malloc](../VS_csharp/malloc.md) to allocate storage space for a copy of `strSource` and then copies `strSource` to the allocated space.  
  
 `_wcsdup` and `_mbsdup` are wide-character and multibyte-character versions of `_strdup`. The arguments and return value of `_wcsdup` are wide-character strings; those of `_mbsdup` are multibyte-character strings. These three functions behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_tcsdup`|`_strdup`|`_mbsdup`|`_wcsdup`|  
  
 Because `_strdup` calls `malloc` to allocate storage space for the copy of `strSource`, it is good practice always to release this memory by calling the [free](../VS_csharp/free.md) routine on the pointer that's returned by the call to `_strdup`.  
  
 If `_DEBUG` and `_CRTDBG_MAP_ALLOC` are defined, `_strdup` and `_wcsdup` are replaced by calls to `_strdup_dbg` and `_wcsdup_dbg` to allow for debugging memory allocations. For more information, see [_strdup_dbg, _wcsdup_dbg](../VS_csharp/_strdup_dbg--_wcsdup_dbg.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_strdup`|<string.h>|  
|`_wcsdup`|<string.h> or <wchar.h>|  
|`_mbsdup`|<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## Example  
  
```  
// crt_strdup.c  
  
#include <string.h>  
#include <stdio.h>  
  
int main( void )  
{  
   char buffer[] = "This is the buffer text";  
   char *newstring;  
   printf( "Original: %s\n", buffer );  
   newstring = _strdup( buffer );  
   printf( "Copy:     %s\n", newstring );  
   free( newstring );  
}  
```  
  
 **Original: This is the buffer text**  
**Copy:     This is the buffer text**   
## .NET Framework Equivalent  
 [System::String::Clone](https://msdn.microsoft.com/en-us/library/system.string.clone.aspx)  
  
## See Also  
 [String Manipulation](../VS_csharp/string-manipulation--crt-.md)   
 [memset, wmemset](../VS_csharp/memset--wmemset.md)   
 [strcat, wcscat, _mbscat](../VS_csharp/strcat--wcscat--_mbscat.md)   
 [strcmp, wcscmp, _mbscmp](../VS_csharp/strcmp--wcscmp--_mbscmp.md)   
 [strncat, _strncat_l, wcsncat, _wcsncat_l, _mbsncat _mbsncat_l](../VS_csharp/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../VS_csharp/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../VS_csharp/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../VS_csharp/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../VS_csharp/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../VS_csharp/strspn--wcsspn--_mbsspn--_mbsspn_l.md)