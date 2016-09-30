---
title: "_outp, _outpw, _outpd"
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
  - "_outpd"
  - "_outp"
  - "_outpw"
apilocation: 
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_outpw"
  - "_outpd"
  - "_outp"
  - "outpd"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "outpw function"
  - "words"
  - "_outpd function"
  - "outpd function"
  - "outp function"
  - "ports, writing bytes at"
  - "bytes, writing to ports"
  - "words, writing to ports"
  - "double words"
  - "double words, writing to ports"
  - "_outpw function"
  - "_outp function"
ms.assetid: c200fe22-41f6-46fd-b0be-ebb805b35181
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _outp, _outpw, _outpd
Outputs, at a port, a byte (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>), a word (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>), or a double word (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
> [!IMPORTANT]
>  These functions are obsolete. Beginning in Visual Studio 2015, they are not available in the CRT.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *port*  
 Port number.  
  
 *databyte, dataword*  
 Output values.  
  
## Return Value  
 The functions return the data output. There is no error return.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> functions write a byte, a word, and a double word, respectively, to the specified output port. The *port* argument can be any unsigned integer in the range 0 – 65,535; *databyte* can be any integer in the range 0 – 255; and *dataword* can be any value in the range of an integer, an unsigned short integer, and an unsigned long integer, respectively.  
  
 Because these functions write directly to an I/O port, they cannot be used in user code in Windows NT, Windows 2000, Windows XP, and Windows Server 2003. For information about using I/O ports in these operating systems, search for "Serial Communications in Win32" at MSDN.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|\<conio.h>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|\<conio.h>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|\<conio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_inp, _inpw, _inpd](../vs140/_inp--_inpw--_inpd.md)