---
title: "CComObjectNoLock Class"
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
  - "ATL.CComObjectNoLock"
  - "ATL::CComObjectNoLock"
  - "ATL.CComObjectNoLock<Base>"
  - "CComObjectNoLock"
  - "ATL::CComObjectNoLock<Base>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComObjectNoLock class"
ms.assetid: 288c6506-7da8-4127-8d58-7f4bd779539a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectNoLock Class
This class implements **IUnknown** for a nonaggregated object, but does not increment the module lock count in the constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Your class, derived from [CComObjectRoot](../vs140/ccomobjectroot-class.md) or [CComObjectRootEx](../vs140/ccomobjectrootex-class.md), as well as from any other interface you want to support on the object.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComObjectNoLock::CComObjectNoLock](../vs140/ccomobjectnolock--ccomobjectnolock.md)|Constructor.|  
|[CComObjectNoLock::~CComObjectNoLock](../vs140/ccomobjectnolock--~ccomobjectnolock.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComObjectNoLock::AddRef](../vs140/ccomobjectnolock--addref.md)|Increments the reference count on the object.|  
|[CComObjectNoLock::QueryInterface](../vs140/ccomobjectnolock--queryinterface.md)|Returns a pointer to the requested interface.|  
|[CComObjectNoLock::Release](../vs140/ccomobjectnolock--release.md)|Decrements the reference count on the object.|  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is similar to [CComObject](../vs140/ccomobject-class.md) in that it implements [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) for a nonaggregated object; however, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> does not increment the module lock count in the constructor.  
  
 ATL uses <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> internally for class factories. In general, you will not use this class directly.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomobjectnolock__addref">\</a>  CComObjectNoLock::AddRef  
 Increments the reference count on the object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 A value that may be useful for diagnostics or testing.  
  
##  \<a name="ccomobjectnolock__ccomobjectnolock">\</a>  CComObjectNoLock::CComObjectNoLock  
 The constructor. Unlike [CComObject](../vs140/ccomobject-class.md), does not increment the module lock count.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 **void\***  
 [in] This unnamed parameter is not used. It exists for symmetry with other **CCom***XXX*<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>*XXX* constructors.  
  
##  \<a name="ccomobjectnolock___dtorccomobjectnolock">\</a>  CComObjectNoLock::~CComObjectNoLock  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources and calls [FinalRelease](../vs140/ccomobjectrootex--finalrelease.md).  
  
##  \<a name="ccomobjectnolock__queryinterface">\</a>  CComObjectNoLock::QueryInterface  
 Retrieves a pointer to the requested interface.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 [in] The identifier of the interface being requested.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> value.  
  
##  \<a name="ccomobjectnolock__release">\</a>  CComObjectNoLock::Release  
 Decrements the reference count on the object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 In debug builds,                         **Release** returns a value that may be useful for diagnostics or testing. In non-debug builds,                         **Release** always returns 0.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)