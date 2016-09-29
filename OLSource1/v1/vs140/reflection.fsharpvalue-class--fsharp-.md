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
|[GetExceptionFields](../vs140/fsharpvalue.getexceptionfields-method--fsharp-.md)|Reads all the fields from a value built using an instance of an F# exception declaration.|  
|[GetRecordField](../vs140/fsharpvalue.getrecordfield-method--fsharp-.md)|Reads a field from a record value.|  
|[GetRecordFields](../vs140/fsharpvalue.getrecordfields-method--fsharp-.md)|Reads all the fields from a record value.|  
|[GetTupleField](../vs140/fsharpvalue.gettuplefield-method--fsharp-.md)|Reads a field from a tuple value.|  
|[GetTupleFields](../vs140/fsharpvalue.gettuplefields-method--fsharp-.md)|Reads all fields from a tuple.|  
|[GetUnionFields](../vs140/fsharpvalue.getunionfields-method--fsharp-.md)|Identify the union case and its fields for an object.|  
|[MakeFunction](../vs140/fsharpvalue.makefunction-method--fsharp-.md)|Creates a typed function from object from a dynamic function implementation.|  
|[MakeRecord](../vs140/fsharpvalue.makerecord-method--fsharp-.md)|Creates an instance of a record type.|  
|[MakeTuple](../vs140/fsharpvalue.maketuple-method--fsharp-.md)|Creates an instance of a tuple type.|  
|[MakeUnion](../vs140/fsharpvalue.makeunion-method--fsharp-.md)|Create a union case value.|  
|[PreComputeRecordConstructor](../vs140/fsharpvalue.precomputerecordconstructor-method--fsharp-.md)|Precompute a function for constructing a record value.|  
|[PreComputeRecordConstructorInfo](../vs140/fsharpvalue.precomputerecordconstructorinfo-method--fsharp-.md)|Get a <xref:System.Reflection.ConstructorInfo*> for a record type.|  
|[PreComputeRecordFieldReader](../vs140/fsharpvalue.precomputerecordfieldreader-method--fsharp-.md)|Precompute a function for reading a particular field from a record.|  
|[PreComputeRecordReader](../vs140/fsharpvalue.precomputerecordreader-method--fsharp-.md)|Precompute a function for reading all the fields from a record. The fields are returned in the same order as the fields reported by a call to Microsoft.FSharp.Reflection.Type.GetInfo for this type.|  
|[PreComputeTupleConstructor](../vs140/fsharpvalue.precomputetupleconstructor-method--fsharp-.md)|Precomputes a function for reading the values of a particular tuple type.|  
|[PreComputeTupleConstructorInfo](../vs140/fsharpvalue.precomputetupleconstructorinfo-method--fsharp-.md)|Gets a method that constructs objects of the given tuple type. For small tuples, no additional type will be returned.|  
|[PreComputeTuplePropertyInfo](../vs140/fsharpvalue.precomputetuplepropertyinfo-method--fsharp-.md)|Gets information that indicates how to read a field of a tuple.|  
|[PreComputeTupleReader](../vs140/fsharpvalue.precomputetuplereader-method--fsharp-.md)|Precomputes a function for reading the values of a particular tuple type.|  
|[PreComputeUnionConstructor](../vs140/fsharpvalue.precomputeunionconstructor-method--fsharp-.md)|Precomputes a function for constructing a discriminated union value for a particular union case.|  
|[PreComputeUnionConstructorInfo](../vs140/fsharpvalue.precomputeunionconstructorinfo-method--fsharp-.md)|A method that constructs objects of the given case.|  
|[PreComputeUnionReader](../vs140/fsharpvalue.precomputeunionreader-method--fsharp-.md)|Precomputes a function for reading all the fields for a particular discriminator case of a union type.|  
|[PreComputeUnionTagMemberInfo](../vs140/fsharpvalue.precomputeuniontagmemberinfo-method--fsharp-.md)|Precomputes a property or static method for reading an integer representing the case tag of a union type.|  
|[PreComputeUnionTagReader](../vs140/fsharpvalue.precomputeuniontagreader-method--fsharp-.md)|Precomputes a function that reads the tags of a union type.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)