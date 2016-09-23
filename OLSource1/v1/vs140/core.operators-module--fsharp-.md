---
title: "Core.Operators Module (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Core.Operators
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.Operators
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Operators module [F#]
ms.assetid: a5a3adf6-3957-4293-8e51-069381017af0
caps.latest.revision: 29
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Core.Operators Module (F#)
Basic F# Operators. This module is automatically opened in all F# code.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AutoOpen>]  
module Operators  
```  
  
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
|[( ! )](../vs140/operators.--!----t--function--fsharp-.md)  `: 'T ref -> 'T`|Dereference a mutable reference cell.|  
|[( % )](../vs140/operators.-----^t1-^t2-^t3--function--fsharp-.md)  `: ^T1 -> ^T2 -> ^T3`|Overloaded modulo operator.|  
|[( &&& )](../vs140/operators.--------^t--function--fsharp-.md)  `: ^T -> ^T -> ^T`|Overloaded bitwise AND operator.|  
|[( * )](../vs140/operators.------^t1-^t2-^t3--function--fsharp-.md)  `: ^T1 -> ^T2 -> ^T3`|Overloaded multiplication operator.|  
|[( ** )](../vs140/operators.-------^t-^u--function--fsharp-.md)  `: ^T -> ^U -> ^T`|Overloaded exponentiation operator.|  
|[( + )](../vs140/operators.------^t1-^t2-^t3--function--fsharp-.md)  `: ^T1 -> ^T2 -> ^T3`|Overloaded addition operator.|  
|[( - )](../vs140/operators.------^t1-^t2-^t3--function--fsharp-1.md)  `: ^T1 -> ^T2 -> ^T3`|Overloaded subtraction operator.|  
|[( .. )](../vs140/operators.--..---^t--function--fsharp-.md)  `: ^T -> ^T -> seq<^T>`|The standard overloaded range operator, e.g. `[n..m]` for lists, `seq {n..m}` for sequences.|  
|[( .. .. )](../vs140/operators.--..-..---^t-^step--function--fsharp-.md)  `: ^T -> ^Step -> ^T -> seq<^T>`|The standard overloaded skip range operator, e.g. `[n..skip..m]` for lists, `seq {n..skip..m}` for sequences.|  
|[( / )](../vs140/operators.------^t1-^t2-^t3--function--fsharp-2.md)  `: ^T1 -> ^T2 -> ^T3`|Overloaded division operator.|  
|[( := )](../vs140/operators.---=----t--function--fsharp-.md)  `: 'T ref -> 'T -> unit`|Assigns to a mutable reference cell.|  
|[( < )](../vs140/operators.-------t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Structural less-than comparison.|  
|[( << )](../vs140/operators.--------t2--t3--t1--function--fsharp-.md)  `: ('T2 -> 'T3) -> ('T1 -> 'T2) -> 'T1 -> 'T3`|Composes two functions, the function on the right being applied first.|  
|[( <<< )](../vs140/operators.--------^t--function--fsharp-.md)  `: ^T -> int32 -> ^T`|Overloaded byte-shift left operator by a specified number of bits.|  
|[( <= )](../vs140/operators.---=----t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Structural less-than-or-equal comparison.|  
|[( <> )](../vs140/operators.--------t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Structural inequality.|  
|[( <&#124; )](../vs140/operators.--------t--u--function--fsharp-.md)  `: ('T -> 'U) -> 'T -> 'U`|Apply a function to a value, the value being on the right, the function on the left.|  
|[( <&#124;&#124; )](../vs140/operators.---------t1--t2--u--function--fsharp-.md)  `: ('T1 -> 'T2 -> 'U) -> 'T1 * 'T2 -> 'U`|Apply a function to two values, the values being a pair on the right, the function on the left.|  
|[( <&#124;&#124;&#124; )](../vs140/operators.----------t1--t2--t3--u--function--fsharp-.md)  `: ('T1 -> 'T2 -> 'T3 -> 'U) -> 'T1 * 'T2 * 'T3 -> 'U`|Apply a function to three values, the values being a triple on the right, the function on the left.|  
|[( = )](../vs140/operators.--=----t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Structural equality.|  
|[( > )](../vs140/operators.-------t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Structural greater-than.|  
|[( >= )](../vs140/operators.---=----t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Structural greater-than-or-equal.|  
|[( >> )](../vs140/operators.--------t1--t2--t3--function--fsharp-.md)  `: ('T1 -> 'T2) -> ('T2 -> 'T3) -> 'T1 -> 'T3`|Compose two functions, the function on the left being applied first.|  
|[( >>> )](../vs140/operators.--------^t--function--fsharp-.md)  `: ^T -> int32 -> ^T`|Overloaded byte-shift right operator by a specified number of bits.|  
|[( @ )](../vs140/operators.--@----t--function--fsharp-.md)  `: 'T list -> 'T list -> 'T list`|Concatenates two lists.|  
|[( ^ )](../vs140/operators.--^---function--fsharp-.md)  `: string -> string -> string`|Concatenates two strings. The operator '+' may also be used.|  
|[( ^^^ )](../vs140/operators.--^^^---^t--function--fsharp-.md)  `: ^T -> ^T -> ^T`|Overloaded bitwise XOR operator.|  
|[( &#124;> )](../vs140/operators.--------t1--u--function--fsharp-.md)  `: 'T1 -> ('T1 -> 'U) -> 'U`|Apply a function to a value, the value being on the left, the function on the right.|  
|[( &#124;&#124;> )](../vs140/operators.---------t1--t2--u--function--fsharp-.md)  `: 'T1 * 'T2 -> ('T1 -> 'T2 -> 'U) -> 'U`|Apply a function to two values, the values being a pair on the left, the function on the right.|  
|[( &#124;&#124;&#124; )](../vs140/operators.--------^t--function--fsharp-.md)  `: ^T -> ^T -> ^T`|Overloaded bitwise OR operator|  
|[( &#124;&#124;&#124;> )](../vs140/operators.----------t1--t2--t3--u--function--fsharp-.md)  `: 'T1 * 'T2 * 'T3 -> ('T1 -> 'T2 -> 'T3 -> 'U) -> 'U`|Apply a function to three values, the values being a triple on the left, the function on the right.|  
|[( ~+ )](../vs140/operators.--~----^t--function--fsharp-.md)  `: ^T -> ^T`|Overloaded prefix plus operator.|  
|[( ~- )](../vs140/operators.--~----^t--function--fsharp-.md)  `: ^T -> ^T`|Overloaded unary negation.|  
|[( ~~~ )](../vs140/operators.--~~~---^t--function--fsharp-.md)  `: ^T -> ^T`|Overloaded bitwise NOT operator.|  
|[abs](../vs140/operators.abs-^t--function--fsharp-.md)  `: ^T -> ^T`|Absolute value of the given number.|  
|[acos](../vs140/operators.acos-^t--function--fsharp-.md)  `: ^T -> ^T`|Inverse cosine of the given number.|  
|[asin](../vs140/operators.asin-^t--function--fsharp-.md)  `: ^T -> ^T`|Inverse sine of the given number.|  
|[atan](../vs140/operators.atan-^t--function--fsharp-.md)  `: ^T -> ^T`|Inverse tangent of the given number.|  
|[atan2](../vs140/operators.atan2-^t1--t2--function--fsharp-.md)  `: ^T1 -> ^T2 -> 'T2`|Inverse tangent of `x/y` where `x` and `y` are specified separately.|  
|[box](../vs140/operators.box--t--function--fsharp-.md)  `: 'T -> obj`|Boxes a strongly typed value.|  
|[byte](../vs140/operators.byte-^t--function--fsharp-.md)  `: ^T -> byte`|Converts the argument to byte. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Byte.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[ceil](../vs140/operators.ceil-^t--function--fsharp-.md)  `: ^T -> ^T`|Ceiling of the given number.|  
|[char](../vs140/operators.char-^t--function--fsharp-.md)  `: ^T -> char`|Converts the argument to character. Numeric inputs are converted according to the UTF-16 encoding for characters. String inputs must be exactly one character long. For other input types the operation requires an appropriate static conversion method on the input type.|  
|[compare](../vs140/operators.compare--t--function--fsharp-.md)  `: 'T -> 'T -> int`|Generic comparison.|  
|[cos](../vs140/operators.cos-^t--function--fsharp-.md)  `: ^T -> ^T`|Cosine of the given number.|  
|[cosh](../vs140/operators.cosh-^t--function--fsharp-.md)  `: ^T -> ^T`|Hyperbolic cosine of the given number.|  
|[decimal](../vs140/operators.decimal-^t--function--fsharp-.md)  `: ^T -> decimal`|Converts the argument to <xref:System.Decimal?qualifyHint=False> using a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.UInt64.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[decr](../vs140/operators.decr-function--fsharp-.md)  `: int ref -> unit`|Decrement a mutable reference cell containing an integer.|  
|[defaultArg](../vs140/operators.defaultarg--t--function--fsharp-.md)  `: 'T option -> 'T -> 'T`|Used to specify a default value for an optional argument in the implementation of a function.|  
|[enum](../vs140/operators.enum-^u--function--fsharp-.md)  `: int32 -> ^U`|Converts the argument to a particular `enum` type.|  
|[exit](../vs140/operators.exit--t--function--fsharp-.md)  `: int -> 'T`|Exit the current hardware isolated process, if security settings permit, otherwise raise an exception. Calls <xref:System.Environment.Exit?qualifyHint=False>.|  
|[exp](../vs140/operators.exp-^t--function--fsharp-.md)  `: ^T -> ^T`|Exponential of the given number.|  
|[Failure](../vs140/operators.failure-function--fsharp-.md)  `: string -> exn`|Builds a <xref:System.Exception?qualifyHint=False> object.|  
|[failwith](../vs140/operators.failwith--t--function--fsharp-.md)  `: string -> 'T`|Throw a <xref:System.Exception?qualifyHint=False> exception.|  
|[float](../vs140/operators.float-^t--function--fsharp-.md)  `: ^T -> float`|Converts the argument to 64-bit float. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Double.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[float32](../vs140/operators.float32-^t--function--fsharp-.md)  `: ^T -> float32`|Converts the argument to 32-bit float. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Single.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[floor](../vs140/operators.floor-^t--function--fsharp-.md)  `: ^T -> ^T`|Floor of the given number.|  
|[fst](../vs140/operators.fst--t1--t2--function--fsharp-.md)  `: 'T1 * 'T2 -> 'T1`|Return the first element of a tuple, `fst (a,b) = a`.|  
|[hash](../vs140/operators.hash--t--function--fsharp-.md)  `: 'T -> int`|A generic hash function, designed to return equal hash values for items that are equal according to the `=` operator. By default it will use structural hashing for F# union, record and tuple types, hashing the complete contents of the type. The exact behavior of the function can be adjusted on a type-by-type basis by implementing <xref:System.Object.GetHashCode?qualifyHint=False> for each type.|  
|[id](../vs140/operators.id--t--function--fsharp-.md)  `: 'T -> 'T`|The identity function.|  
|[ignore](../vs140/operators.ignore--t--function--fsharp-.md)  `: 'T -> unit`|Ignore the passed value. This is often used to throw away results of a computation.|  
|[incr](../vs140/operators.incr-function--fsharp-.md)  `: int ref -> unit`|Increment a mutable reference cell containing an integer.|  
|[infinity](../vs140/operators.infinity-function--fsharp-.md)  `: float`|Equivalent to <xref:System.Double.PositiveInfinity?qualifyHint=False>`.`|  
|[infinityf](../vs140/operators.infinityf-function--fsharp-.md)  `: float32`|Equivalent to <xref:System.Single.PositiveInfinity?qualifyHint=False>`.`|  
|[int](../vs140/operators.int-^t--function--fsharp-.md)  `: ^T -> int`|Converts the argument to signed 32-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int32.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int16](../vs140/operators.int16-^t--function--fsharp-.md)  `: ^T -> int16`|Converts the argument to signed 16-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int16.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int32](../vs140/operators.int32-^t--function--fsharp-.md)  `: ^T -> int32`|Converts the argument to signed 32-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int32.Parse?qualifyHint=False>`)` with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int64](../vs140/operators.int64-^t--function--fsharp-.md)  `: ^T -> int64`|Converts the argument to signed 64-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int64.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[invalidArg](../vs140/operators.invalidarg--t--function--fsharp-.md)  `: string -> string -> 'T`|Throw a <xref:System.ArgumentException?qualifyHint=False> exception.|  
|[invalidOp](../vs140/operators.invalidop--t--function--fsharp-.md)  `: string -> 'T`|Throw a <xref:System.InvalidOperationException?qualifyHint=False> exception.|  
|[limitedHash](../vs140/operators.limitedhash--t--function--fsharp-.md)  `: int -> 'T -> int`|A generic hash function. This function has the same behavior as [hash](../vs140/operators.hash--t--function--fsharp-.md), however the default structural hashing for F# union, record and tuple types stops when the given limit of nodes is reached. The exact behavior of the function can be adjusted on a type-by-type basis by implementing <xref:System.Object.GetHashCode?qualifyHint=False> for each type.|  
|[lock](../vs140/operators.lock--lock--t--function--fsharp-.md)  `: 'Lock -> (unit -> 'T) -> 'T`|Execute the function as a mutual-exclusion region using the input value as a lock.|  
|[log](../vs140/operators.log-^t--function--fsharp-.md)  `: ^T -> ^T`|Natural logarithm of the given number.|  
|[log10](../vs140/operators.log10-^t--function--fsharp-.md)  `: ^T -> ^T`|Logarithm to base 10 of the given number.|  
|[max](../vs140/operators.max--t--function--fsharp-.md)  `: 'T -> 'T -> 'T`|Maximum based on generic comparison.|  
|[min](../vs140/operators.min--t--function--fsharp-.md)  `: 'T -> 'T -> 'T`|Minimum based on generic comparison.|  
|[nan](../vs140/operators.nan-function--fsharp-.md)  `: float`|Equivalent to <xref:System.Double.NaN?qualifyHint=False>`.`|  
|[nanf](../vs140/operators.nanf-function--fsharp-.md)  `: float32`|Equivalent to <xref:System.Single.NaN?qualifyHint=False>`.`|  
|[nativeint](../vs140/operators.nativeint-^t--function--fsharp-.md)  `: ^T -> nativeint`|Converts the argument to signed native integer. This is a direct conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[not](../vs140/operators.not-function--fsharp-.md)  `: bool -> bool`|Negate a logical value.|  
|[nullArg](../vs140/operators.nullarg--t--function--fsharp-.md)  `: string -> 'T`|Throw an <xref:System.ArgumentNullException?qualifyHint=False> exception.|  
|[pown](../vs140/operators.pown-^t--function--fsharp-.md)  `: ^T -> int -> ^T`|Overloaded power operator. If `n > 0` then equivalent to `x*...*x` for `n` occurrences of `x`.|  
|[raise](../vs140/operators.raise--t--function--fsharp-.md)  `: Exception -> 'T`|Raises an exception.|  
|[ref](../vs140/operators.ref--t--function--fsharp-.md)  `: 'T -> 'T ref`|Create a mutable reference cell.|  
|[reraise](../vs140/operators.reraise--t--function--fsharp-.md)  `: unit -> 'T`|Rethrows an exception. This should only be used when handling an exception.|  
|[round](../vs140/operators.round-^t--function--fsharp-.md)  `: ^T -> ^T`|Round the given number.|  
|[sbyte](../vs140/operators.sbyte-^t--function--fsharp-.md)  `: ^T -> sbyte`|Converts the argument to signed byte. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.SByte.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[seq](../vs140/operators.seq--t--function--fsharp-.md)  `: seq<'T> -> seq<'T>`|Builds a sequence using sequence expression syntax.|  
|[sign](../vs140/operators.sign-^t--function--fsharp-.md)  `: ^T -> int`|Sign of the given number.|  
|[sin](../vs140/operators.sin-^t--function--fsharp-.md)  `: ^T -> ^T`|Sine of the given number.|  
|[sinh](../vs140/operators.sinh-^t--function--fsharp-.md)  `: ^T -> ^T`|Hyperbolic sine of the given number.|  
|[sizeof](../vs140/operators.sizeof--t--type-function--fsharp-.md)  `: int`|Returns the internal size of a type in bytes. For example, `sizeof<int>` returns 4.|  
|[snd](../vs140/operators.snd--t1--t2--function--fsharp-.md)  `: 'T1 * 'T2 -> 'T2`|Return the second element of a tuple, `snd (a,b) = b`.|  
|[sqrt](../vs140/operators.sqrt-^t-^u--function--fsharp-.md)  `: ^T -> ^T`|Square root of the given number.|  
|[stderr](../vs140/operators.stderr--t--type-function--fsharp-.md)  `: TextWriter`|Reads the value of the property <xref:System.Console.Error?qualifyHint=False>.|  
|[stdin](../vs140/operators.stdin--t--type-function--fsharp-.md)  `: TextReader`|Reads the value of the property <xref:System.Console.In?qualifyHint=False>.|  
|[stdout](../vs140/operators.stdout--t--type-function--fsharp-.md)  `: TextWriter`|Reads the value of the property <xref:System.Console.Out?qualifyHint=False>.|  
|[string](../vs140/operators.string-^t--function--fsharp-.md)  `: ^T -> string`|Converts the argument to a string using <xref:System.Object.ToString?qualifyHint=False>.|  
|[tan](../vs140/operators.tan-^t--function--fsharp-.md)  `: ^T -> ^T`|Tangent of the given number.|  
|[tanh](../vs140/operators.tanh-^t--function--fsharp-.md)  `: ^T -> ^T`|Hyperbolic tangent of the given number.|  
|[truncate](../vs140/operators.truncate-^t--function--fsharp-.md)  `: ^T -> ^T`|Overloaded truncate operator.|  
|[typedefof](../vs140/operators.typedefof--t--type-function--fsharp-.md)  `: Type`|Generate a <xref:System.Type?qualifyHint=False> representation for a type definition. If the input type is a generic type instantiation then return the generic type definition associated with all such instantiations.|  
|[typeof](../vs140/operators.typeof--t--type-function--fsharp-.md)  `: Type`|Generate a <xref:System.Type?qualifyHint=False> runtime representation of a static type. The static type is still maintained on the value returned.|  
|[uint16](../vs140/operators.uint16-^t--function--fsharp-.md)  `: ^T -> uint16`|Converts the argument to unsigned 16-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.UInt16.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[uint32](../vs140/operators.uint32-^t--function--fsharp-.md)  `: ^T -> uint32`|Converts the argument to unsigned 32-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.UInt32.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[uint64](../vs140/operators.uint64-^t--function--fsharp-.md)  `: ^T -> uint64`|Converts the argument to unsigned 64-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.UInt64.Parse?qualifyHint=False> with <xref:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[unativeint](../vs140/operators.unativeint-^t--function--fsharp-.md)  `: ^T -> nativeint`|Converts the argument to unsigned native integer using a direct conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[unbox](../vs140/operators.unbox--t--function--fsharp-.md)  `: obj -> 'T`|Unboxes a strongly typed value. This is the inverse of `box`, `unbox<'T>(box<'T> a)` equals `a`.|  
|[using](../vs140/operators.using--t--u--function--fsharp-.md)  `: 'T -> ('T -> 'U) -> 'U`|Clean up resources associated with the input object after the completion of the given function. Cleanup occurs even when an exception is raised by the protected code.|  
  
## Active Patterns  
  
|Active Pattern|Description|  
|--------------------|-----------------|  
|[( &#124;Failure&#124;_&#124; )](../vs140/operators.failure-active-pattern--fsharp-.md)  `: exn -> string option`|Matches <xref:System.Exception?qualifyHint=False> objects whose runtime type is precisely <xref:System.Exception?qualifyHint=False>`.`|  
|[( &#124;KeyValue&#124; )](../vs140/operators.keyvalue--key--value--active-pattern--fsharp-.md)  `: KeyValuePair<'Key,'Value> -> 'Key * 'Value`|An active pattern to match values of type <xref:System.Collections.Generic.KeyValuePair`2?qualifyHint=False>|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)