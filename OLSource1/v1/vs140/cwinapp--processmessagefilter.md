---
title: "CWinApp::ProcessMessageFilter"
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
  - "CWinApp::ProcessMessageFilter"
  - "ProcessMessageFilter"
  - "CWinApp.ProcessMessageFilter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message filters"
  - "CWinApp class, overridables"
  - "ProcessMessageFilter method"
ms.assetid: a056150f-245f-4bb9-9938-715c7f82a416
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::ProcessMessageFilter
The framework's hook function calls this member function to filter and respond to certain Windows messages.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies a hook code. This member function uses the code to determine how to process <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a Windows [MSG](../vs140/msg-structure.md) structure.  
  
## Return Value  
 Nonzero if the message is processed; otherwise 0.  
  
## Remarks  
 A hook function processes events before they are sent to the application's normal message processing.  
  
 If you override this advanced feature, be sure to call the base-class version to maintain the framework's hook processing.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [MessageProc](http://msdn.microsoft.com/library/windows/desktop/ms644987)   
 [About Hooks](http://msdn.microsoft.com/library/windows/desktop/ms644959)