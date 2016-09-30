---
title: "_scalb"
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
  - "_scalb"
apilocation: 
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "scalb"
  - "_scalb"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "exponential calculations"
  - "_scalb function"
  - "scalb function"
ms.assetid: 148cf5a8-b405-44bf-a1f0-7487adba2421
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _scalb
Scales argument by a power of 2.  
  
## Syntax  
  
```  
double _scalb(  
   double x,  
   long exp   
);  
```  
  
#### Parameters  
 `x`  
 Double-precision, floating-point value.  
  
 `exp`  
 Long integer exponent.  
  
## Return Value  
 Returns an exponential value if successful. On overflow (depending on the sign of `x`), `_scalb` returns +/– `HUGE_VAL`; the `errno` variable is set to `ERANGE`.  
  
 For more information about this and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The `_scalb` function calculates the value of `x *` 2exp.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_scalb`|\<float.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [ldexp](../vs140/ldexp.md)