---
title: "IPropertyNotifySinkCP Class"
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
  - IPropertyNotifySinkCP
dev_langs: 
  - C++
helpviewer_keywords: 
  - connection points [C++], managing
  - sinks, notifying of changes
  - IPropertyNotifySinkCP class
ms.assetid: 1b41445e-bc88-4fa6-bb62-d68aacec2bd5
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IPropertyNotifySinkCP Class
This class exposes [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638) interface as an outgoing interface on a connectable object.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
template< class  T  
   , class CDV   
   = CComDynamicUnkArray >  
   class IPropertyNotifySinkCP :   
   public IConnectionPointImpl<  T  
   , &IID_IPropertyNotifySink,  CDV>  
  
```  
  
#### Parameters  
 `T`  
 Your class, derived from `IPropertyNotifySinkCP`.  
  
 `CDV`  
 A class that manages the connections between a connection point and its sinks. The default value is [CComDynamicUnkArray](../vs140/ccomdynamicunkarray-class.md), which allows unlimited connections. You can also use [CComUnkArray](../vs140/ccomunkarray-class.md), which specifies a fixed number of connections.  
  
## Remarks  
 `IPropertyNotifySinkCP` inherits all methods through its base class, [IConnectionPointImpl](../vs140/iconnectionpointimpl-class.md).  
  
 The [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638) interface allows a sink object to receive notifications about property changes. Class `IPropertyNotifySinkCP` exposes this interface as an outgoing interface on a connectable object. The client must implement the `IPropertyNotifySink` methods on the sink.  
  
 Derive your class from `IPropertyNotifySinkCP` when you want to create a connection point that represents the `IPropertyNotifySink` interface.  
  
 For more information about using connection points in ATL, see the article [Connection Points](../vs140/atl-connection-points.md).  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IConnectionPointImpl Class](../vs140/iconnectionpointimpl-class.md)   
 [IConnectionPointContainerImpl Class](../vs140/iconnectionpointcontainerimpl-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)