---
title: "ilogb, ilogbf, ilogbl"
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
  - "ilogb"
  - "ilogbf"
  - "ilogbl"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ilogb"
  - "ilogbf"
  - "ilogbl"
  - "math/ilogb"
  - "math/ilogbf"
  - "math/ilogbl"
helpviewer_keywords: 
  - "ilogb function"
  - "ilogbf function"
  - "ilogbl function"
ms.assetid: 9ef19d57-1caa-41d5-8233-2faad3562fcb
caps.latest.revision: 8
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# ilogb, ilogbf, ilogbl
Retrieves an integer that represents the unbiased base-2 exponent of the specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The specified value.  
  
## Return Value  
 If successful, return the base-2 exponent of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> as a signed <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value.  
  
 Otherwise, returns one of the following values, defined in \<math.h>:  
  
|Input|Result|  
|-----------|------------|  
|±0|FP_ILOGB0|  
|±inf, ±nan, indefinite|FP_ILOGBNAN|  
  
 Errors are reported as specified in [_matherr](../vs140/_matherr.md).  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that take and return float and long double types. In a C program, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> always takes and returns a double.  
  
 Calling this function is similar to calling the equivalent <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function, then casting the return value to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|C header|C++ header|  
|-------------|--------------|------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>,                <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [frexp](../vs140/frexp.md)   
 [logb, logbf, logbl, _logb, _logbf](../vs140/logb--logbf--logbl--_logb--_logbf.md)