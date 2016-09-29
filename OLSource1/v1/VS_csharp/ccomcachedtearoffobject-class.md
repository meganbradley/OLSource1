---
title: "CComCachedTearOffObject Class"
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
  - "ATL::CComCachedTearOffObject"
  - "ATL.CComCachedTearOffObject"
  - "ATL.CComCachedTearOffObject<contained>"
  - "CComCachedTearOffObject"
  - "ATL::CComCachedTearOffObject<contained>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cache, ATL cached tear-off objects"
  - "CComCachedTearOffObject class"
ms.assetid: ae19507d-a1de-4dbc-a988-da9f75a50c95
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCachedTearOffObject Class
This class implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) for a tear-off interface.  
  
## Syntax  
  
```  
  
template  
   <  
      class contained>  
   class  
   CComCachedTearOffObject :             public  
   IUnknown,  
   public  
   CComObjectRootEx<  contained  
   ::_ThreadModel::ThreadModelNoCS >  
  
```  
  
#### Parameters  
 `contained`  
 Your tear-off class, derived from `CComTearOffObjectBase` and the interfaces you want your tear-off object to support.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComCachedTearOffObject::CComCachedTearOffObject](../Topic/CComCachedTearOffObject::CComCachedTearOffObject.md)|The constructor.|  
|[CComCachedTearOffObject::~CComCachedTearOffObject](../Topic/CComCachedTearOffObject::~CComCachedTearOffObject.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComCachedTearOffObject::AddRef](../Topic/CComCachedTearOffObject::AddRef.md)|Increments the reference count for a `CComCachedTearOffObject` object.|  
|[CComCachedTearOffObject::FinalConstruct](../Topic/CComCachedTearOffObject::FinalConstruct.md)|Calls the `m_contained::FinalConstruct` (the tear-off class' method).|  
|[CComCachedTearOffObject::FinalRelease](../Topic/CComCachedTearOffObject::FinalRelease.md)|Calls the `m_contained::FinalRelease` (the tear-off class' method).|  
|[CComCachedTearOffObject::QueryInterface](../Topic/CComCachedTearOffObject::QueryInterface.md)|Returns a pointer to the `IUnknown` of the `CComCachedTearOffObject` object, or to the requested interface on your tear-off class (the class `contained`).|  
|[CComCachedTearOffObject::Release](../Topic/CComCachedTearOffObject::Release.md)|Decrements the reference count for a `CComCachedTearOffObject` object and destroys it if the reference count is 0.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComCachedTearOffObject::m_contained](../Topic/CComCachedTearOffObject::m_contained.md)|A `CComContainedObject` object derived from your tear-off class (the class `contained`).|  
  
## Remarks  
 `CComCachedTearOffObject` implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) for a tear-off interface. This class differs from `CComTearOffObject` in that `CComCachedTearOffObject` has its own **IUnknown**, separate from the owner object's **IUnknown** (the owner is the object for which the tear-off is being created). `CComCachedTearOffObject` maintains its own reference count on its **IUnknown** and deletes itself once its reference count is zero. However, if you query for any of its tear-off interfaces, the reference count of the owner object's **IUnknown** will be incremented.  
  
 If the `CComCachedTearOffObject` object implementing the tear-off is already instantiated, and the tear-off interface is queried for again, the same `CComCachedTearOffObject` object is reused. In contrast, if a tear-off interface implemented by a `CComTearOffObject` is again queried for through the owner object, another `CComTearOffObject` will be instantiated.  
  
 The owner class must implement `FinalRelease` and call **Release** on the cached **IUnknown** for the `CComCachedTearOffObject`, which will decrement its reference count. This will cause `CComCachedTearOffObject`'s `FinalRelease` to be called and delete the tear-off.  
  
## Inheritance Hierarchy  
 `CComObjectRootBase`  
  
 [CComObjectRootEx](../VS_csharp/ccomobjectrootex-class.md)  
  
 `IUnknown`  
  
 `CComCachedTearOffObject`  
  
## Requirements  
 **Header:** atlcom.h  
  
##  <a name="ccomcachedtearoffobject__addref"></a>  CComCachedTearOffObject::AddRef  
 Increments the reference count of the `CComCachedTearOffObject` object by 1.  
  
```  
  
STDMETHOD_(ULONG, AddRef)( );  
  
```  
  
### Return Value  
 A value that may be useful for diagnostics and testing.  
  
##  <a name="ccomcachedtearoffobject__ccomcachedtearoffobject"></a>  CComCachedTearOffObject::CComCachedTearOffObject  
 The constructor.  
  
```  
  
CComCachedTearOffObject(  
      void* pv  
   );  
  
```  
  
### Parameters  
 `pv`  
 [in] Pointer to the **IUnknown** of the `CComCachedTearOffObject`.  
  
### Remarks  
 Initializes the `CComContainedObject` member, [m_contained](../Topic/CComCachedTearOffObject::m_contained.md).  
  
##  <a name="ccomcachedtearoffobject___dtorccomcachedtearoffobject"></a>  CComCachedTearOffObject::~CComCachedTearOffObject  
 The destructor.  
  
```  
  
~CComCachedTearOffObject( );  
  
```  
  
### Remarks  
 Frees all allocated resources and calls [FinalRelease](../Topic/CComCachedTearOffObject::FinalRelease.md).  
  
##  <a name="ccomcachedtearoffobject__finalconstruct"></a>  CComCachedTearOffObject::FinalConstruct  
 Calls **m_contained::FinalConstruct** to create `m_contained`, the `CComContainedObject`< `contained`> object used to access the interface implemented by your tear-off class.  
  
```  
  
HRESULT  
   FinalConstruct(  
   );  
  
```  
  
### Return Value  
 A standard `HRESULT` value.  
  
##  <a name="ccomcachedtearoffobject__finalrelease"></a>  CComCachedTearOffObject::FinalRelease  
 Calls **m_contained::FinalRelease** to free `m_contained`, the `CComContainedObject`< `contained`> object.  
  
```  
  
void  
   FinalRelease(  
   );  
  
```  
  
##  <a name="ccomcachedtearoffobject__m_contained"></a>  CComCachedTearOffObject::m_contained  
 A [CComContainedObject](../VS_csharp/ccomcontainedobject-class.md) object derived from your tear-off class.  
  
```  
  
CcomContainedObject < contained>  
   m_contained;  
  
```  
  
### Parameters  
 `contained`  
 [in] Your tear-off class, derived from `CComTearOffObjectBase` and the interfaces you want your tear-off object to support.  
  
### Remarks  
 The methods `m_contained` inherits are used to access the tear-off interface in your tear-off class through the cached tear-off object's `QueryInterface`, `FinalConstruct`, and `FinalRelease`.  
  
##  <a name="ccomcachedtearoffobject__queryinterface"></a>  CComCachedTearOffObject::QueryInterface  
 Retrieves a pointer to the requested interface.  
  
```  
  
STDMETHOD(QueryInterface)(  
      REFIID  iid,  
      void**  ppvObject  
   );  
  
```  
  
### Parameters  
 `iid`  
 [in] The GUID of the interface being requested.  
  
 `ppvObject`  
 [out] A pointer to the interface pointer identified by `iid`, or **NULL** if the interface is not found.  
  
### Return Value  
 A standard `HRESULT` value.  
  
### Remarks  
 If the requested interface is **IUnknown**, returns a pointer to the `CComCachedTearOffObject`'s own **IUnknown** and increments the reference count. Otherwise, queries for the interface on your tear-off class using the [InternalQueryInterface](../Topic/CComObjectRootEx::InternalQueryInterface.md) method inherited from `CComObjectRootEx`.  
  
##  <a name="ccomcachedtearoffobject__release"></a>  CComCachedTearOffObject::Release  
 Decrements the reference count by 1 and, if the reference count is 0, deletes the `CComCachedTearOffObject` object.  
  
```  
  
STDMETHOD_(ULONG, Release)( );  
  
```  
  
### Return Value  
 In non-debug builds, always returns 0. In debug builds, returns a value that may be useful for diagnostics or testing.  
  
## See Also  
 [CComTearOffObject Class](../VS_csharp/ccomtearoffobject-class.md)   
 [CComObjectRootEx Class](../VS_csharp/ccomobjectrootex-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)