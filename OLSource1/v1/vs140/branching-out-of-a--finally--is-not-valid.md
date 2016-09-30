---
title: "Branching out of a &#39;Finally&#39; is not valid"
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
  - "bc30101"
  - "vbc30101"
helpviewer_keywords: 
  - "BC30101"
ms.assetid: 16a0dc29-3657-4373-b77f-38f3cb80e6c9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Branching out of a &#39;Finally&#39; is not valid
A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement inside a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block branches outside the block. It is not valid to branch into or out of a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block.  
  
 **Error ID:** BC30101  
  
### To correct this error  
  
-   Remove the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement, and consider implementing the program logic with decision or loop control structures.  
  
## See Also  
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [GoTo Statement](../vs140/goto-statement.md)   
 [Control Flow](../vs140/control-flow-in-visual-basic.md)