---
title: "ldiv, lldiv"
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
  - "ldiv"
  - "lldiv"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ldiv"
  - "lldiv"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ldiv function"
  - "lldiv function"
  - "quotients, computing"
  - "computing remainders"
  - "remainder computing"
  - "computing quotients"
ms.assetid: 68ab5d83-27a4-479c-9d52-d055eb139eca
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ldiv, lldiv
Computes the quotient and remainder of two integers as one operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Numerator.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Denominator.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a structure of type [ldiv_t](../vs140/standard-types.md) that comprises both the quotient and the remainder. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns a structure of type [lldiv_t](../vs140/standard-types.md) that comprises both the quotient and the remainder.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> functions divide <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and thereby compute the quotient and remainder. The sign of the quotient is the same as that of the mathematical quotient. The absolute value of the quotient is the largest integer that is less than the absolute value of the mathematical quotient. If the denominator is 0, the program terminates with an error message. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are the same as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, except that the arguments of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and the members of the returned structure are all of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and the arguments of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and the members of the returned structure are of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> structures are defined in \<stdlib.h>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [div](../vs140/div.md)   
 [imaxdiv](../vs140/imaxdiv.md)