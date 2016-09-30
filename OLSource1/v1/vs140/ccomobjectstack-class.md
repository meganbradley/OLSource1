---
title: "CComObjectStack Class"
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
  - "ATL::CComObjectStack"
  - "ATL.CComObjectStack"
  - "ATL::CComObjectStack<Base>"
  - "ATL.CComObjectStack<Base>"
  - "CComObjectStack"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComObjectStack class"
ms.assetid: 3da72c40-c834-45f6-bb76-6ac204028d80
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectStack Class
This class creates a temporary COM object and provides it with a skeletal implementation of             **IUnknown**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
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
|[CComObjectStack::AddRef](../vs140/ccomobjectstack--addref.md)|Returns zero. In debug mode, calls                                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|[CComObjectStack::QueryInterface](../vs140/ccomobjectstack--queryinterface.md)|Returns                                         **E_NOINTERFACE**. In debug mode, calls                                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|[CComObjectStack::Release](../vs140/ccomobjectstack--release.md)|Returns zero. In debug mode, calls                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. ~|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComObjectStack::m_hResFinalConstruct](../vs140/ccomobjectstack--m_hresfinalconstruct.md)|Contains the                                         **HRESULT** returned during construction of the                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is used to create a temporary COM object and provide the object a skeletal implementation of                 **IUnknown**. Typically, the object is used as a local variable within one function (that is, pushed onto the stack). Since the object is destroyed when the function finishes, reference counting is not performed to increase efficiency.  
  
 The following example shows how to create a COM object used inside a function:  
  
 [!code[NVC_ATL_COM#42](../vs140/codesnippet/CPP/ccomobjectstack-class_1.cpp)]  
  
 The temporary object                 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is pushed onto the stack and automatically disappears when the function finishes.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomobjectstack__addref">\</a>  CComObjectStack::AddRef  
 Returns zero.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 Returns zero.  
  
### Remarks  
 In debug mode, calls                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
##  \<a name="ccomobjectstack__ccomobjectstack">\</a>  CComObjectStack::CComObjectStack  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Calls                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and then sets                         [m_hResFinalConstruct](../vs140/ccomobjectstack--m_hresfinalconstruct.md) to the                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> returned by                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If you have not derived your base class from                         [CComObjectRoot](../vs140/ccomobjectroot-class.md), you must supply your own                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> method. The destructor calls                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
##  \<a name="ccomobjectstack___dtorccomobjectstack">\</a>  CComObjectStack::~CComObjectStack  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources and calls                         [FinalRelease](../vs140/ccomobjectrootex--finalrelease.md).  
  
##  \<a name="ccomobjectstack__m_hresfinalconstruct">\</a>  CComObjectStack::m_hResFinalConstruct  
 Contains the                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> returned from calling                 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> during construction of the                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="ccomobjectstack__queryinterface">\</a>  CComObjectStack::QueryInterface  
 Returns                 **E_NOINTERFACE**.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns                         **E_NOINTERFACE**.  
  
### Remarks  
 In debug mode, calls                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
##  \<a name="ccomobjectstack__release">\</a>  CComObjectStack::Release  
 Returns zero.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns zero.  
  
### Remarks  
 In debug mode, calls                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
## See Also  
 [CComAggObject Class](../vs140/ccomaggobject-class.md)   
 [CComObject Class](../vs140/ccomobject-class.md)   
 [CComObjectGlobal Class](../vs140/ccomobjectglobal-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)