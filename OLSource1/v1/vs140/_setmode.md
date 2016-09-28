---
title: "_setmode"
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
  - "_setmode"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_setmode"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "Unicode [C++], console output"
  - "files [C++], modes"
  - "_setmode function"
  - "file translation [C++], setting mode"
  - "files [C++], translation"
  - "setmode function"
ms.assetid: 996ff7cb-11d1-43f4-9810-f6097182642a
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _setmode
Sets the file translation mode.  
  
## Syntax  
  
```  
int _setmode (  
   int fd,  
   int mode   
);  
```  
  
#### Parameters  
 `fd`  
 File descriptor.  
  
 `mode`  
 New translation mode.  
  
## Return Value  
 If successful, returns the previous translation mode.  
  
 If invalid parameters are passed to this function, the invalid-parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns –1 and sets `errno` to either `EBADF`, which indicates an invalid file descriptor, or `EINVAL`, which indicates an invalid `mode` argument.  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The `_setmode` function sets to `mode` the translation mode of the file given by `fd`. Passing `_O_TEXT` as `mode` sets text (that is, translated) mode. Carriage return–line feed (CR-LF) combinations are translated into a single line feed character on input. Line feed characters are translated into CR-LF combinations on output. Passing `_O_BINARY` sets binary (untranslated) mode, in which these translations are suppressed.  
  
 You can also pass `_O_U16TEXT`, `_O_U8TEXT`, or _`O_WTEXT` to enable Unicode mode, as demonstrated in the second example later in this document. `_setmode` is typically used to modify the default translation mode of `stdin` and `stdout`, but you can use it on any file. If you apply `_setmode` to the file descriptor for a stream, call `_setmode` before you perform any input or output operations on the stream.  
  
> [!CAUTION]
>  If you write data to a file stream, explicitly flush the code by using [fflush](../vs140/fflush.md) before you use `_setmode` to change the mode. If you do not flush the code, you might get unexpected behavior. If you have not written data to the stream, you do not have to flush the code.  
  
## Requirements  
  
|Routine|Required header|Optional Headers|  
|-------------|---------------------|----------------------|  
|`_setmode`|<io.h>|<fcntl.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
```  
// crt_setmode.c  
// This program uses _setmode to change  
// stdin from text mode to binary mode.  
  
#include <stdio.h>  
#include <fcntl.h>  
#include <io.h>  
  
int main( void )  
{  
   int result;  
  
   // Set "stdin" to have binary mode:  
   result = _setmode( _fileno( stdin ), _O_BINARY );  
   if( result == -1 )  
      perror( "Cannot set mode" );  
   else  
      printf( "'stdin' successfully changed to binary mode\n" );  
}  
```  
  
 **'stdin' successfully changed to binary mode**   
## Example  
  
```  
// crt_setmodeunicode.c  
// This program uses _setmode to change  
// stdout to Unicode. Cyrillic and Ideographic  
// characters will appear on the console (if  
// your console font supports those character sets).  
  
#include <fcntl.h>  
#include <io.h>  
#include <stdio.h>  
  
int main(void) {  
    _setmode(_fileno(stdout), _O_U16TEXT);  
    wprintf(L"\x043a\x043e\x0448\x043a\x0430 \x65e5\x672c\x56fd\n");  
    return 0;  
}  
```  
  
## .NET Framework Equivalent  
  
-   [System::IO::BinaryReader Class](https://msdn.microsoft.com/en-us/library/system.io.binaryreader.aspx)  
  
-   [System::IO::TextReader Class](https://msdn.microsoft.com/en-us/library/system.io.textreader.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_set_fmode](../vs140/_set_fmode.md)