---
title: "IDiaStackFrame::get_type"
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
  - "IDiaStackFrame::get_type method"
ms.assetid: 99daa97b-5c05-455d-bd1e-800762ccf7c9
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackFrame::get_type
Retrieves the frame type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns a value from the [StackFrameTypeEnum](../vs140/stackframetypeenum.md) enumeration.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaStackFrame](../vs140/idiastackframe.md)   
 [StackFrameTypeEnum](../vs140/stackframetypeenum.md)