---
title: "CComObjectStack Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL::CComObjectStack
  - ATL.CComObjectStack
  - ATL::CComObjectStack<Base>
  - ATL.CComObjectStack<Base>
  - CComObjectStack
dev_langs: 
  - C++
helpviewer_keywords: 
  - CComObjectStack class
ms.assetid: 3da72c40-c834-45f6-bb76-6ac204028d80
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComObjectStack Class
This class creates a temporary COM object and provides it with a skeletal implementation of             **IUnknown**.  
  
## Syntax  
  
```  
  
template<  
   class   
Base  
>  
class  
CComObjectStack  
:  
public  
Base  
  
```  
  
#### Parameters  
 `Base`  
 Your class, derived from                         [CComObjectRoot](../vs140/ccomobjectroot-class.md) or                         [CComObjectRootEx](../vs140/ccomobjectrootex-class.md), as well as from any other interface you want to support on the object.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComObjectStack::CComObjectStack](../vs140/ccomobjectstack--ccomobjectstack.md)|The constructor.|  
|[CComObjectStack::~CComObjectStack](../vs140/ccomobjectstack--~ccomobjectstack.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComObjectStack::AddRef](../vs140/ccomobjectstack--addref.md)|Returns zero. In debug mode, calls                                         `_ASSERTE`.|  
|[CComObjectStack::QueryInterface](../vs140/ccomobjectstack--queryinterface.md)|Returns                                         **E_NOINTERFACE**. In debug mode, calls                                         `_ASSERTE`.|  
|[CComObjectStack::Release](../vs140/ccomobjectstack--release.md)|Returns zero. In debug mode, calls                                         `_ASSERTE`. ~|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComObjectStack::m_hResFinalConstruct](../vs140/ccomobjectstack--m_hresfinalconstruct.md)|Contains the                                         **HRESULT** returned during construction of the                                         `CComObjectStack` object.|  
  
## Remarks  
 `CComObjectStack` is used to create a temporary COM object and provide the object a skeletal implementation of                 **IUnknown**. Typically, the object is used as a local variable within one function (that is, pushed onto the stack). Since the object is destroyed when the function finishes, reference counting is not performed to increase efficiency.  
  
 The following example shows how to create a COM object used inside a function:  
  
 [!code[NVC_ATL_COM#42](../vs140/codesnippet/CPP/ccomobjectstack-class_1.cpp)]
  
  
 The temporary object                 `Tempobj` is pushed onto the stack and automatically disappears when the function finishes.  
  
## Inheritance Hierarchy  
 `Base`  
  
 `CComObjectStack`  
  
## Requirements  
 **Header:** atlcom.h  
  
##  <a name="ccomobjectstack__addref"></a>  CComObjectStack::AddRef  
 Returns zero.  
  
```  
  
STDMETHOD_(ULONG, AddRef)( );  
  
```  
  
### Return Value  
 Returns zero.  
  
### Remarks  
 In debug mode, calls                         `_ASSERTE`.  
  
##  <a name="ccomobjectstack__ccomobjectstack"></a>  CComObjectStack::CComObjectStack  
 The constructor.  
  
```  
  
CComObjectStack(  
   void* = NULL   
);  
  
```  
  
### Remarks  
 Calls                         `FinalConstruct` and then sets                         [m_hResFinalConstruct](../vs140/ccomobjectstack--m_hresfinalconstruct.md) to the                         `HRESULT` returned by                         `FinalConstruct`. If you have not derived your base class from                         [CComObjectRoot](../vs140/ccomobjectroot-class.md), you must supply your own                         `FinalConstruct` method. The destructor calls                         `FinalRelease`.  
  
##  <a name="ccomobjectstack___dtorccomobjectstack"></a>  CComObjectStack::~CComObjectStack  
 The destructor.  
  
```  
  
CComObjectStack( );  
  
```  
  
### Remarks  
 Frees all allocated resources and calls                         [FinalRelease](../vs140/ccomobjectrootex--finalrelease.md).  
  
##  <a name="ccomobjectstack__m_hresfinalconstruct"></a>  CComObjectStack::m_hResFinalConstruct  
 Contains the                 `HRESULT` returned from calling                 `FinalConstruct` during construction of the                 `CComObjectStack` object.  
  
```  
  
HRESULT  
m_hResFinalConstruct;  
  
```  
  
##  <a name="ccomobjectstack__queryinterface"></a>  CComObjectStack::QueryInterface  
 Returns                 **E_NOINTERFACE**.  
  
```  
  
HRESULT  
QueryInterface(  
   REFIID,  
   void**  
)  
;  
  
```  
  
### Return Value  
 Returns                         **E_NOINTERFACE**.  
  
### Remarks  
 In debug mode, calls                         `_ASSERTE`.  
  
##  <a name="ccomobjectstack__release"></a>  CComObjectStack::Release  
 Returns zero.  
  
```  
  
STDMETHOD_(ULONG, Release)( );  
  
```  
  
### Return Value  
 Returns zero.  
  
### Remarks  
 In debug mode, calls                         `_ASSERTE`.  
  
## See Also  
 [CComAggObject Class](../vs140/ccomaggobject-class.md)   
 [CComObject Class](../vs140/ccomobject-class.md)   
 [CComObjectGlobal Class](../vs140/ccomobjectglobal-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)