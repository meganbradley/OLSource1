---
title: "fmin, fminf, fminl"
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
  - "fmin"
  - "fminf"
  - "fminl"
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
  - "fmin"
  - "fminf"
  - "fminl"
  - "math/fmin"
  - "math/fminf"
  - "math/fminl"
helpviewer_keywords: 
  - "fmin function"
  - "fminf function"
  - "fminl function"
ms.assetid: 1916dfb5-99c1-4b0d-aefb-513525c3f2ac
caps.latest.revision: 9
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# fmin, fminf, fminl
Determines the smaller of the two specified values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first value to compare.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The second value to compare.  
  
## Return Value  
 If successful, returns the smaller of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
|Input|Result|  
|-----------|------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is NaN|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is NaN|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are NaN|nan|  
  
 The function does not cause [_matherr](../vs140/_matherr.md) to be invoked, cause any floating-point exceptions, or change the value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> that take and return float and long double types. In a C program, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> always takes and returns a double.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>,                <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|C: \<math.h>\<br />\<br /> C++: \<math.h> or \<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)