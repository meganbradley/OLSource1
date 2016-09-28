---
title: "Type arguments cannot be applied to the expression &#39;&lt;expression&gt;&#39;"
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
  - "bc32058"
  - "vbc32058"
helpviewer_keywords: 
  - "BC32058"
ms.assetid: c6b9b49c-6fb2-47b8-a8bb-464562d3adfd
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type arguments cannot be applied to the expression &#39;&lt;expression&gt;&#39;
An import alias is defined with an [Of](../vs140/of-clause--visual-basic-.md) clause that passes type arguments to the import alias.  
  
 Type arguments are used for generic types, and only classes, structures, interfaces, procedures, and delegates can be generic. Neither namespaces nor import aliases can be generic.  
  
 **Error ID:** BC32058  
  
### To correct this error  
  
-   Remove the `Of` clause and its type arguments from the import alias.  
  
## See Also  
 [Imports Statement](../vs140/imports-statement--.net-namespace-and-type-.md)   
 [References and the Imports Statement](../vs140/references-and-the-imports-statement--visual-basic-.md)   
 [NOTINBUILD: Resolving a Reference When Multiple Variables Have the Same Name](assetId:///9601e39f-1911-44e1-ace5-3f6e090408b9)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)