---
title: "Compiler Error CS0559"
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
  - "CS0559"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0559"
ms.assetid: 37122001-8a55-4cf5-873b-68997e196893
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0559
The parameter type for ++ or -- operator must be the containing type  
  
 The method declaration for an operator overload must follow certain guidelines. For the ++ and -- operators, it is required that the parameter be of the same type as the type in which the operator is being overloaded.  
  
## Example  
 The following sample generates CS0559:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates CS0559.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>