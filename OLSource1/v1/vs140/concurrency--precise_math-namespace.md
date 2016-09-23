---
title: "Concurrency::precise_math Namespace"
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
  - amp_math/Concurrency::precise_math
dev_langs: 
  - C++
ms.assetid: ba653308-dc28-4384-b2fd-6cd718a72f91
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Concurrency::precise_math Namespace
Functions in the `precise_math` namespace are C99 compliant. Both single precision and double precision versions of each function are included. For example, `acos` is the double-precision version and `acosf` is the single-precision version. These functions, including the single-precision functions, require extended double-precision support on the accelerator. You can use the [accelerator::supports_double_precision Data Member](../vs140/accelerator--supports_double_precision-data-member.md) to determine if you can run these functions on a specific accelerator.  
  
## Syntax  
  
```cpp  
namespace precise_math;  
```  
  
#### Parameters  
  
## Members  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[acos Function](../vs140/acos-function.md)|Overloaded. Calculates the arccosine of the argument|  
|[acosf Function](../vs140/acosf-function.md)|Calculates the arccosine of the argument|  
|[acosh Function](../vs140/acosh-function.md)|Overloaded. Calculates the inverse hyperbolic cosine of the argument|  
|[acoshf Function](../vs140/acoshf-function.md)|Calculates the inverse hyperbolic cosine of the argument|  
|[asin Function](../vs140/asin-function.md)|Overloaded. Calculates the arcsine of the argument|  
|[asinf Function](../vs140/asinf-function.md)|Calculates the arcsine of the argument|  
|[asinh Function](../vs140/asinh-function.md)|Overloaded. Calculates the inverse hyperbolic sine of the argument|  
|[asinhf Function](../vs140/asinhf-function.md)|Calculates the inverse hyperbolic sine of the argument|  
|[atan Function](../vs140/atan-function.md)|Overloaded. Calculates the arctangent of the argument|  
|[atan2 Function](../vs140/atan2-function.md)|Overloaded. Calculates the arctangent of _Y/_X|  
|[atan2f Function](../vs140/atan2f-function.md)|Calculates the arctangent of _Y/_X|  
|[atanf Function](../vs140/atanf-function.md)|Calculates the arctangent of the argument|  
|[atanh Function](../vs140/atanh-function.md)|Overloaded. Calculates the inverse hyperbolic tangent of the argument|  
|[atanhf Function](../vs140/atanhf-function.md)|Calculates the inverse hyperbolic tangent of the argument|  
|[cbrt Function](../vs140/cbrt-function.md)|Overloaded. Computes the real cube root of the argument|  
|[cbrtf Function](../vs140/cbrtf-function.md)|Computes the real cube root of the argument|  
|[ceil Function](../vs140/ceil-function.md)|Overloaded. Calculates the ceiling of the argument|  
|[ceilf Function](../vs140/ceilf-function.md)|Calculates the ceiling of the argument|  
|[copysign Function](../vs140/copysign-function.md)|Overloaded. Produces a value with the magnitude of _X and the sign of _Y|  
|[copysignf Function](../vs140/copysignf-function.md)|Produces a value with the magnitude of _X and the sign of _Y|  
|[cos Function](../vs140/cos-function.md)|Overloaded. Calculates the cosine of the argument|  
|[cosf Function](../vs140/cosf-function.md)|Calculates the cosine of the argument|  
|[cosh Function](../vs140/cosh-function.md)|Overloaded. Calculates the hyperbolic cosine value of the argument|  
|[coshf Function](../vs140/coshf-function.md)|Calculates the hyperbolic cosine value of the argument|  
|[cospi Function](../vs140/cospi-function.md)|Overloaded. Calculates the cosine value of pi * _X|  
|[cospif Function](../vs140/cospif-function.md)|Calculates the cosine value of pi * _X|  
|[erf Function](../vs140/erf-function.md)|Overloaded. Computes the error function of _X|  
|[erfc Function](../vs140/erfc-function.md)|Overloaded. Computes the complementary error function of _X|  
|[erfcf Function](../vs140/erfcf-function.md)|Computes the complementary error function of _X|  
|[erfcinv Function](../vs140/erfcinv-function.md)|Overloaded. Computes the inverse complementary error function of _X|  
|[erfcinvf Function](../vs140/erfcinvf-function.md)|Computes the inverse complementary error function of _X|  
|[erff Function](../vs140/erff-function.md)|Computes the error function of _X|  
|[erfinv Function](../vs140/erfinv-function.md)|Overloaded. Computes the inverse error function of _X|  
|[erfinvf Function](../vs140/erfinvf-function.md)|Computes the inverse error function of _X|  
|[exp Function](../vs140/exp-function.md)|Overloaded. Calculates the base-e exponential of the argument|  
|[exp10 Function](../vs140/exp10-function.md)|Overloaded. Calculates the base-10 exponential of the argument|  
|[exp10f Function](../vs140/exp10f-function.md)|Calculates the base-10 exponential of the argument|  
|[exp2 Function](../vs140/exp2-function.md)|Overloaded. Calculates the base-2 exponential of the argument|  
|[exp2f Function](../vs140/exp2f-function.md)|Calculates the base-2 exponential of the argument|  
|[expf Function](../vs140/expf-function.md)|Calculates the base-e exponential of the argument|  
|[expm1 Function](../vs140/expm1-function.md)|Overloaded. Calculates the base-e exponential of the argument, minus 1|  
|[expm1f Function](../vs140/expm1f-function.md)|Calculates the base-e exponential of the argument, minus 1|  
|[fabs Function](../vs140/fabs-function.md)|Overloaded. Returns the absolute value of the argument|  
|[fabsf Function](../vs140/fabsf-function.md)|Returns the absolute value of the argument|  
|[fdim Function](../vs140/fdim-function.md)|Overloaded. Determines the positive difference between the arguments|  
|[fdimf Function](../vs140/fdimf-function.md)|Determines the positive difference between the arguments|  
|[floor Function](../vs140/floor-function.md)|Overloaded. Calculates the floor of the argument|  
|[floorf Function](../vs140/floorf-function.md)|Calculates the floor of the argument|  
|[fma Function](../vs140/fma-function.md)|Overloaded. Compute (_X * _Y) + _Z, rounded as one ternary operation|  
|[fmaf Function](../vs140/fmaf-function.md)|Compute (_X * _Y) + _Z, rounded as one ternary operation|  
|[fmax Function](../vs140/fmax-function.md)|Overloaded. Determine the maximum numeric value of the arguments|  
|[fmaxf Function](../vs140/fmaxf-function.md)|Determine the maximum numeric value of the arguments|  
|[fmin Function](../vs140/fmin-function.md)|Overloaded. Determine the minimum numeric value of the arguments|  
|[fminf Function](../vs140/fminf-function.md)|Determine the minimum numeric value of the arguments|  
|[fmod Function (C++ AMP)](../vs140/fmod-function--c---amp-.md)|Overloaded. Calculates the floating-point remainder of _X/_Y|  
|[fmodf Function](../vs140/fmodf-function.md)|Calculates the floating-point remainder of _X/_Y|  
|[fpclassify Function](../vs140/fpclassify-function.md)|Overloaded. Classifies the argument value as NaN, infinite, normal, subnormal, zero|  
|[frexp Function](../vs140/frexp-function.md)|Overloaded. Gets the mantissa and exponent of _X|  
|[frexpf Function](../vs140/frexpf-function.md)|Gets the mantissa and exponent of _X|  
|[hypot Function](../vs140/hypot-function.md)|Overloaded. Computes the square root of the sum of the squares of _X and _Y|  
|[hypotf Function](../vs140/hypotf-function.md)|Computes the square root of the sum of the squares of _X and _Y|  
|[ilogb Function](../vs140/ilogb-function.md)|Overloaded. Extract the exponent of _X as a signed int value|  
|[ilogbf Function](../vs140/ilogbf-function.md)|Extract the exponent of _X as a signed int value|  
|[isfinite Function](../vs140/isfinite-function.md)|Overloaded. Determines whether the argument has a finite value|  
|[isinf Function](../vs140/isinf-function.md)|Overloaded. Determines whether the argument is an infinity|  
|[isnan Function](../vs140/isnan-function.md)|Overloaded. Determines whether the argument is a NaN|  
|[isnormal Function](../vs140/isnormal-function.md)|Overloaded. Determines whether the argument is a normal|  
|[ldexp Function](../vs140/ldexp-function.md)|Overloaded. Computes a real number from the mantissa and exponent|  
|[ldexpf Function](../vs140/ldexpf-function.md)|Computes a real number from the mantissa and exponent|  
|[lgamma Function](../vs140/lgamma-function.md)|Overloaded. Computes the natural logarithm of the absolute value of gamma of the argument|  
|[lgammaf Function](../vs140/lgammaf-function.md)|Computes the natural logarithm of the absolute value of gamma of the argument|  
|[log Function](../vs140/log-function.md)|Overloaded. Calculates the base-e logarithm of the argument|  
|[log10 Function](../vs140/log10-function.md)|Overloaded. Calculates the base-10 logarithm of the argument|  
|[log10f Function](../vs140/log10f-function.md)|Calculates the base-10 logarithm of the argument|  
|[log1p Function](../vs140/log1p-function.md)|Overloaded. Calculates the base-e logarithm of 1 plus the argument|  
|[log1pf Function](../vs140/log1pf-function.md)|Calculates the base-e logarithm of 1 plus the argument|  
|[log2 Function](../vs140/log2-function.md)|Overloaded. Calculates the base-2 logarithm of the argument|  
|[log2f Function](../vs140/log2f-function.md)|Calculates the base-2 logarithm of the argument|  
|[logb Function](../vs140/logb-function.md)|Overloaded. Extracts the exponent of _X, as a signed integer value in floating-point format|  
|[logbf Function](../vs140/logbf-function.md)|Extracts the exponent of _X, as a signed integer value in floating-point format|  
|[logf Function](../vs140/logf-function.md)|Calculates the base-e logarithm of the argument|  
|[modf Function](../vs140/modf-function.md)|Overloaded. Splits _X into fractional and integer parts.|  
|[modff Function](../vs140/modff-function.md)|Splits _X into fractional and integer parts.|  
|[nan Function](../vs140/nan-function.md)|Returns a quiet NaN|  
|[nanf Function](../vs140/nanf-function.md)|Returns a quiet NaN|  
|[nearbyint Function](../vs140/nearbyint-function.md)|Overloaded. Rounds the argument to an integer value in floating-point format, using the current rounding direction.|  
|[nearbyintf Function](../vs140/nearbyintf-function.md)|Rounds the argument to an integer value in floating-point format, using the current rounding direction.|  
|[nextafter Function](../vs140/nextafter-function.md)|Overloaded. Determine the next representable value, in the type of the function, after _X in the direction of _Y|  
|[nextafterf Function](../vs140/nextafterf-function.md)|Determine the next representable value, in the type of the function, after _X in the direction of _Y|  
|[phi Function](../vs140/phi-function.md)|Overloaded. Returns the cumulative distribution function of the argument|  
|[phif Function](../vs140/phif-function.md)|Returns the cumulative distribution function of the argument|  
|[pow Function](../vs140/pow-function.md)|Overloaded. Calculates _X raised to the power of _Y|  
|[powf Function](../vs140/powf-function.md)|Calculates _X raised to the power of _Y|  
|[probit Function](../vs140/probit-function.md)|Overloaded. Returns the inverse cumulative distribution function of the argument|  
|[probitf Function](../vs140/probitf-function.md)|Returns the inverse cumulative distribution function of the argument|  
|[rcbrt Function](../vs140/rcbrt-function.md)|Overloaded. Returns the reciprocal of the cube root of the argument|  
|[rcbrtf Function](../vs140/rcbrtf-function.md)|Returns the reciprocal of the cube root of the argument|  
|[remainder Function](../vs140/remainder-function.md)|Overloaded. Computes the remainder: _X REM _Y|  
|[remainderf Function](../vs140/remainderf-function.md)|Computes the remainder: _X REM _Y|  
|[remquo Function](../vs140/remquo-function.md)|Overloaded. Computes the same remainder as _X REM _Y. Also calculates the lower 23 bits of the integral quotient _X/_Y, and gives that value the same sign as _X/_Y. It stores this signed value in the integer pointed to by _Quo.|  
|[remquof Function](../vs140/remquof-function.md)|Computes the same remainder as _X REM _Y. Also calculates the lower 23 bits of the integral quotient _X/_Y, and gives that value the same sign as _X/_Y. It stores this signed value in the integer pointed to by _Quo.|  
|[round Function](../vs140/round-function.md)|Overloaded. Rounds _X to the nearest integer|  
|[roundf Function](../vs140/roundf-function.md)|Rounds _X to the nearest integer|  
|[rsqrt Function](../vs140/rsqrt-function.md)|Overloaded. Returns the reciprocal of the square root of the argument|  
|[rsqrtf Function](../vs140/rsqrtf-function.md)|Returns the reciprocal of the square root of the argument|  
|[scalb Function](../vs140/scalb-function.md)|Overloaded. Multiplies _X by FLT_RADIX to the power _Y|  
|[scalbf Function](../vs140/scalbf-function.md)|Multiplies _X by FLT_RADIX to the power _Y|  
|[scalbn Function](../vs140/scalbn-function.md)|Overloaded. Multiplies _X by FLT_RADIX to the power _Y|  
|[scalbnf Function](../vs140/scalbnf-function.md)|Multiplies _X by FLT_RADIX to the power _Y|  
|[signbit Function](../vs140/signbit-function.md)|Overloaded. Determines whether the sign of _X is negative|  
|[signbitf Function](../vs140/signbitf-function.md)|Determines whether the sign of _X is negative|  
|[sin Function](../vs140/sin-function.md)|Overloaded. Calculates the sine value of the argument|  
|[sincos Function](../vs140/sincos-function.md)|Overloaded. Calculates sine and cosine value of _X|  
|[sincosf Function](../vs140/sincosf-function.md)|Calculates sine and cosine value of _X|  
|[sinf Function](../vs140/sinf-function.md)|Calculates the sine value of the argument|  
|[sinh Function](../vs140/sinh-function.md)|Overloaded. Calculates the hyperbolic sine value of the argument|  
|[sinhf Function](../vs140/sinhf-function.md)|Calculates the hyperbolic sine value of the argument|  
|[sinpi Function](../vs140/sinpi-function.md)|Overloaded. Calculates the sine value of pi * _X|  
|[sinpif Function](../vs140/sinpif-function.md)|Calculates the sine value of pi * _X|  
|[sqrt Function](../vs140/sqrt-function.md)|Overloaded. Calculates the squre root of the argument|  
|[sqrtf Function](../vs140/sqrtf-function.md)|Calculates the squre root of the argument|  
|[tan Function](../vs140/tan-function.md)|Overloaded. Calculates the tangent value of the argument|  
|[tanf Function](../vs140/tanf-function.md)|Calculates the tangent value of the argument|  
|[tanh Function](../vs140/tanh-function.md)|Overloaded. Calculates the hyperbolic tangent value of the argument|  
|[tanhf Function](../vs140/tanhf-function.md)|Calculates the hyperbolic tangent value of the argument|  
|[tanpi Function](../vs140/tanpi-function.md)|Overloaded. Calculates the tangent value of pi * _X|  
|[tanpif Function](../vs140/tanpif-function.md)|Calculates the tangent value of pi * _X|  
|[tgamma Function](../vs140/tgamma-function.md)|Overloaded. Computes the gamma function of _X|  
|[tgammaf Function](../vs140/tgammaf-function.md)|Computes the gamma function of _X|  
|[trunc Function](../vs140/trunc-function.md)|Overloaded. Truncates the argument to the integer component|  
|[truncf Function](../vs140/truncf-function.md)|Truncates the argument to the integer component|  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ AMP)](../vs140/concurrency-namespace--c---amp-.md)