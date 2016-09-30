---
title: "_fcvt"
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
  - "_fcvt"
apilocation: 
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_fcvt"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "converting floating point, to strings"
  - "_fcvt function"
  - "floating-point functions, converting number to string"
  - "fcvt function"
  - "floating-point functions"
ms.assetid: 74584c88-f0dd-4907-8fca-52da5df583f5
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fcvt
Converts a floating-point number to a string. A more secure version of this function is available; see [_fcvt_s](../vs140/_fcvt_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Number to be converted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number of digits after the decimal point.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the stored decimal-point position.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the stored sign indicator.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns a pointer to the string of digits, NULL on error.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function converts a floating-point number to a null-terminated character string. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter is the floating-point number to be converted. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> stores the digits of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> as a string and appends a null character ('\0'). The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter specifies the number of digits to be stored after the decimal point. Excess digits are rounded off to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> places. If there are fewer than <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> digits of precision, the string is padded with zeros.  
  
 The total number of digits returned by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> will not exceed <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 Only digits are stored in the string. The position of the decimal point and the sign of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> can be obtained from <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and sign after the call. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter points to an integer value; this integer value gives the position of the decimal point with respect to the beginning of the string. A zero or negative integer value indicates that the decimal point lies to the left of the first digit. The parameter <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> points to an integer indicating the sign of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The integer is set to 0 if <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is positive and is set to a nonzero number if <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is negative.  
  
 The difference between <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is in the interpretation of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> interprets <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> as the total number of digits in the output string, whereas <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> interprets <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> as the number of digits after the decimal point.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> use a single statically allocated buffer for the conversion. Each call to one of these routines destroys the results of the previous call.  
  
 This function validates its parameters. If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is NULL, or <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is 0, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and NULL is returned.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **source: 3.1415926535   buffer: '31415927'   decimal: 1   sign: 0**   
## .NET Framework Equivalent  
 [System::Convert::ToString](https://msdn.microsoft.com/en-us/library/system.convert.tostring.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)   
 [_ecvt](../vs140/_ecvt.md)   
 [_gcvt](../vs140/_gcvt.md)