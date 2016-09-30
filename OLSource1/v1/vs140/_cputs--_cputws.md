---
title: "_cputs, _cputws"
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
  - "_cputws"
  - "_cputs"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "cputws"
  - "_cputs"
  - "_cputws"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "strings [C++], writing"
  - "_cputs function"
  - "_cputws function"
  - "putting strings to the console"
  - "cputs function"
  - "console, sending strings to"
  - "cputws function"
ms.assetid: ec418484-0f8d-43ec-8d8b-198a556c659e
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _cputs, _cputws
Puts a string to the console.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Output string.  
  
## Return Value  
 If successful, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns 0. If the function fails, it returns a nonzero value.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function writes the null-terminated string that's pointed to by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directly to the console. A carriage return-line feed (CR-LF) combination is not automatically appended to the string.  
  
 This function validates its parameter. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is **NULL**, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and -1 is returned.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|**_cputts**|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|\<conio.h>|\<errno.h>|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|\<conio.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_putch, _putwch](../vs140/_putch--_putwch.md)