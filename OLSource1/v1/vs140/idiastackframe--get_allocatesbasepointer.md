---
title: "IDiaStackFrame::get_allocatesBasePointer"
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
  - "IDiaStackFrame::get_allocatesBasePointer"
ms.assetid: a91e9c8e-c5e3-4887-a60b-f03b5a98f30c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackFrame::get_allocatesBasePointer
Retrieves a flag that indicates whether the base pointer is allocated for code in this address range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if a base pointer is allocated for code in this frame; otherwise, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaStackFrame](../vs140/idiastackframe.md)