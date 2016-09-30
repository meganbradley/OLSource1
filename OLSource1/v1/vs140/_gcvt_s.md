---
title: "_gcvt_s"
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
  - "_gcvt_s"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_gcvt_s"
  - "gcvt_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_gcvt_s function"
  - "_CVTBUFSIZE"
  - "floating-point functions, converting number to string"
  - "gcvt_s function"
  - "numbers, converting to strings"
  - "conversions, floating point to strings"
  - "strings [C++], converting from floating point"
  - "CVTBUFSIZE"
ms.assetid: 0a8d8a26-5940-4ae3-835e-0aa6ec1b0744
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _gcvt_s
Converts a floating-point value to a string. This is a version of [_gcvt](../vs140/_gcvt.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Buffer to store the result of the conversion.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Size of the buffer.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Value to be converted.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of significant digits stored.  
  
## Return Value  
 Zero if successful. If a failure occurs due to an invalid parameter (see the following table for invalid values), the invalid parameter handler is invoked as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, an error code is returned. Error codes are defined in Errno.h. For a listing of these errors, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Return|Value in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|--------------|-------------------|-------------|--------------|------------|-----------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|any|any|any|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Not modified.|  
|Not <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (points to valid memory)|zero|any|any|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Not modified.|  
|Not <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> (points to valid memory)|any|any|>= <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Not modified.|  
  
 **Security Issues**  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> can generate an access violation if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> does not point to valid memory and is not <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> function converts a floating-point <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to a character string (which includes a decimal point and a possible sign byte) and stores the string in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> should be large enough to accommodate the converted value plus a terminating null character, which is appended automatically. A buffer of length <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is sufficient for any floating point value. If a buffer size of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> + 1 is used, the function will not overwrite the end of the buffer, so be sure to supply a sufficient buffer for this operation. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> attempts to produce <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> digits in decimal format. If it cannot, it produces <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> digits in exponential format. Trailing zeros can be suppressed in the conversion.  
  
 In C++, using this function is simplified by a template overload; the overload can infer buffer length automatically, eliminating the need to specify a size argument. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug version of this function first fills the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<stdlib.h>|\<error.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Converted value: 1.2**   
## .NET Framework Equivalent  
 \<xref:System.Convert.ToString*>  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)   
 [_ecvt_s](../vs140/_ecvt_s.md)   
 [_fcvt_s](../vs140/_fcvt_s.md)   
 [_gcvt](../vs140/_gcvt.md)