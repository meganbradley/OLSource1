---
title: "CA2236: Call base class methods on ISerializable types"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CA2236
  - CallBaseClassMethodsOnISerializableTypes
helpviewer_keywords: 
  - CA2236
  - CallBaseClassMethodsOnISerializableTypes
ms.assetid: 5a15b20d-769c-4640-b31a-36e07077daae
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CA2236: Call base class methods on ISerializable types
|||  
|-|-|  
|TypeName|CallBaseClassMethodsOnISerializableTypes|  
|CheckId|CA2236|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type derives from a type that implements the <xref:System.Runtime.Serialization.ISerializable?qualifyHint=True> interface, and one of the following conditions is true:  
  
-   The type implements the serialization constructor, that is, a constructor with the <xref:System.Runtime.Serialization.SerializationInfo?qualifyHint=True>, <xref:System.Runtime.Serialization.StreamingContext?qualifyHint=True> parameter signature, but does not call the serialization constructor of the base type.  
  
-   The type implements the <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=True> method but does not call the <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method of the base type.  
  
## Rule Description  
 In a custom serialization process, a type implements the <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method to serialize its fields and the serialization constructor to de-serialize the fields. If the type derives from a type that implements the <xref:System.Runtime.Serialization.ISerializable?qualifyHint=False> interface, the base type <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method and serialization constructor should be called to serialize/de-serialize the fields of the base type. Otherwise, the type will not be serialized and de-serialized correctly. Note that if the derived type does not add any new fields, the type does not need to implement the <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method nor the serialization constructor or call the base type equivalents.  
  
## How to Fix Violations  
 To fix a violation of this rule, call the base type <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method or serialization constructor from the corresponding derived type method or constructor.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a derived type that satisfies the rule by calling the serialization constructor and <xref:System.Runtime.Serialization.ISerializable.GetObjectData?qualifyHint=False> method of the base class.  
  
 [!code[FxCop.Usage.CallBaseISerializable#1](../vs140/codesnippet/VisualBasic/ca2236--call-base-class-methods-on-iserializable-types_1.vb)]
[!code[FxCop.Usage.CallBaseISerializable#1](../vs140/codesnippet/CSharp/ca2236--call-base-class-methods-on-iserializable-types_1.cs)]
  
  
## Related Rules  
 [Implement ISerializable correctly](../vs140/ca2240--implement-iserializable-correctly.md)  
  
 [Implement serialization constructors](../vs140/ca2229--implement-serialization-constructors.md)  
  
 [Implement serialization methods correctly](../vs140/ca2238--implement-serialization-methods-correctly.md)  
  
 [Mark all non-serializable fields](../vs140/ca2235--mark-all-non-serializable-fields.md)  
  
 [Mark ISerializable types with serializable](../vs140/ca2237--mark-iserializable-types-with-serializableattribute.md)  
  
 [Provide deserialization methods for optional fields](../vs140/ca2239--provide-deserialization-methods-for-optional-fields.md)  
  
 [Secure serialization constructors](../vs140/ca2120--secure-serialization-constructors.md)