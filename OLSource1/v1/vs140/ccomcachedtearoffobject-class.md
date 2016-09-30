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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Your tear-off class, derived from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and the interfaces you want your tear-off object to support.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComCachedTearOffObject::CComCachedTearOffObject](../vs140/ccomcachedtearoffobject--ccomcachedtearoffobject.md)|The constructor.|  
|[CComCachedTearOffObject::~CComCachedTearOffObject](../vs140/ccomcachedtearoffobject--~ccomcachedtearoffobject.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComCachedTearOffObject::AddRef](../vs140/ccomcachedtearoffobject--addref.md)|Increments the reference count for a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
|[CComCachedTearOffObject::FinalConstruct](../vs140/ccomcachedtearoffobject--finalconstruct.md)|Calls the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (the tear-off class' method).|  
|[CComCachedTearOffObject::FinalRelease](../vs140/ccomcachedtearoffobject--finalrelease.md)|Calls the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (the tear-off class' method).|  
|[CComCachedTearOffObject::QueryInterface](../vs140/ccomcachedtearoffobject--queryinterface.md)|Returns a pointer to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object, or to the requested interface on your tear-off class (the class <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>).|  
|[CComCachedTearOffObject::Release](../vs140/ccomcachedtearoffobject--release.md)|Decrements the reference count for a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object and destroys it if the reference count is 0.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComCachedTearOffObject::m_contained](../vs140/ccomcachedtearoffobject--m_contained.md)|A <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object derived from your tear-off class (the class <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>).|  
  
## Remarks  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) for a tear-off interface. This class differs from <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> in that <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> has its own **IUnknown**, separate from the owner object's **IUnknown** (the owner is the object for which the tear-off is being created). <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> maintains its own reference count on its **IUnknown** and deletes itself once its reference count is zero. However, if you query for any of its tear-off interfaces, the reference count of the owner object's **IUnknown** will be incremented.  
  
 If the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object implementing the tear-off is already instantiated, and the tear-off interface is queried for again, the same <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object is reused. In contrast, if a tear-off interface implemented by a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is again queried for through the owner object, another <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> will be instantiated.  
  
 The owner class must implement <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and call **Release** on the cached **IUnknown** for the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, which will decrement its reference count. This will cause <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>'s <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to be called and delete the tear-off.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 [CComObjectRootEx](../vs140/ccomobjectrootex-class.md)  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomcachedtearoffobject__addref">\</a>  CComCachedTearOffObject::AddRef  
 Increments the reference count of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object by 1.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 A value that may be useful for diagnostics and testing.  
  
##  \<a name="ccomcachedtearoffobject__ccomcachedtearoffobject">\</a>  CComCachedTearOffObject::CComCachedTearOffObject  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 [in] Pointer to the **IUnknown** of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
### Remarks  
 Initializes the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> member, [m_contained](../vs140/ccomcachedtearoffobject--m_contained.md).  
  
##  \<a name="ccomcachedtearoffobject___dtorccomcachedtearoffobject">\</a>  CComCachedTearOffObject::~CComCachedTearOffObject  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources and calls [FinalRelease](../vs140/ccomcachedtearoffobject--finalrelease.md).  
  
##  \<a name="ccomcachedtearoffobject__finalconstruct">\</a>  CComCachedTearOffObject::FinalConstruct  
 Calls **m_contained::FinalConstruct** to create <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>> object used to access the interface implemented by your tear-off class.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A standard <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> value.  
  
##  \<a name="ccomcachedtearoffobject__finalrelease">\</a>  CComCachedTearOffObject::FinalRelease  
 Calls **m_contained::FinalRelease** to free <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="ccomcachedtearoffobject__m_contained">\</a>  CComCachedTearOffObject::m_contained  
 A [CComContainedObject](../vs140/ccomcontainedobject-class.md) object derived from your tear-off class.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 [in] Your tear-off class, derived from <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and the interfaces you want your tear-off object to support.  
  
### Remarks  
 The methods <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> inherits are used to access the tear-off interface in your tear-off class through the cached tear-off object's <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
##  \<a name="ccomcachedtearoffobject__queryinterface">\</a>  CComCachedTearOffObject::QueryInterface  
 Retrieves a pointer to the requested interface.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 [in] The GUID of the interface being requested.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, or **NULL** if the interface is not found.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> value.  
  
### Remarks  
 If the requested interface is **IUnknown**, returns a pointer to the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>'s own **IUnknown** and increments the reference count. Otherwise, queries for the interface on your tear-off class using the [InternalQueryInterface](../vs140/ccomobjectrootex--internalqueryinterface.md) method inherited from <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
##  \<a name="ccomcachedtearoffobject__release">\</a>  CComCachedTearOffObject::Release  
 Decrements the reference count by 1 and, if the reference count is 0, deletes the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 In non-debug builds, always returns 0. In debug builds, returns a value that may be useful for diagnostics or testing.  
  
## See Also  
 [CComTearOffObject Class](../vs140/ccomtearoffobject-class.md)   
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)