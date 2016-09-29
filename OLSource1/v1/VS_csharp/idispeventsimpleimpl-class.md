---
title: "IDispEventSimpleImpl Class"
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
  - "IDispEventSimpleImpl"
  - "ATL::IDispEventSimpleImpl"
  - "ATL.IDispEventSimpleImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDispEventSimpleImpl class"
ms.assetid: 971d82b7-a921-47fa-a4d8-909bed377ab0
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDispEventSimpleImpl Class
This class provides implementations of the `IDispatch` methods, without getting type information from a type library.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
template <  
   UINT  nID,  
   class  T,  
   const IID*  pdiid>  
   class ATL_NO_VTABLE IDispEventSimpleImpl :  
   public _IDispEventLocator< nID  
   ,  pdiid>  
  
```  
  
#### Parameters  
 `nID`  
 A unique identifier for the source object. When `IDispEventSimpleImpl` is the base class for a composite control, use the resource ID of the desired contained control for this parameter. In other cases, use an arbitrary positive integer.  
  
 `T`  
 The user's class, which is derived from `IDispEventSimpleImpl`.  
  
 `pdiid`  
 The pointer to the IID of the event dispinterface implemented by this class.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IDispEventSimpleImpl::Advise](../VS_csharp/idispeventsimpleimpl--advise.md)|Establishes a connection with the default event source.|  
|[IDispEventSimpleImpl::DispEventAdvise](../VS_csharp/idispeventsimpleimpl--dispeventadvise.md)|Establishes a connection with the event source.|  
|[IDispEventSimpleImpl::DispEventUnadvise](../VS_csharp/idispeventsimpleimpl--dispeventunadvise.md)|Breaks the connection with the event source.|  
|[IDispEventSimpleImpl::GetIDsOfNames](../VS_csharp/idispeventsimpleimpl--getidsofnames.md)|Returns **E_NOTIMPL**.|  
|[IDispEventSimpleImpl::GetTypeInfo](../VS_csharp/idispeventsimpleimpl--gettypeinfo.md)|Returns **E_NOTIMPL**.|  
|[IDispEventSimpleImpl::GetTypeInfoCount](../VS_csharp/idispeventsimpleimpl--gettypeinfocount.md)|Returns **E_NOTIMPL**.|  
|[IDispEventSimpleImpl::Invoke](../VS_csharp/idispeventsimpleimpl--invoke.md)|Calls the event handlers listed in the event sink map.|  
|[IDispEventSimpleImpl::Unadvise](../VS_csharp/idispeventsimpleimpl--unadvise.md)|Breaks the connection with the default event source.|  
  
## Remarks  
 `IDispEventSimpleImpl` provides a way of implementing an event dispinterface without requiring you to supply implementation code for every method/event on that interface. `IDispEventSimpleImpl` provides implementations of the `IDispatch` methods. You only need to supply implementations for the events that you are interested in handling.  
  
 `IDispEventSimpleImpl` works in conjunction with the [event sink map](../VS_csharp/begin_sink_map.md) in your class to route events to the appropriate handler function. To use this class:  
  
-   Add a [SINK_ENTRY_INFO](../VS_csharp/sink_entry_info.md) macro to the event sink map for each event on each object that you want to handle.  
  
-   Supply type information for each event by passing a pointer to an [_ATL_FUNC_INFO](../VS_csharp/_atl_func_info-structure.md) structure as a parameter to each entry. On the x86 platform, the `_ATL_FUNC_INFO.cc` value must be CC_CDECL with the callback function calling method of __stdcall.  
  
-   Call [DispEventAdvise](../VS_csharp/idispeventsimpleimpl--dispeventadvise.md) to establish the connection between the source object and the base class.  
  
-   Call [DispEventUnadvise](../VS_csharp/idispeventsimpleimpl--dispeventunadvise.md) to break the connection.  
  
 You must derive from `IDispEventSimpleImpl` (using a unique value for `nID`) for each object for which you need to handle events. You can reuse the base class by unadvising against one source object then advising against a different source object, but the maximum number of source objects that can be handled by a single object at one time is limited by the number of `IDispEventSimpleImpl` base classes.  
  
 **IDispEventSimplImpl** provides the same functionality as [IDispEventImpl](../VS_csharp/idispeventimpl-class.md), except it does not get type information about the interface from a type library. The wizards generate code based only on `IDispEventImpl`, but you can use `IDispEventSimpleImpl` by adding the code by hand. Use `IDispEventSimpleImpl` when you don't have a type library describing the event interface or want to avoid the overhead associated with using the type library.  
  
> [!NOTE]
>  `IDispEventImpl` and `IDispEventSimpleImpl` provide their own implementation of **IUnknown::QueryInterface** enabling each `IDispEventImpl` or `IDispEventSimpleImpl` base class to act as a separate COM identity while still allowing direct access to class members in your main COM object.  
  
 CE ATL implementation of ActiveX event sinks only supports return values of type HRESULT or void from your event handler methods; any other return value is unsupported and its behavior is undefined.  
  
 For more information, see [Supporting IDispEventImpl](../VS_csharp/supporting-idispeventimpl.md).  
  
## Inheritance Hierarchy  
 `_IDispEvent`  
  
 `_IDispEventLocator`  
  
 `IDispEventSimpleImpl`  
  
## Requirements  
 **Header:** atlcom.h  
  
##  <a name="idispeventsimpleimpl__advise"></a>  IDispEventSimpleImpl::Advise  
 Call this method to establish a connection with the event source represented by *pUnk*.  
  
```  
  
HRESULT Advise(  
      IUnknown*  pUnk   
   );  
  
```  
  
### Parameters  
 *pUnk*  
 [in] A pointer to the **IUnknown** interface of the event source object.  
  
### Return Value  
 `S_OK` or any failure `HRESULT` value.  
  
### Remarks  
 Once the connection is established, events fired from *pUnk* will be routed to handlers in your class by way of the event sink map.  
  
> [!NOTE]
>  If your class derives from multiple `IDispEventSimpleImpl` classes, you will need to disambiguate calls to this method by scoping the call with the particular base class you are interested in.  
  
 `Advise` establishes a connection with the default event source, it gets the IID of the default event source of the object as determined by [AtlGetObjectSourceInterface](../VS_csharp/atlgetobjectsourceinterface.md).  
  
##  <a name="idispeventsimpleimpl__dispeventadvise"></a>  IDispEventSimpleImpl::DispEventAdvise  
 Call this method to establish a connection with the event source represented by *pUnk*.  
  
```  
  
HRESULT DispEventAdvise(  
      IUnknown*  pUnk   
   const IID* piid   
   );  
  
```  
  
### Parameters  
 *pUnk*  
 [in] A pointer to the **IUnknown** interface of the event source object.  
  
 `piid`  
 A pointer to the IID of the event source object.  
  
### Return Value  
 `S_OK` or any failure `HRESULT` value.  
  
### Remarks  
 Subsequently, events fired from *pUnk* will be routed to handlers in your class by way of the event sink map.  
  
> [!NOTE]
>  If your class derives from multiple `IDispEventSimpleImpl` classes, you will need to disambiguate calls to this method by scoping the call with the particular base class you are interested in.  
  
 `DispEventAdvise` establishes a connection with the event source specified in `pdiid`.  
  
##  <a name="idispeventsimpleimpl__dispeventunadvise"></a>  IDispEventSimpleImpl::DispEventUnadvise  
 Breaks the connection with the event source represented by *pUnk*.  
  
```  
  
HRESULT DispEventUnadvise(  
      IUnknown*  pUnk   
   const IID* piid   
   );  
  
```  
  
### Parameters  
 *pUnk*  
 [in] A pointer to the **IUnknown** interface of the event source object.  
  
 `piid`  
 A pointer to the IID of the event source object.  
  
### Return Value  
 `S_OK` or any failure `HRESULT` value.  
  
### Remarks  
 Once the connection is broken, events will no longer be routed to the handler functions listed in the event sink map.  
  
> [!NOTE]
>  If your class derives from multiple `IDispEventSimpleImpl` classes, you will need to disambiguate calls to this method by scoping the call with the particular base class you are interested in.  
  
 `DispEventAdvise` breaks a connection that was established with the event source specified in `pdiid`.  
  
##  <a name="idispeventsimpleimpl__getidsofnames"></a>  IDispEventSimpleImpl::GetIDsOfNames  
 This implementation of **IDispatch::GetIDsOfNames** returns **E_NOTIMPL**.  
  
```  
  
STDMETHOD(GetIDsOfNames)(  
      REFIID  /* riid */,  
      LPOLESTR*  /* rgszNames */,  
      UINT  /* cNames */,  
      LCID  /* lcid */,  
      DISPID*  /* rgdispid */   
   );  
  
```  
  
### Remarks  
 See [IDispatch::GetIDsOfNames](assetId:///6f6cf233-3481-436e-8d6a-51f93bf91619) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="idispeventsimpleimpl__gettypeinfo"></a>  IDispEventSimpleImpl::GetTypeInfo  
 This implementation of **IDispatch::GetTypeInfo** returns **E_NOTIMPL**.  
  
```  
  
STDMETHOD(GetTypeInfo)(  
      UINT  /* itinfo */,  
      LCID  /* lcid */,  
      ITypeInfo**  /* pptinfo */   
   );  
  
```  
  
### Remarks  
 See [IDispatch::GetTypeInfo](assetId:///cc1ec9aa-6c40-4e70-819c-a7c6dd6b8c99) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="idispeventsimpleimpl__gettypeinfocount"></a>  IDispEventSimpleImpl::GetTypeInfoCount  
 This implementation of **IDispatch::GetTypeInfoCount** returns **E_NOTIMPL**.  
  
```  
  
STDMETHOD(GetTypeInfoCount)(  
      UINT*  /* pctinfo */   
   );  
  
```  
  
### Remarks  
 See [IDispatch::GetTypeInfoCount](assetId:///da876d53-cb8a-465c-a43e-c0eb272e2a12) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="idispeventsimpleimpl__invoke"></a>  IDispEventSimpleImpl::Invoke  
 This implementation of **IDispatch::Invoke** calls the event handlers listed in the event sink map.  
  
```  
  
STDMETHOD(Invoke)(  
      DISPID  dispidMember,  
      REFIID  /* riid */,  
      LCID  lcid,  
      WORD  /* wFlags */,  
      DISPPARMS*  pdispparams,  
      VARIANT*  pvarResult,  
      EXCEPINFO*  /* pexcepinfo */,  
      UINT*  /* puArgErr */   
   );  
  
```  
  
### Remarks  
 See [IDispatch::Invoke](assetId:///964ade8e-9d8a-4d32-bd47-aa678912a54d).  
  
##  <a name="idispeventsimpleimpl__unadvise"></a>  IDispEventSimpleImpl::Unadvise  
 Breaks the connection with the event source represented by *pUnk*.  
  
```  
  
HRESULT Unadvise(  
      IUnknown*  pUnk   
   );  
  
```  
  
### Parameters  
 *pUnk*  
 [in] A pointer to the **IUnknown** interface of the event source object.  
  
### Return Value  
 `S_OK` or any failure `HRESULT` value.  
  
### Remarks  
 Once the connection is broken, events will no longer be routed to the handler functions listed in the event sink map.  
  
> [!NOTE]
>  If your class derives from multiple `IDispEventSimpleImpl` classes, you will need to disambiguate calls to this method by scoping the call with the particular base class you are interested in.  
  
 `Unadvise` breaks a connection that was established with the default event source specified in `pdiid`.  
  
 **Unavise** breaks a connection with the default event source, it gets the IID of the default event source of the object as determined by [AtlGetObjectSourceInterface](../VS_csharp/atlgetobjectsourceinterface.md).  
  
## See Also  
 [_ATL_FUNC_INFO Structure](../VS_csharp/_atl_func_info-structure.md)   
 [IDispatchImpl Class](../VS_csharp/idispatchimpl-class.md)   
 [IDispEventImpl Class](../VS_csharp/idispeventimpl-class.md)   
 [SINK_ENTRY_INFO](../VS_csharp/sink_entry_info.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)