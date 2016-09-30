---
title: "CA2126: Type link demands require inheritance demands"
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
  - "CA2126"
  - "TypeLinkDemandsRequireInheritanceDemands"
helpviewer_keywords: 
  - "CA2126"
  - "TypeLinkDemandsRequireInheritanceDemands"
ms.assetid: 07b604e5-5579-4df9-a578-dadd0d8370a7
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2126: Type link demands require inheritance demands
|||  
|-|-|  
|TypeName|TypeLinkDemandsRequireInheritanceDemands|  
|CheckId|CA2126|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A public unsealed type is protected with a link demand, has an overridable method, and neither the type nor the method is protected with an inheritance demand.  
  
## Rule Description  
 A link demand on a method or its declaring type requires the immediate caller of the method to have the specified permission. An inheritance demand on a method requires an overriding method to have the specified permission. An inheritance demand on a type requires a deriving class to have the specified permission.  
  
## How to Fix Violations  
 To fix a violation of this rule, secure the type or the method with an inheritance demand for the same permission as the link demand.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a type that violates the rule.  
  
 [!code[FxCop.Security.TypesWithLinkDemands#1](../vs140/codesnippet/CPP/ca2126--type-link-demands-require-inheritance-demands_1.cpp)]
[!code[FxCop.Security.TypesWithLinkDemands#1](../vs140/codesnippet/VisualBasic/ca2126--type-link-demands-require-inheritance-demands_1.vb)]
[!code[FxCop.Security.TypesWithLinkDemands#1](../vs140/codesnippet/CSharp/ca2126--type-link-demands-require-inheritance-demands_1.cs)]  
  
## Related Rules  
 [Review declarative security on value types](../vs140/ca2108--review-declarative-security-on-value-types.md)  
  
 [Secured types should not expose fields](../vs140/ca2112--secured-types-should-not-expose-fields.md)  
  
 [Do not indirectly expose methods with link demands](../vs140/ca2122--do-not-indirectly-expose-methods-with-link-demands.md)  
  
 [Override link demands should be identical to base](../vs140/ca2123--override-link-demands-should-be-identical-to-base.md)  
  
## See Also  
 [Secure Coding Guidelines](assetId:///4f882d94-262b-4494-b0a6-ba9ba1f5f177)   
 [Inheritance Demands](assetId:///28b9adbb-8f08-4f10-b856-dbf59eb932d9)   
 [Link Demands](assetId:///a33fd5f9-2de9-4653-a4f0-d9df25082c4d)   
 [Demands](assetId:///e5283e28-2366-4519-b27d-ef5c1ddc1f48)