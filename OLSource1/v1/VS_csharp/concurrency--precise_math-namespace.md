---
title: "Concurrency::precise_math Namespace"
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
  - "amp_math/Concurrency::precise_math"
dev_langs: 
  - "C++"
ms.assetid: ba653308-dc28-4384-b2fd-6cd718a72f91
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Concurrency::precise_math Namespace
Functions in the `precise_math` namespace are C99 compliant. Both single precision and double precision versions of each function are included. For example, `acos` is the double-precision version and `acosf` is the single-precision version. These functions, including the single-precision functions, require extended double-precision support on the accelerator. You can use the [accelerator::supports_double_precision Data Member](../VS_csharp/accelerator--supports_double_precision-data-member.md) to determine if you can run these functions on a specific accelerator.  
  
## Syntax  
  
```cpp  
namespace precise_math;  
```  
  
#### Parameters  
  
## Members  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[acos Function](../VS_csharp/acos-function.md)|Overloaded. Calculates the arccosine of the argument|  
|[acosf Function](../VS_csharp/acosf-function.md)|Calculates the arccosine of the argument|  
|[acosh Function](../VS_csharp/acosh-function.md)|Overloaded. Calculates the inverse hyperbolic cosine of the argument|  
|[acoshf Function](../VS_csharp/acoshf-function.md)|Calculates the inverse hyperbolic cosine of the argument|  
|[asin Function](../VS_csharp/asin-function.md)|Overloaded. Calculates the arcsine of the argument|  
|[asinf Function](../VS_csharp/asinf-function.md)|Calculates the arcsine of the argument|  
|[asinh Function](../VS_csharp/asinh-function.md)|Overloaded. Calculates the inverse hyperbolic sine of the argument|  
|[asinhf Function](../VS_csharp/asinhf-function.md)|Calculates the inverse hyperbolic sine of the argument|  
|[atan Function](../VS_csharp/atan-function.md)|Overloaded. Calculates the arctangent of the argument|  
|[atan2 Function](../VS_csharp/atan2-function.md)|Overloaded. Calculates the arctangent of _Y/_X|  
|[atan2f Function](../VS_csharp/atan2f-function.md)|Calculates the arctangent of _Y/_X|  
|[atanf Function](../VS_csharp/atanf-function.md)|Calculates the arctangent of the argument|  
|[atanh Function](../VS_csharp/atanh-function.md)|Overloaded. Calculates the inverse hyperbolic tangent of the argument|  
|[atanhf Function](../VS_csharp/atanhf-function.md)|Calculates the inverse hyperbolic tangent of the argument|  
|[cbrt Function](../VS_csharp/cbrt-function.md)|Overloaded. Computes the real cube root of the argument|  
|[cbrtf Function](../VS_csharp/cbrtf-function.md)|Computes the real cube root of the argument|  
|[ceil Function](../VS_csharp/ceil-function.md)|Overloaded. Calculates the ceiling of the argument|  
|[ceilf Function](../VS_csharp/ceilf-function.md)|Calculates the ceiling of the argument|  
|[copysign Function](../VS_csharp/copysign-function.md)|Overloaded. Produces a value with the magnitude of _X and the sign of _Y|  
|[copysignf Function](../VS_csharp/copysignf-function.md)|Produces a value with the magnitude of _X and the sign of _Y|  
|[cos Function](../VS_csharp/cos-function.md)|Overloaded. Calculates the cosine of the argument|  
|[cosf Function](../VS_csharp/cosf-function.md)|Calculates the cosine of the argument|  
|[cosh Function](../VS_csharp/cosh-function.md)|Overloaded. Calculates the hyperbolic cosine value of the argument|  
|[coshf Function](../VS_csharp/coshf-function.md)|Calculates the hyperbolic cosine value of the argument|  
|[cospi Function](../VS_csharp/cospi-function.md)|Overloaded. Calculates the cosine value of pi * _X|  
|[cospif Function](../VS_csharp/cospif-function.md)|Calculates the cosine value of pi * _X|  
|[erf Function](../VS_csharp/erf-function.md)|Overloaded. Computes the error function of _X|  
|[erfc Function](../VS_csharp/erfc-function.md)|Overloaded. Computes the complementary error function of _X|  
|[erfcf Function](../VS_csharp/erfcf-function.md)|Computes the complementary error function of _X|  
|[erfcinv Function](../VS_csharp/erfcinv-function.md)|Overloaded. Computes the inverse complementary error function of _X|  
|[erfcinvf Function](../VS_csharp/erfcinvf-function.md)|Computes the inverse complementary error function of _X|  
|[erff Function](../VS_csharp/erff-function.md)|Computes the error function of _X|  
|[erfinv Function](../VS_csharp/erfinv-function.md)|Overloaded. Computes the inverse error function of _X|  
|[erfinvf Function](../VS_csharp/erfinvf-function.md)|Computes the inverse error function of _X|  
|[exp Function](../VS_csharp/exp-function.md)|Overloaded. Calculates the base-e exponential of the argument|  
|[exp10 Function](../VS_csharp/exp10-function.md)|Overloaded. Calculates the base-10 exponential of the argument|  
|[exp10f Function](../VS_csharp/exp10f-function.md)|Calculates the base-10 exponential of the argument|  
|[exp2 Function](../VS_csharp/exp2-function.md)|Overloaded. Calculates the base-2 exponential of the argument|  
|[exp2f Function](../VS_csharp/exp2f-function.md)|Calculates the base-2 exponential of the argument|  
|[expf Function](../VS_csharp/expf-function.md)|Calculates the base-e exponential of the argument|  
|[expm1 Function](../VS_csharp/expm1-function.md)|Overloaded. Calculates the base-e exponential of the argument, minus 1|  
|[expm1f Function](../VS_csharp/expm1f-function.md)|Calculates the base-e exponential of the argument, minus 1|  
|[fabs Function](../VS_csharp/fabs-function.md)|Overloaded. Returns the absolute value of the argument|  
|[fabsf Function](../VS_csharp/fabsf-function.md)|Returns the absolute value of the argument|  
|[fdim Function](../VS_csharp/fdim-function.md)|Overloaded. Determines the positive difference between the arguments|  
|[fdimf Function](../VS_csharp/fdimf-function.md)|Determines the positive difference between the arguments|  
|[floor Function](../VS_csharp/floor-function.md)|Overloaded. Calculates the floor of the argument|  
|[floorf Function](../VS_csharp/floorf-function.md)|Calculates the floor of the argument|  
|[fma Function](../VS_csharp/fma-function.md)|Overloaded. Compute (_X * _Y) + _Z, rounded as one ternary operation|  
|[fmaf Function](../VS_csharp/fmaf-function.md)|Compute (_X * _Y) + _Z, rounded as one ternary operation|  
|[fmax Function](../VS_csharp/fmax-function.md)|Overloaded. Determine the maximum numeric value of the arguments|  
|[fmaxf Function](../VS_csharp/fmaxf-function.md)|Determine the maximum numeric value of the arguments|  
|[fmin Function](../VS_csharp/fmin-function.md)|Overloaded. Determine the minimum numeric value of the arguments|  
|[fminf Function](../VS_csharp/fminf-function.md)|Determine the minimum numeric value of the arguments|  
|[fmod Function (C++ AMP)](../VS_csharp/fmod-function--c---amp-.md)|Overloaded. Calculates the floating-point remainder of _X/_Y|  
|[fmodf Function](../VS_csharp/fmodf-function.md)|Calculates the floating-point remainder of _X/_Y|  
|[fpclassify Function](../VS_csharp/fpclassify-function.md)|Overloaded. Classifies the argument value as NaN, infinite, normal, subnormal, zero|  
|[frexp Function](../VS_csharp/frexp-function.md)|Overloaded. Gets the mantissa and exponent of _X|  
|[frexpf Function](../VS_csharp/frexpf-function.md)|Gets the mantissa and exponent of _X|  
|[hypot Function](../VS_csharp/hypot-function.md)|Overloaded. Computes the square root of the sum of the squares of _X and _Y|  
|[hypotf Function](../VS_csharp/hypotf-function.md)|Computes the square root of the sum of the squares of _X and _Y|  
|[ilogb Function](../VS_csharp/ilogb-function.md)|Overloaded. Extract the exponent of _X as a signed int value|  
|[ilogbf Function](../VS_csharp/ilogbf-function.md)|Extract the exponent of _X as a signed int value|  
|[isfinite Function](../VS_csharp/isfinite-function.md)|Overloaded. Determines whether the argument has a finite value|  
|[isinf Function](../VS_csharp/isinf-function.md)|Overloaded. Determines whether the argument is an infinity|  
|[isnan Function](../VS_csharp/isnan-function.md)|Overloaded. Determines whether the argument is a NaN|  
|[isnormal Function](../VS_csharp/isnormal-function.md)|Overloaded. Determines whether the argument is a normal|  
|[ldexp Function](../VS_csharp/ldexp-function.md)|Overloaded. Computes a real number from the mantissa and exponent|  
|[ldexpf Function](../VS_csharp/ldexpf-function.md)|Computes a real number from the mantissa and exponent|  
|[lgamma Function](../VS_csharp/lgamma-function.md)|Overloaded. Computes the natural logarithm of the absolute value of gamma of the argument|  
|[lgammaf Function](../VS_csharp/lgammaf-function.md)|Computes the natural logarithm of the absolute value of gamma of the argument|  
|[log Function](../VS_csharp/log-function.md)|Overloaded. Calculates the base-e logarithm of the argument|  
|[log10 Function](../VS_csharp/log10-function.md)|Overloaded. Calculates the base-10 logarithm of the argument|  
|[log10f Function](../VS_csharp/log10f-function.md)|Calculates the base-10 logarithm of the argument|  
|[log1p Function](../VS_csharp/log1p-function.md)|Overloaded. Calculates the base-e logarithm of 1 plus the argument|  
|[log1pf Function](../VS_csharp/log1pf-function.md)|Calculates the base-e logarithm of 1 plus the argument|  
|[log2 Function](../VS_csharp/log2-function.md)|Overloaded. Calculates the base-2 logarithm of the argument|  
|[log2f Function](../VS_csharp/log2f-function.md)|Calculates the base-2 logarithm of the argument|  
|[logb Function](../VS_csharp/logb-function.md)|Overloaded. Extracts the exponent of _X, as a signed integer value in floating-point format|  
|[logbf Function](../VS_csharp/logbf-function.md)|Extracts the exponent of _X, as a signed integer value in floating-point format|  
|[logf Function](../VS_csharp/logf-function.md)|Calculates the base-e logarithm of the argument|  
|[modf Function](../VS_csharp/modf-function.md)|Overloaded. Splits _X into fractional and integer parts.|  
|[modff Function](../VS_csharp/modff-function.md)|Splits _X into fractional and integer parts.|  
|[nan Function](../VS_csharp/nan-function.md)|Returns a quiet NaN|  
|[nanf Function](../VS_csharp/nanf-function.md)|Returns a quiet NaN|  
|[nearbyint Function](../VS_csharp/nearbyint-function.md)|Overloaded. Rounds the argument to an integer value in floating-point format, using the current rounding direction.|  
|[nearbyintf Function](../VS_csharp/nearbyintf-function.md)|Rounds the argument to an integer value in floating-point format, using the current rounding direction.|  
|[nextafter Function](../VS_csharp/nextafter-function.md)|Overloaded. Determine the next representable value, in the type of the function, after _X in the direction of _Y|  
|[nextafterf Function](../VS_csharp/nextafterf-function.md)|Determine the next representable value, in the type of the function, after _X in the direction of _Y|  
|[phi Function](../VS_csharp/phi-function.md)|Overloaded. Returns the cumulative distribution function of the argument|  
|[phif Function](../VS_csharp/phif-function.md)|Returns the cumulative distribution function of the argument|  
|[pow Function](../VS_csharp/pow-function.md)|Overloaded. Calculates _X raised to the power of _Y|  
|[powf Function](../VS_csharp/powf-function.md)|Calculates _X raised to the power of _Y|  
|[probit Function](../VS_csharp/probit-function.md)|Overloaded. Returns the inverse cumulative distribution function of the argument|  
|[probitf Function](../VS_csharp/probitf-function.md)|Returns the inverse cumulative distribution function of the argument|  
|[rcbrt Function](../VS_csharp/rcbrt-function.md)|Overloaded. Returns the reciprocal of the cube root of the argument|  
|[rcbrtf Function](../VS_csharp/rcbrtf-function.md)|Returns the reciprocal of the cube root of the argument|  
|[remainder Function](../VS_csharp/remainder-function.md)|Overloaded. Computes the remainder: _X REM _Y|  
|[remainderf Function](../VS_csharp/remainderf-function.md)|Computes the remainder: _X REM _Y|  
|[remquo Function](../VS_csharp/remquo-function.md)|Overloaded. Computes the same remainder as _X REM _Y. Also calculates the lower 23 bits of the integral quotient _X/_Y, and gives that value the same sign as _X/_Y. It stores this signed value in the integer pointed to by _Quo.|  
|[remquof Function](../VS_csharp/remquof-function.md)|Computes the same remainder as _X REM _Y. Also calculates the lower 23 bits of the integral quotient _X/_Y, and gives that value the same sign as _X/_Y. It stores this signed value in the integer pointed to by _Quo.|  
|[round Function](../VS_csharp/round-function.md)|Overloaded. Rounds _X to the nearest integer|  
|[roundf Function](../VS_csharp/roundf-function.md)|Rounds _X to the nearest integer|  
|[rsqrt Function](../VS_csharp/rsqrt-function.md)|Overloaded. Returns the reciprocal of the square root of the argument|  
|[rsqrtf Function](../VS_csharp/rsqrtf-function.md)|Returns the reciprocal of the square root of the argument|  
|[scalb Function](../VS_csharp/scalb-function.md)|Overloaded. Multiplies _X by FLT_RADIX to the power _Y|  
|[scalbf Function](../VS_csharp/scalbf-function.md)|Multiplies _X by FLT_RADIX to the power _Y|  
|[scalbn Function](../VS_csharp/scalbn-function.md)|Overloaded. Multiplies _X by FLT_RADIX to the power _Y|  
|[scalbnf Function](../VS_csharp/scalbnf-function.md)|Multiplies _X by FLT_RADIX to the power _Y|  
|[signbit Function](../VS_csharp/signbit-function.md)|Overloaded. Determines whether the sign of _X is negative|  
|[signbitf Function](../VS_csharp/signbitf-function.md)|Determines whether the sign of _X is negative|  
|[sin Function](../VS_csharp/sin-function.md)|Overloaded. Calculates the sine value of the argument|  
|[sincos Function](../VS_csharp/sincos-function.md)|Overloaded. Calculates sine and cosine value of _X|  
|[sincosf Function](../VS_csharp/sincosf-function.md)|Calculates sine and cosine value of _X|  
|[sinf Function](../VS_csharp/sinf-function.md)|Calculates the sine value of the argument|  
|[sinh Function](../VS_csharp/sinh-function.md)|Overloaded. Calculates the hyperbolic sine value of the argument|  
|[sinhf Function](../VS_csharp/sinhf-function.md)|Calculates the hyperbolic sine value of the argument|  
|[sinpi Function](../VS_csharp/sinpi-function.md)|Overloaded. Calculates the sine value of pi * _X|  
|[sinpif Function](../VS_csharp/sinpif-function.md)|Calculates the sine value of pi * _X|  
|[sqrt Function](../VS_csharp/sqrt-function.md)|Overloaded. Calculates the squre root of the argument|  
|[sqrtf Function](../VS_csharp/sqrtf-function.md)|Calculates the squre root of the argument|  
|[tan Function](../VS_csharp/tan-function.md)|Overloaded. Calculates the tangent value of the argument|  
|[tanf Function](../VS_csharp/tanf-function.md)|Calculates the tangent value of the argument|  
|[tanh Function](../VS_csharp/tanh-function.md)|Overloaded. Calculates the hyperbolic tangent value of the argument|  
|[tanhf Function](../VS_csharp/tanhf-function.md)|Calculates the hyperbolic tangent value of the argument|  
|[tanpi Function](../VS_csharp/tanpi-function.md)|Overloaded. Calculates the tangent value of pi * _X|  
|[tanpif Function](../VS_csharp/tanpif-function.md)|Calculates the tangent value of pi * _X|  
|[tgamma Function](../VS_csharp/tgamma-function.md)|Overloaded. Computes the gamma function of _X|  
|[tgammaf Function](../VS_csharp/tgammaf-function.md)|Computes the gamma function of _X|  
|[trunc Function](../VS_csharp/trunc-function.md)|Overloaded. Truncates the argument to the integer component|  
|[truncf Function](../VS_csharp/truncf-function.md)|Truncates the argument to the integer component|  
  
## Requirements  
 **Header:** amp_math.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ AMP)](../VS_csharp/concurrency-namespace--c---amp-.md)