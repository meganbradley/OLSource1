---
title: "Registering Single File Generators"
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
  - "registration, custom tools"
  - "custom tools, defining registry settings"
ms.assetid: db7592c0-1273-4843-9617-6e2ddabb6ca8
caps.latest.revision: 20
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Registering Single File Generators
To make a custom tool available in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], you must register it so [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] can instantiate it and associates it with a particular project type.  
  
### To register a custom tool  
  
1.  Register the custom tool DLL either in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] local registry or in the system registry, under HKEY_CLASSES_ROOT.  
  
     For example, here's the registration information for the managed MSDataSetGenerator custom tool, which comes with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Create a registry key in the desired [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] hive under Generators\\*GUID* where *GUID* is the GUID defined by the specific language's project system or service. The name of the key becomes the programmatic name of your custom tool. The custom tool key has the following values:  
  
    -   (Default)  
  
         Optional. Provides a user-friendly description of the custom tool. This parameter is optional, but recommended.  
  
    -   CLSID  
  
         Required. Specifies the identifier of the class library of the COM component that implements \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator*>.  
  
    -   GeneratesDesignTimeSource  
  
         Required. Indicates whether types from files produced by this custom tool are made available to visual designers. The value of this parameter needs to be (zero) 0 for types not available to visual designers or (one) 1 for types available to visual designers.  
  
    > [!NOTE]
    >  You must register the custom tool separately for each language for which you want the custom tool to be available.  
  
     For example, the MSDataSetGenerator registers itself once for each language:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator*>   
 [Implementing Custom Tools](../vs140/implementing-single-file-generators.md)   
 [Determining the Default Namespace of a Project](../vs140/determining-the-default-namespace-of-a-project.md)   
 [Exposing Types to Visual Designers](../vs140/exposing-types-to-visual-designers.md)   
 [Introduction to the BuildManager Object](assetId:///50080ec2-c1c9-412c-98ef-18d7f895e7fa)