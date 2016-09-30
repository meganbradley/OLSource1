---
title: "PROC"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "PROC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PROC directive"
ms.assetid: ee5bb6b6-fa15-4d73-b0cf-e650178539a9
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PROC
Marks start and end of a procedure block called *label*. The statements in the block can be called with the **CALL** instruction or [INVOKE](../vs140/invoke.md) directive.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 [FRAME [:*ehandler-address*] ] is only valid with ml64.exe, and causes MASM to generate a function table entry in .pdata and unwind information in .xdata for a function's structured exception handling unwind behavior.  
  
 When the **FRAME** attribute is used, it must be followed by an [.ENDPROLOG](../vs140/.endprolog.md) directive.  
  
 See [MASM for x64 (ml64.exe)](../vs140/masm-for-x64--ml64.exe-.md) for more information on using ml64.exe.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The above code will emit the following function table and unwind information:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Directives Reference](../vs140/directives-reference.md)