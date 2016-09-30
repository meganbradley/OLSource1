---
title: "IDiaStackFrame::get_cplusplusExceptionHandling"
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
  - "IDiaStackFrame::get_cplusplusExceptionHandling method"
ms.assetid: f2631820-c986-40ca-b61e-230d7a9c426c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackFrame::get_cplusplusExceptionHandling
Retrieves a flag that indicates if C++ exception handling is in effect.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if C++ exception handling is in effect for this frame; otherwise, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 C++ exception handling is not the same as structured or system exception handling.  
  
 To determine if structured exception handling is in effect, call the [IDiaStackFrame::get_systemExceptionHandling](../vs140/idiastackframe--get_systemexceptionhandling.md) method.  
  
## See Also  
 [IDiaStackFrame](../vs140/idiastackframe.md)   
 [IDiaStackFrame::get_systemExceptionHandling](../vs140/idiastackframe--get_systemexceptionhandling.md)