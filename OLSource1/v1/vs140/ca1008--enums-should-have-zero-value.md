---
title: "CA1008: Enums should have zero value"
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
  - "CA1008"
  - "EnumsShouldHaveZeroValue"
helpviewer_keywords: 
  - "CA1008"
  - "EnumsShouldHaveZeroValue"
ms.assetid: 3503a73c-360c-416d-8ee4-c2aa44365a05
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1008: Enums should have zero value
|||  
|-|-|  
|TypeName|EnumsShouldHaveZeroValue|  
|CheckId|CA1008|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking - When you are prompted to add a **None** value to a non-flag enumeration.Breaking - When you are prompted to rename or remove any enumeration values.|  
  
## Cause  
 An enumeration without an applied <xref:System.FlagsAttribute*?displayProperty=fullName> does not define a member that has a value of zero; or an enumeration that has an applied <xref:System.FlagsAttribute*> defines a member that has a value of zero but its name is not 'None', or the enumeration defines multiple zero-valued members.  
  
## Rule Description  
 The default value of an uninitialized enumeration, just like other value types, is zero. A non-flags−attributed enumeration should define a member that has the value of zero so that the default value is a valid value of the enumeration. If appropriate, name the member 'None'. Otherwise, assign zero to the most frequently used member. Note that, by default, if the value of the first enumeration member is not set in the declaration, its value is zero.  
  
 If an enumeration that has the <xref:System.FlagsAttribute*> applied defines a zero-valued member, its name should be 'None' to indicate that no values have been set in the enumeration. Using a zero-valued member for any other purpose is contrary to the use of the <xref:System.FlagsAttribute*> in that the AND and OR bitwise operators are useless with the member. This implies that only one member should be assigned the value zero. Note that if multiple members that have the value zero occur in a flags-attributed enumeration, `Enum.ToString()` returns incorrect results for members that are not zero.  
  
## How to Fix Violations  
 To fix a violation of this rule for non-flags−attributed enumerations, define a member that has the value of zero; this is a non-breaking change. For flags-attributed enumerations that define a zero-valued member, name this member 'None' and delete any other members that have a value of zero; this is a breaking change.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule except for flags-attributed enumerations that have previously shipped.  
  
## Example  
 The following example shows two enumerations that satisfy the rule and an enumeration, `BadTraceOptions`, that violates the rule.  
  
 [!code[FxCop.Design.EnumsZeroValue#1](../vs140/codesnippet/CPP/ca1008--enums-should-have-zero-value_1.cpp)]
[!code[FxCop.Design.EnumsZeroValue#1](../vs140/codesnippet/CSharp/ca1008--enums-should-have-zero-value_1.cs)]
[!code[FxCop.Design.EnumsZeroValue#1](../vs140/codesnippet/VisualBasic/ca1008--enums-should-have-zero-value_1.vb)]  
  
## Related Rules  
 [Do not mark enums with FlagsAttribute](../vs140/ca2217--do-not-mark-enums-with-flagsattribute.md)  
  
 [Do not name enum values 'Reserved'](../vs140/ca1700--do-not-name-enum-values--reserved-.md)  
  
 [Do not prefix enum values with type name](../vs140/ca1712--do-not-prefix-enum-values-with-type-name.md)  
  
 [Enum Storage should be Int32](../vs140/ca1028--enum-storage-should-be-int32.md)  
  
 [Mark enums with FlagsAttribute](../vs140/ca1027--mark-enums-with-flagsattribute.md)  
  
## See Also  
 <xref:System.Enum*?displayProperty=fullName>