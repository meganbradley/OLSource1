---
title: "ceil, ceilf, ceill"
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
  - "ceilf"
  - "ceil"
  - "ceill"
apilocation: 
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "ntdll.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ceil"
  - "ceilf"
  - "ceill"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "calculating value ceilings"
  - "ceill function"
  - "ceil function"
  - "ceilf function"
ms.assetid: f4e5acab-5c8f-4b10-9ae2-9561e6453718
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ceil, ceilf, ceill
Calculates the ceiling of a value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Floating-point value.  
  
## Return Value  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> functions return a floating-point value that represents the smallest integer that is greater than or equal to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. There is no error return.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|none|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> has an implementation that uses Streaming SIMD Extensions 2 (SSE2). For information and restrictions about using the SSE2 implementation, see [_set_SSE2_enable](../vs140/_set_sse2_enable.md).  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. In a C program, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> always takes and returns a double.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|\<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 See the example for [floor](../vs140/floor--floorf--floorl.md).  
  
## .NET Framework Equivalent  
 [System::Math::Ceiling](https://msdn.microsoft.com/en-us/library/system.math.ceiling.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [floor, floorf, floorl](../vs140/floor--floorf--floorl.md)   
 [fmod, fmodf](../vs140/fmod--fmodf.md)   
 [round](../vs140/round--roundf--roundl.md)