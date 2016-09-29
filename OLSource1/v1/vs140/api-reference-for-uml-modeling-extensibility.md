---
title: "API Reference for UML Modeling Extensibility"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "UML - extending"
  - "UML API"
  - "UML model, API"
ms.assetid: 2b2ffe93-c358-4d28-a5e5-3d0474629b58
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# API Reference for UML Modeling Extensibility
You can write program code to read and modify the models that you create with Visual Studio. The API reference provides information about the specific classes to help you with this. For more task-oriented information, see the topics under [Extending Models and Diagrams](../vs140/extend-uml-models-and-diagrams.md). To see which versions of Visual Studio support UML models, see [Version support for architecture and modeling tools](../vs140/what-s-new-for-design-in-visual-studio.md#VersionSupport).  
  
## Assemblies  
  
|Assembly|What this allows you to do|  
|--------------|--------------------------------|  
|Microsoft.VisualStudio.Uml.Interfaces.dll|-   Read and change model elements such as IUseCase, IAssociation, and so on.<br />-   Navigate relationships between elements.<br /><br /> The namespaces and types correspond to those that are defined in the UML Specification.|  
|Microsoft.VisualStudio.ArchitectureTools.Extensibility.dll|-   Create new instances of model elements<br />-   Access and modify shapes and diagrams.|  
  
## See Also  
 [Extending Models and Diagrams](../vs140/extend-uml-models-and-diagrams.md)   
 [Visual Studio Modeling SDK API](../vs140/api-reference-for-modeling-sdk-for-visual-studio.md)