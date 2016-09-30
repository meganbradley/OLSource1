---
title: "_getchar_nolock, _getwchar_nolock"
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
  - "_getchar_nolock"
  - "_getwchar_nolock"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "getwchar_nolock"
  - "_getwchar_nolock"
  - "_getchar_nolock"
  - "getchar_nolock"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_getwchar_nolock function"
  - "getwchar_nolock function"
  - "characters, reading"
  - "_getchar_nolock function"
  - "getchar_nolock function"
  - "standard input, reading from"
ms.assetid: dc49ba60-0647-4ae9-aa9a-a0618b1666de
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _getchar_nolock, _getwchar_nolock
Reads a character from standard input.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 See [getchar, getwchar](../vs140/getchar--getwchar.md).  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are identical to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> except that they are not protected from interference by other threads. They might be faster because they do not incur the overhead of locking out other threads. Use these functions only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>Input was: This text**   
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