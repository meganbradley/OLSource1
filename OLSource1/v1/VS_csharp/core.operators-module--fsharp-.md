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
  
```  
[<AutoOpen>]  
module Operators  
```  
  
## Remarks  
 For an overview of operators in F#, see [Symbol and Operator Reference (F#)](../VS_csharp/symbol-and-operator-reference--fsharp-.md).  
  
## Modules  
  
|Module|Description|  
|------------|-----------------|  
|module [Checked](../VS_csharp/operators.checked-module--fsharp-.md)|This module contains the basic arithmetic operations with overflow checks.|  
|module [OperatorIntrinsics](../VS_csharp/operators.operatorintrinsics-module--fsharp-.md)|A module of compiler intrinsic functions for efficient implementations of F# integer ranges and dynamic invocations of other F# operators|  
|module [Unchecked](../VS_csharp/operators.unchecked-module--fsharp-.md)|This module contains basic operations which do not apply runtime and/or static checks|  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[( ! )](../VS_csharp/operators.--!----t--function--fsharp-.md)  `: 'T ref -> 'T`|Dereference a mutable reference cell.|  
|[( % )](../VS_csharp/operators.-----^t1-^t2-^t3--function--fsharp-.md)  `: ^T1 -> ^T2 -> ^T3`|Overloaded modulo operator.|  
|[( &&& )](../VS_csharp/operators.--------^t--function--fsharp-.md)  `: ^T -> ^T -> ^T`|Overloaded bitwise AND operator.|  
|[( * )](../VS_csharp/operators.------^t1-^t2-^t3--function--fsharp-.md)  `: ^T1 -> ^T2 -> ^T3`|Overloaded multiplication operator.|  
|[( ** )](../VS_csharp/operators.-------^t-^u--function--fsharp-.md)  `: ^T -> ^U -> ^T`|Overloaded exponentiation operator.|  
|[( + )](../VS_csharp/operators.------^t1-^t2-^t3--function--fsharp-.md)  `: ^T1 -> ^T2 -> ^T3`|Overloaded addition operator.|  
|[( - )](../VS_csharp/operators.------^t1-^t2-^t3--function--fsharp-1.md)  `: ^T1 -> ^T2 -> ^T3`|Overloaded subtraction operator.|  
|[( .. )](../VS_csharp/operators.--..---^t--function--fsharp-.md)  `: ^T -> ^T -> seq<^T>`|The standard overloaded range operator, e.g. `[n..m]` for lists, `seq {n..m}` for sequences.|  
|[( .. .. )](../VS_csharp/operators.--..-..---^t-^step--function--fsharp-.md)  `: ^T -> ^Step -> ^T -> seq<^T>`|The standard overloaded skip range operator, e.g. `[n..skip..m]` for lists, `seq {n..skip..m}` for sequences.|  
|[( / )](../VS_csharp/operators.------^t1-^t2-^t3--function--fsharp-2.md)  `: ^T1 -> ^T2 -> ^T3`|Overloaded division operator.|  
|[( := )](../VS_csharp/operators.---=----t--function--fsharp-.md)  `: 'T ref -> 'T -> unit`|Assigns to a mutable reference cell.|  
|[( < )](../VS_csharp/operators.-------t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Structural less-than comparison.|  
|[( << )](../VS_csharp/operators.--------t2--t3--t1--function--fsharp-.md)  `: ('T2 -> 'T3) -> ('T1 -> 'T2) -> 'T1 -> 'T3`|Composes two functions, the function on the right being applied first.|  
|[( <<< )](../VS_csharp/operators.--------^t--function--fsharp-.md)  `: ^T -> int32 -> ^T`|Overloaded byte-shift left operator by a specified number of bits.|  
|[( <= )](../VS_csharp/operators.---=----t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Structural less-than-or-equal comparison.|  
|[( <> )](../VS_csharp/operators.--------t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Structural inequality.|  
|[( <&#124; )](../VS_csharp/operators.--------t--u--function--fsharp-.md)  `: ('T -> 'U) -> 'T -> 'U`|Apply a function to a value, the value being on the right, the function on the left.|  
|[( <&#124;&#124; )](../VS_csharp/operators.---------t1--t2--u--function--fsharp-.md)  `: ('T1 -> 'T2 -> 'U) -> 'T1 * 'T2 -> 'U`|Apply a function to two values, the values being a pair on the right, the function on the left.|  
|[( <&#124;&#124;&#124; )](../VS_csharp/operators.----------t1--t2--t3--u--function--fsharp-.md)  `: ('T1 -> 'T2 -> 'T3 -> 'U) -> 'T1 * 'T2 * 'T3 -> 'U`|Apply a function to three values, the values being a triple on the right, the function on the left.|  
|[( = )](../VS_csharp/operators.--=----t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Structural equality.|  
|[( > )](../VS_csharp/operators.-------t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Structural greater-than.|  
|[( >= )](../VS_csharp/operators.---=----t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Structural greater-than-or-equal.|  
|[( >> )](../VS_csharp/operators.--------t1--t2--t3--function--fsharp-.md)  `: ('T1 -> 'T2) -> ('T2 -> 'T3) -> 'T1 -> 'T3`|Compose two functions, the function on the left being applied first.|  
|[( >>> )](../VS_csharp/operators.--------^t--function--fsharp-.md)  `: ^T -> int32 -> ^T`|Overloaded byte-shift right operator by a specified number of bits.|  
|[( @ )](../VS_csharp/operators.--@----t--function--fsharp-.md)  `: 'T list -> 'T list -> 'T list`|Concatenates two lists.|  
|[( ^ )](../VS_csharp/operators.--^---function--fsharp-.md)  `: string -> string -> string`|Concatenates two strings. The operator '+' may also be used.|  
|[( ^^^ )](../VS_csharp/operators.--^^^---^t--function--fsharp-.md)  `: ^T -> ^T -> ^T`|Overloaded bitwise XOR operator.|  
|[( &#124;> )](../VS_csharp/operators.--------t1--u--function--fsharp-.md)  `: 'T1 -> ('T1 -> 'U) -> 'U`|Apply a function to a value, the value being on the left, the function on the right.|  
|[( &#124;&#124;> )](../VS_csharp/operators.---------t1--t2--u--function--fsharp-.md)  `: 'T1 * 'T2 -> ('T1 -> 'T2 -> 'U) -> 'U`|Apply a function to two values, the values being a pair on the left, the function on the right.|  
|[( &#124;&#124;&#124; )](../VS_csharp/operators.--------^t--function--fsharp-.md)  `: ^T -> ^T -> ^T`|Overloaded bitwise OR operator|  
|[( &#124;&#124;&#124;> )](../VS_csharp/operators.----------t1--t2--t3--u--function--fsharp-.md)  `: 'T1 * 'T2 * 'T3 -> ('T1 -> 'T2 -> 'T3 -> 'U) -> 'U`|Apply a function to three values, the values being a triple on the left, the function on the right.|  
|[( ~+ )](../VS_csharp/operators.--~----^t--function--fsharp-.md)  `: ^T -> ^T`|Overloaded prefix plus operator.|  
|[( ~- )](../VS_csharp/operators.--~----^t--function--fsharp-.md)  `: ^T -> ^T`|Overloaded unary negation.|  
|[( ~~~ )](../VS_csharp/operators.--~~~---^t--function--fsharp-.md)  `: ^T -> ^T`|Overloaded bitwise NOT operator.|  
|[abs](../VS_csharp/operators.abs-^t--function--fsharp-.md)  `: ^T -> ^T`|Absolute value of the given number.|  
|[acos](../VS_csharp/operators.acos-^t--function--fsharp-.md)  `: ^T -> ^T`|Inverse cosine of the given number.|  
|[asin](../VS_csharp/operators.asin-^t--function--fsharp-.md)  `: ^T -> ^T`|Inverse sine of the given number.|  
|[atan](../VS_csharp/operators.atan-^t--function--fsharp-.md)  `: ^T -> ^T`|Inverse tangent of the given number.|  
|[atan2](../VS_csharp/operators.atan2-^t1--t2--function--fsharp-.md)  `: ^T1 -> ^T2 -> 'T2`|Inverse tangent of `x/y` where `x` and `y` are specified separately.|  
|[box](../VS_csharp/operators.box--t--function--fsharp-.md)  `: 'T -> obj`|Boxes a strongly typed value.|  
|[byte](../VS_csharp/operators.byte-^t--function--fsharp-.md)  `: ^T -> byte`|Converts the argument to byte. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Byte.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[ceil](../VS_csharp/operators.ceil-^t--function--fsharp-.md)  `: ^T -> ^T`|Ceiling of the given number.|  
|[char](../VS_csharp/operators.char-^t--function--fsharp-.md)  `: ^T -> char`|Converts the argument to character. Numeric inputs are converted according to the UTF-16 encoding for characters. String inputs must be exactly one character long. For other input types the operation requires an appropriate static conversion method on the input type.|  
|[compare](../VS_csharp/operators.compare--t--function--fsharp-.md)  `: 'T -> 'T -> int`|Generic comparison.|  
|[cos](../VS_csharp/operators.cos-^t--function--fsharp-.md)  `: ^T -> ^T`|Cosine of the given number.|  
|[cosh](../VS_csharp/operators.cosh-^t--function--fsharp-.md)  `: ^T -> ^T`|Hyperbolic cosine of the given number.|  
|[decimal](../VS_csharp/operators.decimal-^t--function--fsharp-.md)  `: ^T -> decimal`|Converts the argument to <xref:System.Decimal*> using a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.UInt64.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[decr](../VS_csharp/operators.decr-function--fsharp-.md)  `: int ref -> unit`|Decrement a mutable reference cell containing an integer.|  
|[defaultArg](../VS_csharp/operators.defaultarg--t--function--fsharp-.md)  `: 'T option -> 'T -> 'T`|Used to specify a default value for an optional argument in the implementation of a function.|  
|[enum](../VS_csharp/operators.enum-^u--function--fsharp-.md)  `: int32 -> ^U`|Converts the argument to a particular `enum` type.|  
|[exit](../VS_csharp/operators.exit--t--function--fsharp-.md)  `: int -> 'T`|Exit the current hardware isolated process, if security settings permit, otherwise raise an exception. Calls <xref:System.Environment.Exit*>.|  
|[exp](../VS_csharp/operators.exp-^t--function--fsharp-.md)  `: ^T -> ^T`|Exponential of the given number.|  
|[Failure](../VS_csharp/operators.failure-function--fsharp-.md)  `: string -> exn`|Builds a <xref:System.Exception*> object.|  
|[failwith](../VS_csharp/operators.failwith--t--function--fsharp-.md)  `: string -> 'T`|Throw a <xref:System.Exception*> exception.|  
|[float](../VS_csharp/operators.float-^t--function--fsharp-.md)  `: ^T -> float`|Converts the argument to 64-bit float. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Double.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[float32](../VS_csharp/operators.float32-^t--function--fsharp-.md)  `: ^T -> float32`|Converts the argument to 32-bit float. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Single.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[floor](../VS_csharp/operators.floor-^t--function--fsharp-.md)  `: ^T -> ^T`|Floor of the given number.|  
|[fst](../VS_csharp/operators.fst--t1--t2--function--fsharp-.md)  `: 'T1 * 'T2 -> 'T1`|Return the first element of a tuple, `fst (a,b) = a`.|  
|[hash](../VS_csharp/operators.hash--t--function--fsharp-.md)  `: 'T -> int`|A generic hash function, designed to return equal hash values for items that are equal according to the `=` operator. By default it will use structural hashing for F# union, record and tuple types, hashing the complete contents of the type. The exact behavior of the function can be adjusted on a type-by-type basis by implementing <xref:System.Object.GetHashCode*> for each type.|  
|[id](../VS_csharp/operators.id--t--function--fsharp-.md)  `: 'T -> 'T`|The identity function.|  
|[ignore](../VS_csharp/operators.ignore--t--function--fsharp-.md)  `: 'T -> unit`|Ignore the passed value. This is often used to throw away results of a computation.|  
|[incr](../VS_csharp/operators.incr-function--fsharp-.md)  `: int ref -> unit`|Increment a mutable reference cell containing an integer.|  
|[infinity](../VS_csharp/operators.infinity-function--fsharp-.md)  `: float`|Equivalent to <xref:System.Double.PositiveInfinity*>`.`|  
|[infinityf](../VS_csharp/operators.infinityf-function--fsharp-.md)  `: float32`|Equivalent to <xref:System.Single.PositiveInfinity*>`.`|  
|[int](../VS_csharp/operators.int-^t--function--fsharp-.md)  `: ^T -> int`|Converts the argument to signed 32-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int32.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int16](../VS_csharp/operators.int16-^t--function--fsharp-.md)  `: ^T -> int16`|Converts the argument to signed 16-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int16.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int32](../VS_csharp/operators.int32-^t--function--fsharp-.md)  `: ^T -> int32`|Converts the argument to signed 32-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int32.Parse*>`)` with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int64](../VS_csharp/operators.int64-^t--function--fsharp-.md)  `: ^T -> int64`|Converts the argument to signed 64-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int64.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[invalidArg](../VS_csharp/operators.invalidarg--t--function--fsharp-.md)  `: string -> string -> 'T`|Throw a <xref:System.ArgumentException*> exception.|  
|[invalidOp](../VS_csharp/operators.invalidop--t--function--fsharp-.md)  `: string -> 'T`|Throw a <xref:System.InvalidOperationException*> exception.|  
|[limitedHash](../VS_csharp/operators.limitedhash--t--function--fsharp-.md)  `: int -> 'T -> int`|A generic hash function. This function has the same behavior as [hash](../VS_csharp/operators.hash--t--function--fsharp-.md), however the default structural hashing for F# union, record and tuple types stops when the given limit of nodes is reached. The exact behavior of the function can be adjusted on a type-by-type basis by implementing <xref:System.Object.GetHashCode*> for each type.|  
|[lock](../VS_csharp/operators.lock--lock--t--function--fsharp-.md)  `: 'Lock -> (unit -> 'T) -> 'T`|Execute the function as a mutual-exclusion region using the input value as a lock.|  
|[log](../VS_csharp/operators.log-^t--function--fsharp-.md)  `: ^T -> ^T`|Natural logarithm of the given number.|  
|[log10](../VS_csharp/operators.log10-^t--function--fsharp-.md)  `: ^T -> ^T`|Logarithm to base 10 of the given number.|  
|[max](../VS_csharp/operators.max--t--function--fsharp-.md)  `: 'T -> 'T -> 'T`|Maximum based on generic comparison.|  
|[min](../VS_csharp/operators.min--t--function--fsharp-.md)  `: 'T -> 'T -> 'T`|Minimum based on generic comparison.|  
|[nan](../VS_csharp/operators.nan-function--fsharp-.md)  `: float`|Equivalent to <xref:System.Double.NaN*>`.`|  
|[nanf](../VS_csharp/operators.nanf-function--fsharp-.md)  `: float32`|Equivalent to <xref:System.Single.NaN*>`.`|  
|[nativeint](../VS_csharp/operators.nativeint-^t--function--fsharp-.md)  `: ^T -> nativeint`|Converts the argument to signed native integer. This is a direct conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[not](../VS_csharp/operators.not-function--fsharp-.md)  `: bool -> bool`|Negate a logical value.|  
|[nullArg](../VS_csharp/operators.nullarg--t--function--fsharp-.md)  `: string -> 'T`|Throw an <xref:System.ArgumentNullException*> exception.|  
|[pown](../VS_csharp/operators.pown-^t--function--fsharp-.md)  `: ^T -> int -> ^T`|Overloaded power operator. If `n > 0` then equivalent to `x*...*x` for `n` occurrences of `x`.|  
|[raise](../VS_csharp/operators.raise--t--function--fsharp-.md)  `: Exception -> 'T`|Raises an exception.|  
|[ref](../VS_csharp/operators.ref--t--function--fsharp-.md)  `: 'T -> 'T ref`|Create a mutable reference cell.|  
|[reraise](../VS_csharp/operators.reraise--t--function--fsharp-.md)  `: unit -> 'T`|Rethrows an exception. This should only be used when handling an exception.|  
|[round](../VS_csharp/operators.round-^t--function--fsharp-.md)  `: ^T -> ^T`|Round the given number.|  
|[sbyte](../VS_csharp/operators.sbyte-^t--function--fsharp-.md)  `: ^T -> sbyte`|Converts the argument to signed byte. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.SByte.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[seq](../VS_csharp/operators.seq--t--function--fsharp-.md)  `: seq<'T> -> seq<'T>`|Builds a sequence using sequence expression syntax.|  
|[sign](../VS_csharp/operators.sign-^t--function--fsharp-.md)  `: ^T -> int`|Sign of the given number.|  
|[sin](../VS_csharp/operators.sin-^t--function--fsharp-.md)  `: ^T -> ^T`|Sine of the given number.|  
|[sinh](../VS_csharp/operators.sinh-^t--function--fsharp-.md)  `: ^T -> ^T`|Hyperbolic sine of the given number.|  
|[sizeof](../VS_csharp/operators.sizeof--t--type-function--fsharp-.md)  `: int`|Returns the internal size of a type in bytes. For example, `sizeof<int>` returns 4.|  
|[snd](../VS_csharp/operators.snd--t1--t2--function--fsharp-.md)  `: 'T1 * 'T2 -> 'T2`|Return the second element of a tuple, `snd (a,b) = b`.|  
|[sqrt](../VS_csharp/operators.sqrt-^t-^u--function--fsharp-.md)  `: ^T -> ^T`|Square root of the given number.|  
|[stderr](../VS_csharp/operators.stderr--t--type-function--fsharp-.md)  `: TextWriter`|Reads the value of the property <xref:System.Console.Error*>.|  
|[stdin](../VS_csharp/operators.stdin--t--type-function--fsharp-.md)  `: TextReader`|Reads the value of the property <xref:System.Console.In*>.|  
|[stdout](../VS_csharp/operators.stdout--t--type-function--fsharp-.md)  `: TextWriter`|Reads the value of the property <xref:System.Console.Out*>.|  
|[string](../VS_csharp/operators.string-^t--function--fsharp-.md)  `: ^T -> string`|Converts the argument to a string using <xref:System.Object.ToString*>.|  
|[tan](../VS_csharp/operators.tan-^t--function--fsharp-.md)  `: ^T -> ^T`|Tangent of the given number.|  
|[tanh](../VS_csharp/operators.tanh-^t--function--fsharp-.md)  `: ^T -> ^T`|Hyperbolic tangent of the given number.|  
|[truncate](../VS_csharp/operators.truncate-^t--function--fsharp-.md)  `: ^T -> ^T`|Overloaded truncate operator.|  
|[typedefof](../VS_csharp/operators.typedefof--t--type-function--fsharp-.md)  `: Type`|Generate a <xref:System.Type*> representation for a type definition. If the input type is a generic type instantiation then return the generic type definition associated with all such instantiations.|  
|[typeof](../VS_csharp/operators.typeof--t--type-function--fsharp-.md)  `: Type`|Generate a <xref:System.Type*> runtime representation of a static type. The static type is still maintained on the value returned.|  
|[uint16](../VS_csharp/operators.uint16-^t--function--fsharp-.md)  `: ^T -> uint16`|Converts the argument to unsigned 16-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.UInt16.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[uint32](../VS_csharp/operators.uint32-^t--function--fsharp-.md)  `: ^T -> uint32`|Converts the argument to unsigned 32-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.UInt32.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[uint64](../VS_csharp/operators.uint64-^t--function--fsharp-.md)  `: ^T -> uint64`|Converts the argument to unsigned 64-bit integer. This is a direct conversion for all primitive numeric types. For strings, the input is converted using <xref:System.UInt64.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[unativeint](../VS_csharp/operators.unativeint-^t--function--fsharp-.md)  `: ^T -> nativeint`|Converts the argument to unsigned native integer using a direct conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[unbox](../VS_csharp/operators.unbox--t--function--fsharp-.md)  `: obj -> 'T`|Unboxes a strongly typed value. This is the inverse of `box`, `unbox<'T>(box<'T> a)` equals `a`.|  
|[using](../VS_csharp/operators.using--t--u--function--fsharp-.md)  `: 'T -> ('T -> 'U) -> 'U`|Clean up resources associated with the input object after the completion of the given function. Cleanup occurs even when an exception is raised by the protected code.|  
  
## Active Patterns  
  
|Active Pattern|Description|  
|--------------------|-----------------|  
|[( &#124;Failure&#124;_&#124; )](../VS_csharp/operators.failure-active-pattern--fsharp-.md)  `: exn -> string option`|Matches <xref:System.Exception*> objects whose runtime type is precisely <xref:System.Exception*>`.`|  
|[( &#124;KeyValue&#124; )](../VS_csharp/operators.keyvalue--key--value--active-pattern--fsharp-.md)  `: KeyValuePair<'Key,'Value> -> 'Key * 'Value`|An active pattern to match values of type <xref:System.Collections.Generic.KeyValuePair`2*>|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)