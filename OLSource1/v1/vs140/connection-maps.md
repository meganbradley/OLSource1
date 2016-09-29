---
title: "Connection Maps"
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
  - "vc.mfc.macros.maps"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "connection maps"
ms.assetid: 1f25a9bc-6d09-4614-99cf-dc38e8ddfa73
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Connection Maps
OLE controls are able to expose interfaces to other applications. These interfaces only allow access from a container into that control. If an OLE control wants to access external interfaces of other OLE objects, a connection point must be established. This connection point allows a control outgoing access to external dispatch maps, such as event maps or notification functions.  
  
 The Microsoft Foundation Class Library offers a programming model that supports connection points. In this model, "connection maps" are used to designate interfaces or connection points for the OLE control. Connection maps contain one macro for each connection point. For more information on connection maps, see the [CConnectionPoint](../vs140/cconnectionpoint-class.md) class.  
  
 Typically, a control will support just two connection points: one for events and one for property notifications. These are implemented by the `COleControl` base class and require no additional work by the control writer. Any additional connection points you want to implement in your class must be added manually. To support connection maps and points, MFC provides the following macros:  
  
### Connection Map Declaration and Demarcation  
  
|||  
|-|-|  
|[BEGIN_CONNECTION_PART](../vs140/begin_connection_part.md)|Declares an embedded class that implements an additional connection point (must be used in the class declaration).|  
|[END_CONNECTION_PART](../vs140/end_connection_part.md)|Ends the declaration of a connection point (must be used in the class declaration).|  
|[CONNECTION_IID](../vs140/connection_iid.md)|Specifies the interface ID of the control's connection point.|  
|[DECLARE_CONNECTION_MAP](../vs140/declare_connection_map.md)|Declares that a connection map will be used in a class (must be used in the class declaration).|  
|[BEGIN_CONNECTION_MAP](../vs140/begin_connection_map.md)|Begins the definition of a connection map (must be used in the class implementation).|  
|[END_CONNECTION_MAP](../vs140/end_connection_map.md)|Ends the definition of a connection map (must be used in the class implementation).|  
|[CONNECTION_PART](../vs140/connection_part.md)|Specifies a connection point in the control's connection map.|  
  
 The following functions assist a sink in establishing and disconnecting a connection using connection points:  
  
### Initialization/Termination of Connection Points  
  
|||  
|-|-|  
|[AfxConnectionAdvise](../vs140/afxconnectionadvise.md)|Establishes a connection between a source and a sink.|  
|[AfxConnectionUnadvise](../vs140/afxconnectionunadvise.md)|Breaks a connection between a source and a sink.|  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)