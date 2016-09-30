---
title: "ungetc, ungetwc"
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
  - "ungetwc"
  - "ungetc"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ungettc"
  - "ungetwc"
  - "ungetc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ungetwc function"
  - "ungettc function"
  - "characters, pushing back onto stream"
  - "_ungettc function"
  - "ungetc function"
ms.assetid: e0754f3a-b4c6-408f-90c7-e6387b830d84
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ungetc, ungetwc
Pushes a character back onto the stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Character to be pushed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 If successful, each of these functions returns the character argument <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>*.* If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> cannot be pushed back or if no character has been read, the input stream is unchanged and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is returned and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 For information on these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function pushes the character <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> back onto <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and clears the end-of-file indicator. The stream must be open for reading. A subsequent read operation on <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> starts with <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>*.* An attempt to push <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> onto the stream using <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is ignored.  
  
 Characters placed on the stream by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> may be erased if <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is called before the character is read from the stream. The file-position indicator will have the value it had before the characters were pushed back. The external storage corresponding to the stream is unchanged. On a successful <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> call against a text stream, the file-position indicator is unspecified until all the pushed-back characters are read or discarded. On each successful <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> call against a binary stream, the file-position indicator is decremented; if its value was 0 before a call, the value is undefined after the call.  
  
 Results are unpredictable if <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is called twice without a read or file-positioning operation between the two calls. After a call to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, a call to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> may fail unless another read operation (such as <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>) has been performed. This is because <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> itself calls <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. However, on each successful <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> call against a text or binary stream, the value of the file-position indicator is unspecified until all pushed-back characters are read or discarded.  
  
 These functions are thread-safe and lock sensitive data during execution. For a non-locking version, see [_ungetc_nolock, _ungetwc_nolock](../vs140/_ungetc_nolock--_ungetwc_nolock.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>Number = 521**  
**Next character in stream = 'a'**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [getc, getwc](../vs140/getc--getwc.md)   
 [putc, putwc](../vs140/putc--putwc.md)