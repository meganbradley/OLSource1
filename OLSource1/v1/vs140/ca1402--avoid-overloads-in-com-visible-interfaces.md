---
title: "CA1402: Avoid overloads in COM visible interfaces"
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
  - "AvoidOverloadsInComVisibleInterfaces"
  - "CA1402"
helpviewer_keywords: 
  - "AvoidOverloadsInComVisibleInterfaces"
  - "CA1402"
ms.assetid: 2724c1f9-d5d3-4704-b124-21c4d398e5df
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1402: Avoid overloads in COM visible interfaces
|||  
|-|-|  
|TypeName|AvoidOverloadsInComVisibleInterfaces|  
|CheckId|CA1402|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A Component Object Model (COM) visible interface declares overloaded methods.  
  
## Rule Description  
 When overloaded methods are exposed to COM clients, only the first method overload retains its name. Subsequent overloads are uniquely renamed by appending to the name an underscore character '_' and an integer that corresponds to the order of declaration of the overload. For example, consider the following methods.  
  
```  
void SomeMethod(int valueOne);  
void SomeMethod(int valueOne, int valueTwo, int valueThree);  
void SomeMethod(int valueOne, int valueTwo);  
```  
  
 These methods are exposed to COM clients as the following.  
  
```  
void SomeMethod(int valueOne);  
void SomeMethod_2(int valueOne, int valueTwo, int valueThree);  
void SomeMethod_3(int valueOne, int valueTwo);  
```  
  
 Visual Basic 6 COM clients cannot implement interface methods by using an underscore in the name.  
  
## How to Fix Violations  
 To fix a violation of this rule, rename the overloaded methods so that the names are unique. Alternatively, make the interface invisible to COM by changing the accessibility to `internal` (`Friend` in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]) or by applying the \<xref:System.Runtime.InteropServices.ComVisibleAttribute*?displayProperty=fullName> attribute set to `false`.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows an interface that violates the rule and an interface that satisfies the rule.  
  
 [!code[FxCop.Interoperability.OverloadsInterface#1](../vs140/codesnippet/VisualBasic/ca1402--avoid-overloads-in-com-visible-interfaces_1.vb)]
[!code[FxCop.Interoperability.OverloadsInterface#1](../vs140/codesnippet/CSharp/ca1402--avoid-overloads-in-com-visible-interfaces_1.cs)]  
  
## Related Rules  
 [Avoid non-public fields in ComVisible value types](../vs140/ca1413--avoid-non-public-fields-in-com-visible-value-types.md)  
  
 [Avoid static members in ComVisible types](../vs140/ca1407--avoid-static-members-in-com-visible-types.md)  
  
 [Mark assemblies with ComVisible](../vs140/ca1017--mark-assemblies-with-comvisibleattribute.md)  
  
## See Also  
 [Interoperating with Unmanaged Code](assetId:///ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)   
 [Long Data Type](../vs140/long-data-type--visual-basic-.md)