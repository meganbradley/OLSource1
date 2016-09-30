---
title: "Compiler Warning (level 1) CS1911"
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
  - "CS1911"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1911"
ms.assetid: 95e8a7a0-1c19-4930-a7e9-3ae4060e97d3
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1911
Access to member 'name' through a 'base' keyword from an anonymous method, lambda expression, query expression, or iterator results in unverifiable code. Consider moving the access into a helper method on the containing type.  
  
 Calling virtual functions with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword inside the method body of an iterator or anonymous methods will result in unverifiable code. Unverifiable code will fail to run in a partial trust environment.  
  
 One resolution for CS1911 is to move the virtual function call to a helper function.  
  
## Example  
 The following sample generates CS1911.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>