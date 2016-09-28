---
title: "COleResizeBar Class"
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
  - "COleResizeBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE items, resizing"
  - "in-place items"
  - "in-place items, resizing"
  - "resizing in-place OLE items"
  - "control bars, resizing"
  - "COleResizeBar class"
ms.assetid: 56a708d9-28c5-4eb0-9404-77b688d91c63
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleResizeBar Class
A type of control bar that supports resizing of in-place OLE items.  
  
## Syntax  
  
```  
class COleResizeBar : public CControlBar  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleResizeBar::COleResizeBar](#coleresizebar__coleresizebar)|Constructs a `COleResizeBar` object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleResizeBar::Create](#coleresizebar__create)|Creates and initializes a Windows child window and associates it to the `COleResizeBar` object.|  
  
## Remarks  
 `COleResizeBar` objects appear as a [CRectTracker](../vs140/crecttracker-class.md) with a hatched border and outer resize handles.  
  
 `COleResizeBar` objects are usually embedded members of frame-window objects derived from the [COleIPFrameWnd](../vs140/coleipframewnd-class.md) class.  
  
 For more information, see the article [Activation](../vs140/activation--c---.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CControlBar](../vs140/ccontrolbar-class.md)  
  
 `COleResizeBar`  
  
## Requirements  
 **Header:** afxole.h  
  
##  <a name="coleresizebar__coleresizebar"></a>  COleResizeBar::COleResizeBar  
 Constructs a `COleResizeBar` object.  
  
```  
COleResizeBar( );  
  
```  
  
### Remarks  
 Call **Create** to create the resize bar object.  
  
##  <a name="coleresizebar__create"></a>  COleResizeBar::Create  
 Creates a child window and associates it with the `COleResizeBar` object.  
  
```  
virtual BOOL Create(    CWnd* pParentWnd ,    DWORD dwStyle = WS_CHILD | WS_VISIBLE,    UINT nID = AFX_IDW_RESIZE_BAR );  
  
```  
  
### Parameters  
 `pParentWnd`  
 Pointer to the parent window of the resize bar.  
  
 `dwStyle`  
 Specifies the [window style](../vs140/window-styles.md) attributes.  
  
 `nID`  
 The resize bar's child window ID.  
  
### Return Value  
 Nonzero if the resize bar was created; otherwise 0.  
  
## See Also  
 [MFC Sample SUPERPAD](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc](../vs140/coleserverdoc-class.md)