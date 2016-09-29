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
  
```  
int _getche_nolock( void );  
wint_t _getwche_nolock( void );  
```  
  
## Return Value  
 Returns the character read. There is no error return.  
  
## Remarks  
 `_getche_nolock` and `_getwche_nolock` are identical to `_getche` and `_getwche` except that they not protected from interference by other threads. They might be faster because they do not incur the overhead of locking out other threads. Use these functions only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|`_gettche_nolock`|`_getche_nolock`|`_getch_nolock`|`_getwche_nolock`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_getche_nolock`|<conio.h>|  
|`_getwche_nolock`|<conio.h> or <wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
```  
// crt_getche_nolock.c  
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
      ch = _getche_nolock();  
      ch = toupper( ch );  
   } while( ch != 'Y' );  
  
   _putch_nolock( ch );  
   _putch_nolock( '\r' );    // Carriage return  
   _putch_nolock( '\n' );    // Line feed   
}  
```  
  
  **`abcdey`Type 'Y' when finished typing keys: Y**   
## NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_cgets, _cgetws](../vs140/_cgets--_cgetws.md)   
 [getc, getwc](../vs140/getc--getwc.md)   
 [_ungetch, _ungetwch, _ungetch_nolock, _ungetwch_nolock](../vs140/_ungetch--_ungetwch--_ungetch_nolock--_ungetwch_nolock.md)