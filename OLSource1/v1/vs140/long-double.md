---
title: "Long Double"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "c.types"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "8-byte long double"
  - "16-bit Windows"
  - "80-bit precision"
  - "32-bit Windows"
  - "long double"
  - "10 byte long double"
  - "8 byte long double"
  - "80 bit precision"
ms.assetid: bb581e20-b5c2-4079-8ee8-ac6739a37852
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Long Double
Previous 16-bit versions of Microsoft C/C++ and Microsoft Visual C++ supported the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, 80-bit precision data type. In Win32 programming, however, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> data type maps to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, 64-bit precision data type. The Microsoft run-time library provides <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> versions of the math functions only for backward compatibility. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function prototypes are identical to the prototypes for their <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> counterparts, except that the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> data type replaces the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> data type. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> versions of these functions should not be used in new code.  
  
### Double Functions and Their Long Double Counterparts  
  
|Function|Long double\<br />\<br /> counterpart|Function|Long double\<br />\<br /> counterpart|  
|--------------|---------------------------------|--------------|---------------------------------|  
|[acos](../vs140/acos--acosf--acosl.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|[frexp](../vs140/frexp.md)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|[asin](../vs140/asin--asinf--asinl.md)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|[_hypot](../vs140/hypot--hypotf--hypotl--_hypot--_hypotf--_hypotl.md)|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|[atan](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|[ldexp](../vs140/ldexp.md)|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|[atan2](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|[log](../vs140/log--logf--log10--log10f.md)|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|[atof](../vs140/atof--_atof_l--_wtof--_wtof_l.md)|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|[log10](../vs140/log--logf--log10--log10f.md)|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|[Bessel functions j0, j1, jn](../vs140/bessel-functions--_j0--_j1--_jn.md)|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|[_matherr](../vs140/_matherr.md)|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|[Bessel functions y0, y1, yn](../Topic/Bessel%20Functions:%20_y0,%20_y1,%20_yn_deleted.md)|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|[modf](../vs140/modf--modff--modfl.md)|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|[_cabs](../vs140/_cabs.md)|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|[pow](../vs140/pow--powf--powl.md)|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|[ceil](../vs140/ceil--ceilf--ceill.md)|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|[sin](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|[cos](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|[sinh](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|[cosh](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|[sqrt](../vs140/sqrt--sqrtf--sqrtl.md)|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|[exp](../vs140/exp--expf.md)|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|[strtod](../vs140/strtod--_strtod_l--wcstod--_wcstod_l.md)|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|[fabs](../vs140/fabs--fabsf--fabsl.md)|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|[tan](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
|[floor](../vs140/floor--floorf--floorl.md)|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|[tanh](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
|[fmod](../vs140/fmod--fmodf.md)|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|||  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)