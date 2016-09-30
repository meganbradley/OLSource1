---
title: "Flag Directives"
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
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "c.flags"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "format specification fields for printf function"
  - "print flag directives"
  - "printf function, format specification fields"
  - "flag directives printf function"
ms.assetid: b00cbdc9-1e5c-4b30-9f56-c1ef8d383767
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Flag Directives
In a format specification, the first optional field is <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. A flag directive is a character that specifies output justification and output of signs, blanks, leading zeros, decimal points, and octal and hexadecimal prefixes. More than one flag directive may appear in a format specification, and flags can appear in any order.  
  
### Flag Characters  
  
|Flag|Meaning|Default|  
|----------|-------------|-------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Left align the result within the given field width.|Right align.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Use a sign (+ or –) to prefix the output value if it is of a signed type.|Sign appears only for negative signed values (–).|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is prefixed by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, leading zeros are added until the minimum width is reached. If both <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> appear, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is ignored. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is specified as an integer format (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) and a precision specification is also present—for example, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>—the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is ignored.|No padding.|  
|blank (' ')|Use a blank to prefix the output value if it is signed and positive. The blank is ignored if both the blank and + flags appear.|No blank appears.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|When it's used with the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> format, the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> flag uses 0, 0x, or 0X, respectively, to prefix any nonzero output value.|No blank appears.|  
||When it's used with the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> format, the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> flag forces the output value to contain a decimal point.|Decimal point appears only if digits follow it.|  
||When it's used with the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> format, the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> flag forces the output value to contain a decimal point and prevents the truncation of trailing zeros.\<br />\<br /> Ignored when used with <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.|Decimal point appears only if digits follow it. Trailing zeros are truncated.|  
  
## See Also  
 [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [Format Specification Fields: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md)   
 [Width Specification](../vs140/printf-width-specification.md)   
 [Precision Specification](../vs140/precision-specification.md)   
 [Size Specification](../vs140/size-specification.md)   
 [printf Type Field Characters](../vs140/printf-type-field-characters.md)