---
title: "Conflict between the default property and the &#39;DefaultMemberAttribute&#39; defined on &#39;|1&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc32304"
  - "bc32304"
helpviewer_keywords: 
  - "BC32304"
ms.assetid: 42803d13-ff1d-40ed-a4a8-269e2fb4aa01
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conflict between the default property and the &#39;DefaultMemberAttribute&#39; defined on &#39;|1&#39;
A class, structure, or interface declares a default property with the [Default (Visual Basic)](../vs140/default--visual-basic-.md) keyword but also applies the <xref:System.Reflection.DefaultMemberAttribute*> to designate a different member as the default member.  
  
 A type can have at most one default member. When you declare a default property, Visual Basic automatically applies the <xref:System.Reflection.DefaultMemberAttribute*> to the class, structure, or interface designating that property.  
  
 **Error ID:** BC32304  
  
### To correct this error  
  
1.  Decide which member should be the default member of the class, structure, or interface.  
  
2.  Remove the conflicting declaration (either the `Default` keyword or the <xref:System.Reflection.DefaultMemberAttribute*>).  
  
## See Also  
 <xref:System.Reflection.DefaultMemberAttribute*>   
 [Default (Visual Basic)](../vs140/default--visual-basic-.md)   
 [NOT IN BUILD: Default Properties](assetId:///a70f2a27-8176-4858-935e-f25afdd43ab5)   
 [How to: Declare and Call a Default Property in Visual Basic](../vs140/how-to--declare-and-call-a-default-property-in-visual-basic.md)