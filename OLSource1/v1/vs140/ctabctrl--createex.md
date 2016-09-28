---
title: "CTabCtrl::CreateEx"
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
  - "CTabCtrl.CreateEx"
  - "CTabCtrl::CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: 5e8c47b1-f3ef-4c43-bff5-8306fe7ed01a
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::CreateEx
Creates a control (a child window) and associates it with the `CTabCtrl` object.  
  
## Syntax  
  
```  
  
      virtual BOOL CreateEx(  
  DWORD dwExStyle,  
  DWORD dwStyle,  
  const RECT& rect,  
  CWnd* pParentWnd,  
  UINT nID   
);  
```  
  
#### Parameters  
 `dwExStyle`  
 Specifies the extended style of the control being created. For a list of extended Windows styles, see the `dwExStyle` parameter for [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `dwStyle`  
 Specifies the tab control's style. Apply any combination of [tab control styles](http://msdn.microsoft.com/library/windows/desktop/bb760549), described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. See **Remarks** in [Create](../vs140/ctabctrl--create.md) for a list of window styles that you can also apply to the control.  
  
 `rect`  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of `pParentWnd`.  
  
 `pParentWnd`  
 A pointer to the window that is the control's parent.  
  
 `nID`  
 The control's child-window ID.  
  
## Return Value  
 Nonzero if successful otherwise 0.  
  
## Remarks  
 Use `CreateEx` instead of [Create](../vs140/ctabctrl--create.md) to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  
  
 `CreateEx` creates the control with the extended Windows styles specified by `dwExStyle`. Set extended styles specific to a control using [SetExtendedStyle](../vs140/ctabctrl--setextendedstyle.md). For example, use `CreateEx` to set such styles as **WS_EX_CONTEXTHELP**, but use `SetExtendedStyle` to set such styles as **TCS_EX_FLATSEPARATORS**. For more information, see the styles described in [Tab Control Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb760546) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::CTabCtrl](../vs140/ctabctrl--ctabctrl.md)