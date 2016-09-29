---
title: "Command Routing in VSPackages"
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
  - "commands, routing"
  - "command routing, Visual Studio SDK"
ms.assetid: a9c7f9ae-3594-4557-a314-8cf76f5f8772
caps.latest.revision: 28
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Command Routing in VSPackages
A command is routed in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] based on the context in which it is executed. It is routed from the initial context outward to the global context.  
  
## In This Section  
 [Command Routing Algorithm](../vs140/command-routing-algorithm.md)  
 Describes the order of command routing resolution.  
  
 [How Command Context Affects Available Menu Items](../vs140/command-availability.md)  
 Discusses command routing.  
  
 [Commands and Menus Using Interop Assemblies](../vs140/commands-and-menus-that-use-interop-assemblies.md)  
 Discusses considerations in routing commands between managed code and COM.  
  
## Related Sections  
 [Selection Context Objects](../vs140/selection-context-objects.md)  
 Discusses the model for how you can determine the user's selection context focus on a window.  
  
 [Menus and Toolbars](../vs140/commands--menus--and-toolbars.md)  
 Explains how to create a UI that includes menus, toolbars, and command combo boxes.