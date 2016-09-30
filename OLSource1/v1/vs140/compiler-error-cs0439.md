---
title: "Compiler Error CS0439"
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
  - "CS0430"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0439"
ms.assetid: 5cbac869-1b1b-45f9-98c8-38c17348035f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0439
An extern alias declaration must precede all other elements defined in the namespace  
  
 This error occurs when an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> declaration comes after something else, such as a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> declaration, in the same namespace. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> declarations must come before all other namespace elements.  
  
## Example  
 The following example generates CS0439:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>