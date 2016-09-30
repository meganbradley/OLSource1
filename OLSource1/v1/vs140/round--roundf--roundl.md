---
title: "round, roundf, roundl"
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
  - "round"
  - "roundl"
  - "roundf"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "roundf"
  - "roundl"
  - "round"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "roundl function"
  - "round function"
  - "roundf function"
ms.assetid: 6be90877-193c-4b80-a32b-c3eca33f9c6f
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# round, roundf, roundl
Rounds a floating-point value to the nearest integer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The floating-point value to round.  
  
## Return Value  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions return a floating-point value that represents the nearest integer to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Halfway values are rounded away from zero, regardless of the setting of the floating-point rounding mode. There is no error return.  
  
|Input|SEH Exception|Matherr Exception|  
|-----------|-------------------|-----------------------|  
|± <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|none|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> values. In a C program, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> always takes and returns a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **round(2.499999) is 2**  
**round(-2.499999) is -2**  
**roundf(2.800000) is 3**  
**roundf(-2.800000) is -3**  
**roundl(2.500000) is 3**  
**roundl(-2.500000) is -3**   
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