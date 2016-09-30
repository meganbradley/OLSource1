---
title: "StackFrameTypeEnum"
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
  - "StackFrameTypeEnum enumeration"
ms.assetid: 61e40163-eee0-4c1f-af47-cef3771bdc41
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# StackFrameTypeEnum
Specifies the stack frame type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Frame pointer omitted; FPO info available.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Kernel Trap frame.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Kernel Trap frame.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Standard EBP stack frame.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Frame pointer omitted; Frame data info available.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Frame that does not have any debug info.  
  
## Remarks  
 The values in this enumeration are returned by a call to the [IDiaStackFrame::get_type](../vs140/idiastackframe--get_type.md) method.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../vs140/enumerations-and-structures.md)   
 [IDiaStackFrame::get_type](../vs140/idiastackframe--get_type.md)