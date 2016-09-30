---
title: "COleMessageFilter::Register"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "COleMessageFilter::Register"
  - "COleMessageFilter.Register"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Register method"
  - "COleMessageFilter class, operations"
ms.assetid: 5eb85e9a-7b22-458e-b335-c7a73078a7f3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleMessageFilter::Register
Registers the message filter with the OLE system DLLs.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero on success; otherwise 0.  
  
## Remarks  
 A message filter has no effect unless it is registered with the system DLLs. Usually your application's initialization code registers the application's message filter. Any other message filter registered by your application should be revoked before the program terminates by a call to [Revoke](../vs140/colemessagefilter--revoke.md).  
  
 The framework's default message filter is automatically registered during initialization and revoked at termination.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleMessageFilter Class](../vs140/colemessagefilter-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleMessageFilter::Revoke](../vs140/colemessagefilter--revoke.md)