---
title: "ATL Connection Point Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFirePropNotifyEvent class, connection point classes"
  - "connection points [C++], ATL classes"
  - "ATL, connection points"
  - "CComDynamicUnkArray class, connection point classes"
  - "CFirePropNotifyEvent class"
  - "CComUnkArray class, connection point classes"
ms.assetid: 9582ba71-7ace-4df4-9c9b-1b0636953efc
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL Connection Point Classes
ATL uses the following classes to support connection points:  
  
-   [IConnectionPointImpl](../VS_csharp/iconnectionpointimpl-class.md) implements a connection point. The IID of the outgoing interface it represents is passed as a template parameter.  
  
-   [IConnectionPointContainerImpl](../VS_csharp/iconnectionpointcontainerimpl-class.md) implements the connection point container and manages the list of `IConnectionPointImpl` objects.  
  
-   [IPropertyNotifySinkCP](../VS_csharp/ipropertynotifysinkcp-class.md) implements a connection point representing the [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638) interface.  
  
-   [CComDynamicUnkArray](../VS_csharp/ccomdynamicunkarray-class.md) manages an arbitrary number of connections between the connection point and its sinks.  
  
-   [CComUnkArray](../VS_csharp/ccomunkarray-class.md) manages a predefined number of connections as specified by the template parameter.  
  
-   [CFirePropNotifyEvent](../VS_csharp/cfirepropnotifyevent-class.md) notifies a client's sink that an object's property has changed or is about to change.  
  
-   [IDispEventImpl](../VS_csharp/idispeventimpl-class.md) provides support for connection points for an ATL COM object. These connection points are mapped with an event sink map, which is provided by your COM object.  
  
-   [IDispEventSimpleImpl](../VS_csharp/idispeventsimpleimpl-class.md) works in conjunction with the event sink map in your class to route events to the appropriate handler function.  
  
## See Also  
 [Connection Point](../VS_csharp/atl-connection-points.md)