---
title: "CTreeView Class"
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
  - CTreeView
dev_langs: 
  - C++
helpviewer_keywords: 
  - directory lists
  - tree view controls
  - file lists [C++]
  - CTreeView class, common controls
  - CTreeView class
ms.assetid: 5df583a6-d69f-42ca-9d8d-57e04558afff
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeView Class
Simplifies use of the tree control and of [CTreeCtrl](../vs140/ctreectrl-class.md), the class that encapsulates tree-control functionality, with MFC's document-view architecture.  
  
## Syntax  
  
```  
class CTreeView : public CCtrlView  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CTreeView::CTreeView](#ctreeview__ctreeview)|Constructs a `CTreeView` object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CTreeView::GetTreeCtrl](#ctreeview__gettreectrl)|Returns the tree control associated with the view.|  
  
## Remarks  
 For more information on this architecture, see the overview for the [CView](../vs140/cview-class.md) class and the cross-references cited there.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CView](../vs140/cview-class.md)  
  
 [CCtrlView](../vs140/cctrlview-class.md)  
  
 `CTreeView`  
  
## Requirements  
 **Header:** afxcview.h  
  
##  <a name="ctreeview__ctreeview"></a>  CTreeView::CTreeView  
 Constructs a `CTreeView` object.  
  
```  
CTreeView( );  
  
```  
  
##  <a name="ctreeview__gettreectrl"></a>  CTreeView::GetTreeCtrl  
 Returns a reference to the tree control associated with the view.  
  
```  
CTreeCtrl& GetTreeCtrl( ) const;  
  
```  
  
## See Also  
 [Base Class](../vs140/cctrlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView](../vs140/cview-class.md)   
 [CCtrlView](../vs140/cctrlview-class.md)   
 [CTreeCtrl](../vs140/ctreectrl-class.md)