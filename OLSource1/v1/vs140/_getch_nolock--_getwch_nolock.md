---
title: "_getch_nolock, _getwch_nolock"
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
  - "_getwch_nolock"
  - "_getch_nolock"
apilocation: 
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_getch_nolock"
  - "getwch_nolock"
  - "getch_nolock"
  - "_getwch_nolock"
  - "_gettch_nolock"
  - "gettch_nolock"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "characters, getting from console"
  - "_getwch_nolock function"
  - "_getch_nolock function"
  - "getwch_nolock function"
  - "_gettch_nolock function"
  - "console, reading from"
  - "getch_nolock function"
  - "gettch_nolock function"
ms.assetid: 9d248546-26ca-482c-b0c6-55812a987e83
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _getch_nolock, _getwch_nolock
Gets a character from the console without echo and without locking the thread.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the character read. There is no error return.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are identical to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> except that they not protected from interference by other threads. They might be faster because they do not incur the overhead of locking out other threads. Use these functions only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<conio.h>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<conio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>Type 'Y' when finished typing keys: Y**   
## NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_getche, _getwche](../vs140/_getche--_getwche.md)   
 [_cgets, _cgetws](../vs140/_cgets--_cgetws.md)   
 [getc, getwc](../vs140/getc--getwc.md)   
 [_ungetch, _ungetwch, _ungetch_nolock, _ungetwch_nolock](../vs140/_ungetch--_ungetwch--_ungetch_nolock--_ungetwch_nolock.md)