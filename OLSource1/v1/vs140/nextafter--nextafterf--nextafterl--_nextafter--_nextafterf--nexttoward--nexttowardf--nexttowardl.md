---
title: "nextafter, nextafterf, nextafterl, _nextafter, _nextafterf, nexttoward, nexttowardf, nexttowardl"
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
  - "nextafterf"
  - "_nextafterf"
  - "nextafter"
  - "nextafterl"
  - "_nextafter"
  - "nexttoward"
  - "nexttowardf"
  - "nexttowardl"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "nextafter"
  - "_nextafter"
  - "nextafterf"
  - "nextafterl"
  - "_nextafterf"
  - "math/nextafter"
  - "math/nextafterf"
  - "math/nextafterl"
  - "nexttoward"
  - "nexttowardf"
  - "nexttowardl"
  - "math/nexttoward"
  - "math/nexttowardf"
  - "math/nexttowardl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_nextafter function"
  - "nextafter function"
  - "_nextafterf function"
  - "nextafterf function"
  - "nextafterl function"
  - "nexttoward function"
  - "nexttowardf function"
  - "nexttowardl function"
ms.assetid: 9785bfb9-de53-4bd0-9637-f05fa0c1f6ab
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# nextafter, nextafterf, nextafterl, _nextafter, _nextafterf, nexttoward, nexttowardf, nexttowardl
Returns the next representable floating-point value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The floating-point value to start from.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The floating-point value to go towards.  
  
## Return Value  
 Returns the next representable floating-point value of the return type after <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the direction of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>=<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the function returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, converted to the return type, with no exception triggered. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is not equal to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and the result is a denormal or zero, the FE_UNDERFLOW and FE_INEXACT floating-point exception states are set, and the correct result is returned. If either <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a NAN, then the return value is one of the input NANs. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is finite and the result is infinite or not representable in the type, a correctly signed infinity or NAN is returned, the FE_OVERFLOW and FE_INEXACT floating-point exception states are set, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is set to ERANGE.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function families are equivalent, except for the parameter type of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are equal, the value returned is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> converted to the return type.  
  
 Because C++ allows overloading, if you include \<cmath> you can call overloads of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> that return <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> types. In a C program, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> always return <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> functions are Microsoft specific. The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> function is only available when compiling for x64.  
  
## Requirements  
  
|Routine|Required header (C)|Required header (C++)|  
|-------------|---------------------------|-------------------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<math.h>|\<math.h> or \<cmath>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|\<float.h>|\<float.h> or \<cfloat>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [isnan, _isnan, _isnanf](../vs140/isnan--_isnan--_isnanf.md)