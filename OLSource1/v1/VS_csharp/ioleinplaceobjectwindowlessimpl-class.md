---
title: "IOleInPlaceObjectWindowlessImpl Class"
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
  - "IOleInPlaceObjectWindowlessImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IOleInPlaceObjectWindowless, ATL implementation"
  - "activation [C++], ATL"
  - "IOleInPlaceObjectWindowlessImpl class"
  - "ActiveX controls [C++], communication between container and control"
  - "controls [ATL], windowless"
  - "deactivating ATL"
ms.assetid: a2e0feb4-bc59-4adf-aab2-105457bbdbb4
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleInPlaceObjectWindowlessImpl Class
This class implements **IUnknown** and provides methods that enable a windowless control to receive window messages and to participate in drag-and-drop operations.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
template< class  T>  
   class IOleInPlaceObjectWindowlessImpl  
  
```  
  
#### Parameters  
 `T`  
 Your class, derived from `IOleInPlaceObjectWindowlessImpl`.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IOleInPlaceObjectWindowlessImpl::ContextSensitiveHelp](../VS_csharp/ioleinplaceobjectwindowlessimpl--contextsensitivehelp.md)|Enables context-sensitive help. The ATL implementation returns **E_NOTIMPL**.|  
|[IOleInPlaceObjectWindowlessImpl::GetDropTarget](../VS_csharp/ioleinplaceobjectwindowlessimpl--getdroptarget.md)|Supplies the `IDropTarget` interface for an in-place active, windowless object that supports drag and drop. The ATL implementation returns **E_NOTIMPL**.|  
|[IOleInPlaceObjectWindowlessImpl::GetWindow](../VS_csharp/ioleinplaceobjectwindowlessimpl--getwindow.md)|Gets a window handle.|  
|[IOleInPlaceObjectWindowlessImpl::InPlaceDeactivate](../VS_csharp/ioleinplaceobjectwindowlessimpl--inplacedeactivate.md)|Deactivates an active in-place control.|  
|[IOleInPlaceObjectWindowlessImpl::OnWindowMessage](../VS_csharp/ioleinplaceobjectwindowlessimpl--onwindowmessage.md)|Dispatches a message from the container to a windowless control that is in-place active.|  
|[IOleInPlaceObjectWindowlessImpl::ReactivateAndUndo](../VS_csharp/ioleinplaceobjectwindowlessimpl--reactivateandundo.md)|Reactivates a previously deactivated control. The ATL implementation returns **E_NOTIMPL**.|  
|[IOleInPlaceObjectWindowlessImpl::SetObjectRects](../VS_csharp/ioleinplaceobjectwindowlessimpl--setobjectrects.md)|Indicates what part of the in-place control is visible.|  
|[IOleInPlaceObjectWindowlessImpl::UIDeactivate](../VS_csharp/ioleinplaceobjectwindowlessimpl--uideactivate.md)|Deactivates and removes the user interface that supports in-place activation.|  
  
## Remarks  
 The [IOleInPlaceObject](http://msdn.microsoft.com/library/windows/desktop/ms692646) interface manages the reactivation and deactivation of in-place controls and determines how much of the control should be visible. The [IOleInPlaceObjectWindowless](http://msdn.microsoft.com/library/windows/desktop/ms687304) interface enables a windowless control to receive window messages and to participate in drag-and-drop operations. Class `IOleInPlaceObjectWindowlessImpl` provides a default implementation of `IOleInPlaceObject` and `IOleInPlaceObjectWindowless` and implements **IUnknown** by sending information to the dump device in debug builds.  
  
 **Related Articles** [ATL Tutorial](../VS_csharp/active-template-library--atl--tutorial.md), [Creating an ATL Project](../VS_csharp/creating-an-atl-project.md)  
  
## Inheritance Hierarchy  
 `IOleInPlaceObjectWindowless`  
  
 `IOleInPlaceObjectWindowlessImpl`  
  
## Requirements  
 **Header:** atlctl.h  
  
##  <a name="ioleinplaceobjectwindowlessimpl__contextsensitivehelp"></a>  IOleInPlaceObjectWindowlessImpl::ContextSensitiveHelp  
 Returns **E_NOTIMPL**.  
  
```  
  
HRESULT ContextSensitiveHelp(  
      BOOL  fEnterMode  
   );  
  
```  
  
### Remarks  
 See [IOleWindow::ContextSensitiveHelp](http://msdn.microsoft.com/library/windows/desktop/ms680059) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="ioleinplaceobjectwindowlessimpl__getdroptarget"></a>  IOleInPlaceObjectWindowlessImpl::GetDropTarget  
 Returns **E_NOTIMPL**.  
  
```  
  
HRESULT GetDropTarget(  
      IDropTarget**  ppDropTarget  
   );  
  
```  
  
### Remarks  
 See [IOleInPlaceObjectWindowless::GetDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms678535) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="ioleinplaceobjectwindowlessimpl__getwindow"></a>  IOleInPlaceObjectWindowlessImpl::GetWindow  
 The container calls this function to get the window handle of the control.  
  
```  
  
HRESULT GetWindow(  
      HWND*  phwnd  
   );  
  
```  
  
### Remarks  
 Some containers will not work with a control that has been windowless, even if it is currently windowed. In ATL's implementation, if the control class's data member `m_bWasOnceWindowless` is **TRUE**, the function returns **E_FAIL**. Otherwise, if *phwnd* is not **NULL**, `GetWindow` sets \* *phwnd* to the control class's data member `m_hWnd` and returns `S_OK`.  
  
 See [IOleWindow::GetWindow](http://msdn.microsoft.com/library/windows/desktop/ms687282) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="ioleinplaceobjectwindowlessimpl__inplacedeactivate"></a>  IOleInPlaceObjectWindowlessImpl::InPlaceDeactivate  
 Called by the container to deactivate an in-place active control.  
  
```  
  
HRESULT InPlaceDeactivate(  
      HWND*  phwnd  
   );  
  
```  
  
### Remarks  
 This method performs a full or partial deactivation depending on the state of the control. If necessary, the control's user interface is deactivated, and the control's window, if any, is destroyed. The container is notified that the control is no longer active in place. The **IOleInPlaceUIWindow** interface used by the container to negotiate menus and border space is released.  
  
 See [IOleInPlaceObject::InPlaceDeactivate](http://msdn.microsoft.com/library/windows/desktop/ms679700) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="ioleinplaceobjectwindowlessimpl__onwindowmessage"></a>  IOleInPlaceObjectWindowlessImpl::OnWindowMessage  
 Dispatches a message from a container to a windowless control that is in-place active.  
  
```  
  
HRESULT OnWindowMessage(  
      UINT  msg,  
      WPARAM  WParam,  
      LPARAM  LParam,  
      LRESULT  plResultParam  
   );  
  
```  
  
### Remarks  
 See [IOleInPlaceObjectWindowless::OnWindowMessage](http://msdn.microsoft.com/library/windows/desktop/ms693783) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="ioleinplaceobjectwindowlessimpl__reactivateandundo"></a>  IOleInPlaceObjectWindowlessImpl::ReactivateAndUndo  
 Returns **E_NOTIMPL**.  
  
```  
  
HRESULT ReactivateAndUndo( );  
  
```  
  
### Remarks  
 See [IOleInPlaceObject::ReactivateAndUndo](http://msdn.microsoft.com/library/windows/desktop/ms691372) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="ioleinplaceobjectwindowlessimpl__setobjectrects"></a>  IOleInPlaceObjectWindowlessImpl::SetObjectRects  
 Called by the container to inform the control that its size and/or position has changed.  
  
```  
  
HRESULT SetObjectRects(  
      LPCRECT  prcPos,  
      LPCRECT  prcClip  
   );  
  
```  
  
### Remarks  
 Updates the control's `m_rcPos` data member and the control display. Only the part of the control that intersects the clip region is displayed. If a control's display was previously clipped but the clipping has been removed, this function can be called to redraw a full view of the control.  
  
 See [IOleInPlaceObject::SetObjectRects](http://msdn.microsoft.com/library/windows/desktop/ms683767) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="ioleinplaceobjectwindowlessimpl__uideactivate"></a>  IOleInPlaceObjectWindowlessImpl::UIDeactivate  
 Deactivates and removes the control's user interface that supports in-place activation.  
  
```  
  
HRESULT UIDeactivate(  
   );  
  
```  
  
### Remarks  
 Sets the control class's data member `m_bUIActive` to **FALSE**. The ATL implementation of this function always returns `S_OK`.  
  
 See [IOleInPlaceObject::UIDeactivate](http://msdn.microsoft.com/library/windows/desktop/ms693348) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## See Also  
 [CComControl Class](../VS_csharp/ccomcontrol-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)