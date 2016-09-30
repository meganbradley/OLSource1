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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Bytes to allocate.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a void pointer to the allocated space, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if there is insufficient memory available. To return a pointer to a type other than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, use a type cast on the return value. The storage space pointed to by the return value is guaranteed to be suitably aligned for storage of any type of object that has an alignment requirement less than or equal to that of the fundamental alignment. (In Visual C++, the fundamental alignment is the alignment that's required for a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or 8 bytes. In code that targets 64-bit platforms, it’s 16 bytes.) Use [_aligned_malloc](../vs140/_aligned_malloc.md) to allocate storage for objects that have a larger alignment requirement—for example, the SSE types [__m128](../vs140/__m128.md) and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and types that are declared by using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is greater than 8. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is 0, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> allocates a zero-length item in the heap and returns a valid pointer to that item. Always check the return from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, even if the amount of memory requested is small.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function allocates a memory block of at least <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> bytes. The block may be larger than <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> bytes because of the space that's required for alignment and maintenance information.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> if a memory allocation fails or if the amount of memory requested exceeds <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. For information about this and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 The startup code uses <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to allocate storage for the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> variables. The following functions and their wide-character counterparts also call <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
|||||  
|-|-|-|-|  
|[calloc](../vs140/calloc.md)|[fscanf](../vs140/fscanf--_fscanf_l--fwscanf--_fwscanf_l.md)|[_getw](../vs140/_getw.md)|[setvbuf](../vs140/setvbuf.md)|  
|[_exec functions](../vs140/_exec--_wexec-functions.md)|[fseek](../vs140/fseek--_fseeki64.md)|[_popen](../vs140/_popen--_wpopen.md)|[_spawn functions](../vs140/_spawn--_wspawn-functions.md)|  
|[fgetc](../vs140/fgetc--fgetwc.md)|[fsetpos](../vs140/fsetpos.md)|[printf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)|[_strdup](../vs140/_strdup--_wcsdup--_mbsdup.md)|  
|[_fgetchar](../vs140/fgetc--fgetwc.md)|[_fullpath](../vs140/_fullpath--_wfullpath.md)|[putc](../vs140/putc--putwc.md)|[system](../vs140/system--_wsystem.md)|  
|[fgets](../vs140/fgets--fgetws.md)|[fwrite](../vs140/fwrite.md)|[putchar](../vs140/putc--putwc.md)|[_tempnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md)|  
|[fprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)|[getc](../vs140/getc--getwc.md)|[_putenv](../vs140/_putenv--_wputenv.md)|[ungetc](../vs140/ungetc--ungetwc.md)|  
|[fputc](../vs140/fputc--fputwc.md)|[getchar](../vs140/getc--getwc.md)|[puts](../vs140/puts--_putws.md)|[vfprintf](../vs140/vfprintf--_vfprintf_l--vfwprintf--_vfwprintf_l.md)|  
|[_fputchar](../vs140/fputc--fputwc.md)|[_getcwd](../vs140/_getcwd--_wgetcwd.md)|[_putw](../vs140/_putw.md)|[vprintf](../vs140/vprintf--_vprintf_l--vwprintf--_vwprintf_l.md)|  
|[fputs](../vs140/fputs--fputws.md)|[_getdcwd](../vs140/_getcwd--_wgetcwd.md)|[scanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)||  
|[fread](../vs140/fread.md)|[gets](../vs140/gets--_getws.md)|[_searchenv](../vs140/_searchenv--_wsearchenv.md)||  
  
 The C++ [_set_new_mode](../vs140/_set_new_mode.md) function sets the new handler mode for <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. The new handler mode indicates whether, on failure, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is to call the new handler routine as set by [_set_new_handler](../vs140/_set_new_handler.md). By default, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> does not call the new handler routine on failure to allocate memory. You can override this default behavior so that, when <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> fails to allocate memory, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> calls the new handler routine in the same way that the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> operator does when it fails for the same reason. To override the default, call  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 early in your program, or link with NEWMODE.OBJ (see [Link Options](../vs140/link-options.md)).  
  
 When the application is linked with a debug version of the C run-time libraries, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> resolves to [_malloc_dbg](../vs140/_malloc_dbg.md). For more information about how the heap is managed during the debugging process, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md).  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is marked <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>; this means that the function is guaranteed not to modify global variables, and that the pointer returned is not aliased. For more information, see [noalias](../vs140/noalias.md) and [restrict](../vs140/restrict.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<stdlib.h> and \<malloc.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Memory space allocated for path name**  
**Memory freed**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [calloc](../vs140/calloc.md)   
 [free](../vs140/free.md)   
 [realloc](../vs140/realloc.md)   
 [_aligned_malloc](../vs140/_aligned_malloc.md)