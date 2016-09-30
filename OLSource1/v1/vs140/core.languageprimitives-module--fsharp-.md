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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
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
|[AdditionDynamic](../vs140/languageprimitives.additiondynamic--t1--t2--u--function--fsharp-.md)  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A compiler intrinsic that implements dynamic invocations to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator.|  
|[CheckedAdditionDynamic](../vs140/languageprimitives.checkedadditiondynamic--t1--t2--u--function--fsharp-.md)  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|A compiler intrinsic that implements dynamic invocations to the checked <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator.|  
|[CheckedMultiplyDynamic](../vs140/languageprimitives.checkedmultiplydynamic--t1--t2--u--function--fsharp-.md)  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|A compiler intrinsic that implements dynamic invocations to the checked <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operator.|  
|[DecimalWithMeasure](../vs140/languageprimitives.decimalwithmeasure--u--function--fsharp-.md)  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Creates a decimal value with units-of-measure|  
|[DivideByInt](../vs140/languageprimitives.dividebyint-^t--function--fsharp-.md)  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Divides a value by an integer.|  
|[DivideByIntDynamic](../vs140/languageprimitives.dividebyintdynamic--t--function--fsharp-.md)  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|A compiler intrinsic that implements dynamic invocations for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> primitive.|  
|[EnumOfValue](../vs140/languageprimitives.enumofvalue--t--enum--function--fsharp-.md)  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Creates an enumeration value from an underlying value.|  
|[EnumToValue](../vs140/languageprimitives.enumtovalue--enum--t--function--fsharp-.md)  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Gets the underlying value for an enumeration value.|  
|[FastGenericComparer](../vs140/languageprimitives.fastgenericcomparer--t--type-function--fsharp-.md)  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Creates an F# comparer object for the given type|  
|[FastGenericEqualityComparer](../vs140/languageprimitives.fastgenericequalitycomparer--t--type-function--fsharp-.md)  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Create an F# hash/equality object for the given type|  
|[FastLimitedGenericEqualityComparer](../vs140/languageprimitives.fastlimitedgenericequalitycomparer--t--function--fsharp-.md)  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Create an F# hash/equality object for the given type using node-limited hashing when hashing F# records, lists and union types.|  
|[Float32WithMeasure](../vs140/languageprimitives.float32withmeasure--measure--function.md)  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Creates a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> value with units-of-measure.|  
|[FloatWithMeasure](../vs140/languageprimitives.floatwithmeasure--measure--function.md)  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Creates a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> value with units-of-measure.|  
|[GenericComparer](../vs140/languageprimitives.genericcomparer-function--fsharp-.md)  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|A static F# comparer object.|  
|[GenericComparison](../vs140/languageprimitives.genericcomparison--t--function--fsharp-.md)  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Compares two values.|  
|[GenericComparisonWithComparer](../vs140/languageprimitives.genericcomparisonwithcomparer--t--function--fsharp-.md)  <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Compare two values. May be called as a recursive case from an implementation of <xref:System.IComparable<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>: 'T -> 'T -> bool<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>: IEqualityComparer<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>: 'T -> 'T -> bool<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>: IEqualityComparer<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>: IEqualityComparer -> 'T -> 'T -> bool<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>: 'T -> 'T -> bool<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>: 'T -> 'T -> bool<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>: 'T -> int<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>: IEqualityComparer -> 'T -> int<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>: 'T -> 'T -> bool<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>: 'T -> 'T -> bool<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>: int -> 'T -> int<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>: 'T -> 'T -> 'T<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>: 'T -> 'T -> 'T<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>: ^T<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>One<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>: unit -> 'T<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>One<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>: ^T<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>Zero<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>: unit -> 'T<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>Zero<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>: int16 -> int16\<'u><CodeContentPlaceHolder>46\</CodeContentPlaceHolder>int16<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>: int32 -> int32\<'u><CodeContentPlaceHolder>48\</CodeContentPlaceHolder>int32<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>: int64 -> int64\<'u><CodeContentPlaceHolder>50\</CodeContentPlaceHolder>int64<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>: 'T1 -> 'T2 -> 'U<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>+<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>: string -> int32<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>int32<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>int32<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>: string -> int64<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>int64<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>int64<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>: string -> uint32<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>uint32<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>uint32<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>: string -> uint64<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>uint64<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>uint64<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>: 'T -> 'T -> bool<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>: 'T -> int<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>: sbyte -> sbyte\<'u><CodeContentPlaceHolder>68\</CodeContentPlaceHolder>sbyte` value with units-of-measure|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)