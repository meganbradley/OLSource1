---
title: "getchar, getwchar"
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
  - "getchar"
  - "getwchar"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "getwchar"
  - "GetChar"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "gettchar function"
  - "characters, reading"
  - "getwchar function"
  - "_gettchar function"
  - "standard input, reading from"
ms.assetid: 19fda588-3e33-415c-bb60-dd73c028086a
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# getchar, getwchar
Reads a character from standard input.  
  
## Syntax  
  
```  
int getchar();  
wint_t getwchar();  
```  
  
## Return Value  
 Returns the character read. To indicate a read error or end-of-file condition, `getchar``returns EOF`, and `getwchar` returns `WEOF`. For `getchar`, use `ferror` or `feof` to check for an error or for end of file.  
  
## Remarks  
 Each routine reads a single character from `stdin` and increments the associated file pointer to point to the next character. `getchar` is the same as [_fgetchar](../vs140/fgetc--fgetwc.md), but it is implemented as a function and as a macro.  
  
 These functions lock the calling thread and are therefore thread-safe. For a non-locking version, see [_getchar_nolock, _getwchar_nolock](../vs140/_getchar_nolock--_getwchar_nolock.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_gettchar`|`getchar`|`getchar`|`getwchar`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`getchar`|<stdio.h>|  
|`getwchar`|<stdio.h> or <wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—`stdin`, `stdout`, and `stderr`—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
```  
// crt_getchar.c  
// Use getchar to read a line from stdin.  
  
#include <stdio.h>  
  
int main()  
{  
    char buffer[81];  
    int i, ch;  
  
    for (i = 0; (i < 80) && ((ch = getchar()) != EOF)  
                         && (ch != '\n'); i++)  
    {  
        buffer[i] = (char) ch;  
    }  
  
    // Terminate string with a null character   
    buffer[i] = '\0';  
    printf( "Input was: %s\n", buffer);  
}  
```  
  
  **`This text`Input was: This text**   
## .NET Framework Equivalent  
  
-   [System::IO::StreamReader::Read](https://msdn.microsoft.com/en-us/library/system.io.streamreader.read.aspx)  
  
-   [System::Console::Read](https://msdn.microsoft.com/en-us/library/system.console.read.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [getc, getwc](../vs140/getc--getwc.md)   
 [fgetc, fgetwc](../vs140/fgetc--fgetwc.md)   
 [_getch, _getwch](../vs140/_getch--_getwch.md)   
 [putc, putwc](../vs140/putc--putwc.md)   
 [ungetc, ungetwc](../vs140/ungetc--ungetwc.md)