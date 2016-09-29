---
title: "&#39;&lt;procedurename1&gt;&#39; cannot override &#39;&lt;procedurename2&gt;&#39; because it is not accessible in this context"
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
  - "bc31417"
  - "vbc31417"
helpviewer_keywords: 
  - "BC31417"
ms.assetid: 1a36acbf-cead-43a0-b12f-f52f94d09124
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;procedurename1&gt;&#39; cannot override &#39;&lt;procedurename2&gt;&#39; because it is not accessible in this context
A procedure or property overrides a procedure or property with an access level that prevents access by the overriding procedure or property.  
  
 For example, if a procedure is declared as `Friend` in one assembly, it cannot be accessed outside that assembly. If a procedure in another assembly in the same project attempts to override the `Friend` procedure, it cannot access it to override it.  
  
 **Error ID:** BC31417  
  
### To correct this error  
  
-   Move the overriding procedure or property to the same assembly as the procedure or property it is to override.  
  
     -or-  
  
-   Remove the `Overrides` keyword.  
  
## See Also  
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)   
 [Overrides](../vs140/overrides--visual-basic-.md)   
 [NOT IN BUILD: Overriding Properties and Methods](assetId:///2167e8f5-1225-4b13-9ebd-02591ba90213)