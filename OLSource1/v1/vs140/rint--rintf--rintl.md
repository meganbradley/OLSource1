---
title: "rint, rintf, rintl"
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
  - "rintf"
  - "rintl"
  - "rint"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "rintf"
  - "rintl"
  - "rint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rintf function"
  - "rint function"
  - "rintl function"
ms.assetid: 312ae3e6-278c-459a-9393-11b8f87d9184
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rint, rintf, rintl
Rounds a floating-point value to the nearest integer in floating-point format.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The floating-point value to round.  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions return a floating-point value that represents the nearest integer to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Halfway values are rounded according to the current setting of the floating-point rounding mode, the same as the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> functions. Unlike the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> functions, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> functions may raise the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> floating-point exception if the result differs in value from the argument. There is no error return.  
  
|Input|SEH Exception|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> Exception|  
|-----------|-------------------|--------------------------|  
|± ∞, QNAN, IND|none|none|  
|Denormals|EXCEPTION_FLT_UNDERFLOW|none|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> always takes and returns a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **rint(2.499999) is 2**  
**rint(-2.499999) is -2**  
**rintf(2.800000) is 3**  
**rintf(-2.800000) is -3**  
**rintl(2.500000) is 3**  
**rintl(-2.500000) is -3**   
## .NET Framework Equivalent  
 [System::Math::Round](https://msdn.microsoft.com/en-us/library/system.math.round.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [ceil](../vs140/ceil--ceilf--ceill.md)   
 [floor, floorf, floorl](../vs140/floor--floorf--floorl.md)   
 [fmod, fmodf](../vs140/fmod--fmodf.md)   
 [lrint, lrintf, lrintl, llrint, llrintf, llrintl](assetId:///312fd869-a9c0-4107-bb23-ab8299d04385)   
 [lround](../vs140/lround--lroundf--lroundl--llround--llroundf--llroundl.md)   
 [nearbyint, nearbyintf, nearbyintl](assetId:///15111e73-331d-41d1-81b7-3e10df894848)   
 [rint](../vs140/rint--rintf--rintl.md)