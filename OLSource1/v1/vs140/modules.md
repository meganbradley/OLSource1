---
title: "Modules"
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
  - "modules"
  - "debugging [Debugging SDK], modules"
ms.assetid: c4cf2809-dbdb-4e75-9273-b3d3d77b67d0
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Modules
In terms of the debugger architecture, a **module**:  
  
-   Is a physical container of code, such as an executable file or a DLL.  
  
-   Can reload its symbols and describe itself. Module descriptions are displayed in the Modules window of the IDE.  
  
-   Is represented by an [IDebugModule2](../vs140/idebugmodule2.md) interface, created by a debug engine to describe the module.  
  
## See Also  
 [Debugger Concepts](../vs140/debugger-concepts.md)   
 [IDebugModule2](../vs140/idebugmodule2.md)