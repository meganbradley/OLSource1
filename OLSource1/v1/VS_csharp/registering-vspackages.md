---
title: "Registering VSPackages"
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
  - "managed VSPackages, registering"
  - "registration, managed VSPackages"
ms.assetid: 79b9424e-7e9b-4fc8-9b9f-00212674573c
caps.latest.revision: 24
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Registering VSPackages
[!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] relies on .pkgdef files to describe and locate a VSPackage. A .pkgdef file contains all the registration information that would otherwise be added to the system registry. Managed VSPackages are registered by adding attributes to the source code and then running the [createpkgdef utility](../VS_csharp/createpkgdef-utility.md) on the resulting assembly to generate a .pkgdef file.  
  
## In This Section  
 [Managed VSPackage File Location Keys](../VS_csharp/specifying-vspackage-file-location-to-the-vs-shell.md)  
 Describes the loading path for VSPackages.  
  
 [How to: Register a VSPackage (C#)](../VS_csharp/registering-and-unregistering-vspackages.md)  
 Explains how to register a VSPackage.  
  
 [Using a Custom Registration Attribute to Register an Extension](../Topic/Using%20a%20Custom%20Registration%20Attribute%20to%20Register%20an%20Extension.md)  
 Describes how to create a registration manifest that can be used to deploy a managed VSPackage.