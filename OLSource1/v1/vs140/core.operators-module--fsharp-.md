---
title: "Core.Operators Module (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Core.Operators"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators module [F#]"
ms.assetid: a5a3adf6-3957-4293-8e51-069381017af0
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.Operators Module (F#)
Basic F# Operators. This module is automatically opened in all F# code.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 For an overview of operators in F#, see [Symbol and Operator Reference (F#)](../vs140/symbol-and-operator-reference--fsharp-.md).  
  
## Modules  
  
|Module|Description|  
|------------|-----------------|  
|module [Checked](../vs140/operators.checked-module--fsharp-.md)|This module contains the basic arithmetic operations with overflow checks.|  
|module [OperatorIntrinsics](../vs140/operators.operatorintrinsics-module--fsharp-.md)|A module of compiler intrinsic functions for efficient implementations of F# integer ranges and dynamic invocations of other F# operators|  
|module [Unchecked](../vs140/operators.unchecked-module--fsharp-.md)|This module contains basic operations which do not apply runtime and/or static checks|  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[( ! )](../vs140/operators.--!----t--function--fsharp-.md)  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Dereference a mutable reference cell.|  
|[( % )](../vs140/operators.-----^t1-^t2-^t3--function--fsharp-.md)  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Overloaded modulo operator.|  
|[( &&& )](../vs140/operators.--------^t--function--fsharp-.md)  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Overloaded bitwise AND operator.|  
|[( * )](../vs140/operators.------^t1-^t2-^t3--function--fsharp-.md)  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Overloaded multiplication operator.|  
|[( ** )](../vs140/operators.-------^t-^u--function--fsharp-.md)  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Overloaded exponentiation operator.|  
|[( + )](../vs140/operators.------^t1-^t2-^t3--function--fsharp-.md)  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Overloaded addition operator.|  
|[( - )](../vs140/operators.------^t1-^t2-^t3--function--fsharp-1.md)  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Overloaded subtraction operator.|  
|[( .. )](../vs140/operators.--..---^t--function--fsharp-.md)  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The standard overloaded range operator, e.g. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for lists, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> for sequences.|  
|[( .. .. )](../vs140/operators.--..-..---^t-^step--function--fsharp-.md)  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The standard overloaded skip range operator, e.g. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for lists, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for sequences.|  
|[( / )](../vs140/operators.------^t1-^t2-^t3--function--fsharp-2.md)  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Overloaded division operator.|  
|[( := )](../vs140/operators.---=----t--function--fsharp-.md)  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Assigns to a mutable reference cell.|  
|[( < )](../vs140/operators.-------t--function--fsharp-.md)  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Structural less-than comparison.|  
|[( << )](../vs140/operators.--------t2--t3--t1--function--fsharp-.md)  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Composes two functions, the function on the right being applied first.|  
|[( <<< )](../vs140/operators.--------^t--function--fsharp-.md)  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Overloaded byte-shift left operator by a specified number of bits.|  
|[( <= )](../vs140/operators.---=----t--function--fsharp-.md)  <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Structural less-than-or-equal comparison.|  
|[( <> )](../vs140/operators.--------t--function--fsharp-.md)  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Structural inequality.|  
|[( <&#124; )](../vs140/operators.--------t--u--function--fsharp-.md)  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Apply a function to a value, the value being on the right, the function on the left.|  
|[( <&#124;&#124; )](../vs140/operators.---------t1--t2--u--function--fsharp-.md)  <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Apply a function to two values, the values being a pair on the right, the function on the left.|  
|[( <&#124;&#124;&#124; )](../vs140/operators.----------t1--t2--t3--u--function--fsharp-.md)  <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Apply a function to three values, the values being a triple on the right, the function on the left.|  
|[( = )](../vs140/operators.--=----t--function--fsharp-.md)  <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Structural equality.|  
|[( > )](../vs140/operators.-------t--function--fsharp-.md)  <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Structural greater-than.|  
|[( >= )](../vs140/operators.---=----t--function--fsharp-.md)  <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Structural greater-than-or-equal.|  
|[( >> )](../vs140/operators.--------t1--t2--t3--function--fsharp-.md)  <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Compose two functions, the function on the left being applied first.|  
|[( >>> )](../vs140/operators.--------^t--function--fsharp-.md)  <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Overloaded byte-shift right operator by a specified number of bits.|  
|[( @ )](../vs140/operators.--@----t--function--fsharp-.md)  <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Concatenates two lists.|  
|[( ^ )](../vs140/operators.--^---function--fsharp-.md)  <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Concatenates two strings. The operator '+' may also be used.|  
|[( ^^^ )](../vs140/operators.--^^^---^t--function--fsharp-.md)  <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Overloaded bitwise XOR operator.|  
|[( &#124;> )](../vs140/operators.--------t1--u--function--fsharp-.md)  <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Apply a function to a value, the value being on the left, the function on the right.|  
|[( &#124;&#124;> )](../vs140/operators.---------t1--t2--u--function--fsharp-.md)  <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Apply a function to two values, the values being a pair on the left, the function on the right.|  
|[( &#124;&#124;&#124; )](../vs140/operators.--------^t--function--fsharp-.md)  <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Overloaded bitwise OR operator|  
|[( &#124;&#124;&#124;> )](../vs140/operators.----------t1--t2--t3--u--function--fsharp-.md)  <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Apply a function to three values, the values being a triple on the left, the function on the right.|  
|[( ~+ )](../vs140/operators.--~----^t--function--fsharp-.md)  <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Overloaded prefix plus operator.|  
|[( ~- )](../vs140/operators.--~----^t--function--fsharp-.md)  <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Overloaded unary negation.|  
|[( ~~~ )](../vs140/operators.--~~~---^t--function--fsharp-.md)  <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Overloaded bitwise NOT operator.|  
|[abs](../vs140/operators.abs-^t--function--fsharp-.md)  <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Absolute value of the given number.|  
|[acos](../vs140/operators.acos-^t--function--fsharp-.md)  <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Inverse cosine of the given number.|  
|[asin](../vs140/operators.asin-^t--function--fsharp-.md)  <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Inverse sine of the given number.|  
|[atan](../vs140/operators.atan-^t--function--fsharp-.md)  <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Inverse tangent of the given number.|  
|[atan2](../vs140/operators.atan2-^t1--t2--function--fsharp-.md)  <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|Inverse tangent of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> are specified separately.|  
|[box](../vs140/operators.box--t--function--fsharp-.md)  <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Boxes a strongly typed value.|  
|[byte](../vs140/operators.byte-^t--function--fsharp-.md)  <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Converts the argument to byte. This is a direct conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.Byte.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[ceil](../vs140/operators.ceil-^t--function--fsharp-.md)  <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Ceiling of the given number.|  
|[char](../vs140/operators.char-^t--function--fsharp-.md)  <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Converts the argument to character. Numeric inputs are converted according to the UTF-16 encoding for characters. String inputs must be exactly one character long. For other input types the operation requires an appropriate static conversion method on the input type.|  
|[compare](../vs140/operators.compare--t--function--fsharp-.md)  <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Generic comparison.|  
|[cos](../vs140/operators.cos-^t--function--fsharp-.md)  <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Cosine of the given number.|  
|[cosh](../vs140/operators.cosh-^t--function--fsharp-.md)  <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|Hyperbolic cosine of the given number.|  
|[decimal](../vs140/operators.decimal-^t--function--fsharp-.md)  <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|Converts the argument to \<xref:System.Decimal*> using a direct conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.UInt64.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[decr](../vs140/operators.decr-function--fsharp-.md)  <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|Decrement a mutable reference cell containing an integer.|  
|[defaultArg](../vs140/operators.defaultarg--t--function--fsharp-.md)  <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|Used to specify a default value for an optional argument in the implementation of a function.|  
|[enum](../vs140/operators.enum-^u--function--fsharp-.md)  <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Converts the argument to a particular <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> type.|  
|[exit](../vs140/operators.exit--t--function--fsharp-.md)  <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|Exit the current hardware isolated process, if security settings permit, otherwise raise an exception. Calls \<xref:System.Environment.Exit*>.|  
|[exp](../vs140/operators.exp-^t--function--fsharp-.md)  <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|Exponential of the given number.|  
|[Failure](../vs140/operators.failure-function--fsharp-.md)  <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|Builds a \<xref:System.Exception*> object.|  
|[failwith](../vs140/operators.failwith--t--function--fsharp-.md)  <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|Throw a \<xref:System.Exception*> exception.|  
|[float](../vs140/operators.float-^t--function--fsharp-.md)  <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Converts the argument to 64-bit float. This is a direct conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.Double.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[float32](../vs140/operators.float32-^t--function--fsharp-.md)  <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|Converts the argument to 32-bit float. This is a direct conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.Single.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[floor](../vs140/operators.floor-^t--function--fsharp-.md)  <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|Floor of the given number.|  
|[fst](../vs140/operators.fst--t1--t2--function--fsharp-.md)  <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Return the first element of a tuple, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.|  
|[hash](../vs140/operators.hash--t--function--fsharp-.md)  <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|A generic hash function, designed to return equal hash values for items that are equal according to the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> operator. By default it will use structural hashing for F# union, record and tuple types, hashing the complete contents of the type. The exact behavior of the function can be adjusted on a type-by-type basis by implementing \<xref:System.Object.GetHashCode*> for each type.|  
|[id](../vs140/operators.id--t--function--fsharp-.md)  <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|The identity function.|  
|[ignore](../vs140/operators.ignore--t--function--fsharp-.md)  <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|Ignore the passed value. This is often used to throw away results of a computation.|  
|[incr](../vs140/operators.incr-function--fsharp-.md)  <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|Increment a mutable reference cell containing an integer.|  
|[infinity](../vs140/operators.infinity-function--fsharp-.md)  <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|Equivalent to \<xref:System.Double.PositiveInfinity*><CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|  
|[infinityf](../vs140/operators.infinityf-function--fsharp-.md)  <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|Equivalent to \<xref:System.Single.PositiveInfinity*><CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|  
|[int](../vs140/operators.int-^t--function--fsharp-.md)  <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|Converts the argument to signed 32-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.Int32.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int16](../vs140/operators.int16-^t--function--fsharp-.md)  <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|Converts the argument to signed 16-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.Int16.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int32](../vs140/operators.int32-^t--function--fsharp-.md)  <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|Converts the argument to signed 32-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.Int32.Parse*><CodeContentPlaceHolder>80\</CodeContentPlaceHolder> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int64](../vs140/operators.int64-^t--function--fsharp-.md)  <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|Converts the argument to signed 64-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.Int64.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[invalidArg](../vs140/operators.invalidarg--t--function--fsharp-.md)  <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|Throw a \<xref:System.ArgumentException*> exception.|  
|[invalidOp](../vs140/operators.invalidop--t--function--fsharp-.md)  <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|Throw a \<xref:System.InvalidOperationException*> exception.|  
|[limitedHash](../vs140/operators.limitedhash--t--function--fsharp-.md)  <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|A generic hash function. This function has the same behavior as [hash](../vs140/operators.hash--t--function--fsharp-.md), however the default structural hashing for F# union, record and tuple types stops when the given limit of nodes is reached. The exact behavior of the function can be adjusted on a type-by-type basis by implementing \<xref:System.Object.GetHashCode*> for each type.|  
|[lock](../vs140/operators.lock--lock--t--function--fsharp-.md)  <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|Execute the function as a mutual-exclusion region using the input value as a lock.|  
|[log](../vs140/operators.log-^t--function--fsharp-.md)  <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|Natural logarithm of the given number.|  
|[log10](../vs140/operators.log10-^t--function--fsharp-.md)  <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|Logarithm to base 10 of the given number.|  
|[max](../vs140/operators.max--t--function--fsharp-.md)  <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|Maximum based on generic comparison.|  
|[min](../vs140/operators.min--t--function--fsharp-.md)  <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|Minimum based on generic comparison.|  
|[nan](../vs140/operators.nan-function--fsharp-.md)  <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|Equivalent to \<xref:System.Double.NaN*><CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|  
|[nanf](../vs140/operators.nanf-function--fsharp-.md)  <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|Equivalent to \<xref:System.Single.NaN*><CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|  
|[nativeint](../vs140/operators.nativeint-^t--function--fsharp-.md)  <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|Converts the argument to signed native integer. This is a direct conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[not](../vs140/operators.not-function--fsharp-.md)  <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|Negate a logical value.|  
|[nullArg](../vs140/operators.nullarg--t--function--fsharp-.md)  <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|Throw an \<xref:System.ArgumentNullException*> exception.|  
|[pown](../vs140/operators.pown-^t--function--fsharp-.md)  <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|Overloaded power operator. If <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> then equivalent to <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> occurrences of <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.|  
|[raise](../vs140/operators.raise--t--function--fsharp-.md)  <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|Raises an exception.|  
|[ref](../vs140/operators.ref--t--function--fsharp-.md)  <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>|Create a mutable reference cell.|  
|[reraise](../vs140/operators.reraise--t--function--fsharp-.md)  <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>|Rethrows an exception. This should only be used when handling an exception.|  
|[round](../vs140/operators.round-^t--function--fsharp-.md)  <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>|Round the given number.|  
|[sbyte](../vs140/operators.sbyte-^t--function--fsharp-.md)  <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>|Converts the argument to signed byte. This is a direct conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.SByte.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[seq](../vs140/operators.seq--t--function--fsharp-.md)  <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>|Builds a sequence using sequence expression syntax.|  
|[sign](../vs140/operators.sign-^t--function--fsharp-.md)  <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>|Sign of the given number.|  
|[sin](../vs140/operators.sin-^t--function--fsharp-.md)  <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>|Sine of the given number.|  
|[sinh](../vs140/operators.sinh-^t--function--fsharp-.md)  <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>|Hyperbolic sine of the given number.|  
|[sizeof](../vs140/operators.sizeof--t--type-function--fsharp-.md)  <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>|Returns the internal size of a type in bytes. For example, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> returns 4.|  
|[snd](../vs140/operators.snd--t1--t2--function--fsharp-.md)  <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>|Return the second element of a tuple, <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.|  
|[sqrt](../vs140/operators.sqrt-^t-^u--function--fsharp-.md)  <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>|Square root of the given number.|  
|[stderr](../vs140/operators.stderr--t--type-function--fsharp-.md)  <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>|Reads the value of the property \<xref:System.Console.Error*>.|  
|[stdin](../vs140/operators.stdin--t--type-function--fsharp-.md)  <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>|Reads the value of the property \<xref:System.Console.In*>.|  
|[stdout](../vs140/operators.stdout--t--type-function--fsharp-.md)  <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>|Reads the value of the property \<xref:System.Console.Out*>.|  
|[string](../vs140/operators.string-^t--function--fsharp-.md)  <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>|Converts the argument to a string using \<xref:System.Object.ToString*>.|  
|[tan](../vs140/operators.tan-^t--function--fsharp-.md)  <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>|Tangent of the given number.|  
|[tanh](../vs140/operators.tanh-^t--function--fsharp-.md)  <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>|Hyperbolic tangent of the given number.|  
|[truncate](../vs140/operators.truncate-^t--function--fsharp-.md)  <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>|Overloaded truncate operator.|  
|[typedefof](../vs140/operators.typedefof--t--type-function--fsharp-.md)  <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>|Generate a \<xref:System.Type*> representation for a type definition. If the input type is a generic type instantiation then return the generic type definition associated with all such instantiations.|  
|[typeof](../vs140/operators.typeof--t--type-function--fsharp-.md)  <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>|Generate a \<xref:System.Type*> runtime representation of a static type. The static type is still maintained on the value returned.|  
|[uint16](../vs140/operators.uint16-^t--function--fsharp-.md)  <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>|Converts the argument to unsigned 16-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.UInt16.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[uint32](../vs140/operators.uint32-^t--function--fsharp-.md)  <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>|Converts the argument to unsigned 32-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.UInt32.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[uint64](../vs140/operators.uint64-^t--function--fsharp-.md)  <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>|Converts the argument to unsigned 64-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using \<xref:System.UInt64.Parse*> with \<xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[unativeint](../vs140/operators.unativeint-^t--function--fsharp-.md)  <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>|Converts the argument to unsigned native integer using a direct conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[unbox](../vs140/operators.unbox--t--function--fsharp-.md)  <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>|Unboxes a strongly typed value. This is the inverse of <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> equals <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.|  
|[using](../vs140/operators.using--t--u--function--fsharp-.md)  <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>|Clean up resources associated with the input object after the completion of the given function. Cleanup occurs even when an exception is raised by the protected code.|  
  
## Active Patterns  
  
|Active Pattern|Description|  
|--------------------|-----------------|  
|[( &#124;Failure&#124;_&#124; )](../vs140/operators.failure-active-pattern--fsharp-.md)  <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>|Matches \<xref:System.Exception*> objects whose runtime type is precisely \<xref:System.Exception*><CodeContentPlaceHolder>135\</CodeContentPlaceHolder>|  
|[( &#124;KeyValue&#124; )](../vs140/operators.keyvalue--key--value--active-pattern--fsharp-.md)  <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>|An active pattern to match values of type \<xref:System.Collections.Generic.KeyValuePair`2*>|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)