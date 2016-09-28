---
title: "VSPackages and the Managed Package Framework"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "managed package framework"
  - "VSPackages, managed package framework"
  - "managed VSPackages, managed package framework"
ms.assetid: e8d80e0f-6b5b-4baf-a7df-59fd808c60cd
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# VSPackages and the Managed Package Framework
You can reduce development time by creating a VSPackage with the managed package framework (MPF) classes instead of by using COM interop classes.  
  
 There are two ways to create a managed VSPackage:  
  
-   Use the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Package project template  
  
     For more information, see [Walkthrough: Create a Menu Command with the Visual Studio Package Template](../Topic/Walkthrough:%20Creating%20a%20Menu%20Command%20By%20Using%20the%20Visual%20Studio%20Package%20Template_deleted.md).  
  
-   Build your VSPackage without the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Package project template  
  
     For example, you can copy a sample VSPackage and change the GUIDs and the names. You can find samples in the VSX section of [Code Gallery](http://code.msdn.microsoft.com/vsx/).  
  
## In This Section  
 [VSIP Managed Package Framework Classes](../vs140/managed-package-framework-classes.md)  
 Describes and lists the MPF class namespaces and DLL files.  
  
## Related Sections  
 [How to: Create VSPackages (C#)](../Topic/Walkthrough:%20Creating%20a%20Menu%20Command%20By%20Using%20the%20Visual%20Studio%20Package%20Template_deleted.md)  
 Explains how to create a managed VSPackage.  
  
 [Managed VSPackages](../vs140/managed-vspackages.md)  
 Introduces aspects of VSPackages that apply to managed code.