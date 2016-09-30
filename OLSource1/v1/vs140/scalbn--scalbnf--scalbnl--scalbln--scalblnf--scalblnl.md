---
title: "scalbn, scalbnf, scalbnl, scalbln, scalblnf, scalblnl"
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
  - "scalblnl"
  - "scalbnl"
  - "scalbnf"
  - "scalblnf"
  - "scalbn"
  - "scalbln"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "scalblnf"
  - "scalbnl"
  - "scalblnl"
  - "scalbln"
  - "scalbn"
  - "scalbnf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scalbn function"
  - "scalbln function"
  - "scalblnl function"
  - "scalbnl function"
  - "scalbnf function"
  - "scalblnf function"
ms.assetid: df2f1543-8e39-4af4-a5cf-29307e64807d
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scalbn, scalbnf, scalbnl, scalbln, scalblnf, scalblnl
Multiplies a floating-point number by an integral power of FLT_RADIX.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Floating-point value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Integer exponent.  
  
## Return Value  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> functions return the value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> * <CodeContentPlaceHolder>7\</CodeContentPlaceHolder><sup>exp\</sup> when successful. On overflow (depending on the sign of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>), <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns +/– <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> value is set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 For more information about <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and possible error return values, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is defined in \<float.h> as the native floating-point radix; on binary systems, it has a value of 2, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is equivalent to [ldexp](../vs140/ldexp.md).  
  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> types. In a C program, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> always takes a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and an <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and returns a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> always takes a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and returns a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::Math::Pow](https://msdn.microsoft.com/en-us/library/system.math.pow.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [frexp](../vs140/frexp.md)   
 [ldexp](../vs140/ldexp.md)   
 [modf, modff, modfl](../vs140/modf--modff--modfl.md)