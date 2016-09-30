---
title: "Bessel Functions: _j0, _j1, _jn, _y0, _y1, _yn"
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
  - "_j0"
  - "_j1"
  - "_jn"
  - "_y0"
  - "_y1"
  - "_yn"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "c.bessel"
  - "_j0"
  - "_j1"
  - "_jn"
  - "_y0"
  - "_y1"
  - "_yn"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "Bessel functions"
  - "_j0 function"
  - "_j1 function"
  - "_jn function"
  - "_y0 function"
  - "_y1 function"
  - "_yn function"
ms.assetid: a21a8bf1-df9d-4ba0-a8c2-e7ef71921d96
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Bessel Functions: _j0, _j1, _jn, _y0, _y1, _yn
Computes the Bessel function of the first or second kind, of orders 0, 1, or n. The Bessel functions are commonly used in the mathematics of electromagnetic wave theory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Floating-point value.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Integer order of Bessel function.  
  
## Return Value  
 Each of these routines returns a Bessel function of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is negative in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> functions, the routine sets <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, prints a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> error message to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. You can modify error handling by using <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> routines return Bessel functions of the first kind: orders 0, 1, and n, respectively.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> routines return Bessel functions of the second kind: orders 0, 1, and n, respectively.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|± 0|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|&#124;x&#124;<0.0|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<cmath> (C++), \<math.h> (C, C++)|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Bessel functions for x = 2.387000:**  
 **Kind   Order  Function     Result**  
 **First  0      _j0( x )     0.009288**  
 **First  1      _j1( x )     0.522941**  
 **First  2      _jn( 2, x )  0.428870**  
 **First  3      _jn( 3, x )  0.195734**  
 **First  4      _jn( 4, x )  0.063131**  
 **Second 0      _y0( x )     0.511681**  
 **Second 1      _y1( x )     0.094374**  
 **Second 2      _yn( 2, x )  -0.432608**  
 **Second 3      _yn( 3, x )  -0.819314**  
 **Second 4      _yn( 4, x )  -1.626833**   
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [_matherr](../vs140/_matherr.md)