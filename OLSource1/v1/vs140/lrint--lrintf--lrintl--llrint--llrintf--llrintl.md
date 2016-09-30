---
title: "lrint, lrintf, lrintl, llrint, llrintf, llrintl"
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
  - "lrint"
  - "lrintl"
  - "lrintf"
  - "llrint"
  - "llrintf"
  - "llrintl"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr400.dll"
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
  - "ucrtbase.dll"
apitype: "DLLExport"
f1_keywords: 
  - "lrint"
  - "lrintf"
  - "lrintl"
  - "llrint"
  - "llrintf"
  - "llrintl"
  - "math/lrint"
  - "math/lrintf"
  - "math/lrintl"
  - "math/llrint"
  - "math/llrintf"
  - "math/llrintl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "lrint function"
  - "lrintf function"
  - "lrintl function"
  - "llrint function"
  - "llrintf function"
  - "llrintl function"
ms.assetid: 28ccd5b3-5e6f-434f-997d-a21d51b8ce7f
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# lrint, lrintf, lrintl, llrint, llrintf, llrintl
Rounds the specified floating-point value to the nearest integral value, by using the current rounding mode and direction.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 the value to round.  
  
## Return Value  
 If successful, returns the rounded integral value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Issue|Return|  
|-----------|------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is outside the range of the return type\<br />\<br /> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> = ±∞\<br />\<br /> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> = NaN|Raises FE_INVALID and returns zero (0).|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that take float and long double types. In a C program, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> always take a double.  
  
 If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> does not represent the floating-point equivalent of an integral value, these functions raise FE_INEXACT.  
  
 **Microsoft specific**: When the result is outside the range of the return type, or when the parameter is a NaN or infinity, the return value is implementation defined. The Microsoft compiler returns a zero (0) value.  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>,                <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)