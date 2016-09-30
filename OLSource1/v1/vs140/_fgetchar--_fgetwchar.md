---
title: "_fgetchar, _fgetwchar"
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
  - "_fgetchar"
  - "_fgetwchar"
apilocation: 
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fgetwchar"
  - "_fgettchar"
  - "_fgetchar"
  - "_fgetwchar"
  - "fgettchar"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "fgetwchar function"
  - "_fgetchar function"
  - "fgettchar function"
  - "_fgetwchar function"
  - "_fgettchar function"
  - "standard input, reading from"
  - "fgetchar function"
ms.assetid: 8bce874c-701a-41a3-b1b2-feff266fb5b9
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fgetchar, _fgetwchar
Reads a character from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns the character read as an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or return <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to indicate an error or end of file. **_**<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns, as a [wint_t](../vs140/standard-types.md), the wide character that corresponds to the character read or returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to indicate an error or end of file. For both functions, use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to distinguish between an error and an end-of-file condition.  
  
## Remarks  
 These functions read a single character from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The function then increments the associated file pointer (if defined) to point to the next character. If the stream is at end of file, the end-of-file indicator for the stream is set.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. It is also equivalent to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, but implemented only as a function, rather than as a function and a macro. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is the wide-character version of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 These functions are not compatible with the ANSI standard.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>Line one.**  
**Line two.**   
## .NET Framework Equivalent  
  
-   [System::IO::StreamReader::Read](https://msdn.microsoft.com/en-us/library/system.io.streamreader.read.aspx)  
  
-   [System::Console::Read](https://msdn.microsoft.com/en-us/library/system.console.read.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fputc, fputwc](../vs140/fputc--fputwc.md)   
 [getc, getwc](../vs140/getc--getwc.md)