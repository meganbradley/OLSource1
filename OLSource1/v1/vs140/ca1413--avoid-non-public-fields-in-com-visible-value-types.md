---
title: "CA1413: Avoid non-public fields in COM visible value types"
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
  - "CA1413"
  - "AvoidNonpublicFieldsInComVisibleValueTypes"
helpviewer_keywords: 
  - "CA1413"
  - "AvoidNonpublicFieldsInComVisibleValueTypes"
ms.assetid: 1352e7eb-fefc-4239-8847-25edc7804a54
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1413: Avoid non-public fields in COM visible value types
|||  
|-|-|  
|TypeName|AvoidNonpublicFieldsInComVisibleValueTypes|  
|CheckId|CA1413|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A value type that is specifically marked as visible to Component Object Model (COM) declares a nonpublic instance field.  
  
## Rule Description  
 Nonpublic instance fields of COM-visible value types are visible to COM clients. Review the content of the field for information that should not be exposed, or that will have an unintended design or security effect.  
  
 By default, all public value types are visible to COM. However, to reduce false positives, this rule requires the COM visibility of the type to be explicitly stated. The containing assembly must be marked with the \<xref:System.Runtime.InteropServices.ComVisibleAttribute*?displayProperty=fullName> set to <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and the type must be marked with the \<xref:System.Runtime.InteropServices.ComVisibleAttribute*> set to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## How to Fix Violations  
 To fix a violation of this rule and keep the field hidden, change the value type to a reference type or remove the \<xref:System.Runtime.InteropServices.ComVisibleAttribute*> attribute from the type.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if public exposure of the field is acceptable.  
  
## Example  
 The following example shows a type that violates the rule.  
  
 [!code[FxCop.Interoperability.NonpublicField#1](../vs140/codesnippet/CSharp/ca1413--avoid-non-public-fields-in-com-visible-value-types_1.cs)]
[!code[FxCop.Interoperability.NonpublicField#1](../vs140/codesnippet/VisualBasic/ca1413--avoid-non-public-fields-in-com-visible-value-types_1.vb)]  
  
## Related Rules  
 [Avoid static members in ComVisible types](../vs140/ca1407--avoid-static-members-in-com-visible-types.md)  
  
 [Mark assemblies with ComVisible](../vs140/ca1017--mark-assemblies-with-comvisibleattribute.md)  
  
## See Also  
 [Interoperating with Unmanaged Code](assetId:///ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)   
 [Qualifying .NET Types for Interoperation](assetId:///4b8afb52-fb8d-4e65-b47c-fd82956a3cdd)