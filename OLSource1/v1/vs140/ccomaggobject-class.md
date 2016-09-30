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
This class implements the [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) interface for an aggregated object. By definition, an aggregated object is contained within an outer object. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class is similar to the [CComObject Class](../vs140/ccomobject-class.md), except that it exposes an interface that is directly accessible to external clients.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
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
|[CComAggObject::CreateInstance](../vs140/ccomaggobject--createinstance.md)|This static function allows you to create a new **CComAggObject<** <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> **>** object without the overhead of [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615).|  
|[CComAggObject::FinalConstruct](../vs140/ccomaggobject--finalconstruct.md)|Performs final initialization of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|[CComAggObject::FinalRelease](../vs140/ccomaggobject--finalrelease.md)|Performs final destruction of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
|[CComAggObject::QueryInterface](../vs140/ccomaggobject--queryinterface.md)|Retrieves a pointer to the requested interface.|  
|[CComAggObject::Release](../vs140/ccomaggobject--release.md)|Decrements the reference count on the aggregated object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComAggObject::m_contained](../vs140/ccomaggobject--m_contained.md)|Delegates <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> calls to the outer unknown.|  
  
## Remarks  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) for an aggregated object. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> has its own **IUnknown** interface, separate from the outer object's **IUnknown** interface, and maintains its own reference count.  
  
 For more information about aggregation, see the article [Fundamentals of ATL COM Objects](../vs140/fundamentals-of-atl-com-objects.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 [CComObjectRootEx](../vs140/ccomobjectrootex-class.md)  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomaggobject__addref">\</a>  CComAggObject::AddRef  
 Increments the reference count on the aggregated object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 A value that may be useful for diagnostics or testing.  
  
##  \<a name="ccomaggobject__ccomaggobject">\</a>  CComAggObject::CComAggObject  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 [in] The outer unknown.  
  
### Remarks  
 Initializes the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> member, [m_contained](../vs140/ccomaggobject--m_contained.md), and increments the module lock count.  
  
 The destructor decrements the module lock count.  
  
##  \<a name="ccomaggobject___dtorccomaggobject">\</a>  CComAggObject::~CComAggObject  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources, calls [FinalRelease](../vs140/ccomaggobject--finalrelease.md), and decrements the module lock count.  
  
##  \<a name="ccomaggobject__createinstance">\</a>  CComAggObject::CreateInstance  
 This static function allows you to create a new **CComAggObject<**<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> **>** object without the overhead of [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 [out] A pointer to a **CComAggObject\<***contained* **>** pointer. If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is unsuccessful, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The object returned has a reference count of zero, so call <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> immediately, then use **Release** to free the reference on the object pointer when you're done.  
  
 If you do not need direct access to the object, but still want to create a new object without the overhead of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, use [CComCoClass::CreateInstance](../vs140/ccomcoclass--createinstance.md) instead.  
  
##  \<a name="ccomaggobject__finalconstruct">\</a>  CComAggObject::FinalConstruct  
 Called during the final stages of object construction, this method performs any final initialization on the [m_contained](../vs140/ccomaggobject--m_contained.md) member.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A standard <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> value.  
  
##  \<a name="ccomaggobject__finalrelease">\</a>  CComAggObject::FinalRelease  
 Called during object destruction, this method frees the [m_contained](../vs140/ccomaggobject--m_contained.md) member.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="ccomaggobject__m_contained">\</a>  CComAggObject::m_contained  
 A [CComContainedObject](../vs140/ccomcontainedobject-class.md) object derived from your class.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 [in] Your class, derived from [CComObjectRoot](../vs140/ccomobjectroot-class.md) or [CComObjectRootEx](../vs140/ccomobjectrootex-class.md), as well as from any other interfaces you want to support on the object.  
  
### Remarks  
 All **IUnknown** calls through <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> are delegated to the outer unknown.  
  
##  \<a name="ccomaggobject__queryinterface">\</a>  CComAggObject::QueryInterface  
 Retrieves a pointer to the requested interface.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 [in] The identifier of the interface being requested.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is set to **NULL**.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> value.  
  
### Remarks  
 If the requested interface is **IUnknown**, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> returns a pointer to the aggregated object's own **IUnknown** and increments the reference count. Otherwise, this method queries for the interface through the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> member, [m_contained](../vs140/ccomaggobject--m_contained.md).  
  
##  \<a name="ccomaggobject__release">\</a>  CComAggObject::Release  
 Decrements the reference count on the aggregated object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 In debug builds,                         **Release** returns a value that may be useful for diagnostics or testing. In non-debug builds,                         **Release** always returns 0.  
  
## See Also  
 [CComObject Class](../vs140/ccomobject-class.md)   
 [CComPolyObject Class](../vs140/ccompolyobject-class.md)   
 [DECLARE_AGGREGATABLE](../vs140/declare_aggregatable.md)   
 [DECLARE_ONLY_AGGREGATABLE](../vs140/declare_only_aggregatable.md)   
 [DECLARE_NOT_AGGREGATABLE](../vs140/declare_not_aggregatable.md)   
 [Class Overview](../vs140/atl-class-overview.md)