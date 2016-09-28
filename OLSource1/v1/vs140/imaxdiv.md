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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# imaxdiv
Computes the quotient and the remainder of two integer values of any size as a single operation.  
  
## Syntax  
  
```  
imaxdiv_t imaxdiv(   
   intmax_t numer,  
   intmax_t denom   
);   
```  
  
#### Parameters  
 `numer`  
 The numerator.  
  
 `denom`  
 The denominator.  
  
## Return Value  
 `imaxdiv` called with arguments of type [intmax_t](../vs140/standard-types.md) returns a structure of type [imaxdiv_t](../vs140/standard-types.md) that comprises the quotient and the remainder.  
  
## Remarks  
 The `imaxdiv` function divides `numer` by `denom` and thereby computes the quotient and the remainder. The `imaxdiv_t` structure contains the quotient, `intmax_t``quot`, and the remainder, `intmax_t``rem`. The sign of the quotient is the same as that of the mathematical quotient. Its absolute value is the largest integer that is less than the absolute value of the mathematical quotient. If the denominator is 0, the program terminates with an error message.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`imaxdiv`|<inttypes.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
```  
// crt_imaxdiv.c  
// Build using: cl /W3 /Tc crt_imaxdiv.c  
// This example takes two integers as command-line  
// arguments and calls imaxdiv to divide the first   
// argument by the second, then displays the results.  
  
#include <stdio.h>  
#include <stdlib.h>  
#include <inttypes.h>  
  
int main(int argc, char *argv[])  
{  
   intmax_t x,y;  
   imaxdiv_t div_result;  
  
   x = atoll(argv[1]);  
   y = atoll(argv[2]);  
  
   printf("The call to imaxdiv(%lld, %lld)\n", x, y);  
   div_result = imaxdiv(x, y);  
   printf("results in a quotient of %lld, and a remainder of %lld\n\n",  
          div_result.quot, div_result.rem);  
}  
```  
  
 When built and then called with command line parameters of `9460730470000000 8766`, the code generates this output:  
  
 **The call to imaxdiv(9460730470000000, 8766)**  
**results in a quotient of 1079252848505, and a remainder of 5170**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [div](../vs140/div.md)   
 [ldiv, lldiv](../vs140/ldiv--lldiv.md)