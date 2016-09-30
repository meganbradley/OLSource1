---
title: "Registering and Unregistering VSPackages"
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
  - "registration, VSPackages"
  - "VSPackages, registering"
ms.assetid: e25e7a46-6a55-4726-8def-ca316f553d6b
caps.latest.revision: 39
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Registering and Unregistering VSPackages
You use attributes to register a VSPackage, but  
  
## Registering a VSPackage  
 You can use attributes to control the registration of managed VSPackages. All registration information is contained in a .pkgdef file. For more information on file-based registration, see [CreatePkgDef Utility](../vs140/createpkgdef-utility.md).  
  
 The following code shows how to use the standard registration attributes to register your VSPackage.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Unregistering an Extension  
 If you have been experimenting with a lot of different VSPackages and want to remove them from the experimental instance, you can just run the **Reset** command. Look for **Reset the Visual Studio Experimental Instance** on the start page of your computer, or run this command from the command line:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If you want to uninstall an extension that you have installed on your development instance of Visual Studio, go to **Tools / Extensions and Updates**, find the extension, and click **Uninstall**.  
  
 If for some reason neither of these methods succeeds at uninstalling the extension, you can unregister the VSPackage assembly from the command line as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [VSPackages](../vs140/vspackages.md)