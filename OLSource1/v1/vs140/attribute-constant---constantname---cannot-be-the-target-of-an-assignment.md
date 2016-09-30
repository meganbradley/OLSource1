---
title: "Attribute constant &#39;&lt;constantname&gt;&#39; cannot be the target of an assignment"
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
  - "bc31510"
  - "vbc31510"
helpviewer_keywords: 
  - "BC31510"
ms.assetid: 5459c531-3a4e-4e03-b185-9c5766254982
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Attribute constant &#39;&lt;constantname&gt;&#39; cannot be the target of an assignment
An attempt was made to assign a value to a constant declared in an attribute.  
  
 **Error ID:** BC31510  
  
### To correct this error  
  
-   Remove the erroneous assignment.  
  
-   If you are using custom attributes that you developed, redefine the member in the attribute as a field.  
  
## See Also  
 [NOT IN BUILD: Attributes in Visual Basic](assetId:///620bfc0e-4582-4c8b-8432-ebc5c3dccc22)   
 [Constants and Enumerations](../vs140/constants-and-enumerations--visual-basic-.md)