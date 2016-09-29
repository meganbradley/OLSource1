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
  
 [abs, _abs64](../VS_csharp/abs--labs--llabs--_abs64.md)  
  
 [acos, acosf, acosl](../VS_csharp/acos--acosf--acosl.md)  
  
 [acosh, acoshf, acoshl](../VS_csharp/acosh--acoshf--acoshl.md)  
  
 [asin, asinf, asinl](../VS_csharp/asin--asinf--asinl.md)  
  
 [asinh, asinhf, asinhl](../VS_csharp/asinh--asinhf--asinhl.md)  
  
 [atan, atanf, atanl, atan2, atan2f, atan2l](../VS_csharp/atan--atanf--atanl--atan2--atan2f--atan2l.md)  
  
 [atanh, atanhf, atanhl](../VS_csharp/atanh--atanhf--atanhl.md)  
  
 [_atodbl, _atodbl_l](../VS_csharp/_atodbl--_atodbl_l--_atoldbl--_atoldbl_l--_atoflt--_atoflt_l.md)  
  
 [atof, _atof_l](../VS_csharp/atof--_atof_l--_wtof--_wtof_l.md)  
  
 [_atoflt, _atoflt_l, _atoldbl, _atoldbl_l](../VS_csharp/_atodbl--_atodbl_l--_atoldbl--_atoldbl_l--_atoflt--_atoflt_l.md)  
  
 [cbrt, cbrtf, cbrtl](../VS_csharp/cbrt--cbrtf--cbrtl.md)  
  
 [ceil, ceilf, ceill](../VS_csharp/ceil--ceilf--ceill.md)  
  
 [_chgsign, _chgsignf, _chgsignl](../VS_csharp/_chgsign--_chgsignf--_chgsignl.md)  
  
 [_clear87, _clearfp](../VS_csharp/_clear87--_clearfp.md)  
  
 [compl](../VS_csharp/compl.md)  
  
 [conj, conjf, conjl](../VS_csharp/conj--conjf--conjl.md)  
  
 [_control87, \__control87_2, _controlfp](../VS_csharp/_control87--_controlfp--__control87_2.md)  
  
 [_controlfp_s](../VS_csharp/_controlfp_s.md)  
  
 [copysign, copysignf, copysignl, _copysign, _copysignf, _copysignl](../VS_csharp/copysign--copysignf--copysignl--_copysign--_copysignf--_copysignl.md)  
  
 [cos, cosf, cosl](../VS_csharp/cos--cosf--cosl--cosh--coshf--coshl.md)  
  
 [cosh, coshf, coshl](../VS_csharp/cos--cosf--cosl--cosh--coshf--coshl.md)  
  
 [div](../VS_csharp/div.md)  
  
 [_ecvt](../VS_csharp/_ecvt.md)  
  
 [ecvt](../VS_csharp/ecvt.md)  
  
 [_ecvt_s](../VS_csharp/_ecvt_s.md)  
  
 [erf, erff, erfl, erfc, erfcf, erfcl](../VS_csharp/erf--erff--erfl--erfc--erfcf--erfcl.md)  
  
 [exp, expf](../VS_csharp/exp--expf.md)  
  
 [exp2, exp2f, exp2l](../VS_csharp/exp2--exp2f--exp2l.md)  
  
 [expm1, expm1f, expm1l](../VS_csharp/expm1--expm1f--expm1l.md)  
  
 [fabs, fabsf](../VS_csharp/fabs--fabsf--fabsl.md)  
  
 [_fcvt](../VS_csharp/_fcvt.md)  
  
 [fcvt](../VS_csharp/fcvt.md)  
  
 [_fcvt_s](../VS_csharp/_fcvt_s.md)  
  
 [fdim, fdimf, fdiml](../VS_csharp/fdim--fdimf--fdiml.md)  
  
 [feclearexcept](../VS_csharp/feclearexcept.md)  
  
 [fegetenv](../VS_csharp/fegetenv.md)  
  
 [fegetexceptflag](../VS_csharp/fegetexceptflag.md)  
  
 [fegetround](../VS_csharp/fegetround--fesetround.md)  
  
 [feholdexcept](../VS_csharp/feholdexcept.md)  
  
 [feraiseexcept](../VS_csharp/feraiseexcept.md)  
  
 [ferror](../VS_csharp/ferror.md)  
  
 [fesetenv](../VS_csharp/fesetenv.md)  
  
 [fesetexceptflag](../VS_csharp/fesetexceptflag.md)  
  
 [fesetround](../VS_csharp/fegetround--fesetround.md)  
  
 [fetestexcept](../VS_csharp/fetestexcept.md)  
  
 [feupdateenv](../VS_csharp/feupdateenv.md)  
  
 [_finite, _finitef](../VS_csharp/_finite--_finitef.md)  
  
 [floor, floorf, floorl](../VS_csharp/floor--floorf--floorl.md)  
  
 [fma, fmaf, fmal](../VS_csharp/fma--fmaf--fmal.md)  
  
 [fmax, fmaxf, fmaxl](../VS_csharp/fmax--fmaxf--fmaxl.md)  
  
 [fmin, fminf, fminl](../VS_csharp/fmin--fminf--fminl.md)  
  
 [fmod, fmodf](../VS_csharp/fmod--fmodf.md)  
  
 [_fpclass, _fpclassf](../VS_csharp/_fpclass--_fpclassf.md)  
  
 [fpclassify](../VS_csharp/fpclassify.md)  
  
 [_fpieee_flt](../VS_csharp/_fpieee_flt.md)  
  
 [_fpreset](../VS_csharp/_fpreset.md)  
  
 [frexp](../VS_csharp/frexp.md)  
  
 [gcvt](../VS_csharp/gcvt.md)  
  
 [_gcvt](../VS_csharp/_gcvt.md)  
  
 [_gcvt_s](../VS_csharp/_gcvt_s.md)  
  
 [hypot, hypotf, hypotl, _hypot, _hypotf, _hypotl](../VS_csharp/hypot--hypotf--hypotl--_hypot--_hypotf--_hypotl.md)  
  
 [ilogb, ilogbf, ilogbl](../VS_csharp/ilogb--ilogbf--ilogbl.md)  
  
 [imaxabs](../VS_csharp/imaxabs.md)  
  
 [imaxdiv](../VS_csharp/imaxdiv.md)  
  
 [isnan, _isnan, _isnanf](../VS_csharp/isnan--_isnan--_isnanf.md)  
  
 [_j0, _j1, _jn](../VS_csharp/bessel-functions--_j0--_j1--_jn--_y0--_y1--_yn.md)  
  
 [labs, llabs](../VS_csharp/abs--labs--llabs--_abs64.md)  
  
 [ldexp](../VS_csharp/ldexp.md)  
  
 [ldiv, lldiv](../VS_csharp/ldiv--lldiv.md)  
  
 [lgamma, lgammaf, lgammal](../VS_csharp/lgamma--lgammaf--lgammal.md)  
  
 [llrint, llrintf, llrintl](../VS_csharp/lrint--lrintf--lrintl--llrint--llrintf--llrintl.md)  
  
 [llround, llroundf, llroundl](../VS_csharp/lround--lroundf--lroundl--llround--llroundf--llroundl.md)  
  
 [log, logf, log10, log10f](../VS_csharp/log--logf--log10--log10f.md)  
  
 [log1p, log1pf, log1pl](../VS_csharp/log1p--log1pf--log1pl.md)  
  
 [log2, log2f, log2l](../VS_csharp/log2--log2f--log2l.md)  
  
 [logb, logbf, logbl, _logb, _logbf](../VS_csharp/logb--logbf--logbl--_logb--_logbf.md)  
  
 [lrint, lrintf, lrintl](../VS_csharp/lrint--lrintf--lrintl--llrint--llrintf--llrintl.md)  
  
 [_lrotl, _lrotr](../VS_csharp/_lrotl--_lrotr.md)  
  
 [lround, lroundf, lroundl](../VS_csharp/lround--lroundf--lroundl--llround--llroundf--llroundl.md)  
  
 [_matherr](../VS_csharp/_matherr.md)  
  
 [__max](../VS_csharp/__max.md)  
  
 [__min](../VS_csharp/__min.md)  
  
 [modf, modff](../VS_csharp/modf--modff--modfl.md)  
  
 [nan, nanf, nanl](../VS_csharp/nan--nanf--nanl.md)  
  
 [nanf](../VS_csharp/nan--nanf--nanl.md)  
  
 [nanl](../VS_csharp/nan--nanf--nanl.md)  
  
 [nearbyint, nearbyintf, nearbyintl](../VS_csharp/nearbyint--nearbyintf--nearbyintl.md)  
  
 [nextafter, nextafterf, nextafterl, _nextafter, _nextafterf, nexttoward, nexttowardf, nexttowardl](../VS_csharp/nextafter--nextafterf--nextafterl--_nextafter--_nextafterf--nexttoward--nexttowardf--nexttowardl.md)  
  
 [norm, normf, norml](../VS_csharp/norm--normf--norml.md)  
  
 [pow, powf, powl](../VS_csharp/pow--powf--powl.md)  
  
 [remainder, remainderf, remainderl](../VS_csharp/remainder--remainderf--remainderl.md)  
  
 [remquo, remquof, remquol](../VS_csharp/remquo--remquof--remquol.md)  
  
 [rint, rintf, rintl](../VS_csharp/rint--rintf--rintl.md)  
  
 [_rotl, _rotl64, _rotr, _rotr64](../VS_csharp/_rotl--_rotl64--_rotr--_rotr64.md)  
  
 [round, roundf, roundl](../VS_csharp/round--roundf--roundl.md)  
  
 [_scalb](../VS_csharp/_scalb.md)  
  
 [scalbn, scalbnf, scalbnl, scalbln, scalblnf, scalblnl](../VS_csharp/scalbn--scalbnf--scalbnl--scalbln--scalblnf--scalblnl.md)  
  
 [_set_controlfp](../VS_csharp/_set_controlfp.md)  
  
 [_set_SSE2_enable](../VS_csharp/_set_sse2_enable.md)  
  
 [sin, sinf, sinl](../VS_csharp/sin--sinf--sinl--sinh--sinhf--sinhl.md)  
  
 [sinh, sinhf, sinhl](../VS_csharp/sin--sinf--sinl--sinh--sinhf--sinhl.md)  
  
 [sqrt, sqrtf, sqrtl](../VS_csharp/sqrt--sqrtf--sqrtl.md)  
  
 [_status87, _statusfp, _statusfp2](../VS_csharp/_status87--_statusfp--_statusfp2.md)  
  
 [strtof, _strtof_l](../VS_csharp/strtof--_strtof_l--wcstof--_wcstof_l.md)  
  
 [strtold, _strtold_l](../VS_csharp/strtold--_strtold_l--wcstold--_wcstold_l.md)  
  
 [tan, tanf, tanl](../VS_csharp/tan--tanf--tanl--tanh--tanhf--tanhl.md)  
  
 [tanh, tanhf, tanhl](../VS_csharp/tan--tanf--tanl--tanh--tanhf--tanhl.md)  
  
 [tgamma, tgammaf, tgammal](../VS_csharp/tgamma--tgammaf--tgammal.md)  
  
 [trunc, truncf, truncl](../VS_csharp/trunc--truncf--truncl.md)  
  
 [_wtof, _wtof_l](../VS_csharp/atof--_atof_l--_wtof--_wtof_l.md)  
  
 [_y0, _y1, _yn](../VS_csharp/bessel-functions--_j0--_j1--_jn--_y0--_y1--_yn.md)  
  
## See Also  
 [Run-Time Routines by Category](../VS_csharp/run-time-routines-by-category.md)