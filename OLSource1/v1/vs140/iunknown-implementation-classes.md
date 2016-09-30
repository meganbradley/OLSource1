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
  
-   [CComObjectRootEx](../vs140/ccomobjectrootex-class.md) Manages reference counting for both aggregated and nonaggregated objects. Allows you to specify a threading model.  
  
-   [CComObjectRoot](../vs140/ccomobjectroot-class.md) Manages reference counting for both aggregated and nonaggregated objects. Uses the default threading model of the server.  
  
-   [CComAggObject](../vs140/ccomaggobject-class.md) Implements **IUnknown** for an aggregated object.  
  
-   [CComObject](../vs140/ccomobject-class.md) Implements **IUnknown** for a nonaggregated object.  
  
-   [CComPolyObject](../vs140/ccompolyobject-class.md) Implements **IUnknown** for aggregated and nonaggregated objects. Using <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> avoids having both <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in your module. A single <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object handles both aggregated and nonaggregated cases.  
  
-   [CComObjectNoLock](../vs140/ccomobjectnolock-class.md) Implements **IUnknown** for a nonaggregated object, without modifying the module lock count.  
  
-   [CComTearOffObject](../vs140/ccomtearoffobject-class.md) Implements **IUnknown** for a tear-off interface.  
  
-   [CComCachedTearOffObject](../vs140/ccomcachedtearoffobject-class.md) Implements **IUnknown** for a "cached" tear-off interface.  
  
-   [CComContainedObject](../vs140/ccomcontainedobject-class.md) Implements **IUnknown** for the inner object of an aggregation or a tear-off interface.  
  
-   [CComObjectGlobal](../vs140/ccomobjectglobal-class.md) Manages a reference count on the module to ensure your object won't be deleted.  
  
-   [CComObjectStack](../vs140/ccomobjectstack-class.md) Creates a temporary COM object, using a skeletal implementation of **IUnknown**.  
  
## Related Articles  
 [Fundamentals of ATL COM Objects](../vs140/fundamentals-of-atl-com-objects.md)  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [Aggregation and Class Factory Macros](../vs140/aggregation-and-class-factory-macros.md)   
 [COM Map Macros](../vs140/com-map-macros.md)   
 [COM Map Global Functions](../vs140/com-map-global-functions.md)