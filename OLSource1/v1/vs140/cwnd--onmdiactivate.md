---
title: "CWnd::OnMDIActivate"
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
  - "CWnd.OnMDIActivate"
  - "CWnd::OnMDIActivate"
  - "OnMDIActivate"
  - "WM_MDIACTIVATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnMDIActivate method"
  - "CWnd class, MDI message handlers"
  - "WM_MDIACTIVATE"
ms.assetid: 4042e25d-4704-427e-afe9-095ec135ee04
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnMDIActivate
The framework calls this member function for the child window being deactivated and the child window being activated.  
  
## Syntax  
  
```  
  
      afx_msg void OnMDIActivate(  
   BOOL bActivate,  
   CWnd* pActivateWnd,  
   CWnd* pDeactivateWnd   
);  
```  
  
#### Parameters  
 `bActivate`  
 **TRUE** if the child is being activated and **FALSE** if it is being deactivated.  
  
 `pActivateWnd`  
 Contains a pointer to the MDI child window to be activated. When received by an MDI child window, `pActivateWnd` contains a pointer to the child window being activated. This pointer may be temporary and should not be stored for later use.  
  
 *pDeactivateWnd*  
 Contains a pointer to the MDI child window being deactivated. This pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 An MDI child window is activated independently of the MDI frame window. When the frame becomes active, the child window that was last activated with a `OnMDIActivate` call receives an [WM_NCACTIVATE](../vs140/cwnd--onncactivate.md) message to draw an active window frame and caption bar, but it does not receive another `OnMDIActivate` call.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMDIFrameWnd::MDIActivate](../vs140/cmdiframewnd--mdiactivate.md)   
 [CMDIFrameWnd::MDIActivate](../vs140/cmdiframewnd--mdiactivate.md)