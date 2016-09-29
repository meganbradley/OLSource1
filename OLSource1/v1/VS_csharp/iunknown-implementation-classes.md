---
title: "IUnknown Implementation Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.atl.Iunknown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IUnknown implementation classes"
ms.assetid: 47b69bb5-69d8-4a9c-84a8-329bdde2bb3f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IUnknown Implementation Classes
The following classes implement **IUnknown** and related methods:  
  
-   [CComObjectRootEx](../VS_csharp/ccomobjectrootex-class.md) Manages reference counting for both aggregated and nonaggregated objects. Allows you to specify a threading model.  
  
-   [CComObjectRoot](../VS_csharp/ccomobjectroot-class.md) Manages reference counting for both aggregated and nonaggregated objects. Uses the default threading model of the server.  
  
-   [CComAggObject](../VS_csharp/ccomaggobject-class.md) Implements **IUnknown** for an aggregated object.  
  
-   [CComObject](../VS_csharp/ccomobject-class.md) Implements **IUnknown** for a nonaggregated object.  
  
-   [CComPolyObject](../VS_csharp/ccompolyobject-class.md) Implements **IUnknown** for aggregated and nonaggregated objects. Using `CComPolyObject` avoids having both `CComAggObject` and `CComObject` in your module. A single `CComPolyObject` object handles both aggregated and nonaggregated cases.  
  
-   [CComObjectNoLock](../VS_csharp/ccomobjectnolock-class.md) Implements **IUnknown** for a nonaggregated object, without modifying the module lock count.  
  
-   [CComTearOffObject](../VS_csharp/ccomtearoffobject-class.md) Implements **IUnknown** for a tear-off interface.  
  
-   [CComCachedTearOffObject](../VS_csharp/ccomcachedtearoffobject-class.md) Implements **IUnknown** for a "cached" tear-off interface.  
  
-   [CComContainedObject](../VS_csharp/ccomcontainedobject-class.md) Implements **IUnknown** for the inner object of an aggregation or a tear-off interface.  
  
-   [CComObjectGlobal](../VS_csharp/ccomobjectglobal-class.md) Manages a reference count on the module to ensure your object won't be deleted.  
  
-   [CComObjectStack](../VS_csharp/ccomobjectstack-class.md) Creates a temporary COM object, using a skeletal implementation of **IUnknown**.  
  
## Related Articles  
 [Fundamentals of ATL COM Objects](../VS_csharp/fundamentals-of-atl-com-objects.md)  
  
## See Also  
 [Class Overview](../VS_csharp/atl-class-overview.md)   
 [Aggregation and Class Factory Macros](../VS_csharp/aggregation-and-class-factory-macros.md)   
 [COM Map Macros](../VS_csharp/com-map-macros.md)   
 [COM Map Global Functions](../VS_csharp/com-map-global-functions.md)