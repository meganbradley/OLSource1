---
title: "Reflection.FSharpValue Class (F#)"
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
  - "Reflection.FSharpValue"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpValue class [F#]"
ms.assetid: 37ecfa9f-1f47-4957-bb2c-a2664e9a68d0
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reflection.FSharpValue Class (F#)
Contains operations associated with constructing and analyzing values associated with F# types such as records, unions and tuples.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AbstractClass>]  
[<Sealed>]  
type FSharpValue =  
 class  
  static member GetExceptionFields : obj * ?BindingFlags -> obj []  
  static member GetRecordField : obj * PropertyInfo -> obj  
  static member GetRecordFields : obj * ?BindingFlags -> obj []  
  static member GetTupleField : obj * int -> obj  
  static member GetTupleFields : obj -> obj []  
  static member GetUnionFields : obj * Type * ?BindingFlags -> UnionCaseInfo * obj []  
  static member MakeFunction : Type * (obj -> obj) -> obj  
  static member MakeRecord : Type * obj [] * ?BindingFlags -> obj  
  static member MakeTuple : obj [] * Type -> obj  
  static member MakeUnion : UnionCaseInfo * obj [] * ?BindingFlags -> obj  
  static member PreComputeRecordConstructor : Type * ?BindingFlags -> obj [] -> obj  
  static member PreComputeRecordConstructorInfo : Type * ?BindingFlags -> ConstructorInfo  
  static member PreComputeRecordFieldReader : PropertyInfo -> obj -> obj  
  static member PreComputeRecordReader : Type * ?BindingFlags -> obj -> obj []  
  static member PreComputeTupleConstructor : Type -> obj [] -> obj  
  static member PreComputeTupleConstructorInfo : Type -> ConstructorInfo * Type option  
  static member PreComputeTuplePropertyInfo : Type * int -> PropertyInfo * Type * int option  
  static member PreComputeTupleReader : Type -> obj -> obj []  
  static member PreComputeUnionConstructor : UnionCaseInfo * ?BindingFlags -> obj [] -> obj  
  static member PreComputeUnionConstructorInfo : UnionCaseInfo * ?BindingFlags -> MethodInfo  
  static member PreComputeUnionReader : UnionCaseInfo * ?BindingFlags -> obj -> obj []  
  static member PreComputeUnionTagMemberInfo : Type * ?BindingFlags -> MemberInfo  
  static member PreComputeUnionTagReader : Type * ?BindingFlags -> obj -> int  
 end  
```  
  
## Remarks  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[GetExceptionFields](../VS_csharp/fsharpvalue.getexceptionfields-method--fsharp-.md)|Reads all the fields from a value built using an instance of an F# exception declaration.|  
|[GetRecordField](../VS_csharp/fsharpvalue.getrecordfield-method--fsharp-.md)|Reads a field from a record value.|  
|[GetRecordFields](../VS_csharp/fsharpvalue.getrecordfields-method--fsharp-.md)|Reads all the fields from a record value.|  
|[GetTupleField](../VS_csharp/fsharpvalue.gettuplefield-method--fsharp-.md)|Reads a field from a tuple value.|  
|[GetTupleFields](../VS_csharp/fsharpvalue.gettuplefields-method--fsharp-.md)|Reads all fields from a tuple.|  
|[GetUnionFields](../VS_csharp/fsharpvalue.getunionfields-method--fsharp-.md)|Identify the union case and its fields for an object.|  
|[MakeFunction](../VS_csharp/fsharpvalue.makefunction-method--fsharp-.md)|Creates a typed function from object from a dynamic function implementation.|  
|[MakeRecord](../VS_csharp/fsharpvalue.makerecord-method--fsharp-.md)|Creates an instance of a record type.|  
|[MakeTuple](../VS_csharp/fsharpvalue.maketuple-method--fsharp-.md)|Creates an instance of a tuple type.|  
|[MakeUnion](../VS_csharp/fsharpvalue.makeunion-method--fsharp-.md)|Create a union case value.|  
|[PreComputeRecordConstructor](../VS_csharp/fsharpvalue.precomputerecordconstructor-method--fsharp-.md)|Precompute a function for constructing a record value.|  
|[PreComputeRecordConstructorInfo](../VS_csharp/fsharpvalue.precomputerecordconstructorinfo-method--fsharp-.md)|Get a <xref:System.Reflection.ConstructorInfo*> for a record type.|  
|[PreComputeRecordFieldReader](../VS_csharp/fsharpvalue.precomputerecordfieldreader-method--fsharp-.md)|Precompute a function for reading a particular field from a record.|  
|[PreComputeRecordReader](../VS_csharp/fsharpvalue.precomputerecordreader-method--fsharp-.md)|Precompute a function for reading all the fields from a record. The fields are returned in the same order as the fields reported by a call to Microsoft.FSharp.Reflection.Type.GetInfo for this type.|  
|[PreComputeTupleConstructor](../VS_csharp/fsharpvalue.precomputetupleconstructor-method--fsharp-.md)|Precomputes a function for reading the values of a particular tuple type.|  
|[PreComputeTupleConstructorInfo](../VS_csharp/fsharpvalue.precomputetupleconstructorinfo-method--fsharp-.md)|Gets a method that constructs objects of the given tuple type. For small tuples, no additional type will be returned.|  
|[PreComputeTuplePropertyInfo](../VS_csharp/fsharpvalue.precomputetuplepropertyinfo-method--fsharp-.md)|Gets information that indicates how to read a field of a tuple.|  
|[PreComputeTupleReader](../VS_csharp/fsharpvalue.precomputetuplereader-method--fsharp-.md)|Precomputes a function for reading the values of a particular tuple type.|  
|[PreComputeUnionConstructor](../VS_csharp/fsharpvalue.precomputeunionconstructor-method--fsharp-.md)|Precomputes a function for constructing a discriminated union value for a particular union case.|  
|[PreComputeUnionConstructorInfo](../VS_csharp/fsharpvalue.precomputeunionconstructorinfo-method--fsharp-.md)|A method that constructs objects of the given case.|  
|[PreComputeUnionReader](../VS_csharp/fsharpvalue.precomputeunionreader-method--fsharp-.md)|Precomputes a function for reading all the fields for a particular discriminator case of a union type.|  
|[PreComputeUnionTagMemberInfo](../VS_csharp/fsharpvalue.precomputeuniontagmemberinfo-method--fsharp-.md)|Precomputes a property or static method for reading an integer representing the case tag of a union type.|  
|[PreComputeUnionTagReader](../VS_csharp/fsharpvalue.precomputeuniontagreader-method--fsharp-.md)|Precomputes a function that reads the tags of a union type.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Reflection Namespace (F#)](../VS_csharp/microsoft.fsharp.reflection-namespace--fsharp-.md)