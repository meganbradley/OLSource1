---
title: "CA2235: Mark all non-serializable fields"
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
  - CA2235
  - MarkAllNonSerializableFields
helpviewer_keywords: 
  - CA2235
  - MarkAllNonSerializableFields
ms.assetid: 599ad877-3a15-426c-bf17-5de15427365f
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CA2235: Mark all non-serializable fields
|||  
|-|-|  
|TypeName|MarkAllNonSerializableFields|  
|CheckId|CA2235|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 An instance field of a type that is not serializable is declared in a type that is serializable.  
  
## Rule Description  
 A serializable type is one that is marked with the <xref:System.SerializableAttribute?qualifyHint=True> attribute. When the type is serialized, a <xref:System.Runtime.Serialization.SerializationException?qualifyHint=True> exception is thrown if a type contains an instance field of a type that is not serializable.  
  
## How to Fix Violations  
 To fix a violation of this rule, apply the <xref:System.NonSerializedAttribute?qualifyHint=True> attribute to the field that is not serializable.  
  
## When to Suppress Warnings  
 Only suppress a warning from this rule if a <xref:System.Runtime.Serialization.ISerializationSurrogate?qualifyHint=True> type is declared that allows instances of the field to be serialized and deserialized.  
  
## Example  
 The following example shows a type that violates the rule and a type that satisfies the rule.  
  
 [!code[FxCop.Usage.MarkNonSerializable#1](../vs140/codesnippet/CSharp/ca2235--mark-all-non-serializable-fields_1.cs)]
[!code[FxCop.Usage.MarkNonSerializable#1](../vs140/codesnippet/VisualBasic/ca2235--mark-all-non-serializable-fields_1.vb)]
  
  
## Related Rules  
 [Call base class methods on ISerializable types](../vs140/ca2236--call-base-class-methods-on-iserializable-types.md)  
  
 [Implement ISerializable correctly](../vs140/ca2240--implement-iserializable-correctly.md)  
  
 [Implement serialization constructors](../vs140/ca2229--implement-serialization-constructors.md)  
  
 [Implement serialization methods correctly](../vs140/ca2238--implement-serialization-methods-correctly.md)  
  
 [Mark ISerializable types with serializable](../vs140/ca2237--mark-iserializable-types-with-serializableattribute.md)  
  
 [Provide deserialization methods for optional fields](../vs140/ca2239--provide-deserialization-methods-for-optional-fields.md)  
  
 [Secure serialization constructors](../vs140/ca2120--secure-serialization-constructors.md)