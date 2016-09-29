---
title: "Port Suppliers"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "port suppliers"
  - "debugging [Debugging SDK], port suppliers"
ms.assetid: a8f3db96-1a13-4e93-9ef6-0861880369e0
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Port Suppliers
In terms of the debugger architecture, a **port supplier**:  
  
-   Is contained by a server and provides ports on request to that server.  
  
-   Can add and remove ports from the containing server.  
  
-   Can enumerate all the ports it has supplied to the server.  
  
-   Is represented by an [IDebugPortSupplier2](../VS_csharp/idebugportsupplier2.md) interface, which is registered with Visual Studio through the registry. This interface can be obtained by calling [GetPortSupplier](../VS_csharp/idebugcoreserver2--getportsupplier.md).  
  
 [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] provides a default port supplier and a default port. If a custom port needs to be implemented, a custom port supplier also needs to be implemented to supply those custom ports.  
  
## See Also  
 [Servers](../VS_csharp/servers--visual-studio-sdk-.md)   
 [Ports](../VS_csharp/ports.md)   
 [Debugger Concepts](../VS_csharp/debugger-concepts.md)   
 [IDebugPortSupplier2](../VS_csharp/idebugportsupplier2.md)   
 [GetPortSupplier](../VS_csharp/idebugcoreserver2--getportsupplier.md)