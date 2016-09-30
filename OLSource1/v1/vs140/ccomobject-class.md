---
title: "CComObject Class"
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
  - "ATL.CComObject<Base>"
  - "ATL::CComObject"
  - "ATL::CComObject<Base>"
  - "ATL.CComObject"
  - "CComObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComObject class"
ms.assetid: e2b6433b-6349-4749-b4bc-acbd7a22c8b0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObject Class
This class implements **IUnknown** for a nonaggregated object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Your class, derived from [CComObjectRoot](../vs140/ccomobjectroot-class.md) or [CComObjectRootEx](../vs140/ccomobjectrootex-class.md), as well as from any other interfaces you want to support on the object.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComObject::CComObject](../vs140/ccomobject--ccomobject.md)|The constructor.|  
|[CComObject::~CComObject](../vs140/ccomobject--~ccomobject.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComObject::AddRef](../vs140/ccomobject--addref.md)|Increments the reference count on the object.|  
|[CComObject::CreateInstance](../vs140/ccomobject--createinstance.md)|(Static) Creates a new <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
|[CComObject::QueryInterface](../vs140/ccomobject--queryinterface.md)|Retrieves a pointer to the requested interface.|  
|[CComObject::Release](../vs140/ccomobject--release.md)|Decrements the reference count on the object.|  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) for a nonaggregated object. However, calls to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and **Release** are delegated to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 For more information about using <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, see the article [Fundamentals of ATL COM Objects](../vs140/fundamentals-of-atl-com-objects.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomobject__addref">\</a>  CComObject::AddRef  
 Increments the reference count on the object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 This function returns the new incremented reference count on the object. This value may be useful for diagnostics or testing.  
  
##  \<a name="ccomobject__ccomobject">\</a>  CComObject::CComObject  
 The constructor increments the module lock count.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 **void\***  
 [in] This unnamed parameter is not used. It exists for symmetry with other **CCom***XXX*<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>*XXX* constructors.  
  
### Remarks  
 The destructor decrements it.  
  
 If a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>-derived object is successfully constructed using the **new** operator, the initial reference count is 0. To set the reference count to the proper value (1), make a call to the [AddRef](../vs140/ccomobject--addref.md) function.  
  
##  \<a name="ccomobject___dtorccomobject">\</a>  CComObject::~CComObject  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources, calls [FinalRelease](../vs140/ccomobjectrootex--finalrelease.md), and decrements the module lock count.  
  
##  \<a name="ccomobject__createinstance">\</a>  CComObject::CreateInstance  
 This static function allows you to create a new **CComObject<**<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>**>** object, without the overhead of [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 [out] A pointer to a **CComObject<**<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>**>** pointer. If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is unsuccessful, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The object returned has a reference count of zero, so call <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> immediately, then use **Release** to free the reference on the object pointer when you're done.  
  
 If you do not need direct access to the object, but still want to create a new object without the overhead of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, use [CComCoClass::CreateInstance](../vs140/ccomcoclass--createinstance.md) instead.  
  
### Example  
 [!code[NVC_ATL_COM#38](../vs140/codesnippet/CPP/ccomobject-class_1.h)]  
  
 [!code[NVC_ATL_COM#39](../vs140/codesnippet/CPP/ccomobject-class_2.cpp)]  
  
##  \<a name="ccomobject__queryinterface">\</a>  CComObject::QueryInterface  
 Retrieves a pointer to the requested interface.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 [in] The identifier of the interface being requested.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is set to **NULL**.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> value.  
  
##  \<a name="ccomobject__release">\</a>  CComObject::Release  
 Decrements the reference count on the object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 This function returns the new decremented reference count on the object. In debug builds, the return value may be useful for diagnostics or testing. In non-debug builds,                         **Release** always returns 0.  
  
## See Also  
 [CComAggObject Class](../vs140/ccomaggobject-class.md)   
 [CComPolyObject Class](../vs140/ccompolyobject-class.md)   
 [DECLARE_AGGREGATABLE](../vs140/declare_aggregatable.md)   
 [DECLARE_NOT_AGGREGATABLE](../vs140/declare_not_aggregatable.md)   
 [Class Overview](../vs140/atl-class-overview.md)