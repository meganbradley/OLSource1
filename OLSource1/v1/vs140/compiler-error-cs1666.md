---
title: "Compiler Error CS1666"
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
  - "CS1666"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1666"
ms.assetid: 4d62aa9c-71b9-4c6e-8141-2426d20ac243
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1666
You cannot use fixed size buffers contained in unfixed expressions. Try using the fixed statement.  
  
 This error occurs if you use the fixed sized buffer in an expression involving a class that is not itself fixed. The runtime is free to move the unfixed class around to optimize memory access, which could lead to errors when using the fixed sized buffer. To avoid this error, use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword on the statement.  
  
## Example  
 The following sample generates CS1666.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>