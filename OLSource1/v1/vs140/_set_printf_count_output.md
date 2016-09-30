---
title: "_set_printf_count_output"
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
  - "_set_printf_count_output"
apilocation: 
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "set_printf_count_output"
  - "_set_printf_count_output"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "%n format"
  - "set_printf_count_output function"
  - "_set_printf_count_output function"
ms.assetid: d8259ec5-764e-42d0-9169-72172e95163b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _set_printf_count_output
Enable or disable support of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> format in [printf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)-family functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A non-zero value to enable <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> support, 0 to disable <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> support.  
  
## Property Value/Return Value  
 The state of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> support before calling this function: non-zero if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> support was enabled, 0 if it was disabled.  
  
## Remarks  
 Because of security reasons, support for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> format specifier is disabled by default in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and all its variants. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is encountered in a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> format specification, the default behavior is to invoke the invalid parameter handler as described in [Parameter Validation](../vs140/parameter-validation.md). Calling <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> with a non-zero argument will cause <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>-family functions to interpret <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> as described in [printf Type Field Characters](../vs140/printf-type-field-characters.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [_get_printf_count_output](../vs140/_get_printf_count_output.md)