---
title: "CCtrlView Class"
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
  - "CCtrlView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "views, and common controls"
  - "controls [MFC], common"
  - "CCtrlView class"
ms.assetid: ff488596-1e71-451f-8fec-b0831a7b44e0
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCtrlView Class
Adapts the document-view architecture to the common controls supported by Windows 98 and Windows NT versions 3.51 and later.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CCtrlView::CCtrlView](#cctrlview__cctrlview)|Constructs a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CCtrlView::OnDraw](#cctrlview__ondraw)|Called by the framework to draw using the specified device context.|  
|[CCtrlView::PreCreateWindow](#cctrlview__precreatewindow)|Called before the creation of the Windows window attached to this <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CCtrlView::m_dwDefaultStyle](#cctrlview__m_dwdefaultstyle)|Contains the default style for the view class.|  
|[CCtrlView::m_strClass](#cctrlview__m_strclass)|Contains the Windows class name for the view class.|  
  
## Remarks  
 The class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and its derivatives, [CEditView](../vs140/ceditview-class.md), [CListView](../vs140/clistview-class.md), [CTreeView](../vs140/ctreeview-class.md), and [CRichEditView](../vs140/cricheditview-class.md), adapt the document-view architecture to the new common controls supported by Windows 95/98 and Windows NT versions 3.51 and later. For more information on the document-view architecture, see [Document/View Architecture](../vs140/document-view-architecture.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CView](../vs140/cview-class.md)  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cctrlview__cctrlview">\</a>  CCtrlView::CCtrlView  
 Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Windows class name of the view class.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Style of the view class.  
  
### Remarks  
 The framework calls the constructor when a new frame window is created or a window is split. Override [CView::OnInitialUpdate](../vs140/cview-class.md#cview__oninitialupdate) to initialize the view after the document is attached. Call [CWnd::Create](../vs140/cwnd-class.md#cwnd__create) or [CWnd::CreateEx](../vs140/cwnd-class.md#cwnd__createex) to create the Windows object.  
  
##  \<a name="cctrlview__m_strclass">\</a>  CCtrlView::m_strClass  
 Contains the Windows class name for the view class.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="cctrlview__m_dwdefaultstyle">\</a>  CCtrlView::m_dwDefaultStyle  
 Contains the default style for the view class.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 This style is applied when a window is created.  
  
##  \<a name="cctrlview__ondraw">\</a>  CCtrlView::OnDraw  
 Called by the framework to draw the contents of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object using the specified device context.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A pointer to the device context in which the drawing occurs.  
  
### Remarks  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is typically called for screen display, passing a screen device context specified by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
##  \<a name="cctrlview__precreatewindow">\</a>  CCtrlView::PreCreateWindow  
 Called before the creation of the Windows window attached to this <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *cs*  
 A                                 [CREATESTRUCT](http://msdn.microsoft.com/library/windows/desktop/ms632603) structure.  
  
### Return Value  
 Nonzero if the window creation should continue; 0 to indicate creation failure.  
  
### Remarks  
 Never call this function directly.  
  
 The default implementation of this function checks for a **NULL** window class name and substitutes an appropriate default. Override this member function to modify the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> structure before the window is created.  
  
 Each class derived from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> adds its own functionality to its override of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. By design, these derivations of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> are not documented. To determine the styles appropriate to each class and the interdependencies between the styles, you can examine the MFC source code for your application's base class. If you choose to override <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, you can determine whether the styles used in your application's base class provide the functionality you need by using information gathered from the MFC source code.  
  
 For more information on changing window styles, see the [Changing the Styles of a Window Created by MFC](../vs140/changing-the-styles-of-a-window-created-by-mfc.md).  
  
## See Also  
 [Base Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeView](../vs140/ctreeview-class.md)   
 [CListView](../vs140/clistview-class.md)   
 [CRichEditView](../vs140/cricheditview-class.md)