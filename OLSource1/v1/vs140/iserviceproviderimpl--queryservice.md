---
title: "IServiceProviderImpl::QueryService"
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
  - QueryService
  - ATL.IServiceProviderImpl.QueryService
  - IServiceProviderImpl.QueryService
  - ATL::IServiceProviderImpl::QueryService
  - ATL::IServiceProviderImpl<T>::QueryService
  - IServiceProviderImpl::QueryService
  - IServiceProviderImpl<T>::QueryService
dev_langs: 
  - C++
helpviewer_keywords: 
  - QueryService method
ms.assetid: 0d53bca2-dd38-4ba9-97b3-2d4cf3b3794f
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IServiceProviderImpl::QueryService
Creates or accesses the specified service and returns an interface pointer to the specified interface for the service.  
  
## Syntax  
  
```  
  
      STDMETHOD(QueryService)(  
   REFGUID guidService,  
   REFIID riid,  
   void** ppvObject   
);  
```  
  
#### Parameters  
 [IN] `guidService`  
 Pointer to a service identifier (SID).  
  
 [IN] `riid`  
 Identifier of the interface to which the caller is to gain access.  
  
 [OUT] `ppvObj`  
 Indirect pointer to the requested interface.  
  
## Return Value  
 The returned `HRESULT` value is one of the following:  
  
|Return value|Meaning|  
|------------------|-------------|  
|S_OK|The service was successfully created or retrieved.|  
|E_INVALIDARG|One or more of the arguments is invalid.|  
|E_OUTOFMEMORY|Memory is insufficient to create the service.|  
|E_UNEXPECTED|An unknown error occurred.|  
|E_NOINTERFACE|The requested interface is not part of this service, or the service is unknown.|  
  
## Remarks  
 `QueryService` returns an indirect pointer to the requested interface in the specified service. The caller is responsible for releasing this pointer when it is no longer required.  
  
 When you call `QueryService`, you pass both a service identifier (`guidService`) and an interface identifier (`riid`). The `guidService` specifies the service to which you want access, and the `riid` identifies an interface that is part of the service. In return, you receive an indirect pointer to the interface.  
  
 The object that implements the interface might also implement interfaces that are part of other services. Consider the following:  
  
-   Some of these interfaces might be optional. Not all interfaces defined in the service description are necessarily present on every implementation of the service or on every returned object.  
  
-   Unlike calls to `QueryInterface`, passing a different service identifier does not necessarily mean that a different Component Object Model (COM) object is returned.  
  
-   The returned object might have additional interfaces that are not part of the definition of the service.  
  
 Two different services, such as SID_SMyService and SID_SYourService, can both specify the use of the same interface, even though the implementation of the interface might have nothing in common between the two services. This works, because a call to `QueryService` (SID_SMyService, IID_IDispatch) can return a different object than `QueryService` (SID_SYourService, IID_IDispatch). Object identity is not assumed when you specify a different service identifier.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IServiceProviderImpl Class](../vs140/iserviceproviderimpl-class.md)   
 [BEGIN_SERVICE_MAP](../vs140/begin_service_map.md)