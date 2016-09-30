---
title: "_fcvt_s"
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
  - "_fcvt_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fcvt_s"
  - "_fcvt_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "fcvt_s function"
  - "converting floating point, to strings"
  - "floating-point functions, converting number to string"
  - "_fcvt_s function"
ms.assetid: 48671197-1d29-4c2b-a5d8-d2368f5f68a1
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fcvt_s
Converts a floating-point number to a string. This is a version of [_fcvt](../vs140/_fcvt.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The supplied buffer that will hold the result of the conversion.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size of the buffer in bytes.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number to be converted.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of digits after the decimal point.  
  
 [out] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the stored decimal-point position.  
  
 [out] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to the stored sign indicator.  
  
## Return Value  
 Zero if successful. The return value is an error code if there is a failure. Error codes are defined in Errno.h. For a listing of these errors, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 In the case of an invalid parameter, as listed in the following table, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|value|count|dec|sign|Return|Value in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|--------------|-------------------|-----------|-----------|---------|----------|------------|-----------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|any|any|any|any|any|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Not modified.|  
|Not <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> (points to valid memory)|<=0|any|any|any|any|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Not modified.|  
|any|any|any|any|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|any|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Not modified.|  
|any|any|any|any|any|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Not modified.|  
  
 **Security Issues**  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> might generate an access violation if <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> does not point to valid memory and is not <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> function converts a floating-point number to a null-terminated character string. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> parameter is the floating-point number to be converted. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> stores the digits of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> as a string and appends a null character ('\0'). The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> parameter specifies the number of digits to be stored after the decimal point. Excess digits are rounded off to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> places. If there are fewer than <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> digits of precision, the string is padded with zeros.  
  
 Only digits are stored in the string. The position of the decimal point and the sign of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> can be obtained from <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> after the call. The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> parameter points to an integer value; this integer value gives the position of the decimal point with respect to the beginning of the string. A zero or negative integer value indicates that the decimal point lies to the left of the first digit. The parameter <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> points to an integer indicating the sign of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. The integer is set to 0 if <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is positive and is set to a nonzero number if <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is negative.  
  
 A buffer of length <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is sufficient for any floating point value.  
  
 The difference between <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is in the interpretation of the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> parameter. <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> interprets <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> as the total number of digits in the output string, and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> interprets c<CodeContentPlaceHolder>47\</CodeContentPlaceHolder> as the number of digits after the decimal point.  
  
 In C++, using this function is simplified by a template overload; the overload can infer buffer length automatically, eliminating the need to specify a size argument. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug version of this function first fills the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
## Requirements  
  
|Function|Required header|Optional header|  
|--------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|\<stdlib.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
 **Libraries:** All versions of the [CRT Library Features](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Converted value: 120000**   
## .NET Framework Equivalent  
 \<xref:System.Convert.ToString*>  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)   
 [_ecvt_s](../vs140/_ecvt_s.md)   
 [_gcvt_s](../vs140/_gcvt_s.md)   
 [_fcvt](../vs140/_fcvt.md)