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
  
-   [CComDispatchDriver](../vs140/ccomdispatchdriver.md) Retrieves or sets an object's properties through an `IDispatch` pointer.  
  
-   [CStockPropImpl](../vs140/cstockpropimpl-class.md) Implements the stock properties supported by ATL.  
  
-   [IPerPropertyBrowsingImpl](../vs140/iperpropertybrowsingimpl-class.md) Accesses the information in an object's property pages.  
  
-   [IPersistPropertyBagImpl](../vs140/ipersistpropertybagimpl-class.md) Stores an object's properties in a client-supplied property bag.  
  
-   [IPropertyPageImpl](../vs140/ipropertypageimpl-class.md) Manages a particular property page within a property sheet.  
  
-   [IPropertyPage2Impl](../vs140/ipropertypage2impl-class.md) Similar to `IPropertyPageImpl`, but also allows a client to select a specific property in a property page.  
  
-   [ISpecifyPropertyPagesImpl](../vs140/ispecifypropertypagesimpl-class.md) Obtains the CLSIDs for the property pages supported by an object.  
  
## Related Articles  
 [ATL Tutorial](../vs140/active-template-library--atl--tutorial.md)  
  
 [ATL COM Property Pages](../vs140/atl-com-property-pages.md)  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [Property Map Macros](../vs140/property-map-macros.md)