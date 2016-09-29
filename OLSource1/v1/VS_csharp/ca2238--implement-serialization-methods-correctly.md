---
title: "CA2238: Implement serialization methods correctly"
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
  - "ImplementSerializationMethodsCorrectly"
  - "CA2238"
helpviewer_keywords: 
  - "ImplementSerializationMethodsCorrectly"
  - "CA2238"
ms.assetid: 00882cf9-e10d-4d40-9126-3e6753e3c934
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2238: Implement serialization methods correctly
|||  
|-|-|  
|TypeName|ImplementSerializationMethodsCorrectly|  
|CheckId|CA2238|  
|Category|Microsoft.Usage|  
|Breaking Change|Breaking - If the method is visible outside the assembly.<br /><br /> Non Breaking - If the method is not visible outside the assembly.|  
  
## Cause  
 A method that handles a serialization event does not have the correct signature, return type, or visibility.  
  
## Rule Description  
 A method is designated a serialization event handler by applying one of the following serialization event attributes:  
  
-   <xref:System.Runtime.Serialization.OnSerializingAttribute*?displayProperty=fullName>  
  
-   <xref:System.Runtime.Serialization.OnSerializedAttribute*?displayProperty=fullName>  
  
-   <xref:System.Runtime.Serialization.OnDeserializingAttribute*?displayProperty=fullName>  
  
-   <xref:System.Runtime.Serialization.OnDeserializedAttribute*?displayProperty=fullName>  
  
 Serialization event handlers take a single parameter of type <xref:System.Runtime.Serialization.StreamingContext*?displayProperty=fullName>, return `void`, and have `private` visibility.  
  
## How to Fix Violations  
 To fix a violation of this rule, correct the signature, return type, or visibility of the serialization event handler.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows correctly declared serialization event handlers.  
  
 [!code[FxCop.Usage.SerializationEventHandlers#1](../VS_csharp/codesnippet/VisualBasic/ca2238--implement-serialization-methods-correctly_1.vb)]
[!code[FxCop.Usage.SerializationEventHandlers#1](../VS_csharp/codesnippet/CSharp/ca2238--implement-serialization-methods-correctly_1.cs)]  
  
## Related Rules  
 [Call base class methods on ISerializable types](../VS_csharp/ca2236--call-base-class-methods-on-iserializable-types.md)  
  
 [Implement ISerializable correctly](../VS_csharp/ca2240--implement-iserializable-correctly.md)  
  
 [Implement serialization constructors](../VS_csharp/ca2229--implement-serialization-constructors.md)  
  
 [Mark all non-serializable fields](../VS_csharp/ca2235--mark-all-non-serializable-fields.md)  
  
 [Mark ISerializable types with serializable](../VS_csharp/ca2237--mark-iserializable-types-with-serializableattribute.md)  
  
 [Provide deserialization methods for optional fields](../VS_csharp/ca2239--provide-deserialization-methods-for-optional-fields.md)  
  
 [Secure serialization constructors](../VS_csharp/ca2120--secure-serialization-constructors.md)