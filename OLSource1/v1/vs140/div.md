---
title: "div"
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
  - "div"
apilocation: 
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "div"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "div function"
  - "quotients, computing"
  - "quotients"
  - "dividing integers"
  - "remainder computing"
ms.assetid: 8ae80d97-54fd-499e-b14c-e30993b58119
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# div
Computes the quotient and the remainder of two integer values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The numerator.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The denominator.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> called by using arguments of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a structure of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, which comprises the quotient and the remainder. The return value of the overload with arguments of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Both <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are defined in STDLIB.H.  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function divides <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and thereby computes the quotient and the remainder. The [div_t](../vs140/standard-types.md) structure contains the quotient, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and the remainder, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The sign of the quotient is the same as that of the mathematical quotient. Its absolute value is the largest integer that is less than the absolute value of the mathematical quotient. If the denominator is 0, the program terminates with an error message.  
  
 The overloads that take arguments of type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> are only available to C++ code. The return type [ldiv_t](../vs140/standard-types.md) contains the members <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and the return type [lldiv_t](../vs140/standard-types.md) contains the members <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, which have the same meanings as the members of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **x is 876, y is 13**  
**The quotient is 67, and the remainder is 5**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [ldiv, lldiv](../vs140/ldiv--lldiv.md)   
 [imaxdiv](../vs140/imaxdiv.md)