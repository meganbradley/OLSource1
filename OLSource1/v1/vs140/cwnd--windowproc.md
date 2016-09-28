---
title: "CWnd::WindowProc"
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
  - "CWnd.WindowProc"
  - "CWnd::WindowProc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WindowProc method"
  - "Windows procedures [C++]"
  - "CWnd class, operations"
ms.assetid: 81390b70-464e-4289-898c-c1ab617e7662
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::WindowProc
Provides a Windows procedure (`WindowProc`) for a `CWnd` object.  
  
## Syntax  
  
```  
  
      virtual LRESULT WindowProc(  
   UINT message,  
   WPARAM wParam,  
   LPARAM lParam   
);  
```  
  
#### Parameters  
 `message`  
 Specifies the Windows message to be processed.  
  
 `wParam`  
 Provides additional information used in processing the message. The parameter value depends on the message.  
  
 `lParam`  
 Provides additional information used in processing the message. The parameter value depends on the message.  
  
## Return Value  
 The return value depends on the message.  
  
## Remarks  
 It dispatches messages through the window's message map.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)