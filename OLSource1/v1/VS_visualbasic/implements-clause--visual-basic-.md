---
title: "Implements Clause (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.ImplementsClause"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "interface implementation, reimplementation"
  - "interface members, reimplementation"
  - "interface members, Implements keyword"
  - "interface members"
  - "members, reimplementation"
  - "interface implementation, Implements keyword"
  - "interface members, implementing"
  - "Implements keyword"
  - "Implements statement, about Implements"
  - "members, implementing"
  - "members, Implements keyword"
  - "reimplementation"
ms.assetid: 5252cdf9-964d-4fc6-af0f-0449b7126b5a
caps.latest.revision: 15
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Implements Clause (Visual Basic)
Indicates that a class or structure member is providing the implementation for a member defined in an interface.  
  
## Remarks  
 The `Implements` keyword is not the same as the [Implements Statement](../VS_visualbasic/implements-statement.md). You use the `Implements` statement to specify that a class or structure implements one or more interfaces, and then for each member you use the `Implements` keyword to specify which interface and which member it implements.  
  
 If a class or structure implements an interface, it must include the `Implements` statement immediately after the [Class Statement](../VS_visualbasic/class-statement--visual-basic-.md) or [Structure Statement](../VS_visualbasic/structure-statement.md), and it must implement all the members defined by the interface.  
  
## Reimplementation  
 In a derived class, you can reimplement an interface member that the base class has already implemented. This is different from overriding the base class member in the following respects:  
  
-   The base class member does not need to be [Overridable](../VS_visualbasic/overridable--visual-basic-.md) to be reimplemented.  
  
-   You can reimplement the member with a different name.  
  
 The `Implements` keyword can be used in these contexts:  
  
 [Event Statement](../VS_visualbasic/event-statement.md)  
  
 [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md)  
  
 [Property Statement](../VS_visualbasic/property-statement.md)  
  
 [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md)  
  
## See Also  
 [Implements Statement](../VS_visualbasic/implements-statement.md)   
 [Interface Statement](../VS_visualbasic/interface-statement--visual-basic-.md)   
 [Class Statement](../VS_visualbasic/class-statement--visual-basic-.md)   
 [Structure Statement](../VS_visualbasic/structure-statement.md)