---
title: "CMDIFrameWndEx::OnEraseMDIClientBackground"
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
  - "CMDIFrameWndEx::OnEraseMDIClientBackground"
  - "OnEraseMDIClientBackground"
  - "CMDIFrameWndEx.OnEraseMDIClientBackground"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnEraseMDIClientBackground method"
ms.assetid: 971adfa2-0d93-40a6-8b74-b5f856088c84
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::OnEraseMDIClientBackground
Called by the framework when the MDI frame window processes a `WM_ERASEBKGND` message.  
  
## Syntax  
  
```  
virtual BOOL OnEraseMDIClientBackground(  
   CDC*    
);  
```  
  
## Return Value  
 `TRUE` if the application processes the message and erases the background.  
  
## Remarks  
 Override this member function if you want to process the `WM_ERASEBKGND` message in a `CMDIFrameWndEx`-derived class.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)