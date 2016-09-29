---
title: "CA1411: COM registration methods should not be visible"
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
  - "CA1411"
  - "ComRegistrationMethodsShouldNotBeVisible"
helpviewer_keywords: 
  - "ComRegistrationMethodsShouldNotBeVisible"
  - "CA1411"
ms.assetid: a59f96f1-1f38-4596-b656-947df5c55311
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1411: COM registration methods should not be visible
|||  
|-|-|  
|TypeName|ComRegistrationMethodsShouldNotBeVisible|  
|CheckId|CA1411|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A method that is marked with the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute*?displayProperty=fullName> or the <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute*?displayProperty=fullName> attribute is externally visible.  
  
## Rule Description  
 When an assembly is registered with Component Object Model (COM), entries are added to the registry for each COM-visible type in the assembly. Methods that are marked with the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute*> and <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute*> attributes are called during the registration and unregistration processes, respectively, to run user code that is specific to the registration/unregistration of these types. This code should not be called outside these processes.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the accessibility of the method to `private` or `internal` (`Friend` in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]).  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows two methods that violate the rule.  
  
 [!code[FxCop.Interoperability.ComRegistration2#1](../vs140/codesnippet/CSharp/ca1411--com-registration-methods-should-not-be-visible_1.cs)]
[!code[FxCop.Interoperability.ComRegistration2#1](../vs140/codesnippet/VisualBasic/ca1411--com-registration-methods-should-not-be-visible_1.vb)]  
  
## Related Rules  
 [Com registration methods should be matched](../vs140/ca1410--com-registration-methods-should-be-matched.md)  
  
## See Also  
 <xref:System.Runtime.InteropServices.RegistrationServices*?displayProperty=fullName>   
 [Registering Assemblies with COM](assetId:///87925795-a3ae-4833-b138-125413478551)   
 [Assembly Registration Tool (Regasm.exe)](assetId:///e190e342-36ef-4651-a0b4-0e8c2c0281cb)