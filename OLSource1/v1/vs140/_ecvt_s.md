---
title: "_ecvt_s"
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
  - "_ecvt_s"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ecvt_s"
  - "_ecvt_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ecvt_s function"
  - "ecvt_s function"
  - "numbers, converting"
  - "converting double numbers"
ms.assetid: d52fb0a6-cb91-423f-80b3-952a8955d914
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ecvt_s
Converts a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> number to a string. This is a version of [_ecvt](../vs140/_ecvt.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Filled with the pointer to the string of digits, the result of the conversion.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Size of the buffer in bytes.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number to be converted.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Number of digits stored.  
  
 [out] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Stored decimal-point position.  
  
 [out] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Sign of the converted number.  
  
## Return Value  
 Zero if successful. The return value is an error code if there is a failure. Error codes are defined in Errno.h. For more information, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 In the case of an invalid parameter, as listed in the following table, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|_Value|_Count|_Dec|_Sign|Return value|Value in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|---------------|--------------------|-------------|-------------|-----------|------------|------------------|-----------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|any|any|any|any|any|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Not modified.|  
|Not <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (points to valid memory)|<=0|any|any|any|any|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Not modified.|  
|any|any|any|any|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|any|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Not modified.|  
|any|any|any|any|any|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Not modified.|  
  
 **Security Issues**  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> might generate an access violation if <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> does not point to valid memory and is not <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> function converts a floating-point number to a character string. The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> parameter is the floating-point number to be converted. This function stores up to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> digits of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> as a string and appends a null character ('\0'). If the number of digits in <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> exceeds <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, the low-order digit is rounded. If there are fewer than <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> digits, the string is padded with zeros.  
  
 Only digits are stored in the string. The position of the decimal point and the sign of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> can be obtained from <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> after the call. The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> parameter points to an integer value giving the position of the decimal point with respect to the beginning of the string. A 0 or negative integer value indicates that the decimal point lies to the left of the first digit. The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> parameter points to an integer that indicates the sign of the converted number. If the integer value is 0, the number is positive. Otherwise, the number is negative.  
  
 A buffer of length <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is sufficient for any floating-point value.  
  
 The difference between <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is in the interpretation of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> parameter. <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> interprets <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> as the total number of digits in the output string, whereas <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> interprets <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> as the number of digits after the decimal point.  
  
 In C++, using this function is simplified by a template overload; the overload can infer buffer length automatically, eliminating the need to specify a size argument. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug version of this function first fills the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
## Requirements  
  
|Function|Required header|Optional header|  
|--------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|\<stdlib.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Converted value: 12000**   
## .NET Framework Equivalent  
 \<xref:System.Convert.ToString*>  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)   
 [_ecvt](../vs140/_ecvt.md)   
 [_fcvt_s](../vs140/_fcvt_s.md)   
 [_gcvt_s](../vs140/_gcvt_s.md)