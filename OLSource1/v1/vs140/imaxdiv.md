---
title: "imaxdiv"
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
  - "imaxdiv"
apilocation: 
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "imaxdiv"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "imaxdiv function"
ms.assetid: 7d90126f-fdc2-4986-9cdf-94e4c9123d26
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# imaxdiv
Computes the quotient and the remainder of two integer values of any size as a single operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The numerator.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The denominator.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> called with arguments of type [intmax_t](../vs140/standard-types.md) returns a structure of type [imaxdiv_t](../vs140/standard-types.md) that comprises the quotient and the remainder.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function divides <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and thereby computes the quotient and the remainder. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure contains the quotient, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and the remainder, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The sign of the quotient is the same as that of the mathematical quotient. Its absolute value is the largest integer that is less than the absolute value of the mathematical quotient. If the denominator is 0, the program terminates with an error message.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<inttypes.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When built and then called with command line parameters of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the code generates this output:  
  
 **The call to imaxdiv(9460730470000000, 8766)**  
**results in a quotient of 1079252848505, and a remainder of 5170**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [div](../vs140/div.md)   
 [ldiv, lldiv](../vs140/ldiv--lldiv.md)