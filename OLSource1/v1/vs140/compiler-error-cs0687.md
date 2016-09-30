---
title: "Compiler Error CS0687"
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
  - "CS0687"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0687"
ms.assetid: b51c5e7c-f4de-4aa4-97b1-ebe220cd19b0
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0687
The namespace alias qualifier '::' always resolves to a type or namespace so is illegal here. Consider using '.' instead.  
  
 This error occurs if you used something which the parser interpreted as a type in an unexpected place. A type or namespace name is valid only in a member access expression, using the member access (**.**) operator. This could occur if you used the global scope operator (::) in another context.  
  
## Example  
 The following sample generates CS0687:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>