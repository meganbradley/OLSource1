---
title: "Floating-Point Support"
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
  - "c.math"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "floating-point numbers, math routines"
  - "math routines"
  - "floating-point numbers"
ms.assetid: e4fcaf69-5c8e-4854-a9bb-1f412042131e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Floating-Point Support
The Microsoft C Runtime library (CRT) provides many floating point math library functions, including all of those required by ISO C99. These functions are implemented to balance performance with correctness. Because producing the correctly rounded result may be prohibitively expensive, these functions are designed to efficiently produce a close approximation to the correctly rounded result. In most cases, the result produced is within +/-1 ulp of the correctly rounded result, though there may be cases where there is greater inaccuracy.  
  
 Many of the floating point math library functions have different implementations for different CPU architectures. For example, the 32-bit x86 CRT may have a different implementation than the 64-bit x64 CRT. In addition, some of the functions may have multiple implementations for a given CPU architecture. The most efficient implementation is selected dynamically at run-time depending on the instruction sets supported by the CPU. For example, in the 32-bit x86 CRT, some functions have both an x87 implementation and an SSE2 implementation. When running on a CPU that supports SSE2, the faster SSE2 implementation is used. When running on a CPU that does not support SSE2, the slower x87 implementation is used. Because different implementations of the math library functions may use different CPU instructions and different algorithms to produce their results, the functions may produce different results across CPUs. In most cases, the results are within +/-1 ulp of the correctly rounded result, but the actual results may vary across CPUs.  
  
 Previous 16-bit versions of Microsoft C/C++ and Microsoft Visual C++ supported the `long double` type as an 80-bit precision floating-point data type. In later versions of Visual C++, the `long double` data type is a 64-bit precision floating-point data type identical to the `double` type. The compiler treats `long double` and `double` as distinct types, but the `long double` functions are identical to their `double` counterparts. The CRT provides `long double` versions of the math functions for ISO C99 source code compatibility, but note that the binary representation may differ from other compilers.  
  
 The CRT supports these floating point functions:  
  
 [abs, _abs64](../vs140/abs--labs--llabs--_abs64.md)  
  
 [acos, acosf, acosl](../vs140/acos--acosf--acosl.md)  
  
 [acosh, acoshf, acoshl](../vs140/acosh--acoshf--acoshl.md)  
  
 [asin, asinf, asinl](../vs140/asin--asinf--asinl.md)  
  
 [asinh, asinhf, asinhl](../vs140/asinh--asinhf--asinhl.md)  
  
 [atan, atanf, atanl, atan2, atan2f, atan2l](../vs140/atan--atanf--atanl--atan2--atan2f--atan2l.md)  
  
 [atanh, atanhf, atanhl](../vs140/atanh--atanhf--atanhl.md)  
  
 [_atodbl, _atodbl_l](../vs140/_atodbl--_atodbl_l--_atoldbl--_atoldbl_l--_atoflt--_atoflt_l.md)  
  
 [atof, _atof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)  
  
 [_atoflt, _atoflt_l, _atoldbl, _atoldbl_l](../vs140/_atodbl--_atodbl_l--_atoldbl--_atoldbl_l--_atoflt--_atoflt_l.md)  
  
 [cbrt, cbrtf, cbrtl](../vs140/cbrt--cbrtf--cbrtl.md)  
  
 [ceil, ceilf, ceill](../vs140/ceil--ceilf--ceill.md)  
  
 [_chgsign, _chgsignf, _chgsignl](../vs140/_chgsign--_chgsignf--_chgsignl.md)  
  
 [_clear87, _clearfp](../vs140/_clear87--_clearfp.md)  
  
 [compl](../vs140/compl.md)  
  
 [conj, conjf, conjl](../vs140/conj--conjf--conjl.md)  
  
 [_control87, \__control87_2, _controlfp](../vs140/_control87--_controlfp--__control87_2.md)  
  
 [_controlfp_s](../vs140/_controlfp_s.md)  
  
 [copysign, copysignf, copysignl, _copysign, _copysignf, _copysignl](../vs140/copysign--copysignf--copysignl--_copysign--_copysignf--_copysignl.md)  
  
 [cos, cosf, cosl](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)  
  
 [cosh, coshf, coshl](../vs140/cos--cosf--cosl--cosh--coshf--coshl.md)  
  
 [div](../vs140/div.md)  
  
 [_ecvt](../vs140/_ecvt.md)  
  
 [ecvt](../vs140/ecvt.md)  
  
 [_ecvt_s](../vs140/_ecvt_s.md)  
  
 [erf, erff, erfl, erfc, erfcf, erfcl](../vs140/erf--erff--erfl--erfc--erfcf--erfcl.md)  
  
 [exp, expf](../vs140/exp--expf.md)  
  
 [exp2, exp2f, exp2l](../vs140/exp2--exp2f--exp2l.md)  
  
 [expm1, expm1f, expm1l](../vs140/expm1--expm1f--expm1l.md)  
  
 [fabs, fabsf](../vs140/fabs--fabsf--fabsl.md)  
  
 [_fcvt](../vs140/_fcvt.md)  
  
 [fcvt](../vs140/fcvt.md)  
  
 [_fcvt_s](../vs140/_fcvt_s.md)  
  
 [fdim, fdimf, fdiml](../vs140/fdim--fdimf--fdiml.md)  
  
 [feclearexcept](../vs140/feclearexcept.md)  
  
 [fegetenv](../vs140/fegetenv.md)  
  
 [fegetexceptflag](../vs140/fegetexceptflag.md)  
  
 [fegetround](../vs140/fegetround--fesetround.md)  
  
 [feholdexcept](../vs140/feholdexcept.md)  
  
 [feraiseexcept](../vs140/feraiseexcept.md)  
  
 [ferror](../vs140/ferror.md)  
  
 [fesetenv](../vs140/fesetenv.md)  
  
 [fesetexceptflag](../vs140/fesetexceptflag.md)  
  
 [fesetround](../vs140/fegetround--fesetround.md)  
  
 [fetestexcept](../vs140/fetestexcept.md)  
  
 [feupdateenv](../vs140/feupdateenv.md)  
  
 [_finite, _finitef](../vs140/_finite--_finitef.md)  
  
 [floor, floorf, floorl](../vs140/floor--floorf--floorl.md)  
  
 [fma, fmaf, fmal](../vs140/fma--fmaf--fmal.md)  
  
 [fmax, fmaxf, fmaxl](../vs140/fmax--fmaxf--fmaxl.md)  
  
 [fmin, fminf, fminl](../vs140/fmin--fminf--fminl.md)  
  
 [fmod, fmodf](../vs140/fmod--fmodf.md)  
  
 [_fpclass, _fpclassf](../vs140/_fpclass--_fpclassf.md)  
  
 [fpclassify](../vs140/fpclassify.md)  
  
 [_fpieee_flt](../vs140/_fpieee_flt.md)  
  
 [_fpreset](../vs140/_fpreset.md)  
  
 [frexp](../vs140/frexp.md)  
  
 [gcvt](../vs140/gcvt.md)  
  
 [_gcvt](../vs140/_gcvt.md)  
  
 [_gcvt_s](../vs140/_gcvt_s.md)  
  
 [hypot, hypotf, hypotl, _hypot, _hypotf, _hypotl](../vs140/hypot--hypotf--hypotl--_hypot--_hypotf--_hypotl.md)  
  
 [ilogb, ilogbf, ilogbl](../vs140/ilogb--ilogbf--ilogbl.md)  
  
 [imaxabs](../vs140/imaxabs.md)  
  
 [imaxdiv](../vs140/imaxdiv.md)  
  
 [isnan, _isnan, _isnanf](../vs140/isnan--_isnan--_isnanf.md)  
  
 [_j0, _j1, _jn](../vs140/bessel-functions--_j0--_j1--_jn--_y0--_y1--_yn.md)  
  
 [labs, llabs](../vs140/abs--labs--llabs--_abs64.md)  
  
 [ldexp](../vs140/ldexp.md)  
  
 [ldiv, lldiv](../vs140/ldiv--lldiv.md)  
  
 [lgamma, lgammaf, lgammal](../vs140/lgamma--lgammaf--lgammal.md)  
  
 [llrint, llrintf, llrintl](../vs140/lrint--lrintf--lrintl--llrint--llrintf--llrintl.md)  
  
 [llround, llroundf, llroundl](../vs140/lround--lroundf--lroundl--llround--llroundf--llroundl.md)  
  
 [log, logf, log10, log10f](../vs140/log--logf--log10--log10f.md)  
  
 [log1p, log1pf, log1pl](../vs140/log1p--log1pf--log1pl.md)  
  
 [log2, log2f, log2l](../vs140/log2--log2f--log2l.md)  
  
 [logb, logbf, logbl, _logb, _logbf](../vs140/logb--logbf--logbl--_logb--_logbf.md)  
  
 [lrint, lrintf, lrintl](../vs140/lrint--lrintf--lrintl--llrint--llrintf--llrintl.md)  
  
 [_lrotl, _lrotr](../vs140/_lrotl--_lrotr.md)  
  
 [lround, lroundf, lroundl](../vs140/lround--lroundf--lroundl--llround--llroundf--llroundl.md)  
  
 [_matherr](../vs140/_matherr.md)  
  
 [__max](../vs140/__max.md)  
  
 [__min](../vs140/__min.md)  
  
 [modf, modff](../vs140/modf--modff--modfl.md)  
  
 [nan, nanf, nanl](../vs140/nan--nanf--nanl.md)  
  
 [nanf](../vs140/nan--nanf--nanl.md)  
  
 [nanl](../vs140/nan--nanf--nanl.md)  
  
 [nearbyint, nearbyintf, nearbyintl](../vs140/nearbyint--nearbyintf--nearbyintl.md)  
  
 [nextafter, nextafterf, nextafterl, _nextafter, _nextafterf, nexttoward, nexttowardf, nexttowardl](../vs140/nextafter--nextafterf--nextafterl--_nextafter--_nextafterf--nexttoward--nexttowardf--nexttowardl.md)  
  
 [norm, normf, norml](../vs140/norm--normf--norml.md)  
  
 [pow, powf, powl](../vs140/pow--powf--powl.md)  
  
 [remainder, remainderf, remainderl](../vs140/remainder--remainderf--remainderl.md)  
  
 [remquo, remquof, remquol](../vs140/remquo--remquof--remquol.md)  
  
 [rint, rintf, rintl](../vs140/rint--rintf--rintl.md)  
  
 [_rotl, _rotl64, _rotr, _rotr64](../vs140/_rotl--_rotl64--_rotr--_rotr64.md)  
  
 [round, roundf, roundl](../vs140/round--roundf--roundl.md)  
  
 [_scalb](../vs140/_scalb.md)  
  
 [scalbn, scalbnf, scalbnl, scalbln, scalblnf, scalblnl](../vs140/scalbn--scalbnf--scalbnl--scalbln--scalblnf--scalblnl.md)  
  
 [_set_controlfp](../vs140/_set_controlfp.md)  
  
 [_set_SSE2_enable](../vs140/_set_sse2_enable.md)  
  
 [sin, sinf, sinl](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)  
  
 [sinh, sinhf, sinhl](../vs140/sin--sinf--sinl--sinh--sinhf--sinhl.md)  
  
 [sqrt, sqrtf, sqrtl](../vs140/sqrt--sqrtf--sqrtl.md)  
  
 [_status87, _statusfp, _statusfp2](../vs140/_status87--_statusfp--_statusfp2.md)  
  
 [strtof, _strtof_l](../vs140/strtof--_strtof_l--wcstof--_wcstof_l.md)  
  
 [strtold, _strtold_l](../vs140/strtold--_strtold_l--wcstold--_wcstold_l.md)  
  
 [tan, tanf, tanl](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)  
  
 [tanh, tanhf, tanhl](../vs140/tan--tanf--tanl--tanh--tanhf--tanhl.md)  
  
 [tgamma, tgammaf, tgammal](../vs140/tgamma--tgammaf--tgammal.md)  
  
 [trunc, truncf, truncl](../vs140/trunc--truncf--truncl.md)  
  
 [_wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)  
  
 [_y0, _y1, _yn](../vs140/bessel-functions--_j0--_j1--_jn--_y0--_y1--_yn.md)  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)