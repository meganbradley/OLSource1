---
title: "Numerics.BigInteger Structure (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "BigInteger structure [F#]"
ms.assetid: e96b4062-9459-48b2-b558-2138255adefe
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Numerics.BigInteger Structure (F#)
The type of arbitrary-sized integers  
  
 **Namespace/Module Path**: System.Numerics  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<CustomEquality>]  
[<CustomComparison>]  
type BigInteger =  
 struct  
  interface IComparable  
  new BigInteger : int64 -> BigInteger  
  new BigInteger : int -> BigInteger  
  static member Abs : BigInteger -> BigInteger  
  static member DivRem : BigInteger * BigInteger * byref<BigInteger> -> BigInteger  
  static member GreatestCommonDivisor : BigInteger * BigInteger -> BigInteger  
  static member Parse : string -> BigInteger  
  static member Pow : BigInteger * int32 -> BigInteger  
  member this.IsOne :  bool  
  member this.IsZero :  bool  
  static member One :  BigInteger  
  member this.Sign :  int  
  static member Zero :  BigInteger  
  static member ( + ) : BigInteger * BigInteger -> BigInteger  
  static member ( / ) : BigInteger * BigInteger -> BigInteger  
  static member ( = ) : BigInteger * BigInteger -> bool  
  static member op_Explicit : BigInteger -> int32  
  static member op_Explicit : BigInteger -> int64  
  static member op_Explicit : BigInteger -> float  
  static member ( > ) : BigInteger * BigInteger -> bool  
  static member ( >= ) : BigInteger * BigInteger -> bool  
  static member ( <> ) : BigInteger * BigInteger -> bool  
  static member ( < ) : BigInteger * BigInteger -> bool  
  static member ( <= ) : BigInteger * BigInteger -> bool  
  static member ( % ) : BigInteger * BigInteger -> BigInteger  
  static member ( * ) : BigInteger * BigInteger -> BigInteger  
  static member ( - ) : BigInteger * BigInteger -> BigInteger  
  static member ( ~- ) : BigInteger -> BigInteger  
  static member ( ~+ ) : BigInteger -> BigInteger  
 end  
```  
  
## Remarks  
 This type is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 type with the same name, <xref:System.Numerics.BigInteger*>.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/numerics.biginteger-constructor--fsharp-.md)|Construct a BigInteger value for the given 64-bit integer|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[IsOne](../vs140/biginteger.isone-property--fsharp-.md)|Return true if a big integer is 'one'|  
|[IsZero](../vs140/biginteger.iszero-property--fsharp-.md)|Return true if a big integer is 'zero'|  
|[Sign](../vs140/biginteger.sign-property--fsharp-.md)|Return the sign of a big integer: 0, +1 or -1|  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[( % )](../vs140/biginteger.-----method--fsharp-.md)|Return the modulus of big integers|  
|[( * )](../vs140/biginteger.------method--fsharp-.md)|Return the product of big integers|  
|[( + )](../vs140/biginteger.------method--fsharp-.md)|Return the sum of two big integers|  
|[( - )](../vs140/biginteger.------method--fsharp-1.md)|Return the difference of two big integers|  
|[( / )](../vs140/biginteger.------method--fsharp-2.md)|Return the ratio of two big integers|  
|[( < )](../vs140/biginteger.------method--fsharp-.md)|This operator is for consistency when this type be used from other CLI languages|  
|[( <= )](../vs140/biginteger.---=---method--fsharp-.md)|This operator is for consistency when this type be used from other CLI languages|  
|[( <> )](../vs140/biginteger.-------method--fsharp-.md)|This operator is for consistency when this type be used from other CLI languages|  
|[( = )](../vs140/biginteger.--=---method--fsharp-.md)|This operator is for consistency when this type be used from other CLI languages|  
|[( > )](../vs140/biginteger.------method--fsharp-.md)|This operator is for consistency when this type be used from other CLI languages|  
|[( >= )](../vs140/biginteger.---=---method--fsharp-.md)|This operator is for consistency when this type be used from other CLI languages|  
|[( ~+ )](../vs140/biginteger.--~----method--fsharp-.md)|Return the given big integer|  
|[( ~- )](../vs140/biginteger.--~----method--fsharp-.md)|Return the negation of a big integer|  
|[Abs](../vs140/biginteger.abs-method--fsharp-.md)|Compute the absolute value of a big integer|  
|[DivRem](../vs140/biginteger.divrem-method--fsharp-.md)|Compute the ratio and remainder of two big integers|  
|[GreatestCommonDivisor](../vs140/biginteger.greatestcommondivisor-method--fsharp-.md)|Return the greatest common divisor of two big integers|  
|[One](../vs140/biginteger.one-property--fsharp-.md)|Get the big integer for one|  
|[op_Explicit](../vs140/biginteger.op_explicit-method--fsharp-.md)|Convert a big integer to a floating point number|  
|[Parse](../vs140/biginteger.parse-method--fsharp-.md)|Parse a big integer from a string format|  
|[Pow](../vs140/biginteger.pow-method--fsharp-.md)|Return n^m for two big integers|  
|[Zero](../vs140/biginteger.zero-property--fsharp-.md)|Get the big integer for zero|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [System.Numerics Namespace (F#)](../vs140/system.numerics-namespace--fsharp-.md)