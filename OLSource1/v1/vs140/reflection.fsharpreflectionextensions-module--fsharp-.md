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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The .NET portable library does not have the \<xref:System.Reflection.BindingFlags*> type, so these methods provide alternative versions of certain methods on the [FSharpType](../vs140/reflection.fsharptype-class--fsharp-.md) and [FSharpValue](../vs140/reflection.fsharpvalue-class--fsharp-.md) types that take a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> as a parameter instead of \<xref:System.Reflection.BindingFlags*>. For other methods, use the [FSharpType](../vs140/reflection.fsharptype-class--fsharp-.md) and [FSharpValue](../vs140/reflection.fsharpvalue-class--fsharp-.md) types directly.  
  
## Extension Members  
  
|Extension Member|Description|  
|----------------------|-----------------|  
|[FSharpType.GetExceptionFields](../vs140/fsharptype.getexceptionfields-method--fsharp-.md)|Reads all the fields from an F# exception declaration, in declaration order.|  
|[FSharpType.GetRecordFields](../vs140/fsharptype.getrecordfields-method--fsharp-.md)|Reads all the fields from a record value, in declaration order.|  
|[FSharpType.GetUnionCases](../vs140/fsharptype.getunioncases-method--fsharp-.md)|Gets the cases of a union type.|  
|[FSharpType.IsExceptionRepresentation](../vs140/fsharptype.isexceptionrepresentation-method--fsharp-.md)|Returns true if the given type is a representation of an F# exception declaration.|  
|[FSharpType.IsRecord](../vs140/fsharptype.isrecord-method--fsharp-.md)|Returns true if the type is a representation of an F# record type.|  
|[FSharpType.IsUnion](../vs140/fsharptype.isunion-method--fsharp-.md)|Returns true if the given type is a representation of an F# union type or the runtime type of a value of that type.|  
|[FSharpValue.GetExceptionFields](../vs140/fsharpvalue.getexceptionfields-method--fsharp-.md)|Reads all the fields from a value built using an instance of an F# exception declaration.|  
|[FSharpValue.GetRecordFields](../vs140/fsharpvalue.getrecordfields-method--fsharp-.md)|Reads all the fields from a record value.|  
|[FSharpValue.GetUnionFields](../vs140/fsharpvalue.getunionfields-method--fsharp-.md)|Identify the union case and its fields for an object.|  
|[FSharpValue.MakeRecord](../vs140/fsharpvalue.makerecord-method--fsharp-.md)|Creates an instance of a record type.|  
|[FSharpValue.MakeUnion](../vs140/fsharpvalue.makeunion-method--fsharp-.md)|Create a union case value.|  
|[FSharpValue.PreComputeRecordConstructor](../vs140/fsharpvalue.precomputerecordconstructor-method--fsharp-.md)|Precompute a function for constructing a record value.|  
|[FSharpValue.PreComputeRecordConstructorInfo](../vs140/fsharpvalue.precomputerecordconstructorinfo-method--fsharp-.md)|Get a ConstructorInfo for a record type.|  
|[FSharpValue.PreComputeRecordReader](../vs140/fsharpvalue.precomputerecordreader-method--fsharp-.md)|Precompute a function for reading all the fields from a record. The fields are returned in the same order as the fields reported by a call to Microsoft.FSharp.Reflection.Type.GetInfo for this type.|  
|[FSharpValue.PreComputeUnionConstructor](../vs140/fsharpvalue.precomputeunionconstructor-method--fsharp-.md)|Precomputes a function for constructing a discriminated union value for a particular union case.|  
|[FSharpValue.PreComputeUnionConstructorInfo](../vs140/fsharpvalue.precomputeunionconstructorinfo-method--fsharp-.md)|A method that constructs objects of the given case.|  
|[FSharpValue.PreComputeUnionReader](../vs140/fsharpvalue.precomputeunionreader-method--fsharp-.md)|Precomputes a function for reading all the fields for a particular discriminator case of a union type.|  
|[FSharpValue.PreComputeUnionTagMemberInfo](../vs140/fsharpvalue.precomputeuniontagmemberinfo-method--fsharp-.md)FSharpValue.PreComputeUnionTagMemberInfo|Precompute a property or static method for reading an integer representing the case tag of a union type.|  
|[FSharpValue.PreComputeUnionTagReader](../vs140/fsharpvalue.precomputeuniontagreader-method--fsharp-.md)|Precompute an optimized function to read the tags of the given union type.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)   
 [Reflection.FSharpType Class (F#)](../vs140/reflection.fsharptype-class--fsharp-.md)   
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)