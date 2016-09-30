---
title: "_fputc_nolock, _fputwc_nolock"
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
  - "_fputwc_nolock"
  - "_fputc_nolock"
apilocation: 
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_fputc_nolock"
  - "fputwc_nolock"
  - "fputc_nolock"
  - "fputtc_nolock"
  - "_fputwc_nolock"
  - "_fputtc_nolock"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "streams, writing characters to"
  - "fputwc_nolock function"
  - "fputtc_nolock function"
  - "_fputc_nolock function"
  - "fputc_nolock function"
  - "_fputtc_nolock function"
  - "_fputwc_nolock function"
ms.assetid: c63eb3ad-58fa-46d0-9249-9c25f815eab9
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fputc_nolock, _fputwc_nolock
Writes a character to a stream without locking the thread.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Character to be written.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 Each of these functions returns the character written. For error information, see [fputc, fputwc](../vs140/fputc--fputwc.md).  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are identical to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, respectively, except that they are not protected from interference by other threads. They might be faster because they do not incur the overhead of locking out other threads. Use these functions only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
 The two functions behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> does not currently support output into a UNICODE stream.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **This is a test of _fputc_nolock!!**   
## .NET Framework Equivalent  
  
-   [System::IO::StreamWriter::Write](https://msdn.microsoft.com/en-us/library/system.io.streamwriter.write.aspx)  
  
-   [System::Console::Write](https://msdn.microsoft.com/en-us/library/system.console.write.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fgetc, fgetwc](../vs140/fgetc--fgetwc.md)   
 [putc, putwc](../vs140/putc--putwc.md)