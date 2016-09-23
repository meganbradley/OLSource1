---
title: "Source Control VSPackage Design Elements"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - source control packages, design elements
ms.assetid: edd3f2ff-ca32-4465-8ace-4330493b67bb
caps.latest.revision: 19
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Source Control VSPackage Design Elements
The topics in this section outline the structure the source control VSPackage must implement for deep integration. It also lists the interfaces and services that the source control VSPackage can implement, and the interfaces and services the source control VSPackage can use from other [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] components to support its source control model and functionality.  
  
## In This Section  
 [VSPackage Structure](../vs140/vspackage-structure--source-control-vspackage-.md)  
 Defines the structure of the source control VSPackage.  
  
 [Source Control Package Related Services and Interfaces](../vs140/related-services-and-interfaces--source-control-vspackage-.md)  
 Lists source control package-related interfaces and services.  
  
 [Services Provided by a Source Control Package](../vs140/services-provided--source-control-vspackage-.md)  
 Describes the source control service provided by the source control VSPackage.  
  
## Related Sections  
 [Creating a Source-Control VSPackage](../vs140/creating-a-source-control-vspackage.md)  
 Discusses how to create a source control VSPackage that not only supplies source control functionality but can be used to customize the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] source control UI.