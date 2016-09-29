---
title: "CWnd::OnEnterIdle"
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
  - "OnEnterIdle"
  - "CWnd.OnEnterIdle"
  - "WM_ENTERIDLE"
  - "CWnd::OnEnterIdle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnEnterIdle method"
  - "WM_ENTERIDLE"
ms.assetid: 15e3a108-7e69-4be2-a1b0-b93a62e05fed
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnEnterIdle
The framework calls this member function to inform an application's main window procedure that a modal dialog box or a menu is entering an idle state.  
  
## Syntax  
  
```  
  
      afx_msg void OnEnterIdle(  
   UINT nWhy,  
   CWnd* pWho   
);  
```  
  
#### Parameters  
 `nWhy`  
 Specifies whether the message is the result of a dialog box or a menu being displayed. This parameter can be one of the following values:  
  
-   **MSGF_DIALOGBOX** The system is idle because a dialog box is being displayed.  
  
-   **MSGF_MENU** The system is idle because a menu is being displayed.  
  
 *pWho*  
 Specifies a pointer to the dialog box (if `nWhy` is **MSGF_DIALOGBOX**), or the window that contains the displayed menu (if `nWhy` is **MSGF_MENU**). This pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 A modal dialog box or menu enters an idle state when no messages are waiting in its queue after it has processed one or more previous messages.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_ENTERIDLE](http://msdn.microsoft.com/library/windows/desktop/ms645422)