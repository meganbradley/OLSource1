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
[!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] relies on .pkgdef files to describe and locate a VSPackage. A .pkgdef file contains all the registration information that would otherwise be added to the system registry. Managed VSPackages are registered by adding attributes to the source code and then running the [createpkgdef utility](../vs140/createpkgdef-utility.md) on the resulting assembly to generate a .pkgdef file.  
  
## In This Section  
 [Managed VSPackage File Location Keys](../vs140/specifying-vspackage-file-location-to-the-vs-shell.md)  
 Describes the loading path for VSPackages.  
  
 [How to: Register a VSPackage (C#)](../vs140/registering-and-unregistering-vspackages.md)  
 Explains how to register a VSPackage.  
  
 [Using a Custom Registration Attribute to Register an Extension](../vs140/using-a-custom-registration-attribute-to-register-an-extension.md)  
 Describes how to create a registration manifest that can be used to deploy a managed VSPackage.