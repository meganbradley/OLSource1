---
title: "printf Width Specification"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "printf function, width specification"
  - "printf function, format specification fields"
ms.assetid: 8b4a1b1e-bf6e-414f-a1b6-a9b6f1b6ce92
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# printf Width Specification
In a format specification, the second optional field is the width specification. The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> argument is a non-negative decimal integer that controls the minimum number of characters that are output. If the number of characters in the output value is less than the specified width, blanks are added to the left or the right of the values—depending on whether the left alignment flag (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) is specified—until the minimum width is reached. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is prefixed by 0, leading zeros are added to integer or floating-point conversions until the minimum width is reached, except when conversion is to an infinity or NAN.  
  
 The width specification never causes a value to be truncated. If the number of characters in the output value is greater than the specified width, or if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is not given, all characters of the value are output, subject to the [precision](../vs140/precision-specification.md) specification.  
  
 If the width specification is an asterisk (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>), an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> argument from the argument list supplies the value. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> argument must precede the value that's being formatted in the argument list, as shown in this example:  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 A missing or small <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value in a format specification does not cause the truncation of an output value. If the result of a conversion is wider than the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> value, the field expands to contain the conversion result.  
  
## See Also  
 [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [Format Specification Fields: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md)   
 [Flag Directives](../vs140/flag-directives.md)   
 [Precision Specification](../vs140/precision-specification.md)   
 [Size Specification](../vs140/size-specification.md)   
 [printf Type Field Characters](../vs140/printf-type-field-characters.md)