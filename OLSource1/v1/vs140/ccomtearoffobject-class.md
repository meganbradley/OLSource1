---
title: "CComTearOffObject Class"
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
  - "ATL::CComTearOffObject<Base>"
  - "ATL::CComTearOffObject"
  - "ATL.CComTearOffObject"
  - "ATL.CComTearOffObject<Base>"
  - "CComTearOffObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tear-off interfaces, ATL"
  - "tear-off interfaces"
  - "CComTearOffObject class"
ms.assetid: d974b598-c6b2-42b1-8360-9190d9d0fbf3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComTearOffObject Class
This class implements a tear-off interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Your tear-off class, derived from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and the interfaces you want your tear-off object to support.  
  
 ATL implements its tear-off interfaces in two phases — the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> methods handle the reference count and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, while <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509).  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComTearOffObject::CComTearOffObject](../vs140/ccomtearoffobject--ccomtearoffobject.md)|The constructor.|  
|[CComTearOffObject::~CComTearOffObject](../vs140/ccomtearoffobject--~ccomtearoffobject.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComTearOffObject::AddRef](../vs140/ccomtearoffobject--addref.md)|Increments the reference count for a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
|[CComTearOffObject::QueryInterface](../vs140/ccomtearoffobject--queryinterface.md)|Returns a pointer to the requested interface on either your tear-off class or the owner class.|  
|[CComTearOffObject::Release](../vs140/ccomtearoffobject--release.md)|Decrements the reference count for a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object and destroys it.|  
  
### CComTearOffObjectBase Methods  
  
|||  
|-|-|  
|[CComTearOffObjectBase](../vs140/ccomtearoffobject--ccomtearoffobjectbase.md)|Constructor.|  
  
### CComTearOffObjectBase Data Members  
  
|||  
|-|-|  
|[m_pOwner](../vs140/ccomtearoffobject--m_powner.md)|A pointer to a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> derived from the owner class.|  
  
## Remarks  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> implements a tear-off interface as a separate object that is instantiated only when that interface is queried for. The tear-off is deleted when its reference count becomes zero. Typically, you build a tear-off interface for an interface that is rarely used, since using a tear-off saves a vtable pointer in all the instances of your main object.  
  
 You should derive the class implementing the tear-off from <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and from whichever interfaces you want your tear-off object to support. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is templatized on the owner class and the thread model. The owner class is the class of the object for which a tear-off is being implemented. If you do not specify a thread model, the default thread model is used.  
  
 You should create a COM map for your tear-off class. When ATL instantiates the tear-off, it will create **CComTearOffObject\<CYourTearOffClass>** or **CComCachedTearOffObject\<CYourTearOffClass>**.  
  
 For example, in the BEEPER sample, the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class is the tear-off class and the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class is the owner class:  
  
 [!code[NVC_ATL_COM#43](../vs140/codesnippet/CPP/ccomtearoffobject-class_1.h)]  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomtearoffobject__addref">\</a>  CComTearOffObject::AddRef  
 Increments the reference count of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object by one.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 A value that may be useful for diagnostics and testing.  
  
##  \<a name="ccomtearoffobject__ccomtearoffobject">\</a>  CComTearOffObject::CComTearOffObject  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 [in] Pointer that will be converted to a pointer to a **CComObject\<Owner>** object.  
  
### Remarks  
 Increments the owner's reference count by one.  
  
##  \<a name="ccomtearoffobject___dtorccomtearoffobject">\</a>  CComTearOffObject::~CComTearOffObject  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources, calls FinalRelease, and decrements the module lock count.  
  
##  \<a name="ccomtearoffobject__ccomtearoffobjectbase">\</a>  CComTearOffObject::CComTearOffObjectBase  
 The constructor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Initializes the [m_pOwner](../vs140/ccomtearoffobject--m_powner.md) member to **NULL**.  
  
##  \<a name="ccomtearoffobject__m_powner">\</a>  CComTearOffObject::m_pOwner  
 A pointer to a [CComObject](../vs140/ccomobject-class.md) object derived from *Owner*.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *Owner*  
 [in] The class for which a tear-off is being implemented.  
  
### Remarks  
 The pointer is initialized to  **NULL** during construction.  
  
##  \<a name="ccomtearoffobject__queryinterface">\</a>  CComTearOffObject::QueryInterface  
 Retrieves a pointer to the requested interface.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 [in] The IID of the interface being requested.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, or **NULL** if the interface is not found.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> value.  
  
### Remarks  
 Queries first for interfaces on your tear-off class. If the interface is not there, queries for the interface on the owner object. If the requested interface is **IUnknown**, returns the **IUnknown** of the owner.  
  
##  \<a name="ccomtearoffobject__release">\</a>  CComTearOffObject::Release  
 Decrements the reference count by one and, if the reference count is zero, deletes the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 In non-debug builds, always returns zero. In debug builds, returns a value that may be useful for diagnostics or testing.  
  
## See Also  
 [CComCachedTearOffObject Class](../vs140/ccomcachedtearoffobject-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)