---
title: "CListCtrl::CreateEx"
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
  - "CListCtrl::CreateEx"
  - "CListCtrl.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: e2ea862b-73bf-4613-8fcb-21970d44d9d2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::CreateEx
Creates a control (a child window) and associates it with the `CListCtrl` object.  
  
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
 Specifies the list control's style. Apply any combination of list control styles to the control. For a complete list of these styles, see [List view window styles](http://msdn.microsoft.com/library/windows/desktop/bb774739) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `rect`  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of `pParentWnd`.  
  
 `pParentWnd`  
 A pointer to the window that is the control's parent.  
  
 `nID`  
 The control's child-window ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Use `CreateEx` instead of [Create](../vs140/clistctrl--create.md) to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  
  
 `CreateEx` creates the control with the extended Windows styles specified by `dwExStyle`. To set extended styles specific to a control, call [SetExtendedStyle](../vs140/clistctrl--setextendedstyle.md). For example, use `CreateEx` to set such styles as **WS_EX_CONTEXTHELP**, but use `SetExtendedStyle` to set such styles as **LVS_EX_FULLROWSELECT**. For more information, see the styles described in the topic [Extended List View Styles](http://msdn.microsoft.com/library/windows/desktop/bb774732) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::CListCtrl](../vs140/clistctrl--clistctrl.md)