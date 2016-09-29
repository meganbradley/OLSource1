---
title: "_getch, _getwch"
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
  - "_getch"
  - "_getwch"
apilocation: 
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "getwch"
  - "_getch"
  - "_getwch"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "characters, getting from console"
  - "getch function"
  - "_getwch function"
  - "console, reading from"
  - "_getch function"
  - "getwch function"
ms.assetid: cc116be7-cff2-4274-970f-5e7b18ccc05c
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _getch, _getwch
Gets a character from the console without echo.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
int _getch( void );  
wint_t _getwch( void );  
```  
  
## Return Value  
 Returns the character read. There is no error return.  
  
## Remarks  
 The `_getch` and`_getwch` functions read a single character from the console without echoing the character. None of these functions can be used to read CTRL+C. When reading a function key or an arrow key, each function must be called twice; the first call returns 0 or 0xE0, and the second call returns the actual key code.  
  
 These functions lock the calling thread and are therefore thread-safe. For non-locking versions, see [_getch_nolock, _getwch_nolock](../vs140/_getch_nolock--_getwch_nolock.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|`_gettch`|`_getch`|`_getch`|`_getwch`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_getch`|<conio.h>|  
|`_getwch`|<conio.h> or <wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
```  
// crt_getch.c  
// compile with: /c  
// This program reads characters from  
// the keyboard until it receives a 'Y' or 'y'.  
  
#include <conio.h>  
#include <ctype.h>  
  
int main( void )  
{  
   int ch;  
  
   _cputs( "Type 'Y' when finished typing keys: " );  
   do  
   {  
      ch = _getch();  
      ch = toupper( ch );  
   } while( ch != 'Y' );  
  
   _putch( ch );  
   _putch( '\r' );    // Carriage return  
   _putch( '\n' );    // Line feed    
}  
```  
  
  **`abcdey`Type 'Y' when finished typing keys: Y**   
## NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_getche, _getwche](../vs140/_getche--_getwche.md)   
 [_cgets, _cgetws](../vs140/_cgets--_cgetws.md)   
 [getc, getwc](../vs140/getc--getwc.md)   
 [_ungetch, _ungetwch, _ungetch_nolock, _ungetwch_nolock](../vs140/_ungetch--_ungetwch--_ungetch_nolock--_ungetwch_nolock.md)