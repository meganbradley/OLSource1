---
title: "_getche, _getwche"
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
  - "_getwche"
  - "_getche"
apilocation: 
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "getwche"
  - "_getche"
  - "_getwche"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "characters, getting from console"
  - "_getwche function"
  - "getche function"
  - "console, reading from"
  - "getwche function"
  - "_getche function"
ms.assetid: eac978a8-c43a-4130-938f-54f12e2a0fda
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _getche, _getwche
Gets a character from the console with echo.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the character read. There is no error return.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions read a single character from the console with echo, meaning that the character is displayed at the console. None of these functions can be used to read CTRL+C. When reading a function key or an arrow key, each function must be called twice; the first call returns 0 or 0xE0, and the second call returns the actual key code.  
  
 These functions lock the calling thread and are therefore thread-safe. For non-locking versions, see [_getche_nolock, _getwche_nolock](../vs140/_getche_nolock--_getwche_nolock.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|\<conio.h>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|\<conio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>Type 'Y' when finished typing keys: Y**   
## NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_cgets, _cgetws](../vs140/_cgets--_cgetws.md)   
 [getc, getwc](../vs140/getc--getwc.md)   
 [_ungetch, _ungetwch, _ungetch_nolock, _ungetwch_nolock](../vs140/_ungetch--_ungetwch--_ungetch_nolock--_ungetwch_nolock.md)