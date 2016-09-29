---
title: "Core.LanguagePrimitives Module (F#)"
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
  - "Core.LanguagePrimitives"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.LanguagePrimitives"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "LanguagePrimitives module [F#]"
ms.assetid: 69d08ac5-5d51-4c20-bf1e-850fd312ece3
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
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
|module [ErrorStrings](../VS_csharp/languageprimitives.errorstrings-module--fsharp-.md)|For internal use only|  
|module [HashCompare](../VS_csharp/languageprimitives.hashcompare-module--fsharp-.md)|The F# compiler emits calls to some of the functions in this module as part of the compiled form of some language constructs|  
|module [IntrinsicFunctions](../VS_csharp/languageprimitives.intrinsicfunctions-module--fsharp-.md)|The F# compiler emits calls to some of the functions in this module as part of the compiled form of some language constructs|  
|module [IntrinsicOperators](../VS_csharp/languageprimitives.intrinsicoperators-module--fsharp-.md)|The F# compiler emits calls to some of the functions in this module as part of the compiled form of some language constructs|  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[AdditionDynamic](../VS_csharp/languageprimitives.additiondynamic--t1--t2--u--function--fsharp-.md)  `: 'T1 -> 'T2 -> 'U`|A compiler intrinsic that implements dynamic invocations to the `+` operator.|  
|[CheckedAdditionDynamic](../VS_csharp/languageprimitives.checkedadditiondynamic--t1--t2--u--function--fsharp-.md)  `: 'T1 -> 'T2 -> 'U`|A compiler intrinsic that implements dynamic invocations to the checked `+` operator.|  
|[CheckedMultiplyDynamic](../VS_csharp/languageprimitives.checkedmultiplydynamic--t1--t2--u--function--fsharp-.md)  `: 'T1 -> 'T2 -> 'U`|A compiler intrinsic that implements dynamic invocations to the checked `+` operator.|  
|[DecimalWithMeasure](../VS_csharp/languageprimitives.decimalwithmeasure--u--function--fsharp-.md)  `: decimal -> decimal<'u>`|Creates a decimal value with units-of-measure|  
|[DivideByInt](../VS_csharp/languageprimitives.dividebyint-^t--function--fsharp-.md)  `: ^T -> int -> ^T`|Divides a value by an integer.|  
|[DivideByIntDynamic](../VS_csharp/languageprimitives.dividebyintdynamic--t--function--fsharp-.md)  `: 'T -> int -> 'T`|A compiler intrinsic that implements dynamic invocations for the `DivideByInt` primitive.|  
|[EnumOfValue](../VS_csharp/languageprimitives.enumofvalue--t--enum--function--fsharp-.md)  `: 'T -> enum`|Creates an enumeration value from an underlying value.|  
|[EnumToValue](../VS_csharp/languageprimitives.enumtovalue--enum--t--function--fsharp-.md)  `: 'Enum -> 'T`|Gets the underlying value for an enumeration value.|  
|[FastGenericComparer](../VS_csharp/languageprimitives.fastgenericcomparer--t--type-function--fsharp-.md)  `: IComparer<'T>`|Creates an F# comparer object for the given type|  
|[FastGenericEqualityComparer](../VS_csharp/languageprimitives.fastgenericequalitycomparer--t--type-function--fsharp-.md)  `: IEqualityComparer<'T>`|Create an F# hash/equality object for the given type|  
|[FastLimitedGenericEqualityComparer](../VS_csharp/languageprimitives.fastlimitedgenericequalitycomparer--t--function--fsharp-.md)  `: int -> IEqualityComparer<'T>`|Create an F# hash/equality object for the given type using node-limited hashing when hashing F# records, lists and union types.|  
|[Float32WithMeasure](../VS_csharp/languageprimitives.float32withmeasure--measure--function.md)  `: float -> float<'u>`|Creates a `float32` value with units-of-measure.|  
|[FloatWithMeasure](../VS_csharp/languageprimitives.floatwithmeasure--measure--function.md)  `: float32 -> float32<'u>`|Creates a `float` value with units-of-measure.|  
|[GenericComparer](../VS_csharp/languageprimitives.genericcomparer-function--fsharp-.md)  `: IComparer`|A static F# comparer object.|  
|[GenericComparison](../VS_csharp/languageprimitives.genericcomparison--t--function--fsharp-.md)  `: 'T -> 'T -> int`|Compares two values.|  
|[GenericComparisonWithComparer](../VS_csharp/languageprimitives.genericcomparisonwithcomparer--t--function--fsharp-.md)  `: IComparer -> 'T -> 'T -> int`|Compare two values. May be called as a recursive case from an implementation of <xref:System.IComparable`1*> to ensure consistent NaN comparison semantics.|  
|[GenericEquality](../VS_csharp/languageprimitives.genericequality--t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Compares two values for equality using partial equivalence relation semantics ([nan] <> [nan]).|  
|[GenericEqualityComparer](../VS_csharp/languageprimitives.genericequalitycomparer-function--fsharp-.md)  `: IEqualityComparer`|Returns an F# comparer object suitable for hashing and equality. This hashing behavior of the returned comparer is not limited by an overall node count when hashing F# records, lists and union types.|  
|[GenericEqualityER](../VS_csharp/languageprimitives.genericequalityer--t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Compares two values for equality using equivalence relation semantics ([nan] = [nan]).|  
|[GenericEqualityERComparer](../VS_csharp/languageprimitives.genericequalityercomparer-function--fsharp-.md)  `: IEqualityComparer`|Return an F# comparer object suitable for hashing and equality. This hashing behavior of the returned comparer is not limited by an overall node count when hashing F# records, lists and union types. This equality comparer has equivalence relation semantics ([nan] = [nan]).|  
|[GenericEqualityWithComparer](../VS_csharp/languageprimitives.genericequalitywithcomparer--t--function--fsharp-.md)  `: IEqualityComparer -> 'T -> 'T -> bool`|Compare two values for equality|  
|[GenericGreaterOrEqual](../VS_csharp/languageprimitives.genericgreaterorequal--t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Compares two values|  
|[GenericGreaterThan](../VS_csharp/languageprimitives.genericgreaterthan--t--function--fsharp-.md) `: 'T -> 'T -> bool`|Compares two values|  
|[GenericHash](../VS_csharp/languageprimitives.generichash--t--function--fsharp-.md)  `: 'T -> int`|Hashes a value according to its structure. This hash is not limited by an overall node count when hashing F# records, lists and union types.|  
|[GenericHashWithComparer](../VS_csharp/languageprimitives.generichashwithcomparer--t--function--fsharp-.md)  `: IEqualityComparer -> 'T -> int`|Recursively hashes a part of a value according to its structure.|  
|[GenericLessOrEqual](../VS_csharp/languageprimitives.genericlessorequal--t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Compares two values|  
|[GenericLessThan](../VS_csharp/languageprimitives.genericlessthan--t--function--fsharp-.md)  `: 'T -> 'T -> bool`|Compares two values|  
|[GenericLimitedHash](../VS_csharp/languageprimitives.genericlimitedhash--t--function--fsharp-.md) `: int -> 'T -> int`|Hashes a value according to its structure. Use the given limit to restrict the hash when hashing F# records, lists and union types.|  
|[GenericMaximum](../VS_csharp/languageprimitives.genericmaximum--t--function--fsharp-.md)  `: 'T -> 'T -> 'T`|Takes the maximum of two values structurally according to the order given by [GenericComparison](../VS_csharp/languageprimitives.genericcomparison--t--function--fsharp-.md).|  
|[GenericMinimum](../VS_csharp/languageprimitives.genericminimum--t--function--fsharp-.md)  `: 'T -> 'T -> 'T`|Takes the minimum of two values structurally according to the order given by [GenericComparison](../VS_csharp/languageprimitives.genericcomparison--t--function--fsharp-.md).|  
|[GenericOne](../VS_csharp/languageprimitives.genericone-^t--type-function--fsharp-.md) `: ^T`|Resolves to the one value for any primitive numeric type or any type with a static member called `One`.|  
|[GenericOneDynamic](../VS_csharp/languageprimitives.genericonedynamic--t--function--fsharp-.md)  `: unit -> 'T`|Resolves to the one value for any primitive numeric type or any type with a static member called `One`..|  
|[GenericZero](../VS_csharp/languageprimitives.genericzero-^t--type-function--fsharp-.md)  `: ^T`|Resolves to the zero value for any primitive numeric type or any type with a static member called `Zero`.|  
|[GenericZeroDynamic](../VS_csharp/languageprimitives.genericzerodynamic--t--function--fsharp-.md) `: unit -> 'T`|Resolves to the zero value for any primitive numeric type or any type with a static member called `Zero`.|  
|[Int16WithMeasure](../VS_csharp/languageprimitives.int16withmeasure--measure--function.md)  `: int16 -> int16<'u>`|Creates an `int16` value with units-of-measure|  
|[Int32WithMeasure](../VS_csharp/languageprimitives.int32withmeasure--measure--function.md)  `: int32 -> int32<'u>`|Creates an `int32` value with units-of-measure|  
|[Int64WithMeasure](../VS_csharp/languageprimitives.int64withmeasure--measure--function.md)  `: int64 -> int64<'u>`|Creates an `int64` value with units-of-measure|  
|[MultiplyDynamic](../VS_csharp/languageprimitives.multiplydynamic--t1--t2--u--function--fsharp-.md)  `: 'T1 -> 'T2 -> 'U`|A compiler intrinsic that implements dynamic invocations to the `+` operator.|  
|[ParseInt32](../VS_csharp/languageprimitives.parseint32-function--fsharp-.md)  `: string -> int32`|Parses an `int32` according to the rules used by the overloaded `int32` conversion operator when applied to strings|  
|[ParseInt64](../VS_csharp/languageprimitives.parseint64-function--fsharp-.md)  `: string -> int64`|Parses an `int64` according to the rules used by the overloaded `int64` conversion operator when applied to strings|  
|[ParseUInt32](../VS_csharp/languageprimitives.parseuint32-function--fsharp-.md)  `: string -> uint32`|Parses an `uint32` according to the rules used by the overloaded `uint32` conversion operator when applied to strings|  
|[ParseUInt64](../VS_csharp/languageprimitives.parseuint64-function--fsharp-.md)  `: string -> uint64`|Parses an `uint64` according to the rules used by the overloaded `uint64` conversion operator when applied to strings|  
|[PhysicalEquality](../VS_csharp/languageprimitives.physicalequality--t--function--fsharp-.md) `: 'T -> 'T -> bool`|Reference/physical equality. True if boxed versions of the inputs are reference-equal, OR if both are primitive numeric types and the implementation of <xref:System.Object.Equals*> for the type of the first argument returns true on the boxed versions of the inputs.|  
|[PhysicalHash](../VS_csharp/languageprimitives.physicalhash--t--function--fsharp-.md) `: 'T -> int`|The physical hash. Hashes on the object identity, except for value types, where we hash on the contents.|  
|[SByteWithMeasure](../VS_csharp/languageprimitives.sbytewithmeasure--measure--function.md) `: sbyte -> sbyte<'u>`|Creates an `sbyte` value with units-of-measure|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)