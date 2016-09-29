---
title: "Creating a Source Control VSPackage"
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
  - "source control [Visual Studio SDK], creating source control packages"
  - "source control packages"
ms.assetid: cca0a9ed-48ff-409f-8036-ed8db0f7533e
caps.latest.revision: 27
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Creating a Source Control VSPackage
This documentation includes links to the architecture overview of a source-control package integrated with [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)], the API that is defined by the interfaces to be implemented and the services to be consumed, and a sample that illustrates a simple source control package implementation.  
  
 With a source control VSPackage, you can create a deep integration path for source control to integrate with [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)]. It enables the package to bypass the default source control UI hosted by [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)], respond to source control requests from the project system, and interact with [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] components such as **Solution Explorer**. The [!INCLUDE[vsipsdk](../VS_csharp/includes/vsipsdk_md.md)] empowers [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] partners with a mechanism to create a VSPackage that can integrate with [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] using a service model.  
  
## In This Section  
 [Getting Started](../VS_csharp/getting-started-with-source-control-vspackages.md)  
 Discusses the source control package, which is a more advanced alternative to the source control plug-in for implementing source control features in [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)].  
  
 [Source Control Package Architecture Overview](../VS_csharp/source-control-vspackage-architecture.md)  
 Presents a diagram and explains the components of a source control package.  
  
 [Source Control Package Features](../VS_csharp/source-control-vspackage-features.md)  
 Describes the various features of a source control package.  
  
 [Design Elements](../VS_csharp/source-control-vspackage-design-elements.md)  
 Describes the structure of the VSPackage that a source control package must implement for deep integration.  
  
## Related Sections  
 [Creating a Source Control Plug-in](../VS_csharp/creating-a-source-control-plug-in.md)  
 Discusses how to create a source control plug-in that supplies source control functionality in the [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] source control user interface (UI).  
  
 [Source Control (Visual Studio SDK)](../VS_csharp/source-control.md)  
 Discusses the options for implementing source control as an integrated feature of [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)].