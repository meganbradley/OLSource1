---
title: "CA2240: Implement ISerializable correctly"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CA2240"
  - "ImplementISerializableCorrectly"
helpviewer_keywords: 
  - "CA2240"
  - "ImplementISerializableCorrectly"
ms.assetid: cf05936d-0d6c-49ed-a1b4-220032e50b97
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2240: Implement ISerializable correctly
|||  
|-|-|  
|TypeName|ImplementISerializableCorrectly|  
|CheckId|CA2240|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 An externally visible type is assignable to the <xref:System.Runtime.Serialization.ISerializable*?displayProperty=fullName> interface and one of the following conditions is true:  
  
-   The type inherits but does not override the <xref:System.Runtime.Serialization.ISerializable.GetObjectData*?displayProperty=fullName> method and the type declares instance fields that are not marked with the <xref:System.NonSerializedAttribute*?displayProperty=fullName> attribute.  
  
-   The type is not sealed and the type implements a <xref:System.Runtime.Serialization.ISerializable.GetObjectData*> method that is not externally visible and overridable.  
  
## Rule Description  
 Instance fields that are declared in a type that inherits the <xref:System.Runtime.Serialization.ISerializable*?displayProperty=fullName> interface are not automatically included in the serialization process. To include the fields, the type must implement the <xref:System.Runtime.Serialization.ISerializable.GetObjectData*> method and the serialization constructor. If the fields should not be serialized, apply the <xref:System.NonSerializedAttribute*> attribute to the fields to explicitly indicate the decision.  
  
 In types that are not sealed, implementations of the <xref:System.Runtime.Serialization.ISerializable.GetObjectData*> method should be externally visible. Therefore, the method can be called by derived types, and is overridable.  
  
## How to Fix Violations  
 To fix a violation of this rule, make the <xref:System.Runtime.Serialization.ISerializable.GetObjectData*> method visible and overridable and make sure all instance fields are included in the serialization process or explicitly marked with the <xref:System.NonSerializedAttribute*> attribute.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows two serializable types that violate the rule.  
  
 [!code[FxCop.Usage.ImplementISerializableCorrectly#1](../vs140/codesnippet/CSharp/ca2240--implement-iserializable-correctly_1.cs)]
[!code[FxCop.Usage.ImplementISerializableCorrectly#1](../vs140/codesnippet/CPP/ca2240--implement-iserializable-correctly_1.cpp)]
[!code[FxCop.Usage.ImplementISerializableCorrectly#1](../vs140/codesnippet/VisualBasic/ca2240--implement-iserializable-correctly_1.vb)]  
  
## Example  
 The following example fixes the two previous violations by providing an overrideable implementation of [ISerializable.GetObjectData](assetId:///ISerializable.GetObjectData?qualifyHint=False&autoUpgrade=False) on the Book class and by providing an implementation of assetId:///ISerializable.GetObjectData?qualifyHint=False&autoUpgrade=False on the Library class.  
  
 [!code[FxCop.Usage.ImplementISerializableCorrectly2#1](../vs140/codesnippet/CPP/ca2240--implement-iserializable-correctly_2.cpp)]
[!code[FxCop.Usage.ImplementISerializableCorrectly2#1](../vs140/codesnippet/CSharp/ca2240--implement-iserializable-correctly_2.cs)]
[!code[FxCop.Usage.ImplementISerializableCorrectly2#1](../vs140/codesnippet/VisualBasic/ca2240--implement-iserializable-correctly_2.vb)]  
  
## Related Rules  
 [Call base class methods on ISerializable types](../vs140/ca2236--call-base-class-methods-on-iserializable-types.md)  
  
 [Implement serialization constructors](../vs140/ca2229--implement-serialization-constructors.md)  
  
 [Implement serialization methods correctly](../vs140/ca2238--implement-serialization-methods-correctly.md)  
  
 [Mark all non-serializable fields](../vs140/ca2235--mark-all-non-serializable-fields.md)  
  
 [Mark ISerializable types with serializable](../vs140/ca2237--mark-iserializable-types-with-serializableattribute.md)  
  
 [Provide deserialization methods for optional fields](../vs140/ca2239--provide-deserialization-methods-for-optional-fields.md)  
  
 [Secure serialization constructors](../vs140/ca2120--secure-serialization-constructors.md)