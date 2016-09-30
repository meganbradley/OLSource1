---
title: "CComClassFactory Class"
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
  - "ATL.CComClassFactory"
  - "CComClassFactory"
  - "ATL::CComClassFactory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComClassFactory class"
ms.assetid: e56dacf7-d5c4-4c42-aef4-a86d91981a1b
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactory Class
This class implements the [IClassFactory](http://msdn.microsoft.com/library/windows/desktop/ms694364) interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComClassFactory::CreateInstance](../vs140/ccomclassfactory--createinstance.md)|Creates an object of the specified CLSID.|  
|[CComClassFactory::LockServer](../vs140/ccomclassfactory--lockserver.md)|Locks the class factory in memory.|  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> implements the [IClassFactory](http://msdn.microsoft.com/library/windows/desktop/ms694364) interface, which contains methods for creating an object of a particular CLSID, as well as locking the class factory in memory to allow new objects to be created more quickly. **IClassFactory** must be implemented for every class that you register in the system registry and to which you assign a CLSID.  
  
 ATL objects normally acquire a class factory by deriving from [CComCoClass](../vs140/ccomcoclass-class.md). This class includes the macro [DECLARE_CLASSFACTORY](../vs140/declare_classfactory.md), which declares <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> as the default class factory. To override this default, specify one of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>*XXX* macros in your class definition. For example, the [DECLARE_CLASSFACTORY_EX](../vs140/declare_classfactory_ex.md) macro uses the specified class for the class factory:  
  
 [!code[NVC_ATL_COM#8](../vs140/codesnippet/CPP/ccomclassfactory-class_1.h)]  
  
 The above class definition specifies that **CMyClassFactory** will be used as the object's default class factory. **CMyClassFactory** must derive from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and override <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 ATL provides three other macros that declare a class factory:  
  
-   [DECLARE_CLASSFACTORY2](../vs140/declare_classfactory2.md) Uses [CComClassFactory2](../vs140/ccomclassfactory2-class.md), which controls creation through a license.  
  
-   [DECLARE_CLASSFACTORY_AUTO_THREAD](../vs140/declare_classfactory_auto_thread.md) Uses [CComClassFactoryAutoThread](../vs140/ccomclassfactoryautothread-class.md), which creates objects in multiple apartments.  
  
-   [DECLARE_CLASSFACTORY_SINGLETON](../vs140/declare_classfactory_singleton.md) Uses [CComClassFactorySingleton](../vs140/ccomclassfactorysingleton-class.md), which constructs a single [CComObjectGlobal](../vs140/ccomobjectglobal-class.md) object.  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomclassfactory__createinstance">\</a>  CComClassFactory::CreateInstance  
 Creates an object of the specified CLSID and retrieves an interface pointer to this object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] If the object is being created as part of an aggregate, then <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> must be the outer unknown. Otherwise, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> must be **NULL**.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 [in] The IID of the requested interface. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is non-                                **NULL**, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> must be **IID_IUnknown**.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> value.  
  
##  \<a name="ccomclassfactory__lockserver">\</a>  CComClassFactory::LockServer  
 Increments and decrements the module lock count by calling **_Module::Lock** and **_Module::Unlock**, respectively.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 [in] If **TRUE**, the lock count is incremented; otherwise, the lock count is decremented.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> value.  
  
### Remarks  
 **_Module** refers to the global instance of [CComModule](../vs140/ccommodule-class.md) or a class derived from it.  
  
 Calling <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> allows a client to hold onto a class factory so that multiple objects can be created quickly.  
  
## See Also  
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)   
 [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md)   
 [Class Overview](../vs140/atl-class-overview.md)