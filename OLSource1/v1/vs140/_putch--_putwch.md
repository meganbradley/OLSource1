---
title: "_putch, _putwch"
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
  - "_putwch"
  - "_putch"
apilocation: 
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_putch"
  - "putwch"
  - "_putwch"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_putch function"
  - "characters, writing"
  - "putwch function"
  - "_putwch function"
  - "putch function"
  - "console, writing characters to"
ms.assetid: 3babc7cf-e333-405d-8449-c788d61d51aa
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _putch, _putwch
Writes a character to the console.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Character to be output.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if successful. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> fails, it returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; if **_putwch** fails, it returns **WEOF**.  
  
## Remarks  
 These functions write the character <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> directly, without buffering, to the console. In Windows NT, **_putwch** writes Unicode characters using the current console locale setting.  
  
 The versions with the **_nolock** suffix are identical except that they are not protected from interference by other threads. For more information, see <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|**_puttch**|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|**_putwch**|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<conio.h>|  
|**_putwch**|\<conio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
 See the example for [_getch](../vs140/_getch--_getwch.md).  
  
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_cprintf, _cwprintf](../vs140/_cprintf--_cprintf_l--_cwprintf--_cwprintf_l.md)   
 [_getch, _getwch](../vs140/_getch--_getwch.md)