---
title: "_ecvt"
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
  - "_ecvt"
apilocation: 
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ecvt"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ecvt function"
  - "numbers, converting"
  - "converting double numbers"
  - "ecvt function"
ms.assetid: a916eb05-92d1-4b5c-8563-093acdb49dc8
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ecvt
Converts a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> number to a string. A more secure version of this function is available; see [_ecvt_s](../vs140/_ecvt_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number to be converted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number of digits stored.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Stored decimal-point position.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Sign of the converted number.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns a pointer to the string of digits; NULL if an error occurred.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function converts a floating-point number to a character string. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter is the floating-point number to be converted. This function stores up to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> digits of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> as a string and appends a null character ('\0'). If the number of digits in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> exceeds <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the low-order digit is rounded. If there are fewer than <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> digits, the string is padded with zeros.  
  
 The total number of digits returned by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> will not exceed <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 Only digits are stored in the string. The position of the decimal point and the sign of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> can be obtained from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> after the call. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> parameter points to an integer value giving the position of the decimal point with respect to the beginning of the string. A 0 or negative integer value indicates that the decimal point lies to the left of the first digit. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter points to an integer that indicates the sign of the converted number. If the integer value is 0, the number is positive. Otherwise, the number is negative.  
  
 The difference between <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is in the interpretation of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> interprets <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> as the total number of digits in the output string, whereas <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> interprets <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> as the number of digits after the decimal point.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> use a single statically allocated buffer for the conversion. Each call to one of these routines destroys the result of the previous call.  
  
 This function validates its parameters. If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is NULL, or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is 0, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and NULL is returned.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **source: 3.1415926535   buffer: '3141592654'  decimal: 1  sign: 0**   
## .NET Framework Equivalent  
 [System::Convert::ToString](https://msdn.microsoft.com/en-us/library/system.convert.tostring.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)   
 [_fcvt](../vs140/_fcvt.md)   
 [_gcvt](../vs140/_gcvt.md)