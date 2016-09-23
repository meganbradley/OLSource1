---
title: "Key (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vb.AnonymousKey
dev_langs: 
  - VB
helpviewer_keywords: 
  - anonymous types [Visual Basic], key
  - Key [Visual Basic]
  - Key keyword [Visual Basic]
ms.assetid: 7697a928-7d14-4430-a72a-c9e96e8d6c11
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Key (Visual Basic)
The `Key` keyword enables you to specify behavior for properties of anonymous types. Only properties you designate as key properties participate in tests of equality between anonymous type instances, or calculation of hash code values. The values of key properties cannot be changed.  
  
 You designate a property of an anonymous type as a key property by placing the keyword `Key` in front of its declaration in the initialization list. In the following example, `Airline` and `FlightNo` are key properties, but `Gate` is not.  
  
 [!code[VbVbalrAnonymousTypes#26](../vs140/codesnippet/VisualBasic/key--visual-basic-_1.vb)]
  
  
 When a new anonymous type is created, it inherits directly from <xref:System.Object?qualifyHint=False>. The compiler overrides three inherited members: <xref:System.Object.Equals?qualifyHint=False>, <xref:System.Object.GetHashCode?qualifyHint=False>, and <xref:System.Object.ToString?qualifyHint=False>. The override code that is produced for <xref:System.Object.Equals?qualifyHint=False> and <xref:System.Object.GetHashCode?qualifyHint=False> is based on key properties. If there are no key properties in the type, <xref:System.Object.GetHashCode?qualifyHint=False> and <xref:System.Object.Equals?qualifyHint=False> are not overridden.  
  
## Equality  
 Two anonymous type instances are equal if they are instances of the same type and if the values of their key properties are equal. In the following examples, `flight2` is equal to `flight1` from the previous example because they are instances of the same anonymous type and they have matching values for their key properties. However, `flight3` is not equal to `flight1` because it has a different value for a key property, `FlightNo`. Instance `flight4` is not the same type as `flight1` because they designate different properties as key properties.  
  
 [!code[VbVbalrAnonymousTypes#27](../vs140/codesnippet/VisualBasic/key--visual-basic-_2.vb)]
  
  
 If two instances are declared with only non-key properties, identical in name, type, order, and value, the two instances are not equal. An instance without key properties is equal only to itself.  
  
 For more information about the conditions under which two anonymous type instances are instances of the same anonymous type, see [Anonymous Types](../vs140/anonymous-types--visual-basic-.md).  
  
## Hash Code Calculation  
 Like <xref:System.Object.Equals?qualifyHint=False>, the hash function that is defined in <xref:System.Object.GetHashCode?qualifyHint=False> for an anonymous type is based on the key properties of the type. The following examples show the interaction between key properties and hash code values.  
  
 Instances of an anonymous type that have the same values for all key properties have the same hash code value, even if non-key properties do not have matching values. The following statement returns `True`.  
  
 [!code[VbVbalrAnonymousTypes#37](../vs140/codesnippet/VisualBasic/key--visual-basic-_3.vb)]
  
  
 Instances of an anonymous type that have different values for one or more key properties have different hash code values. The following statement returns `False`.  
  
 [!code[VbVbalrAnonymousTypes#38](../vs140/codesnippet/VisualBasic/key--visual-basic-_4.vb)]
  
  
 Instances of anonymous types that designate different properties as key properties are not instances of the same type. They have different hash code values even when the names and values of all properties are the same. The following statement returns `False`.  
  
 [!code[VbVbalrAnonymousTypes#39](../vs140/codesnippet/VisualBasic/key--visual-basic-_5.vb)]
  
  
## Read-Only Values  
 The values of key properties cannot be changed. For example, in `flight1` in the earlier examples, the `Airline` and `FlightNo` fields are read-only, but `Gate` can be changed.  
  
 [!code[VbVbalrAnonymousTypes#28](../vs140/codesnippet/VisualBasic/key--visual-basic-_6.vb)]
  
  
## See Also  
 [Anonymous Class Definition](../vs140/anonymous-type-definition--visual-basic-.md)   
 [How to: Infer Property Names and Types in Anonymous Type Declarations](../vs140/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-.md)   
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)