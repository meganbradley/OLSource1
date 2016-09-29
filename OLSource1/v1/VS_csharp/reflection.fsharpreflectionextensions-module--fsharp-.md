---
title: "Reflection.FSharpReflectionExtensions Module (F#)"
ms.custom: na
ms.date: "09/23/2016"
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
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpReflectionExtensions"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpReflectionExtensions module"
ms.assetid: 3ec09ab8-f1db-47ee-957d-b4c622949056
caps.latest.revision: 5
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reflection.FSharpReflectionExtensions Module (F#)
A module of extension members that provides versions of certain F# reflection APIs for use with the .NET portable library.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection.FSharpReflectionExtensions  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module FSharpReflectionExtensions =  type FSharpType with    static member GetExceptionFields : Type * ?bool -> PropertyInfo []  
    static member GetRecordFields : Type * ?bool -> PropertyInfo []  
    static member GetUnionCases : Type * ?bool -> UnionCaseInfo []  
    static member IsExceptionRepresentation : Type * ?bool -> bool  
    static member IsRecord : Type * ?bool -> bool  
    static member IsUnion : Type * ?bool -> bool  
  type FSharpValue with    static member GetExceptionFields : obj * ?bool -> obj []  
    static member GetRecordFields : obj * ?bool -> obj []  
    static member GetUnionFields : obj * Type * ?bool -> UnionCaseInfo * obj []  
    static member MakeRecord : Type * obj [] * ?bool -> obj  
    static member MakeUnion : UnionCaseInfo * obj [] * ?bool -> obj  
    static member PreComputeRecordConstructor : Type * ?bool -> obj [] -> obj  
    static member PreComputeRecordConstructorInfo : Type * ?bool -> ConstructorInfo  
    static member PreComputeRecordFieldReader : PropertyInfo -> obj -> obj  
    static member PreComputeRecordReader : Type * ?bool -> obj -> obj []  
    static member PreComputeUnionConstructor : UnionCaseInfo * ?bool -> obj [] -> obj  
    static member PreComputeUnionConstructorInfo : UnionCaseInfo * ?bool -> MethodInfo  
    static member PreComputeUnionReader : UnionCaseInfo * ?bool -> obj -> obj []  
    static member PreComputeUnionTagMemberInfo : Type * ?bool -> MemberInfo  
    static member PreComputeUnionTagReader : Type * ?bool -> obj -> int  
```  
  
## Remarks  
 The .NET portable library does not have the <xref:System.Reflection.BindingFlags*> type, so these methods provide alternative versions of certain methods on the [FSharpType](../VS_csharp/reflection.fsharptype-class--fsharp-.md) and [FSharpValue](../VS_csharp/reflection.fsharpvalue-class--fsharp-.md) types that take a `bool` as a parameter instead of <xref:System.Reflection.BindingFlags*>. For other methods, use the [FSharpType](../VS_csharp/reflection.fsharptype-class--fsharp-.md) and [FSharpValue](../VS_csharp/reflection.fsharpvalue-class--fsharp-.md) types directly.  
  
## Extension Members  
  
|Extension Member|Description|  
|----------------------|-----------------|  
|[FSharpType.GetExceptionFields](../VS_csharp/fsharptype.getexceptionfields-method--fsharp-.md)|Reads all the fields from an F# exception declaration, in declaration order.|  
|[FSharpType.GetRecordFields](../VS_csharp/fsharptype.getrecordfields-method--fsharp-.md)|Reads all the fields from a record value, in declaration order.|  
|[FSharpType.GetUnionCases](../VS_csharp/fsharptype.getunioncases-method--fsharp-.md)|Gets the cases of a union type.|  
|[FSharpType.IsExceptionRepresentation](../VS_csharp/fsharptype.isexceptionrepresentation-method--fsharp-.md)|Returns true if the given type is a representation of an F# exception declaration.|  
|[FSharpType.IsRecord](../VS_csharp/fsharptype.isrecord-method--fsharp-.md)|Returns true if the type is a representation of an F# record type.|  
|[FSharpType.IsUnion](../VS_csharp/fsharptype.isunion-method--fsharp-.md)|Returns true if the given type is a representation of an F# union type or the runtime type of a value of that type.|  
|[FSharpValue.GetExceptionFields](../VS_csharp/fsharpvalue.getexceptionfields-method--fsharp-.md)|Reads all the fields from a value built using an instance of an F# exception declaration.|  
|[FSharpValue.GetRecordFields](../VS_csharp/fsharpvalue.getrecordfields-method--fsharp-.md)|Reads all the fields from a record value.|  
|[FSharpValue.GetUnionFields](../VS_csharp/fsharpvalue.getunionfields-method--fsharp-.md)|Identify the union case and its fields for an object.|  
|[FSharpValue.MakeRecord](../VS_csharp/fsharpvalue.makerecord-method--fsharp-.md)|Creates an instance of a record type.|  
|[FSharpValue.MakeUnion](../VS_csharp/fsharpvalue.makeunion-method--fsharp-.md)|Create a union case value.|  
|[FSharpValue.PreComputeRecordConstructor](../VS_csharp/fsharpvalue.precomputerecordconstructor-method--fsharp-.md)|Precompute a function for constructing a record value.|  
|[FSharpValue.PreComputeRecordConstructorInfo](../VS_csharp/fsharpvalue.precomputerecordconstructorinfo-method--fsharp-.md)|Get a ConstructorInfo for a record type.|  
|[FSharpValue.PreComputeRecordReader](../VS_csharp/fsharpvalue.precomputerecordreader-method--fsharp-.md)|Precompute a function for reading all the fields from a record. The fields are returned in the same order as the fields reported by a call to Microsoft.FSharp.Reflection.Type.GetInfo for this type.|  
|[FSharpValue.PreComputeUnionConstructor](../VS_csharp/fsharpvalue.precomputeunionconstructor-method--fsharp-.md)|Precomputes a function for constructing a discriminated union value for a particular union case.|  
|[FSharpValue.PreComputeUnionConstructorInfo](../VS_csharp/fsharpvalue.precomputeunionconstructorinfo-method--fsharp-.md)|A method that constructs objects of the given case.|  
|[FSharpValue.PreComputeUnionReader](../VS_csharp/fsharpvalue.precomputeunionreader-method--fsharp-.md)|Precomputes a function for reading all the fields for a particular discriminator case of a union type.|  
|[FSharpValue.PreComputeUnionTagMemberInfo](../VS_csharp/fsharpvalue.precomputeuniontagmemberinfo-method--fsharp-.md)FSharpValue.PreComputeUnionTagMemberInfo|Precompute a property or static method for reading an integer representing the case tag of a union type.|  
|[FSharpValue.PreComputeUnionTagReader](../VS_csharp/fsharpvalue.precomputeuniontagreader-method--fsharp-.md)|Precompute an optimized function to read the tags of the given union type.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Reflection Namespace (F#)](../VS_csharp/microsoft.fsharp.reflection-namespace--fsharp-.md)   
 [Reflection.FSharpType Class (F#)](../VS_csharp/reflection.fsharptype-class--fsharp-.md)   
 [Reflection.FSharpValue Class (F#)](../VS_csharp/reflection.fsharpvalue-class--fsharp-.md)