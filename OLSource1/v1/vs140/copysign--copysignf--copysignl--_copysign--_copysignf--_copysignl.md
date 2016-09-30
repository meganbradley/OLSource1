---
title: "copysign, copysignf, copysignl, _copysign, _copysignf, _copysignl"
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
  - "copysignf"
  - "copysignl"
  - "_copysignl"
  - "_copysign"
  - "_copysignf"
  - "copysign"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_copysignl"
  - "copysign"
  - "copysignf"
  - "_copysign"
  - "copysignl"
  - "_copysignf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "copysignl function"
  - "_copysignl function"
  - "copysign function"
  - "_copysignf function"
  - "_copysign function"
  - "copysignf function"
ms.assetid: 009216d6-72a2-402d-aa6c-91d924b2c9e4
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copysign, copysignf, copysignl, _copysign, _copysignf, _copysignl
Returns a value that has the magnitude of one argument and the sign of another.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The floating-point value that's returned as the magnitude of the result.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The floating-point value that's returned as the sign of the result.  
  
 [Floating-Point Support Routines](../vs140/floating-point-support.md)  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions return a floating-point value that combines the magnitude of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and the sign of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. There is no error return.  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> always takes and returns a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<float.h>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<math.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [fabs, fabsf, fabsl](../vs140/fabs--fabsf--fabsl.md)   
 [_chgsign, _chgsignf, _chgsignl](../vs140/_chgsign--_chgsignf--_chgsignl.md)