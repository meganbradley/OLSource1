---
title: "numeric_limits Class"
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
  - "std::numeric_limits"
  - "std.numeric_limits"
  - "numeric_limits"
  - "limits/std::numeric_limits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "numeric_limits class"
ms.assetid: 9e817177-0e91-48e6-b680-0531c4b26625
caps.latest.revision: 26
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits Class
The template class describes arithmetic properties of built-in numerical types.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The fundamental element data type whose properties are being tested or queried or set.  
  
## Remarks  
 The header defines explicit specializations for the types <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>. For these explicit specializations, the member [numeric_limits::is_specialized](#numeric_limits__is_specialized) is <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, and all relevant members have meaningful values. The program can supply additional explicit specializations. Most member functions of the class describe or test possible implementations of <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
 For an arbitrary specialization, no members have meaningful values. A member object that does not have a meaningful value stores zero (or <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>) and a member function that does not return a meaningful value returns <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
### Static Functions and Constants  
  
|||  
|-|-|  
|[denorm_min](#numeric_limits__denorm_min)|Returns the smallest nonzero denormalized value.|  
|[digits](#numeric_limits__digits)|Returns the number of radix digits that the type can represent without loss of precision.|  
|[digits10](#numeric_limits__digits10)|Returns the number of decimal digits that the type can represent without loss of precision.|  
|[epsilon](#numeric_limits__epsilon)|Returns the difference between 1 and the smallest value greater than 1 that the data type can represent.|  
|[has_denorm](#numeric_limits__has_denorm)|Tests whether a type allows denormalized values.|  
|[has_denorm_loss](#numeric_limits__has_denorm_loss)|Tests whether loss of accuracy is detected as a denormalization loss rather than as an inexact result.|  
|[has_infinity](#numeric_limits__has_infinity)|Tests whether a type has a representation for positive infinity.|  
|[has_quiet_NaN](#numeric_limits__has_quiet_nan)|Tests whether a type has a representation for a quiet not a number (NAN), which is nonsignaling.|  
|[has_signaling_NaN](#numeric_limits__has_signaling_nan)|Tests whether a type has a representation for signaling not a number (NAN).|  
|[infinity](#numeric_limits__infinity)|The representation for positive infinity for a type, if available.|  
|[is_bounded](#numeric_limits__is_bounded)|Tests if the set of values that a type may represent is finite.|  
|[is_exact](#numeric_limits__is_exact)|Tests if the calculations done on a type are free of rounding errors.|  
|[is_iec559](#numeric_limits__is_iec559)|Tests if a type conforms to IEC 559 standards.|  
|[is_integer](#numeric_limits__is_integer)|Tests if a type has an integer representation.|  
|[is_modulo](#numeric_limits__is_modulo)|Tests if a type has a modulo representation.|  
|[is_signed](#numeric_limits__is_signed)|Tests if a type has a signed representation.|  
|[is_specialized](#numeric_limits__is_specialized)|Tests if a type has an explicit specialization defined in the template class <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.|  
|[lowest](#numeric_limits__lowest)|Returns the most negative finite value.|  
|[max](#numeric_limits__max)|Returns the maximum finite value for a type.|  
|[max_digits10](#numeric_limits__max_digits10)|Returns the number of decimal digits required to ensure that two distinct values of the type have distinct decimal representations.|  
|[max_exponent](#numeric_limits__max_exponent)|Returns the maximum positive integral exponent that the floating-point type can represent as a finite value when a base of radix is raised to that power.|  
|[max_exponent10](#numeric_limits__max_exponent10)|Returns the maximum positive integral exponent that the floating-point type can represent as a finite value when a base of ten is raised to that power.|  
|[min](#numeric_limits__min)|Returns the minimum normalized value for a type.|  
|[min_exponent](#numeric_limits__min_exponent)|Returns the maximum negative integral exponent that the floating-point type can represent as a finite value when a base of radix is raised to that power.|  
|[min_exponent10](#numeric_limits__min_exponent10)|Returns the maximum negative integral exponent that the floating-point type can represent as a finite value when a base of ten is raised to that power.|  
|[quiet_NaN](#numeric_limits__quiet_nan)|Returns the representation of a quiet not a number (NAN) for the type.|  
|[radix](#numeric_limits__radix)|Returns the integral base, referred to as radix, used for the representation of a type.|  
|[round_error](#numeric_limits__round_error)|Returns the maximum rounding error for the type.|  
|[round_style](#numeric_limits__round_style)|Returns a value that describes the various methods that an implementation can choose for rounding a floating-point value to an integer value.|  
|[signaling_NaN](#numeric_limits__signaling_nan)|Returns the representation of a signaling not a number (NAN) for the type.|  
|[tinyness_before](#numeric_limits__tinyness_before)|Tests whether a type can determine that a value is too small to represent as a normalized value before rounding it.|  
|[traps](#numeric_limits__traps)|Tests whether trapping that reports on arithmetic exceptions is implemented for a type.|  
  
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
##  \<a name="numeric_limits__denorm_min">\</a>  numeric_limits::denorm_min  
 Returns the smallest nonzero denormalized value.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The smallest nonzero denormalized value.  
  
### Remarks  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> is the same as **double** for the C++ compiler.  
  
 The function returns the minimum value for the type, which is the same as [min](#numeric_limits__min) if [has_denorm](#numeric_limits__has_denorm) is not equal to **denorm_present**.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **The smallest nonzero denormalized value**  
 **for float objects is: 1.4013e-045**  
**The smallest nonzero denormalized value**  
 **for double objects is: 4.94066e-324**  
**The smallest nonzero denormalized value**  
 **for long double objects is: 4.94066e-324**  
**0**  
**0**  
**0**    
##  \<a name="numeric_limits__digits">\</a>  numeric_limits::digits  
 Returns the number of radix digits that the type can represent without loss of precision.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The number of radix digits that the type can represent without loss of precision.  
  
### Remarks  
 The member stores the number of radix digits that the type can represent without change, which is the number of bits other than any sign bit for a predefined integer type, or the number of mantissa digits for a predefined floating-point type.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **24**  
**53**  
**53**  
**31**  
**63**    
##  \<a name="numeric_limits__digits10">\</a>  numeric_limits::digits10  
 Returns the number of decimal digits that the type can represent without loss of precision.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The number of decimal digits that the type can represent without loss of precision.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **6**  
**15**  
**15**  
**9**  
**18**  
**The float is; 100000000**    
##  \<a name="numeric_limits__epsilon">\</a>  numeric_limits::epsilon  
 The function returns the difference between 1 and the smallest value greater than 1 that is representable for the data type.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The difference between 1 and the smallest value greater than 1 that is representable for the data type.  
  
### Remarks  
 The value is FLT_EPSILON for type **float**. <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> for a type is the smallest positive floating-point number                         *N* such that                         *N* + <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> +                         *N* is representable.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **The difference between 1 and the smallest value greater than 1**  
 **for float objects is: 1.19209e-007**  
**The difference between 1 and the smallest value greater than 1**  
 **for double objects is: 2.22045e-016**  
**The difference between 1 and the smallest value greater than 1**  
 **for long double objects is: 2.22045e-016**    
##  \<a name="numeric_limits__has_denorm">\</a>  numeric_limits::has_denorm  
 Tests whether a type allows denormalized values.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 An enumeration value of type **const**<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, indicating whether the type allows denormalized values.  
  
### Remarks  
 The member stores **denorm_present** for a floating-point type that has denormalized values, effectively a variable number of exponent bits.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **Whether float objects allow denormalized values: 1**  
**Whether double objects allow denormalized values: 1**  
**Whether long int objects allow denormalized values: 0**    
##  \<a name="numeric_limits__has_denorm_loss">\</a>  numeric_limits::has_denorm_loss  
 Tests whether loss of accuracy is detected as a denormalization loss rather than as an inexact result.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the loss of accuracy is detected as a denormalization loss; **false** if not.  
  
### Remarks  
 The member stores true for a type that determines whether a value has lost accuracy because it is delivered as a denormalized result (too small to represent as a normalized value) or because it is inexact (not the same as a result not subject to limitations of exponent range and precision), an option with IEC 559 floating-point representations that can affect some results.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **Whether float objects can detect denormalized loss: 1**  
**Whether double objects can detect denormalized loss: 1**  
**Whether long int objects can detect denormalized loss: 0**    
##  \<a name="numeric_limits__has_infinity">\</a>  numeric_limits::has_infinity  
 Tests whether a type has a representation for positive infinity.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the type has a representation for positive infinity; **false** if not.  
  
### Remarks  
 The member returns **true** if [is_iec559](#numeric_limits__is_iec559) is **true**.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **Whether float objects have infinity: 1**  
**Whether double objects have infinity: 1**  
**Whether long int objects have infinity: 0**    
##  \<a name="numeric_limits__has_quiet_nan">\</a>  numeric_limits::has_quiet_NaN  
 Tests whether a type has a representation for a quiet not a number (NAN), which is nonsignaling.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the **type** has a representation for a quiet NAN; **false** if not.  
  
### Remarks  
 A quiet NAN is an encoding for not a number, which does not signal its presence in an expression. The return value is **true** if [is_iec559](#numeric_limits__is_iec559) is true.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **Whether float objects have quiet_NaN: 1**  
**Whether double objects have quiet_NaN: 1**  
**Whether long int objects have quiet_NaN: 0**    
##  \<a name="numeric_limits__has_signaling_nan">\</a>  numeric_limits::has_signaling_NaN  
 Tests whether a type has a representation for signaling not a number (NAN).  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the type has a representation for a signaling NAN; **false** if not.  
  
### Remarks  
 A signaling NAN is an encoding for not a number, which signals its presence in an expression. The return value is **true**[is_iec559](#numeric_limits__is_iec559) is true.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **Whether float objects have a signaling_NaN: 1**  
**Whether double objects have a signaling_NaN: 1**  
**Whether long int objects have a signaling_NaN: 0**    
##  \<a name="numeric_limits__infinity">\</a>  numeric_limits::infinity  
 The representation of positive infinity for a type, if available.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 The representation of positive infinity for a type, if available.  
  
### Remarks  
 The return value is meaningful only if [has_infinity](#numeric_limits__has_infinity) is **true**.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **1**  
**1**  
**1**  
**0**  
**0**  
**The representation of infinity for type float is: 1.#INF**  
**The representation of infinity for type double is: 1.#INF**  
**The representation of infinity for type long double is: 1.#INF**    
##  \<a name="numeric_limits__is_bounded">\</a>  numeric_limits::is_bounded  
 Tests if the set of values that a type may represent is finite.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the type has a bounded set of representable values; **false** if not.  
  
### Remarks  
 All predefined types have a bounded set of representable values and return **true**.  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **Whether float objects have bounded set of representable values: 1**  
**Whether double objects have bounded set of representable values: 1**  
**Whether long int objects have bounded set of representable values: 1**  
**Whether unsigned char objects have bounded set of representable values: 1**    
##  \<a name="numeric_limits__is_exact">\</a>  numeric_limits::is_exact  
 Tests if the calculations done on a type are free of rounding errors.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the calculations are free of rounding errors; **false** if not.  
  
### Remarks  
 All predefined integer types have exact representations for their values and return **false**. A fixed-point or rational representation is also considered exact, but a floating-point representation is not.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **Whether float objects have calculations free of rounding errors: 0**  
**Whether double objects have calculations free of rounding errors: 0**  
**Whether long int objects have calculations free of rounding errors: 1**  
**Whether unsigned char objects have calculations free of rounding errors: 1**    
##  \<a name="numeric_limits__is_iec559">\</a>  numeric_limits::is_iec559  
 Tests if a type conforms to IEC 559 standards.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the type conforms to the IEC 559 standards; **false** if not.  
  
### Remarks  
 The IEC 559 is an international standard for representing floating-point values and is also known as IEEE 754 in the USA.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  **Whether float objects conform to iec559 standards: 1**  
**Whether double objects conform to iec559 standards: 1**  
**Whether int objects conform to iec559 standards: 0**  
**Whether unsigned char objects conform to iec559 standards: 0**    
##  \<a name="numeric_limits__is_integer">\</a>  numeric_limits::is_integer  
 Tests if a type has an integer representation.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the type has an integer representation; **false** if not.  
  
### Remarks  
 All predefined integer types have an integer representation.  
  
### Example  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  **Whether float objects have an integral representation: 0**  
**Whether double objects have an integral representation: 0**  
**Whether int objects have an integral representation: 1**  
**Whether unsigned char objects have an integral representation: 1**    
##  \<a name="numeric_limits__is_modulo">\</a>  numeric_limits::is_modulo  
 Tests if a **type** has a modulo representation.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the type has a modulo representation; **false** if not.  
  
### Remarks  
 A modulo representation is a representation where all results are reduced modulo some value. All predefined unsigned integer types have a modulo representation.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **Whether float objects have a modulo representation: 0**  
**Whether double objects have a modulo representation: 0**  
**Whether signed char objects have a modulo representation: 1**  
**Whether unsigned char objects have a modulo representation: 1**    
##  \<a name="numeric_limits__is_signed">\</a>  numeric_limits::is_signed  
 Tests if a type has a signed representation.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the type has a signed representation; **false** if not.  
  
### Remarks  
 The member stores true for a type that has a signed representation, which is the case for all predefined floating-point and signed integer types.  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  **Whether float objects have a signed representation: 1**  
**Whether double objects have a signed representation: 1**  
**Whether signed char objects have a signed representation: 1**  
**Whether unsigned char objects have a signed representation: 0**    
##  \<a name="numeric_limits__is_specialized">\</a>  numeric_limits::is_specialized  
 Tests if a type has an explicit specialization defined in the template class <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the type has an explicit specialization defined in the template class; **false** if not.  
  
### Remarks  
 All scalar types other than pointers have an explicit specialization defined for template class <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  **Whether float objects have an explicit specialization in the class: 1**  
**Whether float\* objects have an explicit specialization in the class: 0**  
**Whether int objects have an explicit specialization in the class: 1**  
**Whether int\* objects have an explicit specialization in the class: 0**    
##  \<a name="numeric_limits__lowest">\</a>  numeric_limits::lowest  
 Returns the most negative finite value.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 Returns the most negative finite value.  
  
### Remarks  
 Returns the most negative finite value for the type (which is typically <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> for integer types and <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> for floating-point types). The return value is meaningful if <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
##  \<a name="numeric_limits__max">\</a>  numeric_limits::max  
 Returns the maximum finite value for a type.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 The maximum finite value for a type.  
  
### Remarks  
 The maximum finite value is INT_MAX for type <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> and FLT_MAX for type **float**. The return value is meaningful if [is_bounded](#numeric_limits__is_bounded) is **true**.  
  
### Example  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
##  \<a name="numeric_limits__max_digits10">\</a>  numeric_limits::max_digits10  
 Returns the number of decimal digits required to make sure that two distinct values of the type have distinct decimal representations.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of decimal digits that are required to make sure that two distinct values of the type have distinct decimal representations.  
  
### Remarks  
 The member stores the number of decimal digits required to make sure that two distinct values of the type have distinct decimal representations.  
  
##  \<a name="numeric_limits__max_exponent">\</a>  numeric_limits::max_exponent  
 Returns the maximum positive integral exponent that the floating-point type can represent as a finite value when a base of radix is raised to that power.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
 The maximum integral radix-based exponent representable by the type.  
  
### Remarks  
 The member function return is meaningful only for floating-point types. The <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> is the value FLT_MAX_EXP for type **float**.  
  
### Example  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  **The maximum radix-based exponent for type float is:  128**  
**The maximum radix-based exponent for type double is:  1024**  
**The maximum radix-based exponent for type long double is:  1024**    
##  \<a name="numeric_limits__max_exponent10">\</a>  numeric_limits::max_exponent10  
 Returns the maximum positive integral exponent that the floating-point type can represent as a finite value when a base of ten is raised to that power.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Return Value  
 The maximum integral base 10 exponent representable by the type.  
  
### Remarks  
 The member function return is meaningful only for floating-point types. The <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> is the value FLT_MAX_10 for type **float**.  
  
### Example  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  **The maximum base 10 exponent for type float is:  38**  
**The maximum base 10 exponent for type double is:  308**  
**The maximum base 10 exponent for type long double is:  308**    
##  \<a name="numeric_limits__min">\</a>  numeric_limits::min  
 Returns the minimum normalized value for a type.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 The minimum normalized value for the type.  
  
### Remarks  
 The minimum normalized value is INT_MIN for type <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> and FLT_MIN for type <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>. The return value is meaningful if [is_bounded](#numeric_limits__is_bounded) is <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> or if [is_signed](#numeric_limits__is_signed) is <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  **The minimum value for type float is:  1.17549e-038**  
**The minimum value for type double is:  2.22507e-308**  
**The minimum value for type int is:  -2147483648**  
**The minimum value for type short int is:  -32768**    
##  \<a name="numeric_limits__min_exponent">\</a>  numeric_limits::min_exponent  
 Returns the maximum negative integral exponent that the floating-point type can represent as a finite value when a base of radix is raised to that power.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Return Value  
 The minimum integral radix-based exponent representable by the type.  
  
### Remarks  
 The member function is meaningful only for floating-point types. The <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> is the value FLT_MIN_EXP for type **float**.  
  
### Example  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  **The minimum radix-based exponent for type float is:  -125**  
**The minimum radix-based exponent for type double is:  -1021**  
**The minimum radix-based exponent for type long double is:  -1021**    
##  \<a name="numeric_limits__min_exponent10">\</a>  numeric_limits::min_exponent10  
 Returns the maximum negative integral exponent that the floating-point type can represent as a finite value when a base of ten is raised to that power.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Return Value  
 The minimum integral base 10 exponent representable by the type.  
  
### Remarks  
 The member function is meaningful only for floating-point types. The <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> is the value FLT_MIN_10_EXP for type **float**.  
  
### Example  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  **The minimum base 10 exponent for type float is:  -37**  
**The minimum base 10 exponent for type double is:  -307**  
**The minimum base 10 exponent for type long double is:  -307**    
##  \<a name="numeric_limits__quiet_nan">\</a>  numeric_limits::quiet_NaN  
 Returns the representation of a quiet not a number (NAN) for the type.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Return Value  
 The representation of a quiet NAN for the type.  
  
### Remarks  
 The return value is meaningful only if [has_quiet_NaN](#numeric_limits__has_quiet_nan) is **true**.  
  
### Example  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  **The quiet NaN for type float is:  1.#QNAN**  
**The quiet NaN for type int is:  0**  
**The quiet NaN for type long double is:  1.#QNAN**    
##  \<a name="numeric_limits__radix">\</a>  numeric_limits::radix  
 Returns the integral base, referred to as radix, used for the representation of a type.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Return Value  
 The integral base for the representation of the type.  
  
### Remarks  
 The base is 2 for the predefined integer types, and the base to which the exponent is raised, or FLT_RADIX, for the predefined floating-point types.  
  
### Example  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  **The base for type float is:  2**  
**The base for type int is:  2**  
**The base for type long double is:  2**    
##  \<a name="numeric_limits__round_error">\</a>  numeric_limits::round_error  
 Returns the maximum rounding error for the type.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Return Value  
 The maximum rounding error for the type.  
  
### Example  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  **The maximum rounding error for type float is:  0.5**  
**The maximum rounding error for type int is:  0**  
**The maximum rounding error for type long double is:  0.5**    
##  \<a name="numeric_limits__round_style">\</a>  numeric_limits::round_style  
 Returns a value that describes the various methods that an implementation can choose for rounding a floating-point value to an integer value.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Return Value  
 A value from the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> enumeration that describes the rounding style.  
  
### Remarks  
 The member stores a value that describes the various methods that an implementation can choose for rounding a floating-point value to an integer value.  
  
 The round style is hard coded in this implementation, so even if the program starts up with a different rounding mode, that value will not change.  
  
### Example  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  **The rounding style for a double type is: 1**  
**The rounding style for a double type is now: 1**  
**The rounding style for an int type is: 0**    
##  \<a name="numeric_limits__signaling_nan">\</a>  numeric_limits::signaling_NaN  
 Returns the representation of a signaling not a number (NAN) for the type.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Return Value  
 The representation of a signaling NAN for the type.  
  
### Remarks  
 The return value is meaningful only if [has_signaling_NaN](#numeric_limits__has_signaling_nan) is **true**.  
  
### Example  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
##  \<a name="numeric_limits__tinyness_before">\</a>  numeric_limits::tinyness_before  
 Tests whether a type can determine that a value is too small to represent as a normalized value before rounding it.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> if the type can detect tiny values before rounding; <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> if it cannot.  
  
### Remarks  
 Types that can detect tinyness were included as an option with IEC 559 floating-point representations and its implementation can affect some results.  
  
### Example  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  **Whether float types can detect tinyness before rounding: 1**  
**Whether double types can detect tinyness before rounding: 1**  
**Whether long int types can detect tinyness before rounding: 0**  
**Whether unsigned char types can detect tinyness before rounding: 0**    
##  \<a name="numeric_limits__traps">\</a>  numeric_limits::traps  
 Tests whether trapping that reports on arithmetic exceptions is implemented for a type.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Return Value  
 **true** if trapping is implemented for the type; **false** if it is not.  
  
### Example  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  **Whether float types have implemented trapping: 1**  
**Whether double types have implemented trapping: 1**  
**Whether long int types have implemented trapping: 0**  
**Whether unsigned char types have implemented trapping: 0**    
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)