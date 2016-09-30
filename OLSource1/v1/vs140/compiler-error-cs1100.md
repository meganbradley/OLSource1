---
title: "Compiler Error CS1100"
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
  - "CS1100"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1100"
ms.assetid: ea233371-36b6-49ae-a98c-a00ee3b79e53
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1100
Method 'name' has a parameter modifier 'this' which is not on the first parameter.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier is allowed only on the first parameter of a method, which indicates to the compiler that the method is an extension method.  
  
### To correct this error  
  
1.  Remove the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> modifier from all except the first parameter of the method.  
  
## Example  
 The following code generates CS1100 because a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter is modifying the second parameter:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md)