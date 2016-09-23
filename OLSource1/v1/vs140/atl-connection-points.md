---
title: "ATL Connection Points"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - connections, connection points
  - ATL, connection points
  - connection points [C++], about connection points
ms.assetid: 17d76165-5f83-4f95-b36d-483821c247a1
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ATL Connection Points
A connectable object is one that supports outgoing interfaces. An outgoing interface allows the object to communicate with a client. For each outgoing interface, the connectable object exposes a connection point. Each outgoing interface is implemented by a client on an object called a sink.  
  
 ![Connection points](../vs140/media/vc2zw31.gif "vc2ZW31")  
  
 Each connection point supports the [IConnectionPoint](http://msdn.microsoft.com/library/windows/desktop/ms694318) interface. The connectable object exposes its connection points to the client through the [IConnectionPointContainer](http://msdn.microsoft.com/library/windows/desktop/ms683857) interface.  
  
## In This Section  
 [ATL Connection Point Classes](../vs140/atl-connection-point-classes.md)  
 Briefly describes the ATL classes that support connection points.  
  
 [Adding Connection Points to an Object](../vs140/adding-connection-points-to-an-object.md)  
 Outlines the steps used to add connection points to an object.  
  
 [ATL Connection Point Example](../vs140/atl-connection-point-example.md)  
 Provides an example of declaring a connection point.  
  
## Related Sections  
 [ATL](../vs140/active-template-library--atl--concepts.md)  
 Provides links to conceptual topics on how to program using the Active Template Library.  
  
## See Also  
 [ATL](../vs140/active-template-library--atl--concepts.md)