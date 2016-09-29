---
title: "IViewObjectExImpl Class"
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
  - "ATL::IViewObjectExImpl<T>"
  - "ATL.IViewObjectExImpl"
  - "ATL::IViewObjectExImpl"
  - "ATL.IViewObjectExImpl<T>"
  - "IViewObjectExImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActiveX controls [C++], drawing"
  - "IViewObjectEx ATL implementation"
  - "advise sinks"
  - "IViewObjectExImpl class"
ms.assetid: ad6de760-1ee5-4883-b033-ae57beffc369
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IViewObjectExImpl Class
This class implements **IUnknown** and provides default implementations of the [IViewObject](http://msdn.microsoft.com/library/windows/desktop/ms680763), [IViewObject2](http://msdn.microsoft.com/library/windows/desktop/ms691318), and [IViewObjectEx](http://msdn.microsoft.com/library/windows/desktop/ms682375) interfaces.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
template<  
   class  T>  
   class ATL_NO_VTABLE IViewObjectExImpl :  
   public IViewObjectEx  
  
```  
  
#### Parameters  
 `T`  
 Your class, derived from `IViewObjectExImpl`.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IViewObjectExImpl::Draw](../vs140/iviewobjecteximpl--draw.md)|Draws a representation of the control onto a device context.|  
|[IViewObjectExImpl::Freeze](../vs140/iviewobjecteximpl--freeze.md)|Freezes the drawn representation of a control so it won't change until an `Unfreeze`. The ATL implementation returns **E_NOTIMPL**.|  
|[IViewObjectExImpl::GetAdvise](../vs140/iviewobjecteximpl--getadvise.md)|Retrieves an existing advisory sink connection on the control, if there is one.|  
|[IViewObjectExImpl::GetColorSet](../vs140/iviewobjecteximpl--getcolorset.md)|Returns the logical palette used by the control for drawing. The ATL implementation returns **E_NOTIMPL**.|  
|[IViewObjectExImpl::GetExtent](../vs140/iviewobjecteximpl--getextent.md)|Retrieves the control's display size in HIMETRIC units (0.01 millimeter per unit) from the control class data member [CComControlBase::m_sizeExtent](../vs140/ccomcontrolbase--m_sizeextent.md).|  
|[IViewObjectExImpl::GetNaturalExtent](../vs140/iviewobjecteximpl--getnaturalextent.md)|Provides sizing hints from the container for the object to use as the user resizes it.|  
|[IViewObjectExImpl::GetRect](../vs140/iviewobjecteximpl--getrect.md)|Returns a rectangle describing a requested drawing aspect. The ATL implementation returns **E_NOTIMPL**.|  
|[IViewObjectExImpl::GetViewStatus](../vs140/iviewobjecteximpl--getviewstatus.md)|Returns information about the opacity of the object and what drawing aspects are supported.|  
|[IViewObjectExImpl::QueryHitPoint](../vs140/iviewobjecteximpl--queryhitpoint.md)|Checks if the specified point is in the specified rectangle and returns a [HITRESULT](http://msdn.microsoft.com/library/windows/desktop/ms682187) value in `pHitResult`.|  
|[IViewObjectExImpl::QueryHitRect](../vs140/iviewobjecteximpl--queryhitrect.md)|Checks whether the control's display rectangle overlaps any point in the specified location rectangle and returns a **HITRESULT** value in `pHitResult`.|  
|[IViewObjectExImpl::SetAdvise](../vs140/iviewobjecteximpl--setadvise.md)|Sets up a connection between the control and an advise sink so the sink can be notified about changes in the control's view.|  
|[IViewObjectExImpl::Unfreeze](../vs140/iviewobjecteximpl--unfreeze.md)|Unfreezes the drawn representation of the control. The ATL implementation returns **E_NOTIMPL**.|  
  
## Remarks  
 The [IViewObject](http://msdn.microsoft.com/library/windows/desktop/ms680763), [IViewObject2](http://msdn.microsoft.com/library/windows/desktop/ms691318), and [IViewObjectEx](http://msdn.microsoft.com/library/windows/desktop/ms682375) interfaces enable a control to display itself directly, and to create and manage an advise sink to notify the container of changes in the control display. The **IViewObjectEx** interface provides support for extended control features such as flicker-free drawing, non-rectangular and transparent controls, and hit-testing (for example, how close a mouse click must be to be considered on the control). Class `IViewObjectExImpl` provides a default implementation of these interfaces and implements **IUnknown** by sending information to the dump device in debug builds.  
  
## Inheritance Hierarchy  
 `IViewObjectEx`  
  
 `IViewObjectExImpl`  
  
## Requirements  
 **Header:** atlctl.h  
  
##  <a name="iviewobjecteximpl__draw"></a>  IViewObjectExImpl::Draw  
 Draws a representation of the control onto a device context.  
  
```  
  
STDMETHOD(Draw)(  
      DWORD  dwDrawAspect,  
   LONG  lindex,  
   void*  pvAspect,  
   DVTARGETDEVICE*  ptd,  
   HDC  hicTargetDev,  
   LPCRECTL  prcBounds,  
   LPCRECTL  prcWBounds,  
   BOOL(_stdcall *  /* pfnContinue   
   /) (DWORD_PTR  dwContinue  
   ),  
      DWORD_PTR  /* dwContinue */  
   );  
  
```  
  
### Remarks  
 This method calls **CComControl::OnDrawAdvanced** which in turn calls your control class's `OnDraw` method. An `OnDraw` method is automatically added to your control class when you create your control with the ATL Control Wizard. The Wizard's default `OnDraw` draws a rectangle with the label "ATL 3.0".  
  
 See [IViewObject::Draw](http://msdn.microsoft.com/library/windows/desktop/ms688655) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iviewobjecteximpl__freeze"></a>  IViewObjectExImpl::Freeze  
 Freezes the drawn representation of a control so it won't change until an `Unfreeze`. The ATL implementation returns **E_NOTIMPL**.  
  
```  
  
STDMETHOD(Freeze)(  
      DWORD  /* dwAspect */,  
   LONG  /* lindex */,  
   void*  /* pvAspect */,  
   DWORD*  /* pdwFreeze */  
   );  
  
```  
  
### Remarks  
 See [IViewObject::Freeze](http://msdn.microsoft.com/library/windows/desktop/ms688728) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iviewobjecteximpl__getadvise"></a>  IViewObjectExImpl::GetAdvise  
 Retrieves an existing advisory sink connection on the control, if there is one.  
  
```  
  
STDMETHOD(GetAdvise)(  
      DWORD*  /* pAspects */,  
   DWORD*  /* pAdvf */,  
   IAdviseSink**  /* ppAdvSink */  
   );  
  
```  
  
### Remarks  
 The advisory sink is stored in the control class data member [CComControlBase::m_spAdviseSink](../vs140/ccomcontrolbase--m_spadvisesink.md).  
  
 See [IViewObject::GetAdvise](http://msdn.microsoft.com/library/windows/desktop/ms692772) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iviewobjecteximpl__getcolorset"></a>  IViewObjectExImpl::GetColorSet  
 Returns the logical palette used by the control for drawing. The ATL implementation returns **E_NOTIMPL**.  
  
```  
  
STDMETHOD(GetColorSet)(  
      DWORD  /* dwAspect */,  
   LONG  /* lindex */,  
   void*  /* pvAspect */,  
   DVTARGETDEVICE*  /* ptd */,  
   HDC  /* hicTargetDevice */,  
   LOGPALETTE**  /* ppColorSet */  
   );  
  
```  
  
### Remarks  
 See [IViewObject::GetColorSet](http://msdn.microsoft.com/library/windows/desktop/ms686553) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iviewobjecteximpl__getextent"></a>  IViewObjectExImpl::GetExtent  
 Retrieves the control's display size in HIMETRIC units (0.01 millimeter per unit) from the control class data member [CComControlBase::m_sizeExtent](../vs140/ccomcontrolbase--m_sizeextent.md).  
  
```  
  
STDMETHOD(GetExtent)(  
      DWORD  /* dwDrawAspect */,  
   LONG  /* lindex */,  
   DVTARGETDEVICE*  /* ptd */,  
   LPSIZEL*  lpsizel  
   );  
  
```  
  
### Remarks  
 See [IViewObject2::GetExtent](http://msdn.microsoft.com/library/windows/desktop/ms684032) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iviewobjecteximpl__getnaturalextent"></a>  IViewObjectExImpl::GetNaturalExtent  
 Provides sizing hints from the container for the object to use as the user resizes it.  
  
```  
  
STDMETHOD(GetNaturalExtent)(  
      DWORD  dwAspect,  
   LONG  /* lindex */,  
   DVTARGETDEVICE*  /* ptd */,  
   HDC  /* hicTargetDevice */,  
   DVEXTENTINFO*  pExtentInfo,  
   LPSIZEL  psizel  
   );  
  
```  
  
### Remarks  
 If `dwAspect` is `DVASPECT_CONTENT` and *pExtentInfo->dwExtentMode* is **DVEXTENT_CONTENT**, sets * `psizel` to the control class's data member [CComControlBase::m_sizeNatural](../vs140/ccomcontrolbase--m_sizenatural.md). Otherwise, returns an error `HRESULT`.  
  
 See [IViewObjectEx::GetNaturalExtent](http://msdn.microsoft.com/library/windows/desktop/ms683718) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iviewobjecteximpl__getrect"></a>  IViewObjectExImpl::GetRect  
 Returns a rectangle describing a requested drawing aspect. The ATL implementation returns **E_NOTIMPL**.  
  
```  
  
STDMETHOD(GetRect)(  
      DWORD  /* dwAspect */,  
   LPRECTL  /* pRect */  
   );  
  
```  
  
### Remarks  
 See [IViewObjectEx::GetRect](http://msdn.microsoft.com/library/windows/desktop/ms695246) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iviewobjecteximpl__getviewstatus"></a>  IViewObjectExImpl::GetViewStatus  
 Returns information about the opacity of the object and what drawing aspects are supported.  
  
```  
  
STDMETHOD(GetViewStatus)(  
      DWORD*  pdwStatus  
   );  
  
```  
  
### Remarks  
 By default, ATL sets `pdwStatus` to indicate that the control supports **VIEWSTATUS_OPAQUE** (possible values are in the [VIEWSTATUS](http://msdn.microsoft.com/library/windows/desktop/ms687201) enumeration).  
  
 See [IViewObjectEx::GetViewStatus](http://msdn.microsoft.com/library/windows/desktop/ms693371) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iviewobjecteximpl__queryhitpoint"></a>  IViewObjectExImpl::QueryHitPoint  
 Checks if the specified point is in the specified rectangle and returns a [HITRESULT](http://msdn.microsoft.com/library/windows/desktop/ms682187) value in `pHitResult`.  
  
```  
  
STDMETHOD(QueryHitPoint)(  
      DWORD  dwAspect,  
   LPCRECT  pRectBounds,  
   POINT  ptlLoc,  
   LONG  /* lCloseHit */,  
   DWORD*  /* pHitResult */   
   );  
  
```  
  
### Remarks  
 The value can be either **HITRESULT_HIT** or **HITRESULT_OUTSIDE**.  
  
 If `dwAspect` equals [DVASPECT_CONTENT](http://msdn.microsoft.com/library/windows/desktop/ms690318), the method returns `S_OK`. Otherwise, the method returns **E_FAIL**.  
  
 See [IViewObjectEx::QueryHitPoint](http://msdn.microsoft.com/library/windows/desktop/ms691209) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iviewobjecteximpl__queryhitrect"></a>  IViewObjectExImpl::QueryHitRect  
 Checks whether the control's display rectangle overlaps any point in the specified location rectangle and returns a [HITRESULT](http://msdn.microsoft.com/library/windows/desktop/ms682187) value in `pHitResult`.  
  
```  
  
STDMETHOD(QueryHitRect)(  
      DWORD  dwAspect,  
   LPCRECT  pRectBounds,  
   LPRECT  prcLoc,  
   LONG  /* lCloseHit */,  
   DWORD*  /* pHitResult */  
   );  
  
```  
  
### Remarks  
 The value can be either **HITRESULT_HIT** or **HITRESULT_OUTSIDE**.  
  
 If `dwAspect` equals [DVASPECT_CONTENT](http://msdn.microsoft.com/library/windows/desktop/ms690318), the method returns `S_OK`. Otherwise, the method returns **E_FAIL**.  
  
 See [IViewObjectEx::QueryHitRect](http://msdn.microsoft.com/library/windows/desktop/ms693797) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iviewobjecteximpl__setadvise"></a>  IViewObjectExImpl::SetAdvise  
 Sets up a connection between the control and an advise sink so the sink can be notified about changes in the control's view.  
  
```  
  
STDMETHOD(SetAdvise)(  
      DWORD  /* aspects */,  
   DWORD  /* advf */,  
   IAdviseSink*  pAdvSink  
   );  
  
```  
  
### Remarks  
 The pointer to the [IAdviseSink](http://msdn.microsoft.com/library/windows/desktop/ms692513) interface on the advise sink is stored in the control class data member [CComControlBase::m_spAdviseSink](../vs140/ccomcontrolbase--m_spadvisesink.md).  
  
 See [IViewObject::SetAdvise](http://msdn.microsoft.com/library/windows/desktop/ms683950) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iviewobjecteximpl__unfreeze"></a>  IViewObjectExImpl::Unfreeze  
 Unfreezes the drawn representation of the control. The ATL implementation returns **E_NOTIMPL**.  
  
```  
  
STDMETHOD(Unfreeze)(  
      DWORD  /* dwFreeze */  
   );  
  
```  
  
### Remarks  
 See [IViewObject::Unfreeze](http://msdn.microsoft.com/library/windows/desktop/ms686641) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iworkerthreadclient__closehandle"></a>  IWorkerThreadClient::CloseHandle  
 Implement this method to close the handle associated with this object.  
  
```  
  
HRESULT CloseHandle(  
      HANDLE  hHandle  
   );  
  
```  
  
### Parameters  
 *hHandle*  
 The handle to be closed.  
  
### Return Value  
 Return S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 The handle passed to this method was previously associated with this object by a call to [CWorkerThread::AddHandle](../vs140/cworkerthread--addhandle.md).  
  
### Example  
 The following code shows a simple implementation of `IWorkerThreadClient::CloseHandle`.  
  
 [!code[NVC_ATL_Utilities#135](../vs140/codesnippet/CPP/iviewobjecteximpl-class_1.cpp)]  
  
##  <a name="iworkerthreadclient__execute"></a>  IWorkerThreadClient::Execute  
 Implement this method to execute code when the handle associated with this object becomes signaled.  
  
```  
  
HRESULT Execute(  
      DWORD_PTR  dwParam,  
      HANDLE  hObject  
   );  
  
```  
  
### Parameters  
 `dwParam`  
 The user parameter.  
  
 `hObject`  
 The handle that has become signaled.  
  
### Return Value  
 Return S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 The handle and DWORD/pointer passed to this method were previously associated with this object by a call to [CWorkerThread::AddHandle](../vs140/cworkerthread--addhandle.md).  
  
### Example  
 The following code shows a simple implementation of `IWorkerThreadClient::Execute`.  
  
 [!code[NVC_ATL_Utilities#136](../vs140/codesnippet/CPP/iviewobjecteximpl-class_2.cpp)]  
  
## See Also  
 [CComControl Class](../vs140/ccomcontrol-class.md)   
 [ActiveX Controls Interfaces](http://msdn.microsoft.com/library/windows/desktop/ms692724)   
 [Tutorial](../vs140/active-template-library--atl--tutorial.md)   
 [Creating an ATL Project](../vs140/creating-an-atl-project.md)   
 [Class Overview](../vs140/atl-class-overview.md)