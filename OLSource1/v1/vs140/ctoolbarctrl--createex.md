---
title: "CToolBarCtrl::CreateEx"
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
  - "CToolBarCtrl::CreateEx"
  - "CToolBarCtrl.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: 26e8dadc-2a50-4de3-ac7e-e4bdc7339686
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::CreateEx
Creates a control (a child window) and associates it with the `CToolBarCtrl` object.  
  
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
 Specifies the toolbar control's style. Toolbars must always have the **WS_CHILD** style. In addition, you can specify any combination of toolbar styles and window styles as described in the **Remarks** section of [Create](../vs140/ctoolbarctrl--create.md).  
  
 `rect`  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of `pParentWnd`.  
  
 `pParentWnd`  
 A pointer to the window that is the control's parent.  
  
 `nID`  
 The control's child-window ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Use `CreateEx` instead of [Create](../vs140/ctoolbarctrl--create.md) to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**. **CreateEx** creates the control with the extended Windows styles specified by `dwExStyle`. Set extended styles specific to a control using [SetExtendedStyle](../vs140/ctoolbarctrl--setextendedstyle.md). For example, use `CreateEx` to set such styles as **WS_EX_CONTEXTHELP**, but use `SetExtendedStyle` to set such styles as **TBSTYLE_EX_DRAWDDARROWS**. For more information, see the styles described in [Toolbar Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb760430) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::CToolBarCtrl](../vs140/ctoolbarctrl--ctoolbarctrl.md)