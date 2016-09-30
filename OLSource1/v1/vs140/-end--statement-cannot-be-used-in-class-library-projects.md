---
title: "&#39;End&#39; statement cannot be used in class library projects"
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
  - "bc30615"
  - "vbc30615"
helpviewer_keywords: 
  - "BC30615"
ms.assetid: c8606b17-b50b-4014-b76e-b748d57e9389
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;End&#39; statement cannot be used in class library projects
Class library projects used to create DLLs do not allow the use of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> keyword to stop the execution of code in a procedure.  
  
 **Error ID:** BC30615  
  
### To correct this error  
  
-   Use control structures such as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to control the flow of program execution.  
  
## See Also  
 [Control Flow](../vs140/control-flow-in-visual-basic.md)