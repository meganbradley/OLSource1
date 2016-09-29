---
title: "Introduction to COM"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "index-page "
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM"
ms.assetid: 120735d9-db71-4ad3-a730-ce576ea2354e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Introduction to COM
COM is the fundamental "object model" on which ActiveX Controls and OLE are built. COM allows an object to expose its functionality to other components and to host applications. It defines both how the object exposes itself and how this exposure works across processes and across networks. COM also defines the object's life cycle.  
  
 Fundamental to COM are these concepts:  
  
-   [Interfaces](../vs140/interfaces--atl-.md) — the mechanism through which an object exposes its functionality.  
  
-   [IUnknown](../vs140/iunknown.md) — the basic interface on which all others are based. It implements the reference counting and interface querying mechanisms running through COM.  
  
-   [Reference counting](../vs140/reference-counting.md) — the technique by which an object (or, strictly, an interface) decides when it is no longer being used and is therefore free to remove itself.  
  
-   [QueryInterface](../vs140/queryinterface.md) — the method used to query an object for a given interface.  
  
-   [Marshaling](../vs140/marshaling.md) — the mechanism that enables objects to be used across thread, process, and network boundaries, allowing for location independence.  
  
-   [Aggregation](../vs140/aggregation.md) — a way in which one object can make use of another.  
  
## See Also  
 [Introduction to COM and ATL](../vs140/introduction-to-com-and-atl.md)   
 [The Component Object Model](http://msdn.microsoft.com/library/windows/desktop/ms694363)