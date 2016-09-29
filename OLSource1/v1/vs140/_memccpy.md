---
title: "_memccpy"
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
  - "_memccpy"
apilocation: 
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_memccpy"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_memccpy function"
  - "memccpy function"
ms.assetid: 9a2337df-6e85-4eba-b247-dd0532f45ddb
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _memccpy
Copies characters from a buffer.  
  
## Syntax  
  
```  
  
      void *_memccpy(  
   void *dest,  
   const void *src,  
   int c,  
   size_t count   
);  
```  
  
#### Parameters  
 *dest*  
 Pointer to the destination.  
  
 *src*  
 Pointer to the source.  
  
 `c`  
 Last character to copy.  
  
 *count*  
 Number of characters.  
  
## Return Value  
 If the character `c` is copied, `_memccpy` returns a pointer to the char in *dest* that immediately follows the character. If `c` is not copied, it returns **NULL**.  
  
## Remarks  
 The `_memccpy` function copies 0 or more characters of *src* to *dest*, halting when the character `c` has been copied or when *count* characters have been copied, whichever comes first.  
  
 **Security Note** Make sure that the destination buffer is the same size or larger than the source buffer. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_memccpy`|<memory.h> or <string.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
```  
// crt_memccpy.c  
  
#include <memory.h>  
#include <stdio.h>  
#include <string.h>  
  
char string1[60] = "The quick brown dog jumps over the lazy fox";  
  
int main( void )  
{  
   char buffer[61];  
   char *pdest;  
  
   printf( "Function: _memccpy 60 characters or to character 's'\n" );  
   printf( "Source: %s\n", string1 );  
   pdest = _memccpy( buffer, string1, 's', 60 );  
   *pdest = '\0';  
   printf( "Result: %s\n", buffer );  
   printf( "Length: %d characters\n", strlen( buffer ) );  
}  
```  
  
## Output  
  
```  
Function: _memccpy 60 characters or to character 's'  
Source: The quick brown dog jumps over the lazy fox  
Result: The quick brown dog jumps  
Length: 25 characters  
```  
  
## .NET Framework Equivalent  
  
-   [System::Buffer::BlockCopy](https://msdn.microsoft.com/en-us/library/system.buffer.blockcopy.aspx)  
  
-   [System::String::Copy](https://msdn.microsoft.com/en-us/library/system.string.copy.aspx)  
  
## See Also  
 [Buffer Manipulation](../vs140/buffer-manipulation.md)   
 [memchr, wmemchr](../vs140/memchr--wmemchr.md)   
 [memcmp, wmemcmp](../vs140/memcmp--wmemcmp.md)   
 [memcpy, wmemcpy](../vs140/memcpy--wmemcpy.md)   
 [memset, wmemset](../vs140/memset--wmemset.md)