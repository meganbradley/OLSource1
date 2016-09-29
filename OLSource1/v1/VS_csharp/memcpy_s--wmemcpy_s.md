---
title: "memcpy_s, wmemcpy_s"
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
  - "memcpy_s"
  - "wmemcpy_s"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wmemcpy_s"
  - "memcpy_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "memcpy_s function"
  - "wmemcpy_s function"
ms.assetid: 5504e20a-83d9-4063-91fc-3f55f7dabe99
caps.latest.revision: 29
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# memcpy_s, wmemcpy_s
Copies bytes between buffers. These are versions of [memcpy, wmemcpy](../VS_csharp/memcpy--wmemcpy.md) with security enhancements as described in [Security Enhancements in the CRT](../VS_csharp/security-features-in-the-crt.md).  
  
## Syntax  
  
```  
errno_t memcpy_s(  
   void *dest,  
   size_t destSize,  
   const void *src,  
   size_t count   
);  
errno_t wmemcpy_s(  
   wchar_t *dest,  
   size_t destSize,  
   const wchar_t *src,  
   size_t count  
);  
```  
  
#### Parameters  
 `dest`  
 New buffer.  
  
 `destSize`  
 Size of the destination buffer, in bytes for memcpy_s and wide characters (wchar_t) for wmemcpy_s.  
  
 `src`  
 Buffer to copy from.  
  
 `count`  
 Number of characters to copy.  
  
## Return Value  
 Zero if successful; an error code on failure.  
  
### Error Conditions  
  
|`dest`|`destSize`|`src`|Return value|Contents of `dest`|  
|------------|----------------|-----------|------------------|------------------------|  
|`NULL`|any|any|`EINVAL`|not modified|  
|any|any|`NULL`|`EINVAL`|`dest` is zeroed out|  
|any|< `count`|any|`ERANGE`|`dest` is zeroed out|  
  
## Remarks  
 `memcpy_s` copies `count` bytes from `src` to `dest`; `wmemcpy_s` copies `count` wide characters (two bytes). If the source and destination overlap, the behavior of `memcpy_s` is undefined. Use `memmove_s` to handle overlapping regions.  
  
 These functions validate their parameters. If `dest` or `src` is a null pointer, or `destSize` is smaller than `count`, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../VS_csharp/parameter-validation.md). If execution is allowed to continue, these functions return `EINVAL` and set `errno` to `EINVAL`.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`memcpy_s`|<memory.h> or <string.h>|  
|`wmemcpy_s`|<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## Example  
  
```  
// crt_memcpy_s.c  
// Copy memory in a more secure way.  
  
#include <memory.h>  
#include <stdio.h>  
  
int main()  
{  
   int a1[10], a2[100], i;  
   errno_t err;  
  
   // Populate a2 with squares of integers  
   for (i = 0; i < 100; i++)  
   {  
      a2[i] = i*i;  
   }  
  
   // Tell memcpy_s to copy 10 ints (40 bytes), giving  
   // the size of the a1 array (also 40 bytes).  
   err = memcpy_s(a1, sizeof(a1), a2, 10 * sizeof (int) );      
   if (err)  
   {  
      printf("Error executing memcpy_s.\n");  
   }  
   else  
   {  
     for (i = 0; i < 10; i++)  
       printf("%d ", a1[i]);  
   }  
   printf("\n");  
}  
```  
  
 **0 1 4 9 16 25 36 49 64 81**    
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Buffer Manipulation](../VS_csharp/buffer-manipulation.md)   
 [_memccpy](../VS_csharp/_memccpy.md)   
 [memchr, wmemchr](../VS_csharp/memchr--wmemchr.md)   
 [memcmp, wmemcmp](../VS_csharp/memcmp--wmemcmp.md)   
 [memmove, wmemmove](../VS_csharp/memmove--wmemmove.md)   
 [memset, wmemset](../VS_csharp/memset--wmemset.md)   
 [strcpy, wcscpy, _mbscpy](../VS_csharp/strcpy--wcscpy--_mbscpy.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../VS_csharp/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)   
 [strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, \__mbsncpy_s_l](../VS_csharp/strncpy_s--_strncpy_s_l--wcsncpy_s--_wcsncpy_s_l--_mbsncpy_s--_mbsncpy_s_l.md)