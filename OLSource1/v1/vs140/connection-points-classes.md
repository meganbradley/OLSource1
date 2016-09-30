---
title: "Connection Points Classes"
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
  - "vc.atl.connection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "classes [C++], connection points"
  - "connection points classes"
ms.assetid: 076365fa-299a-4dce-84c3-a5dff0e0da1f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Connection Points Classes
The following classes provide support for connection points:  
  
-   [IConnectionPointContainerImpl](../vs140/iconnectionpointcontainerimpl-class.md) Implements a connection point container.  
  
-   [IConnectionPointImpl](../vs140/iconnectionpointimpl-class.md) Implements a connection point.  
  
-   [IPropertyNotifySinkCP](../vs140/ipropertynotifysinkcp-class.md) Implements a connection point representing the [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638) interface.  
  
-   [CComDynamicUnkArray](../vs140/ccomdynamicunkarray-class.md) Manages unlimited connections between a connection point and its sinks.  
  
-   [CComUnkArray](../vs140/ccomunkarray-class.md) Manages a fixed number of connections between a connection point and its sinks.  
  
-   [CFirePropNotifyEvent](../vs140/cfirepropnotifyevent-class.md) Notifies a client's sink that an object's property has changed or is about to change.  
  
-   [IDispEventImpl](../vs140/idispeventimpl-class.md) Provides support for connection points for an ATL COM object. These connection points are mapped with an event sink map, which is provided by your COM object.  
  
-   [IDispEventSimpleImpl](../vs140/idispeventsimpleimpl-class.md) Works in conjunction with the event sink map in your class to route events to the appropriate handler function.  
  
## Related Articles  
 [Connection Points](../vs140/atl-connection-points.md)  
  
 [Event Handling and ATL](../vs140/event-handling-and-atl.md)  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [Connection Point Macros](../vs140/connection-point-macros.md)   
 [Connection Point Global Functions](../vs140/connection-point-global-functions.md)