---
title: "imaxabs"
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
  - "imaxabs"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "imaxabs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "imaxabs function"
ms.assetid: de2566a3-1415-4e9a-91b5-7ac3a49ebf5e
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# imaxabs
Calculates the absolute value of an integer of any size.  
  
## Syntax  
  
```  
intmax_t imaxabs(  
   intmax_t n   
);  
```  
  
#### Parameters  
 *n*  
 Integer value.  
  
## Return Value  
 The `imaxabs` function returns the absolute value of the argument. There is no error return.  
  
> [!NOTE]
>  Because the range of negative integers that can be represented by using `intmax_t` is larger than the range of positive integers that can be represented, it's possible to supply an argument to `imaxabs` that can’t be converted. If the absolute value of the argument cannot be represented by the return type, the behavior of `imaxabs` is undefined.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`imaxabs`|<inttypes.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
```  
// crt_imaxabs.c  
// Build using: cl /W3 /Tc crt_imaxabs.c  
// This example calls imaxabs to compute an  
// absolute value, then displays the results.  
  
#include <stdio.h>  
#include <stdlib.h>  
#include <inttypes.h>  
  
int main(int argc, char *argv[])  
{  
   intmax_t x = LLONG_MIN + 2;  
  
   printf("The absolute value of %lld is %lld\n", x, imaxabs(x));  
}  
```  
  
 **The absolute value of -9223372036854775806 is 9223372036854775806**   
## .NET Framework Equivalent  
 [System::Math::Abs](https://msdn.microsoft.com/en-us/library/system.math.abs.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [abs, labs, llabs, _abs64](../vs140/abs--labs--llabs--_abs64.md)   
 [_cabs](../vs140/_cabs.md)   
 [fabs, fabsf, fabsl](../vs140/fabs--fabsf--fabsl.md)   
 [labs](../vs140/labs--llabs.md)