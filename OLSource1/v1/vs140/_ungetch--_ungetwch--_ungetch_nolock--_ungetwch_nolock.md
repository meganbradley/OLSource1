---
title: "_ungetch, _ungetwch, _ungetch_nolock, _ungetwch_nolock"
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
  - "_ungetch_nolock"
  - "_ungetwch_nolock"
  - "_ungetwch"
  - "_ungetch"
apilocation: 
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ungetch_nolock"
  - "ungetwch"
  - "ungetch_nolock"
  - "_ungetwch"
  - "ungetch"
  - "ungetwch_nolock"
  - "_ungetch"
  - "_ungettch_nolock"
  - "_ungettch"
  - "_ungetwch_nolock"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ungetch function"
  - "ungetwch function"
  - "characters, pushing back to console"
  - "_ungettch_nolock function"
  - "ungettch function"
  - "_ungettch function"
  - "ungetch_nolock function"
  - "ungettch_nolock function"
  - "_ungetwch_nolock function"
  - "_ungetch_nolock function"
  - "ungetwch_nolock function"
  - "_ungetwch function"
ms.assetid: 70ae71c6-228c-4883-a57d-de6d5f873825
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ungetch, _ungetwch, _ungetch_nolock, _ungetwch_nolock
Pushes back the last character that's read from the console.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Character to be pushed.  
  
## Return Value  
 Both functions return the character <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if successful. If there is an error, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>returns<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 These functions push the character <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> back to the console, causing <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to be the next character read by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (or<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>). <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> fail if they are called more than once before the next read. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> argument may not be <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>).  
  
 The versions with the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> suffix are identical except that they are not protected from interference by other threads. They may be faster since they do not incur the overhead of locking out other threads. Use these functions only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<conio.h>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<conio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>token = White**   
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_cscanf, _cwscanf](../vs140/_cscanf--_cscanf_l--_cwscanf--_cwscanf_l.md)   
 [_getch, _getwch](../vs140/_getch--_getwch.md)