---
title: "IDispatchImpl Class"
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
  - "IDispatchImpl"
  - "ATL.IDispatchImpl"
  - "ATL::IDispatchImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dual interfaces, classes"
  - "IDispatchImpl class"
  - "IDispatch class support in ATL"
ms.assetid: 8108eb36-1228-4127-a203-3ab5ba488892
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDispatchImpl Class
Provides a default implementation for the `IDispatch` part of a dual interface.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
template<  
   class T,  
   const IID* piid= &__uuidof(T),  
   const GUID* plibid = &CAtlModule::m_libid,  
   WORD wMajor = 1,  
   WORD wMinor = 0,  
   class tihclass = CComTypeInfoHolder   
>   
class ATL_NO_VTABLE IDispatchImpl :  
   public T  
```  
  
#### Parameters  
 [in] `T`  
 A dual interface.  
  
 [in] `piid`  
 A pointer to the IID of `T`.  
  
 [in] `plibid`  
 A pointer to the LIBID of the type library that contains information about the interface. By default, the server-level type library is passed.  
  
 [in] `wMajor`  
 The major version of the type library. By default, the value is 1.  
  
 [in] `wMinor`  
 The minor version of the type library. By default, the value is 0.  
  
 [in] `tihclass`  
 The class used to manage the type information for `T`. By default, the value is `CComTypeInfoHolder`.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[IDispatchImpl::IDispatchImpl](../vs140/idispatchimpl--idispatchimpl.md)|The constructor. Calls `AddRef` on the protected member variable that manages the type information for the dual interface. The destructor calls `Release`.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IDispatchImpl::GetIDsOfNames](../vs140/idispatchimpl--getidsofnames.md)|Maps a set of names to a corresponding set of dispatch identifiers.|  
|[IDispatchImpl::GetTypeInfo](../vs140/idispatchimpl--gettypeinfo.md)|Retrieves the type information for the dual interface.|  
|[IDispatchImpl::GetTypeInfoCount](../vs140/idispatchimpl--gettypeinfocount.md)|Determines whether there is type information available for the dual interface.|  
|[IDispatchImpl::Invoke](../vs140/idispatchimpl--invoke.md)|Provides access to the methods and properties exposed by the dual interface.|  
  
## Remarks  
 `IDispatchImpl` provides a default implementation for the `IDispatch` part of any dual interface on an object. A dual interface derives from `IDispatch` and uses only Automation-compatible types. Like a dispinterface, a dual interface supports early binding and late binding; however, a dual interface also supports vtable binding.  
  
 The following example shows a typical implementation of `IDispatchImpl`.  
  
 [!code[NVC_ATL_COM#47](../vs140/codesnippet/CPP/idispatchimpl-class_1.h)]  
  
 By default, the `IDispatchImpl` class looks up the type information for `T` in the registry. To implement an unregistered interface, you can use the `IDispatchImpl` class without accessing the registry by using a predefined version number. If you create an `IDispatchImpl` object that has 0xFFFF as the value for `wMajor` and 0xFFFF as the value for `wMinor`, the `IDispatchImpl` class retrieves the type library from the .dll file instead of the registry.  
  
 `IDispatchImpl` contains a static member of type `CComTypeInfoHolder` that manages the type information for the dual interface. If you have multiple objects that implement the same dual interface, only one instance of `CComTypeInfoHolder` is used.  
  
## Inheritance Hierarchy  
 `T`  
  
 `IDispatchImpl`  
  
## Requirements  
 **Header:** atlcom.h  
  
##  <a name="idispatchimpl__getidsofnames"></a>  IDispatchImpl::GetIDsOfNames  
 Maps a set of names to a corresponding set of dispatch identifiers.  
  
```  
  
STDMETHOD(GetIDsOfNames)(  
      REFIID  riid,  
      LPOLESTR*  rgszNames,  
      UINT  cNames,  
      LCID  lcid,  
      DISPID*  rgdispid  
   );  
  
```  
  
### Remarks  
 See [IDispatch::GetIDsOfNames](assetId:///6f6cf233-3481-436e-8d6a-51f93bf91619) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="idispatchimpl__gettypeinfo"></a>  IDispatchImpl::GetTypeInfo  
 Retrieves the type information for the dual interface.  
  
```  
  
STDMETHOD(GetTypeInfo)(  
      UINT  itinfo,  
      LCID  lcid,  
      ITypeInfo**  pptinfo  
   );  
  
```  
  
### Remarks  
 See [IDispatch::GetTypeInfo](assetId:///cc1ec9aa-6c40-4e70-819c-a7c6dd6b8c99) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="idispatchimpl__gettypeinfocount"></a>  IDispatchImpl::GetTypeInfoCount  
 Determines whether there is type information available for the dual interface.  
  
```  
  
STDMETHOD(GetTypeInfoCount)(  
      UINT*  pctinfo  
   );  
  
```  
  
### Remarks  
 See `IDispatch::GetTypeInfoCount` in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="idispatchimpl__idispatchimpl"></a>  IDispatchImpl::IDispatchImpl  
 The constructor. Calls `AddRef` on the protected member variable that manages the type information for the dual interface. The destructor calls **Release**.  
  
```  
  
IDispatchImpl( );  
  
```  
  
##  <a name="idispatchimpl__invoke"></a>  IDispatchImpl::Invoke  
 Provides access to the methods and properties exposed by the dual interface.  
  
```  
  
STDMETHOD(Invoke)(  
      DISPID  dispidMember,  
      REFIID  riid,  
      LCID  lcid,  
      WORD  wFlags,  
      DISPPARAMS*  pdispparams,  
      VARIANT*  pvarResult,  
      EXCEPINFO*  pexcepinfo,  
      UINT*  puArgErr  
   );  
  
```  
  
### Remarks  
 See [IDispatch::Invoke](assetId:///964ade8e-9d8a-4d32-bd47-aa678912a54d) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)