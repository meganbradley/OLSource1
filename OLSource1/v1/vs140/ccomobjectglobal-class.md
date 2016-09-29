---
title: "CComObjectGlobal Class"
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
  - "CComObjectGlobal"
  - "ATL::CComObjectGlobal<Base>"
  - "ATL::CComObjectGlobal"
  - "ATL.CComObjectGlobal"
  - "ATL.CComObjectGlobal<Base>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComObjectGlobal class"
ms.assetid: 79bdee55-66e4-4536-b5b3-bdf09f78b9a6
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectGlobal Class
This class manages a reference count on the module containing your `Base` object.  
  
## Syntax  
  
```  
  
template<  
      class  Base>  
   class  
   CComObjectGlobal  
   :  
   public Base  
  
```  
  
#### Parameters  
 `Base`  
 Your class, derived from [CComObjectRoot](../vs140/ccomobjectroot-class.md) or [CComObjectRootEx](../vs140/ccomobjectrootex-class.md), as well as from any other interface you want to support on the object.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComObjectGlobal::CComObjectGlobal](../vs140/ccomobjectglobal--ccomobjectglobal.md)|The constructor.|  
|[CComObjectGlobal::~CComObjectGlobal](../vs140/ccomobjectglobal--~ccomobjectglobal.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComObjectGlobal::AddRef](../vs140/ccomobjectglobal--addref.md)|Implements a global `AddRef`.|  
|[CComObjectGlobal::QueryInterface](../vs140/ccomobjectglobal--queryinterface.md)|Implements a global `QueryInterface`.|  
|[CComObjectGlobal::Release](../vs140/ccomobjectglobal--release.md)|Implements a global **Release**.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComObjectGlobal::m_hResFinalConstruct](../vs140/ccomobjectglobal--m_hresfinalconstruct.md)|Contains the  **HRESULT** returned during construction of the `CComObjectGlobal` object.|  
  
## Remarks  
 `CComObjectGlobal` manages a reference count on the module containing your `Base` object. `CComObjectGlobal` ensures your object will not be deleted as long as the module is not released. Your object will only be removed when the reference count on the entire module goes to zero.  
  
 For example, using `CComObjectGlobal`, a class factory can hold a common global object that is shared by all its clients.  
  
## Inheritance Hierarchy  
 `Base`  
  
 `CComObjectGlobal`  
  
## Requirements  
 **Header:** atlcom.h  
  
##  <a name="ccomobjectglobal__addref"></a>  CComObjectGlobal::AddRef  
 Increments the reference count of the object by 1.  
  
```  
  
STDMETHOD_(ULONG, AddRef)( );  
  
```  
  
### Return Value  
 A value that may be useful for diagnostics and testing.  
  
### Remarks  
 By default, `AddRef` calls **_Module::Lock**, where **_Module** is the global instance of [CComModule](../vs140/ccommodule-class.md) or a class derived from it.  
  
##  <a name="ccomobjectglobal__ccomobjectglobal"></a>  CComObjectGlobal::CComObjectGlobal  
 The constructor. Calls `FinalConstruct` and then sets [m_hResFinalConstruct](../vs140/ccomobjectglobal--m_hresfinalconstruct.md) to the `HRESULT` returned by `FinalConstruct`.  
  
```  
  
CComObjectGlobal(   
      void* = NULL   
   )  
   );  
  
```  
  
### Remarks  
 If you have not derived your base class from [CComObjectRoot](../vs140/ccomobjectroot-class.md), you must supply your own `FinalConstruct` method. The destructor calls `FinalRelease`.  
  
##  <a name="ccomobjectglobal___dtorccomobjectglobal"></a>  CComObjectGlobal::~CComObjectGlobal  
 The destructor.  
  
```  
  
CComObjectGlobal( );  
  
```  
  
### Remarks  
 Frees all allocated resources and calls [FinalRelease](../vs140/ccomobjectrootex--finalrelease.md).  
  
##  <a name="ccomobjectglobal__m_hresfinalconstruct"></a>  CComObjectGlobal::m_hResFinalConstruct  
 Contains the `HRESULT` from calling `FinalConstruct` during construction of the `CComObjectGlobal` object.  
  
```  
  
HRESULT  
   m_hResFinalConstruct;  
  
```  
  
##  <a name="ccomobjectglobal__queryinterface"></a>  CComObjectGlobal::QueryInterface  
 Retrieves a pointer to the requested interface pointer.  
  
```  
  
STDMETHOD(QueryInterface)(  
      REFIID iid,  
   void** ppvObject  
   )  
   ;  
  
```  
  
### Parameters  
 `iid`  
 [in] The GUID of the interface being requested.  
  
 `ppvObject`  
 [out] A pointer to the interface pointer identified by iid, or **NULL** if the interface is not found.  
  
### Return Value  
 A standard `HRESULT` value.  
  
### Remarks  
 `QueryInterface` only handles interfaces in the COM map table.  
  
##  <a name="ccomobjectglobal__release"></a>  CComObjectGlobal::Release  
 Decrements the reference count of the object by 1.  
  
```  
  
STDMETHOD_(ULONG, Release)(  
   );  
  
```  
  
### Return Value  
 In debug builds,                         **Release** returns a value that may be useful for diagnostics and testing. In non-debug builds,                         **Release** always returns 0.  
  
### Remarks  
 By default,                         **Release** calls **_Module::Unlock**, where **_Module** is the global instance of [CComModule](../vs140/ccommodule-class.md) or a class derived from it.  
  
## See Also  
 [CComObjectStack Class](../vs140/ccomobjectstack-class.md)   
 [CComAggObject Class](../vs140/ccomaggobject-class.md)   
 [CComObject Class](../vs140/ccomobject-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)