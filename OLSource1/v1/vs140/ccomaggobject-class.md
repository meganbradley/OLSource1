---
title: "CComAggObject Class"
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
  - "ATL::CComAggObject<contained>"
  - "ATL.CComAggObject"
  - "ATL.CComAggObject<contained>"
  - "CComAggObject"
  - "ATL::CComAggObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aggregate objects [C++], in ATL"
  - "aggregation [C++], ATL objects"
  - "CComAggObject class"
ms.assetid: 7aa90d69-d399-477b-880d-e2cdf0ef7881
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAggObject Class
This class implements the [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) interface for an aggregated object. By definition, an aggregated object is contained within an outer object. The `CComAggObject` class is similar to the [CComObject Class](../vs140/ccomobject-class.md), except that it exposes an interface that is directly accessible to external clients.  
  
## Syntax  
  
```  
  
template<  
      class  contained>  
   class CComAggObject :  
      public IUnknown, public CComObjectRootEx  
      <  contained  
   ::_ThreadModel::ThreadModelNoCS >  
  
```  
  
#### Parameters  
 `contained`  
 Your class, derived from [CComObjectRoot](../vs140/ccomobjectroot-class.md) or [CComObjectRootEx](../vs140/ccomobjectrootex-class.md), as well as from any other interfaces you want to support on the object.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComAggObject::CComAggObject](../vs140/ccomaggobject--ccomaggobject.md)|The constructor.|  
|[CComAggObject::~CComAggObject](../vs140/ccomaggobject--~ccomaggobject.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComAggObject::AddRef](../vs140/ccomaggobject--addref.md)|Increments the reference count on the aggregated object.|  
|[CComAggObject::CreateInstance](../vs140/ccomaggobject--createinstance.md)|This static function allows you to create a new **CComAggObject<** `contained` **>** object without the overhead of [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615).|  
|[CComAggObject::FinalConstruct](../vs140/ccomaggobject--finalconstruct.md)|Performs final initialization of `m_contained`.|  
|[CComAggObject::FinalRelease](../vs140/ccomaggobject--finalrelease.md)|Performs final destruction of `m_contained`.|  
|[CComAggObject::QueryInterface](../vs140/ccomaggobject--queryinterface.md)|Retrieves a pointer to the requested interface.|  
|[CComAggObject::Release](../vs140/ccomaggobject--release.md)|Decrements the reference count on the aggregated object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComAggObject::m_contained](../vs140/ccomaggobject--m_contained.md)|Delegates `IUnknown` calls to the outer unknown.|  
  
## Remarks  
 `CComAggObject` implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) for an aggregated object. `CComAggObject` has its own **IUnknown** interface, separate from the outer object's **IUnknown** interface, and maintains its own reference count.  
  
 For more information about aggregation, see the article [Fundamentals of ATL COM Objects](../vs140/fundamentals-of-atl-com-objects.md).  
  
## Inheritance Hierarchy  
 `CComObjectRootBase`  
  
 [CComObjectRootEx](../vs140/ccomobjectrootex-class.md)  
  
 `IUnknown`  
  
 `CComAggObject`  
  
## Requirements  
 **Header:** atlcom.h  
  
##  <a name="ccomaggobject__addref"></a>  CComAggObject::AddRef  
 Increments the reference count on the aggregated object.  
  
```  
  
STDMETHOD_(ULONG, AddRef)( );  
  
```  
  
### Return Value  
 A value that may be useful for diagnostics or testing.  
  
##  <a name="ccomaggobject__ccomaggobject"></a>  CComAggObject::CComAggObject  
 The constructor.  
  
```  
  
CComAggObject(  
      void*  pv  
   );  
  
```  
  
### Parameters  
 `pv`  
 [in] The outer unknown.  
  
### Remarks  
 Initializes the `CComContainedObject` member, [m_contained](../vs140/ccomaggobject--m_contained.md), and increments the module lock count.  
  
 The destructor decrements the module lock count.  
  
##  <a name="ccomaggobject___dtorccomaggobject"></a>  CComAggObject::~CComAggObject  
 The destructor.  
  
```  
  
~CComAggObject( );  
  
```  
  
### Remarks  
 Frees all allocated resources, calls [FinalRelease](../vs140/ccomaggobject--finalrelease.md), and decrements the module lock count.  
  
##  <a name="ccomaggobject__createinstance"></a>  CComAggObject::CreateInstance  
 This static function allows you to create a new **CComAggObject<**`contained` **>** object without the overhead of [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615).  
  
```  
  
static HRESULT WINAPI CreateInstance(  
      LPUNKNOWN pUnkOuter,   
      CComAggObject<  contained  
   >**  pp  
   );  
  
```  
  
### Parameters  
 `pp`  
 [out] A pointer to a **CComAggObject\<***contained* **>** pointer. If `CreateInstance` is unsuccessful, `pp` is set to **NULL**.  
  
### Return Value  
 A standard `HRESULT` value.  
  
### Remarks  
 The object returned has a reference count of zero, so call `AddRef` immediately, then use **Release** to free the reference on the object pointer when you're done.  
  
 If you do not need direct access to the object, but still want to create a new object without the overhead of `CoCreateInstance`, use [CComCoClass::CreateInstance](../vs140/ccomcoclass--createinstance.md) instead.  
  
##  <a name="ccomaggobject__finalconstruct"></a>  CComAggObject::FinalConstruct  
 Called during the final stages of object construction, this method performs any final initialization on the [m_contained](../vs140/ccomaggobject--m_contained.md) member.  
  
```  
  
HRESULT FinalConstruct( );  
  
```  
  
### Return Value  
 A standard `HRESULT` value.  
  
##  <a name="ccomaggobject__finalrelease"></a>  CComAggObject::FinalRelease  
 Called during object destruction, this method frees the [m_contained](../vs140/ccomaggobject--m_contained.md) member.  
  
```  
  
void FinalRelease( );  
  
```  
  
##  <a name="ccomaggobject__m_contained"></a>  CComAggObject::m_contained  
 A [CComContainedObject](../vs140/ccomcontainedobject-class.md) object derived from your class.  
  
```  
  
CComContainedObject<  contained  
    > m_contained;  
  
```  
  
### Parameters  
 `contained`  
 [in] Your class, derived from [CComObjectRoot](../vs140/ccomobjectroot-class.md) or [CComObjectRootEx](../vs140/ccomobjectrootex-class.md), as well as from any other interfaces you want to support on the object.  
  
### Remarks  
 All **IUnknown** calls through `m_contained` are delegated to the outer unknown.  
  
##  <a name="ccomaggobject__queryinterface"></a>  CComAggObject::QueryInterface  
 Retrieves a pointer to the requested interface.  
  
```  
  
STDMETHOD(QueryInterface)(  
      REFIID  iid  
   ,   
      void **  ppvObject  
   );  
   template <class  Q>  
   HRESULT STDMETHODCALLTYPE QueryInterface(  
      Q**  pp  
   );  
  
```  
  
### Parameters  
 `iid`  
 [in] The identifier of the interface being requested.  
  
 `ppvObject`  
 [out] A pointer to the interface pointer identified by `iid`. If the object does not support this interface, `ppvObject` is set to **NULL**.  
  
 `pp`  
 [out] A pointer to the interface pointer identified by type `Q`. If the object does not support this interface, `pp` is set to **NULL**.  
  
### Return Value  
 A standard `HRESULT` value.  
  
### Remarks  
 If the requested interface is **IUnknown**, `QueryInterface` returns a pointer to the aggregated object's own **IUnknown** and increments the reference count. Otherwise, this method queries for the interface through the `CComContainedObject` member, [m_contained](../vs140/ccomaggobject--m_contained.md).  
  
##  <a name="ccomaggobject__release"></a>  CComAggObject::Release  
 Decrements the reference count on the aggregated object.  
  
```  
  
STDMETHOD_(ULONG, Release)( );  
  
```  
  
### Return Value  
 In debug builds,                         **Release** returns a value that may be useful for diagnostics or testing. In non-debug builds,                         **Release** always returns 0.  
  
## See Also  
 [CComObject Class](../vs140/ccomobject-class.md)   
 [CComPolyObject Class](../vs140/ccompolyobject-class.md)   
 [DECLARE_AGGREGATABLE](../vs140/declare_aggregatable.md)   
 [DECLARE_ONLY_AGGREGATABLE](../vs140/declare_only_aggregatable.md)   
 [DECLARE_NOT_AGGREGATABLE](../vs140/declare_not_aggregatable.md)   
 [Class Overview](../vs140/atl-class-overview.md)