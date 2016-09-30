---
title: "CWnd::DefWindowProc"
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
  - "CWnd.DefWindowProc"
  - "CWnd::DefWindowProc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DefWindowProc method"
  - "CWnd class, operations"
ms.assetid: 4a8b4438-2dad-48d6-bb22-9685f2902c58
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::DefWindowProc
Calls the default window procedure, which provides default processing for any window message that an application does not process.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the Windows message to be processed.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies additional message-dependent information.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies additional message-dependent information.  
  
## Return Value  
 Depends on the message sent.  
  
## Remarks  
 This member function ensures that every message is processed. It should be called with the same parameters as those received by the window procedure.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Default](../vs140/cwnd--default.md)   
 [DefWindowProc](http://msdn.microsoft.com/library/windows/desktop/ms633572)