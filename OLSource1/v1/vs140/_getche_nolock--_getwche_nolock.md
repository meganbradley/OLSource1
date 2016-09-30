---
title: "_getche_nolock, _getwche_nolock"
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
  - "_getche_nolock"
  - "_getwche_nolock"
apilocation: 
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_getche_nolock"
  - "_gettche_nolock"
  - "_getwche_nolock"
  - "getche_nolock"
  - "getwche_nolock"
  - "gettche_nolock"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "characters, getting from console"
  - "_gettche_nolock function"
  - "getwche_nolock function"
  - "_getche_nolock function"
  - "getche_nolock function"
  - "console, reading from"
  - "_getwche_nolock function"
  - "gettche_nolock function"
ms.assetid: 9e853ad4-4d8a-4442-9ae5-da4b434f0b8c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _getche_nolock, _getwche_nolock
Gets a character from the console, with echo and without locking the thread.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the character read. There is no error return.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are identical to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> except that they not protected from interference by other threads. They might be faster because they do not incur the overhead of locking out other threads. Use these functions only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
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
 [_cgets, _cgetws](../vs140/_cgets--_cgetws.md)   
 [getc, getwc](../vs140/getc--getwc.md)   
 [_ungetch, _ungetwch, _ungetch_nolock, _ungetwch_nolock](../vs140/_ungetch--_ungetwch--_ungetch_nolock--_ungetwch_nolock.md)