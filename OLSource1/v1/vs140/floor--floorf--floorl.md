---
title: "floor, floorf, floorl"
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
  - "floorf"
  - "floorl"
  - "floor"
apilocation: 
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "floor"
  - "floorl"
  - "_floorl"
  - "floorf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "floor function"
  - "floorf function"
  - "calculating floors of values"
  - "floorl function"
ms.assetid: e9955f70-d659-414f-8050-132e13c8ff36
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# floor, floorf, floorl
Calculates the floor of a value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Floating-point value.  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions return a floating-point value that represents the largest integer that is less than or equal to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. There is no error return.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± QNAN,IND|none|_DOMAIN|  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> has an implementation that uses Streaming SIMD Extensions 2 (SSE2). For information and restrictions about using the SSE2 implementation, see [_set_SSE2_enable](../vs140/_set_sse2_enable.md).  
  
## Remarks  
 C++ allows overloading, so you can call overloads of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> always takes and returns a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|\<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The floor of 2.8 is 2.000000**  
**The floor of -2.8 is -3.000000**  
**The ceil of 2.8 is 3.000000**  
**The ceil of -2.8 is -2.000000**   
## .NET Framework Equivalent  
 [System::Math::Floor](https://msdn.microsoft.com/en-us/library/system.math.floor.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [ceil, ceilf, ceill](../vs140/ceil--ceilf--ceill.md)   
 [round](../vs140/round--roundf--roundl.md)   
 [fmod, fmodf](../vs140/fmod--fmodf.md)