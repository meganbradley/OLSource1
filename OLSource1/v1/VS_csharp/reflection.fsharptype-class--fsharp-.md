---
title: "Reflection.FSharpType Class (F#)"
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
  - "Reflection.FSharpType"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpType"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpType class [F#]"
ms.assetid: e3304409-1849-4058-957a-872a376e3663
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reflection.FSharpType Class (F#)
Contains operations associated with constructing and analyzing F# types such as records, unions and tuples.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AbstractClass>]  
[<Sealed>]  
type FSharpType =  
 class  
  static member GetExceptionFields : Type * ?BindingFlags -> PropertyInfo []  
  static member GetFunctionElements : Type -> Type * Type  
  static member GetRecordFields : Type * ?BindingFlags -> PropertyInfo []  
  static member GetTupleElements : Type -> Type []  
  static member GetUnionCases : Type * ?BindingFlags -> UnionCaseInfo []  
  static member IsExceptionRepresentation : Type * ?BindingFlags -> bool  
  static member IsFunction : Type -> bool  
  static member IsModule : Type -> bool  
  static member IsRecord : Type * ?BindingFlags -> bool  
  static member IsTuple : Type -> bool  
  static member IsUnion : Type * ?BindingFlags -> bool  
  static member MakeFunctionType : Type * Type -> Type  
  static member MakeTupleType : Type [] -> Type  
 end  
```  
  
## Remarks  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[GetExceptionFields](../VS_csharp/fsharptype.getexceptionfields-method--fsharp-.md)|Reads all the fields from an F# exception declaration, in declaration order.|  
|[GetFunctionElements](../VS_csharp/fsharptype.getfunctionelements-method--fsharp-.md)|Gets the domain and range types from an F# function type or from the runtime type of a closure implementing an F# type.|  
|[GetRecordFields](../VS_csharp/fsharptype.getrecordfields-method--fsharp-.md)|Reads all the fields from a record value, in declaration order.|  
|[GetTupleElements](../VS_csharp/fsharptype.gettupleelements-method--fsharp-.md)|Gets the tuple elements from the representation of an F# tuple type.|  
|[GetUnionCases](../VS_csharp/fsharptype.getunioncases-method--fsharp-.md)|Gets the cases of a union type.|  
|[IsExceptionRepresentation](../VS_csharp/fsharptype.isexceptionrepresentation-method--fsharp-.md)|Returns `true` if the specified type is a representation of an F# exception declaration.|  
|[IsFunction](../VS_csharp/fsharptype.isfunction-method--fsharp-.md)|Returns `true` if the specified type is a representation of an F# function type or the runtime type of a closure implementing an F# function type.|  
|[IsModule](../VS_csharp/fsharptype.ismodule-method--fsharp-.md)|Returns `true` if the specified type is a <xref:System.Type*> value corresponding to the compiled form of an F# module.|  
|[IsRecord](../VS_csharp/fsharptype.isrecord-method--fsharp-.md)|Returns `true` if the specified type is a representation of an F# record type.|  
|[IsTuple](../VS_csharp/fsharptype.istuple-method--fsharp-.md)|Returns `true` if the specified type is a representation of an F# tuple type.|  
|[IsUnion](../VS_csharp/fsharptype.isunion-method--fsharp-.md)|Returns `true` if the specified type is a representation of an F# union type or the runtime type of a value of that type.|  
|[MakeFunctionType](../VS_csharp/fsharptype.makefunctiontype-method--fsharp-.md)|Returns a <xref:System.Type*> `object` representing the F# function type with the given domain and range.|  
|[MakeTupleType](../VS_csharp/fsharptype.maketupletype-method--fsharp-.md)|Returns a <xref:System.Type*> representing an F# tuple type with the given element types.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Reflection Namespace (F#)](../VS_csharp/microsoft.fsharp.reflection-namespace--fsharp-.md)