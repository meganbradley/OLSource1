---
title: "IRunnableObjectImpl Class"
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
  - "IRunnableObjectImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "containers, running controls"
  - "IRunnableObjectImpl class"
  - "IRunnableObject, ATL implementation"
  - "controls [ATL], running"
  - "controls [C++], container running in ATL"
ms.assetid: 305c7c3b-889e-49dd-aca1-34379c1b9931
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRunnableObjectImpl Class
This class implements **IUnknown** and provides a default implementation of the [IRunnableObject](http://msdn.microsoft.com/library/windows/desktop/ms692783) interface.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
template< class  T>  
   class IRunnableObjectImpl  
  
```  
  
#### Parameters  
 `T`  
 Your class, derived from `IRunnableObjectImpl`.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IRunnableObjectImpl::GetRunningClass](../vs140/irunnableobjectimpl--getrunningclass.md)|Returns the CLSID of the running control. The ATL implementation sets the CLSID to `GUID_NULL` and returns **E_UNEXPECTED**.|  
|[IRunnableObjectImpl::IsRunning](../vs140/irunnableobjectimpl--isrunning.md)|Determines if the control is running. The ATL implementation returns **TRUE**.|  
|[IRunnableObjectImpl::LockRunning](../vs140/irunnableobjectimpl--lockrunning.md)|Locks the control into the running state. The ATL implementation returns `S_OK`.|  
|[IRunnableObjectImpl::Run](../vs140/irunnableobjectimpl--run.md)|Forces the control to run. The ATL implementation returns `S_OK`.|  
|[IRunnableObjectImpl::SetContainedObject](../vs140/irunnableobjectimpl--setcontainedobject.md)|Indicates that the control is embedded. The ATL implementation returns `S_OK`.|  
  
## Remarks  
 The [IRunnableObject](http://msdn.microsoft.com/library/windows/desktop/ms692783) interface enables a container to determine if a control is running, force it to run, or lock it into the running state. Class `IRunnableObjectImpl` provides a default implementation of this interface and implements **IUnknown** by sending information to the dump device in debug builds.  
  
 **Related Articles** [ATL Tutorial](../vs140/active-template-library--atl--tutorial.md), [Creating an ATL Project](../vs140/creating-an-atl-project.md)  
  
## Inheritance Hierarchy  
 `IRunnableObject`  
  
 `IRunnableObjectImpl`  
  
## Requirements  
 **Header:** atlctl.h  
  
##  <a name="irunnableobjectimpl__getrunningclass"></a>  IRunnableObjectImpl::GetRunningClass  
 Returns the CLSID of the running control.  
  
```  
  
HRESULT GetRunningClass(  
      LPCLSID  lpClsid  
   );  
  
```  
  
### Return Value  
 The ATL implementation sets \* *lpClsid* to `GUID_NULL` and returns **E_UNEXPECTED**.  
  
### Remarks  
 See [IRunnableObject::GetRunningClass](http://msdn.microsoft.com/library/windows/desktop/ms693734) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="irunnableobjectimpl__isrunning"></a>  IRunnableObjectImpl::IsRunning  
 Determines if the control is running.  
  
```  
  
virtual BOOL IsRunning( );  
  
```  
  
### Return Value  
 The ATL implementation returns **TRUE**.  
  
### Remarks  
 See [IRunnableObject::IsRunning](http://msdn.microsoft.com/library/windows/desktop/ms678496) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="irunnableobjectimpl__lockrunning"></a>  IRunnableObjectImpl::LockRunning  
 Locks the control into the running state.  
  
```  
  
HRESULT LockRunning(  
      BOOL  fLock,  
   BOOL  fLastUnlockCloses  
   );  
  
```  
  
### Return Value  
 The ATL implementation returns `S_OK`.  
  
### Remarks  
 See [IRunnableObject::LockRunning](http://msdn.microsoft.com/library/windows/desktop/ms693361) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="irunnableobjectimpl__run"></a>  IRunnableObjectImpl::Run  
 Forces the control to run.  
  
```  
  
HRESULT Run(  
      LPBINDCTX lpbc  
   );  
  
```  
  
### Return Value  
 The ATL implementation returns `S_OK`.  
  
### Remarks  
 See [IRunnableObject::Run](http://msdn.microsoft.com/library/windows/desktop/ms694517) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="irunnableobjectimpl__setcontainedobject"></a>  IRunnableObjectImpl::SetContainedObject  
 Indicates that the control is embedded.  
  
```  
  
HRESULT SetContainedObject(  
      BOOL  fContained  
   );  
  
```  
  
### Return Value  
 The ATL implementation returns `S_OK`.  
  
### Remarks  
 See [IRunnableObject::SetContainedObject](http://msdn.microsoft.com/library/windows/desktop/ms693710) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [CComControl Class](../vs140/ccomcontrol-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)