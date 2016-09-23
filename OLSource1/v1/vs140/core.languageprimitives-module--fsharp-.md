---
title: "Core.LanguagePrimitives Module (F#)"
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
  - Core.LanguagePrimitives
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.LanguagePrimitives
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - LanguagePrimitives module [F#]
ms.assetid: 69d08ac5-5d51-4c20-bf1e-850fd312ece3
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Core.LanguagePrimitives Module (F#)
Language primitives associated with the F# language  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module LanguagePrimitives  
```  
  
## Remarks  
  
## Modules  
  
|Module|Description|  
|------------|-----------------|  
|module [ErrorStrings](../vs140/languageprimitives.errorstrings-module--fsharp-.md)|For internal use only|  
|module [HashCompare](../vs140/languageprimitives.hashcompare-module--fsharp-.md)|The F# compiler emits calls to some of the functions in this module as part of the compiled form of some language constructs|  
|module [IntrinsicFunctions](../vs140/languageprimitives.intrinsicfunctions-module--fsharp-.md)|The F# compiler emits calls to some of the functions in this module as part of the compiled form of some language constructs|  
|module [IntrinsicOperators](../vs140/languageprimitives.intrinsicoperators-module--fsharp-.md)|The F# compiler emits calls to some of the functions in this module as part of the compiled form of some language constructs|  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[AdditionDynamic](../vs140/languageprimitives.additiondynamic--t1--t2--u--function--fsharp-.md)  `: 'T1 -> 'T2 -> 'U`|A compiler intrinsic that implements dynamic invocations to the `+` operator.|  
|[CheckedAdditionDynamic](../vs140/languageprimitives.checkedadditiondynamic--t1--t2--u--function--fsharp-.md)  `: 'T1 -> 'T2 -> 'U`|A compiler intrinsic that implements dynamic invocations to the checked `+` operator.|  
|[CheckedMultiplyDynamic](../vs140/languageprimitives.checkedmultiplydynamic--t1--t2--u--function--fsharp-.md)  `: 'T1 -> 'T2 -> 'U`|A compiler intrinsic that implements dynamic invocations to the checked `+` operator.|  
|[DecimalWithMeasure](../vs140/languageprimitives.decimalwithmeasure--u--function--fsharp-.md)  `: decimal -> decimal<'u>`|Creates a decimal value with units-of-measure|  
|[DivideByInt](../vs140/languageprimitives.dividebyint-^t--function--fsharp-.md)  `: ^T -> int -> ^T`|Divides a value by an integer.|  
|[DivideByIntDynamic](../vs140/languageprimitives.dividebyintdynamic--t--function--fsharp-.md)  `: 'T -> int -> 'T`|A compiler intrinsic that implements dynamic invocations for the `DivideByInt` primitive.|  
|[EnumOfValue](../vs140/languageprimitives.enumofvalue--t--enum--function--fsharp-.md)  `: 'T -> enum`|Creates an enumeration value from an underlying value.|  
|[EnumToValue](../vs140/languageprimitives.enumtovalue--enum--t--function--fsharp-.md)  `: 'Enum -> 'T`|Gets the underlying value for an enumeration value.|  
|[FastGenericComparer](../vs140/languageprimitives.fastgenericcomparer--t--type-function--fsharp-.md)  `: IComparer<'T>`|Creates an F# comparer object for the given type|  
|[FastGenericEqualityComparer](../vs140/languageprimitives.fastgenericequalitycomparer--t--type-function--fsharp-.md)  `: IEqualityComparer<'T>`|Create an F# hash/equality object for the given type|  
|[FastLimitedGenericEqualityComparer](../vs140/languageprimitives.fastlimitedgenericequalitycomparer--t--function--fsharp-.md)  `: int -> IEqualityComparer<'T>`|Create an F# hash/equality object for the given type using node-limited hashing when hashing F# records, lists and union types.|  
|[Float32WithMeasure](../vs140/languageprimitives.float32withmeasure--measure--function.md)  `: float -> float<'u>`|Creates a `float32` value with units-of-measure.|  
|[FloatWithMeasure](../vs140/languageprimitives.floatwithmeasure--measure--function.md)  `: float32 -> float32<'u>`|Creates a `float` value with units-of-measure.|  
|[GenericComparer](../vs140/languageprimitives.genericcomparer-function--fsharp-.md)  `: IComparer`|A static F# comparer object.|  
|[GenericComparison](../vs140/languageprimitives.genericcomparison--t--function--fsharp-.md)  `: 'T -> 'T -> int`|Compares two values.|  
|[GenericComparisonWithComparer](../vs140/languageprimitives.genericcomparisonwithcomparer--t--function--fsharp-.md)  `: IComparer -> 'T -> 'T -> int`|Compare two values. May be called as a recursive case from an implementation of <xref:System.IComparable`1?qualifyHint=False> to ensure consistent NaN comparison semantics.|  
|[GenericEquality](../vs140/languageprimitives.genericequality--t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Compares two values for equality using partial equivalence relation semantics ([nan] <> [nan]).|  
|[GenericEqualityComparer](../vs140/languageprimitives.genericequalitycomparer-function--fsharp-.md)  `: IEqualityComparer`|Returns an F# comparer object suitable for hashing and equality. This hashing behavior of the returned comparer is not limited by an overall node count when hashing F# records, lists and union types.|  
|[GenericEqualityER](../vs140/languageprimitives.genericequalityer--t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Compares two values for equality using equivalence relation semantics ([nan] = [nan]).|  
|[GenericEqualityERComparer](../vs140/languageprimitives.genericequalityercomparer-function--fsharp-.md)  `: IEqualityComparer`|Return an F# comparer object suitable for hashing and equality. This hashing behavior of the returned comparer is not limited by an overall node count when hashing F# records, lists and union types. This equality comparer has equivalence relation semantics ([nan] = [nan]).|  
|[GenericEqualityWithComparer](../vs140/languageprimitives.genericequalitywithcomparer--t--function--fsharp-.md)  `: IEqualityComparer -> 'T -> 'T -> bool`|Compare two values for equality|  
|[GenericGreaterOrEqual](../vs140/languageprimitives.genericgreaterorequal--t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Compares two values|  
|[GenericGreaterThan](../vs140/languageprimitives.genericgreaterthan--t--function--fsharp-.md) `: 'T -> 'T -> bool`|Compares two values|  
|[GenericHash](../vs140/languageprimitives.generichash--t--function--fsharp-.md)  `: 'T -> int`|Hashes a value according to its structure. This hash is not limited by an overall node count when hashing F# records, lists and union types.|  
|[GenericHashWithComparer](../vs140/languageprimitives.generichashwithcomparer--t--function--fsharp-.md)  `: IEqualityComparer -> 'T -> int`|Recursively hashes a part of a value according to its structure.|  
|[GenericLessOrEqual](../vs140/languageprimitives.genericlessorequal--t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Compares two values|  
|[GenericLessThan](../vs140/languageprimitives.genericlessthan--t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Compares two values|  
|[GenericLimitedHash](../vs140/languageprimitives.genericlimitedhash--t--function--fsharp-.md) `: int -> 'T -> int`|Hashes a value according to its structure. Use the given limit to restrict the hash when hashing F# records, lists and union types.|  
|[GenericMaximum](../vs140/languageprimitives.genericmaximum--t--function--fsharp-.md)  `: 'T -> 'T -> 'T`|Takes the maximum of two values structurally according to the order given by [GenericComparison](../vs140/languageprimitives.genericcomparison--t--function--fsharp-.md).|  
|[GenericMinimum](../vs140/languageprimitives.genericminimum--t--function--fsharp-.md)  `: 'T -> 'T -> 'T`|Takes the minimum of two values structurally according to the order given by [GenericComparison](../vs140/languageprimitives.genericcomparison--t--function--fsharp-.md).|  
|[GenericOne](../vs140/languageprimitives.genericone-^t--type-function--fsharp-.md) `: ^T`|Resolves to the one value for any primitive numeric type or any type with a static member called `One`.|  
|[GenericOneDynamic](../vs140/languageprimitives.genericonedynamic--t--function--fsharp-.md)  `: unit -> 'T`|Resolves to the one value for any primitive numeric type or any type with a static member called `One`..|  
|[GenericZero](../vs140/languageprimitives.genericzero-^t--type-function--fsharp-.md)  `: ^T`|Resolves to the zero value for any primitive numeric type or any type with a static member called `Zero`.|  
|[GenericZeroDynamic](../vs140/languageprimitives.genericzerodynamic--t--function--fsharp-.md) `: unit -> 'T`|Resolves to the zero value for any primitive numeric type or any type with a static member called `Zero`.|  
|[Int16WithMeasure](../vs140/languageprimitives.int16withmeasure--measure--function.md)  `: int16 -> int16<'u>`|Creates an `int16` value with units-of-measure|  
|[Int32WithMeasure](../vs140/languageprimitives.int32withmeasure--measure--function.md)  `: int32 -> int32<'u>`|Creates an `int32` value with units-of-measure|  
|[Int64WithMeasure](../vs140/languageprimitives.int64withmeasure--measure--function.md)  `: int64 -> int64<'u>`|Creates an `int64` value with units-of-measure|  
|[MultiplyDynamic](../vs140/languageprimitives.multiplydynamic--t1--t2--u--function--fsharp-.md)  `: 'T1 -> 'T2 -> 'U`|A compiler intrinsic that implements dynamic invocations to the `+` operator.|  
|[ParseInt32](../vs140/languageprimitives.parseint32-function--fsharp-.md)  `: string -> int32`|Parses an `int32` according to the rules used by the overloaded `int32` conversion operator when applied to strings|  
|[ParseInt64](../vs140/languageprimitives.parseint64-function--fsharp-.md)  `: string -> int64`|Parses an `int64` according to the rules used by the overloaded `int64` conversion operator when applied to strings|  
|[ParseUInt32](../vs140/languageprimitives.parseuint32-function--fsharp-.md)  `: string -> uint32`|Parses an `uint32` according to the rules used by the overloaded `uint32` conversion operator when applied to strings|  
|[ParseUInt64](../vs140/languageprimitives.parseuint64-function--fsharp-.md)  `: string -> uint64`|Parses an `uint64` according to the rules used by the overloaded `uint64` conversion operator when applied to strings|  
|[PhysicalEquality](../vs140/languageprimitives.physicalequality--t--function--fsharp-.md) `: 'T -> 'T -> bool`|Reference/physical equality. True if boxed versions of the inputs are reference-equal, OR if both are primitive numeric types and the implementation of <xref:System.Object.Equals?qualifyHint=False> for the type of the first argument returns true on the boxed versions of the inputs.|  
|[PhysicalHash](../vs140/languageprimitives.physicalhash--t--function--fsharp-.md) `: 'T -> int`|The physical hash. Hashes on the object identity, except for value types, where we hash on the contents.|  
|[SByteWithMeasure](../vs140/languageprimitives.sbytewithmeasure--measure--function.md) `: sbyte -> sbyte<'u>`|Creates an `sbyte` value with units-of-measure|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)