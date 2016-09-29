---
title: "CProgressCtrl::Create"
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
  - "CProgressCtrl.Create"
  - "CProgressCtrl::Create"
  - "PBS_SMOOTH"
  - "PBS_VERTICAL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
  - "PBS_SMOOTH constant"
  - "PBS_VERTICAL constant"
ms.assetid: 63cf3e18-53cc-460a-9454-e7de2aece306
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CProgressCtrl::Create
Creates a progress bar control and attaches it to a `CProgressCtrl` object.  
  
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
 Specifies the progress bar control's style. Apply any combination of window stylesdescribed in [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)], in addition to the following progress bar control styles, to the control:  
  
-   `PBS_VERTICAL` Displays progress information vertically, top to bottom. Without this flag, the progress bar control displays horizontally, left to right.  
  
-   `PBS_SMOOTH` Displays gradual, smooth filling in the progress bar control. Without this flag, the control will fill with blocks.  
  
 `rect`  
 Specifies the progress bar control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure. Because the control must be a child window, the specified coordinates are relative to the client area of the `pParentWnd`.  
  
 `pParentWnd`  
 Specifies the progress bar control's parent window, usually a `CDialog`. It must not be **NULL.**  
  
 `nID`  
 Specifies the progress bar control's ID.  
  
## Return Value  
 **TRUE** if the `CProgressCtrl` object is successfully created; otherwise **FALSE**.  
  
## Remarks  
 You construct a `CProgressCtrl` object in two steps. First, call the constructor, which creates the `CProgressCtrl` object, and then call **Create**, which creates the progress bar control.  
  
## Example  
 [!code[NVC_MFC_CProgressCtrl#2](../vs140/codesnippet/CPP/cprogressctrl--create_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CProgressCtrl::CProgressCtrl](../vs140/cprogressctrl--cprogressctrl.md)   
 [CProgressCtrl::CreateEx](../vs140/cprogressctrl--createex.md)