---
title: "Compiler Error CS0835"
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
  - "CS0835"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0835"
ms.assetid: 593c26f6-6d82-49a6-8ace-4d29dd9f5fbe
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0835
Cannot convert lambda to an expression tree whose type argument 'type' is not a delegate type.  
  
 If a lambda expression is converted to an expression tree, the expression tree must have a delegate type for its argument. Furthermore, the lambda expression must be convertible to the delegate type.  
  
### To correct this error  
  
1.  Change the type parameter from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to a delegate type, for example <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Example  
 The following example generates CS0835:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>