---
title: "CComClassFactorySingleton Class"
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
  - "ATL.CComClassFactorySingleton"
  - "ATL.CComClassFactorySingleton<T>"
  - "ATL::CComClassFactorySingleton"
  - "ATL::CComClassFactorySingleton<T>"
  - "CComClassFactorySingleton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComClassFactorySingleton class"
ms.assetid: debb983c-382b-487b-8d42-7ea26dc158b8
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactorySingleton Class
This class derives from [CComClassFactory](../vs140/ccomclassfactory-class.md) and uses [CComObjectGlobal](../vs140/ccomobjectglobal-class.md) to construct a single object.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Your class.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> derives from [CComClassFactory](../vs140/ccomclassfactory-class.md) and uses [CComObjectGlobal](../vs140/ccomobjectglobal-class.md) to construct a single object. Each call to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method simply queries this object for an interface pointer.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComClassFactorySingleton::CreateInstance](../vs140/ccomclassfactorysingleton--createinstance.md)|Queries <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for an interface pointer.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComClassFactorySingleton::m_spObj](../vs140/ccomclassfactorysingleton--m_spobj.md)|The [CComObjectGlobal](../vs140/ccomobjectglobal-class.md) object constructed by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
  
## Remarks  
 ATL objects normally acquire a class factory by deriving from [CComCoClass](../vs140/ccomcoclass-class.md). This class includes the macro [DECLARE_CLASSFACTORY](../vs140/declare_classfactory.md), which declares <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as the default class factory. To use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, specify the [DECLARE_CLASSFACTORY_SINGLETON](../vs140/declare_classfactory_singleton.md) macro in your object's class definition. For example:  
  
 [!code[NVC_ATL_COM#10](../vs140/codesnippet/CPP/ccomclassfactorysingleton-class_1.h)]  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 [CComObjectRootEx](../vs140/ccomobjectrootex-class.md)  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 [CComClassFactory](../vs140/ccomclassfactory-class.md)  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomclassfactorysingleton__createinstance">\</a>  CComClassFactorySingleton::CreateInstance  
 Calls <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> through [m_spObj](../vs140/ccomclassfactorysingleton--m_spobj.md) to retrieve an interface pointer.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 [in] If the object is being created as part of an aggregate, then <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> must be the outer unknown. Otherwise, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> must be **NULL**.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 [in] The IID of the requested interface. If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is non-                                **NULL**, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> must be **IID_IUnknown**.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> value.  
  
##  \<a name="ccomclassfactorysingleton__m_spobj">\</a>  CComClassFactorySingleton::m_spObj  
 The [CComObjectGlobal](../vs140/ccomobjectglobal-class.md) object constructed by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Each call to the [CreateInstance](../vs140/ccomclassfactorysingleton--createinstance.md) method simply queries this object for an interface pointer.  
  
 Note that the current form of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> presents a breaking change from the way that <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> worked in previous versions of ATL. In previous versions the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object was created at the same time as the class factory, during server initialization. In Visual C++.NET 2003, the object is created lazily, on the first request. This change could cause errors in programs that rely on early initialization.  
  
## See Also  
 [IClassFactory](http://msdn.microsoft.com/library/windows/desktop/ms694364)   
 [CComClassFactory2 Class](../vs140/ccomclassfactory2-class.md)   
 [CComClassFactoryAutoThread Class](../vs140/ccomclassfactoryautothread-class.md)   
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)   
 [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md)   
 [Class Overview](../vs140/atl-class-overview.md)