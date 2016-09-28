---
title: "CWnd::OnExitMenuLoop"
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
  - "CWnd::OnExitMenuLoop"
  - "CWnd.OnExitMenuLoop"
  - "OnExitMenuLoop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnExitMenuLoop method"
  - "CWnd class, menu loop notification"
ms.assetid: 68f6e58f-e9a1-4060-8cf8-8b3134787ae6
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnExitMenuLoop
The framework calls this member function when a menu modal loop has been exited.  
  
## Syntax  
  
```  
  
      afx_msg void OnExitMenuLoop(  
   BOOL bIsTrackPopupMenu   
);  
```  
  
#### Parameters  
 `bIsTrackPopupMenu`  
 Specifies whether the menu involved is a pop-up menu. Has a nonzero value if the function is successful; otherwise 0.  
  
## Remarks  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnEnterMenuLoop](../vs140/cwnd--onentermenuloop.md)   
 [WM_EXITMENULOOP](http://msdn.microsoft.com/library/windows/desktop/ms647599)