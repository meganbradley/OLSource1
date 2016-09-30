---
title: "CComContainedObject Class"
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
  - "CComContainedObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aggregate objects [C++], in ATL"
  - "aggregation [C++], ATL objects"
  - "CComContainedObject class"
ms.assetid: e8616b41-c200-47b8-bf2c-fb9f713ebdad
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComContainedObject Class
This class implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) by delegating to the owner object's **IUnknown**.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Your class, derived from [CComObjectRoot](../vs140/ccomobjectroot-class.md) or [CComObjectRootEx](../vs140/ccomobjectrootex-class.md).  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComContainedObject::CComContainedObject](../vs140/ccomcontainedobject--ccomcontainedobject.md)|The constructor. Initializes the member pointer to the owner object's <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|[CComContainedObject::~CComContainedObject](../vs140/ccomcontainedobject--~ccomcontainedobject.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComContainedObject::AddRef](../vs140/ccomcontainedobject--addref.md)|Increments the reference count on the owner object.|  
|[CComContainedObject::GetControllingUnknown](../vs140/ccomcontainedobject--getcontrollingunknown.md)|Retrieves the owner object's <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|[CComContainedObject::QueryInterface](../vs140/ccomcontainedobject--queryinterface.md)|Retrieves a pointer to the interface requested on the owner object.|  
|[CComContainedObject::Release](../vs140/ccomcontainedobject--release.md)|Decrements the reference count on the owner object.|  
  
## Remarks  
 ATL uses <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in classes [CComAggObject](../vs140/ccomaggobject-class.md), [CComPolyObject](../vs140/ccompolyobject-class.md), and [CComCachedTearOffObject](../vs140/ccomcachedtearoffobject-class.md). <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) by delegating to the owner object's **IUnknown**. (The owner is either the outer object of an aggregation, or the object for which a tear-off interface is being created.) <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>'s <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, all inherited through <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomcontainedobject__addref">\</a>  CComContainedObject::AddRef  
 Increments the reference count on the owner object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 A value that may be useful for diagnostics or testing.  
  
##  \<a name="ccomcontainedobject__ccomcontainedobject">\</a>  CComContainedObject::CComContainedObject  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 [in] The owner object's **IUnknown**.  
  
### Remarks  
 Sets the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> member pointer (inherited through the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class) to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
##  \<a name="ccomcontainedobject___dtorccomcontainedobject">\</a>  CComContainedObject::~CComContainedObject  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources.  
  
##  \<a name="ccomcontainedobject__getcontrollingunknown">\</a>  CComContainedObject::GetControllingUnknown  
 Returns the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> member pointer (inherited through the *Base* class) that holds the owner object's **IUnknown**.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The owner object's **IUnknown**.  
  
### Remarks  
 This method may be virtual if <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> has declared the [DECLARE_GET_CONTROLLING_UNKNOWN](../vs140/declare_get_controlling_unknown.md) macro.  
  
##  \<a name="ccomcontainedobject__queryinterface">\</a>  CComContainedObject::QueryInterface  
 Retrieves a pointer to the interface requested on the owner object.  
  
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
  
##  \<a name="ccomcontainedobject__release">\</a>  CComContainedObject::Release  
 Decrements the reference count on the owner object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 In debug builds,                         **Release** returns a value that may be useful for diagnostics or testing. In non-debug builds,                         **Release** always returns 0.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)