---
title: "CTabCtrl::Create"
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
  - "CTabCtrl::Create"
  - "CTabCtrl.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
  - "tab controls, styles"
ms.assetid: 7ea1cc02-e82e-4400-b08b-8c85f47116e5
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::Create
Creates a tab control and attaches it to an instance of a `CTabCtrl` object.  
  
## Syntax  
  
```  
  
      virtual BOOL Create(  
  DWORD dwStyle,  
  const RECT& rect,  
  CWnd* pParentWnd,  
  UINT nID   
);  
```  
  
#### Parameters  
 `dwStyle`  
 Specifies the tab control's style. Apply any combination of [tab control styles](http://msdn.microsoft.com/library/windows/desktop/bb760549), described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. See **Remarks** for a list of window styles that you can also apply to the control.  
  
 `rect`  
 Specifies the tab control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
 `pParentWnd`  
 Specifies the tab control's parent window, usually a `CDialog`. It must not be **NULL**.  
  
 `nID`  
 Specifies the tab control's ID.  
  
## Return Value  
 **TRUE** if initialization of the object was successful; otherwise **FALSE**.  
  
## Remarks  
 You construct a `CTabCtrl` object in two steps. First, call the constructor, and then call **Create**, which creates the tab control and attaches it to the `CTabCtrl` object.  
  
 In addition to tab control styles, you can apply the following window styles to a tab control:  
  
-   **WS_CHILD** Creates a child window that represents the tab control. Cannot be used with the `WS_POPUP` style.  
  
-   **WS_VISIBLE** Creates a tab control that is initially visible.  
  
-   **WS_DISABLED** Creates a window that is initially disabled.  
  
-   **WS_GROUP** Specifies the first control of a group of controls in which the user can move from one control to the next with the arrow keys. All controls defined with the **WS_GROUP** style after the first control belong to the same group. The next control with the **WS_GROUP** style ends the style group and starts the next group (that is, one group ends where the next begins).  
  
-   **WS_TABSTOP** Specifies one of any number of controls through which the user can move by using the TAB key. The TAB key moves the user to the next control specified by the **WS_TABSTOP** style.  
  
 To create a tab control with extended window styles, call [CTabCtrl::CreateEx](../vs140/ctabctrl--createex.md) instead of **Create**.  
  
## Example  
 [!code[NVC_MFC_CTabCtrl#2](../vs140/codesnippet/CPP/ctabctrl--create_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::CTabCtrl](../vs140/ctabctrl--ctabctrl.md)