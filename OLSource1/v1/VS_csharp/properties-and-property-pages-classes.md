---
title: "Properties and Property Pages Classes"
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
  - "vc.atl.properties"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "property pages, classes"
  - "properties [ATL], classes"
  - "properties [ATL]"
ms.assetid: 31616f98-69f8-48b2-8d58-b8e7d1c2b2d8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Properties and Property Pages Classes
The following classes support properties and property pages:  
  
-   [CComDispatchDriver](../VS_csharp/ccomdispatchdriver.md) Retrieves or sets an object's properties through an `IDispatch` pointer.  
  
-   [CStockPropImpl](../VS_csharp/cstockpropimpl-class.md) Implements the stock properties supported by ATL.  
  
-   [IPerPropertyBrowsingImpl](../VS_csharp/iperpropertybrowsingimpl-class.md) Accesses the information in an object's property pages.  
  
-   [IPersistPropertyBagImpl](../VS_csharp/ipersistpropertybagimpl-class.md) Stores an object's properties in a client-supplied property bag.  
  
-   [IPropertyPageImpl](../VS_csharp/ipropertypageimpl-class.md) Manages a particular property page within a property sheet.  
  
-   [IPropertyPage2Impl](../VS_csharp/ipropertypage2impl-class.md) Similar to `IPropertyPageImpl`, but also allows a client to select a specific property in a property page.  
  
-   [ISpecifyPropertyPagesImpl](../VS_csharp/ispecifypropertypagesimpl-class.md) Obtains the CLSIDs for the property pages supported by an object.  
  
## Related Articles  
 [ATL Tutorial](../VS_csharp/active-template-library--atl--tutorial.md)  
  
 [ATL COM Property Pages](../VS_csharp/atl-com-property-pages.md)  
  
## See Also  
 [Class Overview](../VS_csharp/atl-class-overview.md)   
 [Property Map Macros](../VS_csharp/property-map-macros.md)