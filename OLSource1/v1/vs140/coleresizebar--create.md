---
title: "COleResizeBar::Create"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleResizeBar.Create
  - COleResizeBar::Create
dev_langs: 
  - C++
helpviewer_keywords: 
  - Create method [C++]
  - COleResizeBar class, construction
ms.assetid: a6db5507-822a-4def-a8fc-4b45990ba407
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleResizeBar::Create
Creates a child window and associates it with the `COleResizeBar` object.  
  
## Syntax  
  
```  
  
      virtual BOOL Create(  
   CWnd* pParentWnd,  
   DWORD dwStyle = WS_CHILD | WS_VISIBLE,  
   UINT nID = AFX_IDW_RESIZE_BAR   
);  
```  
  
#### Parameters  
 `pParentWnd`  
 Pointer to the parent window of the resize bar.  
  
 `dwStyle`  
 Specifies the [window style](../vs140/window-styles.md) attributes.  
  
 `nID`  
 The resize bar's child window ID.  
  
## Return Value  
 Nonzero if the resize bar was created; otherwise 0.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleResizeBar Class](../vs140/coleresizebar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Create](../vs140/cwnd--create.md)   
 [CControlBar Class](../vs140/ccontrolbar-class.md)