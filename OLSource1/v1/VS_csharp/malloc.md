---
title: "malloc"
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
  - "malloc"
apilocation: 
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "malloc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "malloc function"
  - "memory allocation"
ms.assetid: 144fcee2-be34-4a03-bb7e-ed6d4b99eea0
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# malloc
Allocates memory blocks.  
  
## Syntax  
  
```  
void *malloc(  
   size_t size   
);  
```  
  
#### Parameters  
 `size`  
 Bytes to allocate.  
  
## Return Value  
 `malloc` returns a void pointer to the allocated space, or `NULL` if there is insufficient memory available. To return a pointer to a type other than `void`, use a type cast on the return value. The storage space pointed to by the return value is guaranteed to be suitably aligned for storage of any type of object that has an alignment requirement less than or equal to that of the fundamental alignment. (In Visual C++, the fundamental alignment is the alignment that's required for a `double`, or 8 bytes. In code that targets 64-bit platforms, it’s 16 bytes.) Use [_aligned_malloc](../VS_csharp/_aligned_malloc.md) to allocate storage for objects that have a larger alignment requirement—for example, the SSE types [__m128](../VS_csharp/__m128.md) and `__m256`, and types that are declared by using `__declspec(align(``n``))` where `n` is greater than 8. If `size` is 0, `malloc` allocates a zero-length item in the heap and returns a valid pointer to that item. Always check the return from `malloc`, even if the amount of memory requested is small.  
  
## Remarks  
 The `malloc` function allocates a memory block of at least `size` bytes. The block may be larger than `size` bytes because of the space that's required for alignment and maintenance information.  
  
 `malloc` sets `errno` to `ENOMEM` if a memory allocation fails or if the amount of memory requested exceeds `_HEAP_MAXREQ`. For information about this and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../VS_csharp/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 The startup code uses `malloc` to allocate storage for the `_environ`, `envp`, and `argv` variables. The following functions and their wide-character counterparts also call `malloc`.  
  
|||||  
|-|-|-|-|  
|[calloc](../VS_csharp/calloc.md)|[fscanf](../VS_csharp/fscanf--_fscanf_l--fwscanf--_fwscanf_l.md)|[_getw](../VS_csharp/_getw.md)|[setvbuf](../VS_csharp/setvbuf.md)|  
|[_exec functions](../VS_csharp/_exec--_wexec-functions.md)|[fseek](../VS_csharp/fseek--_fseeki64.md)|[_popen](../VS_csharp/_popen--_wpopen.md)|[_spawn functions](../VS_csharp/_spawn--_wspawn-functions.md)|  
|[fgetc](../VS_csharp/fgetc--fgetwc.md)|[fsetpos](../VS_csharp/fsetpos.md)|[printf](../VS_csharp/printf--_printf_l--wprintf--_wprintf_l.md)|[_strdup](../VS_csharp/_strdup--_wcsdup--_mbsdup.md)|  
|[_fgetchar](../VS_csharp/fgetc--fgetwc.md)|[_fullpath](../VS_csharp/_fullpath--_wfullpath.md)|[putc](../VS_csharp/putc--putwc.md)|[system](../VS_csharp/system--_wsystem.md)|  
|[fgets](../VS_csharp/fgets--fgetws.md)|[fwrite](../VS_csharp/fwrite.md)|[putchar](../VS_csharp/putc--putwc.md)|[_tempnam](../VS_csharp/_tempnam--_wtempnam--tmpnam--_wtmpnam.md)|  
|[fprintf](../VS_csharp/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)|[getc](../VS_csharp/getc--getwc.md)|[_putenv](../VS_csharp/_putenv--_wputenv.md)|[ungetc](../VS_csharp/ungetc--ungetwc.md)|  
|[fputc](../VS_csharp/fputc--fputwc.md)|[getchar](../VS_csharp/getc--getwc.md)|[puts](../VS_csharp/puts--_putws.md)|[vfprintf](../VS_csharp/vfprintf--_vfprintf_l--vfwprintf--_vfwprintf_l.md)|  
|[_fputchar](../VS_csharp/fputc--fputwc.md)|[_getcwd](../VS_csharp/_getcwd--_wgetcwd.md)|[_putw](../VS_csharp/_putw.md)|[vprintf](../VS_csharp/vprintf--_vprintf_l--vwprintf--_vwprintf_l.md)|  
|[fputs](../VS_csharp/fputs--fputws.md)|[_getdcwd](../VS_csharp/_getcwd--_wgetcwd.md)|[scanf](../VS_csharp/scanf--_scanf_l--wscanf--_wscanf_l.md)||  
|[fread](../VS_csharp/fread.md)|[gets](../VS_csharp/gets--_getws.md)|[_searchenv](../VS_csharp/_searchenv--_wsearchenv.md)||  
  
 The C++ [_set_new_mode](../VS_csharp/_set_new_mode.md) function sets the new handler mode for `malloc`. The new handler mode indicates whether, on failure, `malloc` is to call the new handler routine as set by [_set_new_handler](../VS_csharp/_set_new_handler.md). By default, `malloc` does not call the new handler routine on failure to allocate memory. You can override this default behavior so that, when `malloc` fails to allocate memory, `malloc` calls the new handler routine in the same way that the `new` operator does when it fails for the same reason. To override the default, call  
  
```cpp  
_set_new_mode(1)  
```  
  
 early in your program, or link with NEWMODE.OBJ (see [Link Options](../VS_csharp/link-options.md)).  
  
 When the application is linked with a debug version of the C run-time libraries, `malloc` resolves to [_malloc_dbg](../VS_csharp/_malloc_dbg.md). For more information about how the heap is managed during the debugging process, see [CRT Debug Heap Details](../VS_csharp/crt-debug-heap-details.md).  
  
 `malloc` is marked `__declspec(noalias)` and `__declspec(restrict)`; this means that the function is guaranteed not to modify global variables, and that the pointer returned is not aliased. For more information, see [noalias](../VS_csharp/noalias.md) and [restrict](../VS_csharp/restrict.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`malloc`|<stdlib.h> and <malloc.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../VS_csharp/crt-library-features.md).  
  
## Example  
  
```c  
// crt_malloc.c  
// This program allocates memory with  
// malloc, then frees the memory with free.  
  
#include <stdlib.h>   // For _MAX_PATH definition  
#include <stdio.h>  
#include <malloc.h>  
  
int main( void )  
{  
   char *string;  
  
   // Allocate space for a path name  
   string = malloc( _MAX_PATH );  
  
   // In a C++ file, explicitly cast malloc's return.  For example,   
   // string = (char *)malloc( _MAX_PATH );  
  
   if( string == NULL )  
      printf( "Insufficient memory available\n" );  
   else  
   {  
      printf( "Memory space allocated for path name\n" );  
      free( string );  
      printf( "Memory freed\n" );  
   }  
}  
```  
  
 **Memory space allocated for path name**  
**Memory freed**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../VS_csharp/memory-allocation.md)   
 [calloc](../VS_csharp/calloc.md)   
 [free](../VS_csharp/free.md)   
 [realloc](../VS_csharp/realloc.md)   
 [_aligned_malloc](../VS_csharp/_aligned_malloc.md)