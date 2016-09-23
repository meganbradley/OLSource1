---
title: "Long Double"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - c.types
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - 8-byte long double
  - 16-bit Windows
  - 80-bit precision
  - 32-bit Windows
  - long double
  - 10 byte long double
  - 8 byte long double
  - 80 bit precision
ms.assetid: bb581e20-b5c2-4079-8ee8-ac6739a37852
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Long Double
Previous 16-bit versions of Microsoft C/C++ and Microsoft Visual C++ supported the `long double`, 80-bit precision data type. In Win32 programming, however, the `long double` data type maps to the `double`, 64-bit precision data type. The Microsoft run-time library provides `long double` versions of the math functions only for backward compatibility. The `long double` function prototypes are identical to the prototypes for their `double` counterparts, except that the `long``double` data type replaces the `double` data type. The `long double` versions of these functions should not be used in new code.  
  
### Double Functions and Their Long Double Counterparts  
  
|Function|Long double<br /><br /> counterpart|Function|Long double<br /><br /> counterpart|  
|--------------|---------------------------------|--------------|---------------------------------|  
|[acos](../vs140/acos--acosf--acosl.md)|`acosl`|[frexp](../vs140/frexp.md)|`frexpl`|  
|[asin](../vs140/asin--asinf--asinl.md)|`asinl`|[_hypot](../vs140/hypot--hypotf--hypotl--_hypot--_hypotf--_hypotl.md)|`_hypotl`|  
|[atan](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)|`atanl`|[ldexp](../vs140/ldexp.md)|`ldexpl`|  
|[atan2](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)|`atan2l`|[log](../vs140/log--logf--log10--log10f.md)|`logl`|  
|[atof](../vs140/atof--_atof_l--_wtof--_wtof_l.md)|`_atold`|[log10](../vs140/log--logf--log10--log10f.md)|`log10l`|  
|[Bessel functions j0, j1, jn](../vs140/bessel-functions--_j0--_j1--_jn.md)|`j0l, j1l, jnl`|[_matherr](../vs140/_matherr.md)|`_matherrl`|  
|[Bessel functions y0, y1, yn](../Topic/Bessel%20Functions:%20_y0,%20_y1,%20_yn_deleted.md)|`y0l, y1l, ynl`|[modf](../vs140/modf--modff--modfl.md)|`modfl`|  
|[_cabs](../vs140/_cabs.md)|`_cabsl`|[pow](../vs140/pow--powf--powl.md)|`powl`|  
|[ceil](../vs140/ceil--ceilf--ceill.md)|`ceill`|[sin](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)|`sinl`|  
|[cos](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)|`cosl`|[sinh](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)|`sinhl`|  
|[cosh](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)|`coshl`|[sqrt](../vs140/sqrt--sqrtf--sqrtl.md)|`sqrtl`|  
|[exp](../vs140/exp--expf.md)|`expl`|[strtod](../vs140/strtod--_strtod_l--wcstod--_wcstod_l.md)|`_strtold`|  
|[fabs](../vs140/fabs--fabsf--fabsl.md)|`fabsl`|[tan](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)|`tanl`|  
|[floor](../vs140/floor--floorf--floorl.md)|`floorl`|[tanh](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)|`tanhl`|  
|[fmod](../vs140/fmod--fmodf.md)|`fmodl`|||  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)