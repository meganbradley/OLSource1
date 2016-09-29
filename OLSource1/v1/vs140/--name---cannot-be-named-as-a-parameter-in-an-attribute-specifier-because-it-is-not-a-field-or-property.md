---
title: "&#39;&lt;name&gt;&#39; cannot be named as a parameter in an attribute specifier because it is not a field or property"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc32010"
  - "bc32010"
helpviewer_keywords: 
  - "BC32010"
ms.assetid: bfa68729-71ea-410e-bef1-83a7dab44d2a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;name&gt;&#39; cannot be named as a parameter in an attribute specifier because it is not a field or property
An attribute block sets a value for a nonvariable member of the attribute. You can assign values only to variable members such as fields or properties.  
  
 **Error ID:** BC32010  
  
### To correct this error  
  
1.  Ensure that the attribute and member names are spelled correctly.  
  
2.  Remove the argument from the attribute block if the member is nonvariable.  
  
## See Also  
 [NOT IN BUILD: Application of Attributes](assetId:///2b1703ed-4437-49b3-bc0b-568094324f47)