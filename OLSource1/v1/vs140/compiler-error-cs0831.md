---
title: "Compiler Error CS0831"
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
  - "CS0831"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0831"
ms.assetid: f626a77d-3844-4438-954b-b8201e72b1b5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0831
An expression tree may not contain a base access.  
  
 A base access means to make a function call that would ordinarily be a virtual function call as a non-virtual function call on the base class method. This is not allowed in the expression tree itself, but you can invoke a helper method in your class that invokes the base class method.  
  
### To correct this error  
  
1.  If you must access a base class method in this manner, create a helper method that calls into the base class and have the expression tree call the helper method. This technique is shown in the following code.  
  
## Example  
 The following example generates CS0831:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>