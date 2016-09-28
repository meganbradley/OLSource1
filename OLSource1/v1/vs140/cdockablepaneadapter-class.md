---
title: "CDockablePaneAdapter Class"
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
  - "CDockablePaneAdapter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDockablePaneAdapter class"
ms.assetid: 6ed6cf82-f39c-4d0c-bf7c-8641495cf8f3
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePaneAdapter Class
Provides docking support for `CWnd`-derived panes.  
  
## Syntax  
  
```  
class CDockablePaneAdapter : public CDockablePane  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDockablePaneAdapter::CDockablePaneAdaptor::GetWrappedWnd](#cdockablepaneadapter__getwrappedwnd)|Returns the wrapped window.|  
|[CDockablePaneAdapter::LoadState](#cdockablepaneadapter__loadstate)|(Overrides [CDockablePane::LoadState](assetId:///96110136-4f46-4764-8a76-3b4abaf77917).)|  
|[CDockablePaneAdapter::SaveState](#cdockablepaneadapter__savestate)|(Overrides [CDockablePane::SaveState](assetId:///c5c24249-8d0d-46cb-96d9-9f5c6dc191db).)|  
|[CDockablePaneAdapter::SetWrappedWnd](#cdockablepaneadapter__setwrappedwnd)||  
  
## Remarks  
 Usually, the framework instantiates objects of this class when you use the [CMFCBaseTabCtrl::AddTab](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__addtab) or [CMFCBaseTabCtrl::InsertTab](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__inserttab) methods.  
  
 If you want to customize the `CDockablePaneAdapter` behavior, just derive a new class from it and set the runtime class information to a tabbed window by using [CMFCBaseTabCtrl::SetDockingBarWrapperRTC](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__setdockingbarwrapperrtc).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md) [CCmdTarget](../vs140/ccmdtarget-class.md) [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md) [CPane](../vs140/cpane-class.md) [CDockablePane](../vs140/cdockablepane-class.md)  
  
 [CDockablePaneAdapter](../vs140/cdockablepaneadapter-class.md)  
  
## Requirements  
 **Header:** afxDockablePaneAdapter.h  
  
##  <a name="cdockablepaneadapter__getwrappedwnd"></a>  CDockablePaneAdapter::GetWrappedWnd  
 Returns the underlying window for the dockable pane adapter.  
  
```  
virtual CWnd* GetWrappedWnd() const;  
```  
  
### Return Value  
 A pointer to the wrapped window.  
  
### Remarks  
 Use this function to access the wrapped window.  
  
##  <a name="cdockablepaneadapter__loadstate"></a>  CDockablePaneAdapter::LoadState  
 Loads the state of the pane from the registry.  
  
```  
virtual BOOL LoadState(  
   LPCTSTR lpszProfileName = NULL,  
   int nIndex = -1,  
   UINT uiID = (UINT) -1  
);  
```  
  
### Parameters  
 [in] `lpszProfileName`  
 The profile name.  
  
 [in] `nIndex`  
 The profile index.  
  
 [in] `uiID`  
 The pane ID.  
  
### Return Value  
  
### Remarks  
  
##  <a name="cdockablepaneadapter__savestate"></a>  CDockablePaneAdapter::SaveState  
 Saves the state of the pane to the registry.  
  
```  
virtual BOOL SaveState(  
   LPCTSTR lpszProfileName = NULL,  
   int nIndex = -1,  
   UINT uiID = (UINT) -1  
);  
```  
  
### Parameters  
 [in] `lpszProfileName`  
 The profile name.  
  
 [in] `nIndex`  
 The profile index (defaults to the control ID of the window).  
  
 [in] `uiID`  
 The pane ID.  
  
### Return Value  
  
### Remarks  
  
##  <a name="cdockablepaneadapter__setwrappedwnd"></a>  CDockablePaneAdapter::SetWrappedWnd  
 Sets the underlying window for the dockable pane adapter.  
  
```  
virtual BOOL SetWrappedWnd(  
   CWnd* pWnd  
);  
```  
  
### Parameters  
 [in] `pWnd`  
 A pointer to the window for the pane adapter to wrap.  
  
### Return Value  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CDockablePane Class](../vs140/cdockablepane-class.md)