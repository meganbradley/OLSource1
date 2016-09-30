---
title: "IDiaStackFrame::get_lengthLocals"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackFrame::get_lengthLocals method"
ms.assetid: dbc3e544-578a-4f0b-8d20-f21ad4cbb604
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackFrame::get_lengthLocals
Retrieves the number of bytes of local variables pushed on the stack.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns the number of bytes of local variables.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaStackFrame](../vs140/idiastackframe.md)