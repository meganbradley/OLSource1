---
title: "Understanding Manifest Generation for C-C++ Programs"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Understanding Manifest Generation for C/C++ Programs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "manifests [C++]"
ms.assetid: a1f24221-5b09-4824-be48-92eae5644b53
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Understanding Manifest Generation for C-C++ Programs
A [manifest](http://msdn.microsoft.com/library/aa375365) is an XML document that can be an external XML file or a resource embedded inside an application or an assembly. The manifest of an [isolated application](http://msdn.microsoft.com/library/aa375190) is used to manage the names and versions of shared side-by-side assemblies to which the application should bind at run time. The manifest of a side-by-side assembly specifies its dependencies on names, versions, resources, and other assemblies.  
  
 There are two ways to create a manifest for an isolated application or a side-by-side assembly. First, the author of the assembly can manually create a manifest file following rules and naming requirements. Alternatively, if a program only depends on [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] assemblies such as CRT, MFC, ATL or others, then a manifest can be generated automatically by the linker.  
  
 The headers of [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] libraries contain assembly information, and when the libraries are included in application code, this assembly information is used by the linker to form a manifest for the final binary. The linker does not embed the manifest file inside the binary, and can only generate the manifest as an external file. Having a manifest as an external file may not work for all scenarios. For example, it is recommended that private assemblies have embedded manifests. In command line builds such as those that use nmake to build code, a manifest can be embedded using the manifest tool; for more information see [Manifest Generation at the Command Line](../vs140/manifest-generation-at-the-command-line.md). When building in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], a manifest can be embedded by setting a property for the manifest tool in the **Project Properties** dialog; see [Manifest Generation in Visual Studio](../vs140/manifest-generation-in-visual-studio.md).  
  
## See Also  
 [Concepts of Isolated Assemblies and Side-by-side Assemblies](../vs140/concepts-of-isolated-applications-and-side-by-side-assemblies.md)   
 [Building C/C++ Isolated Applications and Side-by-side Assemblies](../vs140/building-c-c---isolated-applications-and-side-by-side-assemblies.md)