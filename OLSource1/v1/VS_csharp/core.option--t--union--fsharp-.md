---
title: "Core.Option&lt;&#39;T&gt; Union (F#)"
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
  - "Core.Option<'T> Union (F#)"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.FSharpOption`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "None union case [F#]"
  - "Option union [F#]"
  - "FSharpOption union [F#]"
  - "Some union case [F#]"
ms.assetid: b08add48-34bf-4410-80a1-ef6a8daddc58
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.Option&lt;&#39;T&gt; Union (F#)
Specifies the type of optional values, which you use when there might or might not be a value.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<DefaultAugmentation(false)>]  
[<StructuralEquality>]  
[<StructuralComparison>]  
type Option<'T> =  
| None  
| Some of 'T  
 with  
  interface IStructuralEquatable  
  interface IComparable  
  interface IComparable  
  interface IStructuralComparable  
  static member Some : 'T -> 'T option  
  member this.IsNone :  bool  
  member this.IsSome :  bool  
  static member None :  'T option  
  member this.Value :  'T  
 end  
```  
  
## Remarks  
 Use the constructors `Some` and `None`to create values of this type. Use the values in the [Option module](../VS_csharp/core.option-module--fsharp-.md) to manipulate values of this type, or pattern match against the values directly. `None` values appear as the value `null` to other .NET Framework languages. Instance methods of this type appear as static methods to other .NET Framework languages because of the use of `null` as a value representation.  
  
 For an overview of options, see [Options (F#)](../VS_csharp/options--fsharp-.md).  
  
 This type is named `FSharpOption` in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[IsNone](../VS_csharp/option.isnone--t--property--fsharp-.md)|Returns `true` if the option is a `None` value.|  
|[IsSome](../VS_csharp/option.issome--t--property--fsharp-.md)|Returns `true` if the option is a `Some` value.|  
|[Value](../VS_csharp/option.value--t--property--fsharp-.md)|Gets the value of a `Some` option. A `NullReferenceException` is raised if the option is `None`.|  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[None](../VS_csharp/option.none--t--property--fsharp-.md)|Creates an option value that is a `None` value.|  
|[Some](../VS_csharp/option.some--t--method--fsharp-.md)|Creates an option value that is a `Some` value.|  
  
## Union Cases  
  
|Case|Description|  
|----------|-----------------|  
|`None`|Specifies that there is no value.|  
|`Some of 'T`|Contains the value, when there is a value.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)