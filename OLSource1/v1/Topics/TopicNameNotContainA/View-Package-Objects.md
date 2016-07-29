---
title: "View Package Objects"
ms.custom: 
  - SQL2016_New_Updated
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a85c0245-0a68-4eb0-83b1-9b11df80bd10
caps.latest.revision: 36
manager: jhubbard
---
# View Package Objects
In [!INCLUDE[ssIS](../../Topics/TopicNameContainA/includes/ssIS_md.md)] Designer, the **Package Explorer** tab provides an explorer view of the package. The view reflects the container hierarchy of the [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] architecture. The package container is at the top of the hierarchy, and you expand the package to view the connections, executables, event handlers, log providers, precedence constraints, and variables in the package.  
  
 The executables, which are the containers and tasks in the package, can include event handlers, precedence constraints, and variables. [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] supports a nested hierarchy of containers, and the For Loop, Foreach Loop, and Sequence containers can include other executables.  
  
 If a package includes a data flow, the **Package Explorer** lists the Data Flow task and includes a **Components** folder that lists the data flow components.  
  
 From the **Package Explorer** tab, you can delete objects in a package and access the **Properties** window to view object properties.  
  
 The following diagram shows a tree view of a simple package.  
  
 ![Screenshot of the Package Explorer tab](../../Topics/TopicNameNotContainA/media/PackageExplorer.gif "PackageExplorer")  
  
### To view package content  
  
-   [View Package Objects in Package Explorer](../../Topics/TopicNameNotContainA/View-Package-Objects-in-Package-Explorer.md)  
  
## See Also  
 [Integration Services Tasks](../../Topics/TopicNameNotContainA/Integration-Services-Tasks.md)   
 [Integration Services Containers](../../Topics/TopicNameNotContainA/Integration-Services-Containers.md)   
 [Precedence Constraints](../../Topics/TopicNameNotContainA/Precedence-Constraints.md)   
 [Integration Services (SSIS) Variables](../../Topics/TopicNameNotContainA/Integration-Services--SSIS--Variables.md)   
 [Integration Services (SSIS) Event Handlers](../../Topics/TopicNameNotContainA/Integration-Services--SSIS--Event-Handlers.md)   
 [Integration Services (SSIS) Logging](../../Topics/TopicNameNotContainA/Integration-Services--SSIS--Logging.md)