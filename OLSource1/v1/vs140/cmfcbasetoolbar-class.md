---
title: "CMFCBaseToolBar Class"
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
  - "CMFCBaseToolBar::CreateObject"
  - "~CMFCBaseToolBar"
  - "CMFCBaseToolBar"
  - "CMFCBaseToolBar::CMFCBaseToolBar"
  - "CMFCBaseToolBar::~CMFCBaseToolBar"
  - "CMFCBaseToolBar.~CMFCBaseToolBar"
  - "CreateObject"
  - "CMFCBaseToolBar.CMFCBaseToolBar"
  - "CMFCBaseToolBar.CreateObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCBaseToolBar class, constructor"
  - "CMFCBaseToolBar class, destructor"
  - "~CMFCBaseToolBar destructor"
  - "CreateObject method"
  - "CMFCBaseToolBar class"
ms.assetid: 5d79206d-55e4-46f8-b1b8-042e34d7f9da
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseToolBar Class
Base class for toolbars.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|[CMFCBaseToolBar::GetDockingMode](#cmfcbasetoolbar__getdockingmode)|Returns the docking mode. (Overrides [CBasePane::GetDockingMode](../vs140/cbasepane-class.md#cbasepane__getdockingmode).)|  
|[CMFCBaseToolBar::GetMinSize](#cmfcbasetoolbar__getminsize)|Returns the minimum size of a toolbar. (Overrides [CPane::GetMinSize](../vs140/cpane-class.md#cpane__getminsize).)|  
|[CMFCBaseToolBar::OnAfterChangeParent](#cmfcbasetoolbar__onafterchangeparent)|Called by the framework after the pane's parent changes. (Overrides [CBasePane::OnAfterChangeParent](../vs140/cbasepane-class.md#cbasepane__onafterchangeparent).)|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
 [CMFCBaseToolBar](../vs140/cmfcbasetoolbar-class.md)  
  
## Requirements  
 **Header:** afxbasetoolbar.h  
  
##  \<a name="cmfcbasetoolbar__getdockingmode">\</a>  CMFCBaseToolBar::GetDockingMode  
 Returns the docking mode.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The docking mode.  
  
##  \<a name="cmfcbasetoolbar__getminsize">\</a>  CMFCBaseToolBar::GetMinSize  
 Returns the minimum size of a toolbar.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The minimum size of a toolbar.  
  
##  \<a name="cmfcbasetoolbar__onafterchangeparent">\</a>  CMFCBaseToolBar::OnAfterChangeParent  
 Called by the framework after the pane's parent changes.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to the previous parent window.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)