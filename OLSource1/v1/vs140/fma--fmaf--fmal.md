---
title: "fma, fmaf, fmal"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "fma"
  - "fmaf"
  - "fmal"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr400.dll"
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fma"
  - "fmaf"
  - "fmal"
  - "math/fma"
  - "math/fmaf"
  - "math/fmal"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "fma function"
  - "fmaf function"
  - "fmal function"
ms.assetid: 584a6037-da1e-4e86-9f0c-97aae86de0c0
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# fma, fmaf, fmal
Multiplies two values together,  adds a third value, and then rounds the result, without losing any precision due to intermediary rounding.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first value to multiply.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The second value to multiply.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value to add.  
  
## Return Value  
 Returns (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> ×    <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) + <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The return value is then rounded using the current rounding format.  
  
 Otherwise, may return one of the following values:  
  
|Issue|Return|  
|-----------|------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> = INFINITY, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> = 0 or\<br />\<br /> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> = 0, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> = INFINITY|NaN|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> = exact ± INFINITY, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> = INFINITY with the opposite sign|NaN|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> = NaN|NaN|  
|not (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> = 0, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>= indefinite) and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> = NaN\<br />\<br /> not (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>=indefinite, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>=0) and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> = NaN|NaN|  
|Overflow range error|±HUGE_VAL, ±HUGE_VALF, or ±HUGE_VALL|  
|Underflow range error|correct value, after rounding.|  
  
 Errors are reported as specified in [_matherr](../vs140/_matherr.md).  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> that take and return float and long double types. In a C program, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> always takes and returns a double.  
  
 This function computes the value as though it were taken to infinite precision, and then rounds the final result.  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>,                <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [remainder, remainderf, remainderl](../vs140/remainder--remainderf--remainderl.md)   
 [remquo, remquof, remquol](../vs140/remquo--remquof--remquol.md)