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
This class derives from [CComClassFactory](../VS_csharp/ccomclassfactory-class.md) and uses [CComObjectGlobal](../VS_csharp/ccomobjectglobal-class.md) to construct a single object.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
template<  
   class  T>  
   class CComClassFactorySingleton :  
   public CComClassFactory  
  
```  
  
#### Parameters  
 `T`  
 Your class.  
  
 `CComClassFactorySingleton` derives from [CComClassFactory](../VS_csharp/ccomclassfactory-class.md) and uses [CComObjectGlobal](../VS_csharp/ccomobjectglobal-class.md) to construct a single object. Each call to the `CreateInstance` method simply queries this object for an interface pointer.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComClassFactorySingleton::CreateInstance](../Topic/CComClassFactorySingleton::CreateInstance.md)|Queries `m_spObj` for an interface pointer.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComClassFactorySingleton::m_spObj](../Topic/CComClassFactorySingleton::m_spObj.md)|The [CComObjectGlobal](../VS_csharp/ccomobjectglobal-class.md) object constructed by `CComClassFactorySingleton`.|  
  
## Remarks  
 ATL objects normally acquire a class factory by deriving from [CComCoClass](../VS_csharp/ccomcoclass-class.md). This class includes the macro [DECLARE_CLASSFACTORY](../VS_csharp/declare_classfactory.md), which declares `CComClassFactory` as the default class factory. To use `CComClassFactorySingleton`, specify the [DECLARE_CLASSFACTORY_SINGLETON](../VS_csharp/declare_classfactory_singleton.md) macro in your object's class definition. For example:  
  
 [!code[NVC_ATL_COM#10](../VS_csharp/codesnippet/CPP/ccomclassfactorysingleton-class_1.h)]  
  
## Inheritance Hierarchy  
 `CComObjectRootBase`  
  
 [CComObjectRootEx](../VS_csharp/ccomobjectrootex-class.md)  
  
 `IClassFactory`  
  
 [CComClassFactory](../VS_csharp/ccomclassfactory-class.md)  
  
 `CComClassFactorySingleton`  
  
## Requirements  
 **Header:** atlcom.h  
  
##  <a name="ccomclassfactorysingleton__createinstance"></a>  CComClassFactorySingleton::CreateInstance  
 Calls `QueryInterface` through [m_spObj](../Topic/CComClassFactorySingleton::m_spObj.md) to retrieve an interface pointer.  
  
```  
  
STDMETHOD(CreateInstance)(  
      LPUNKNOWN  pUnkOuter,  
      REFIID  riid,  
      void**  ppvObj  
   );  
  
```  
  
### Parameters  
 `pUnkOuter`  
 [in] If the object is being created as part of an aggregate, then `pUnkOuter` must be the outer unknown. Otherwise, `pUnkOuter` must be **NULL**.  
  
 `riid`  
 [in] The IID of the requested interface. If `pUnkOuter` is non-                                **NULL**, `riid` must be **IID_IUnknown**.  
  
 `ppvObj`  
 [out] A pointer to the interface pointer identified by `riid`. If the object does not support this interface, `ppvObj` is set to **NULL**.  
  
### Return Value  
 A standard `HRESULT` value.  
  
##  <a name="ccomclassfactorysingleton__m_spobj"></a>  CComClassFactorySingleton::m_spObj  
 The [CComObjectGlobal](../VS_csharp/ccomobjectglobal-class.md) object constructed by `CComClassFactorySingleton`.  
  
```  
  
CComPtr<IUnknown> m_spObj;  
  
```  
  
### Remarks  
 Each call to the [CreateInstance](../Topic/CComClassFactorySingleton::CreateInstance.md) method simply queries this object for an interface pointer.  
  
 Note that the current form of `m_spObj` presents a breaking change from the way that `CComClassFactorySingleton` worked in previous versions of ATL. In previous versions the `CComClassFactorySingleton` object was created at the same time as the class factory, during server initialization. In Visual C++.NET 2003, the object is created lazily, on the first request. This change could cause errors in programs that rely on early initialization.  
  
## See Also  
 [IClassFactory](http://msdn.microsoft.com/library/windows/desktop/ms694364)   
 [CComClassFactory2 Class](../VS_csharp/ccomclassfactory2-class.md)   
 [CComClassFactoryAutoThread Class](../VS_csharp/ccomclassfactoryautothread-class.md)   
 [CComObjectRootEx Class](../VS_csharp/ccomobjectrootex-class.md)   
 [CComGlobalsThreadModel](../VS_csharp/ccomglobalsthreadmodel.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)