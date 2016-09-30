---
title: "fgetc, fgetwc"
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
  - "fgetwc"
  - "fgetc"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_fgettc"
  - "fgetwc"
  - "fgetc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "fgettc function"
  - "characters, reading"
  - "_fgettc function"
  - "fgetc function"
  - "streams, reading characters from"
  - "reading characters from streams"
  - "fgetwc function"
ms.assetid: 13348b7b-dc86-421c-9d6c-611ca79c8338
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fgetc, fgetwc
Read a character from a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns the character read as an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to indicate an error or end of file. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns, as a [wint_t](../vs140/standard-types.md), the wide character that corresponds to the character read or returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to indicate an error or end of file. For both functions, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to distinguish between an error and an end-of-file condition. If a read error occurs, the error indicator for the stream is set. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and return <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Remarks  
 Each of these functions reads a single character from the current position of the file associated with <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The function then increments the associated file pointer (if defined) to point to the next character. If the stream is at end of file, the end-of-file indicator for the stream is set.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, but is implemented only as a function, rather than as a function and a macro.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is the wide-character version of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>; it reads <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> as a multibyte character or a wide character according to whether <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is opened in text mode or binary mode.  
  
 The versions with the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> suffix are identical except that they are not protected from interference by other threads.  
  
 For more information about processing wide characters and multibyte characters in text and binary modes, see [Unicode Stream I/O in Text and Binary Modes](../vs140/unicode-stream-i-o-in-text-and-binary-modes.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: crt_fgetc.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
  
-   [System::IO::StreamReader::Read](https://msdn.microsoft.com/en-us/library/system.io.streamreader.read.aspx)  
  
-   [System::Console::Read](https://msdn.microsoft.com/en-us/library/system.console.read.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fputc, fputwc](../vs140/fputc--fputwc.md)   
 [getc, getwc](../vs140/getc--getwc.md)