---
title: "Application and Deployment Manifests in Office Solutions"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "manifests [Office development in Visual Studio]"
  - "deployment manifests [Office development in Visual Studio]"
  - "application manifests [Office development in Visual Studio]"
  - "assemblies [Office development in Visual Studio], updating"
ms.assetid: 4e9abc7c-ef9f-4cb2-a7a9-c95c5f4a1fb7
caps.latest.revision: 45
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Application and Deployment Manifests in Office Solutions
  An application manifest is an XML file that provides information that is used by an Office solution to locate and update its assemblies. An application manifest can be used with a deployment manifest, which is an XML file stored on the server that provides the information needed to locate the most current version of the application manifest and assemblies.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
## Manifest Structure for Office Solutions  
 For Microsoft Office solutions created by using the Office development tools in Visual Studio, all manifests are based on the standard ClickOnce schema. When you deploy your Office solutions, the application manifests for both document-level and VSTO Add-in projects are located in the ClickOnce cache. The deployment manifests are not copied to the client computer.  
  
 For information about the contents of application and deployment manifests for Office projects, see [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md) and [Deployment Manifests for Office Solutions](../VS_officedev/deployment-manifests-for-office-solutions.md).  
  
## Creating Application and Deployment Manifests  
 Application manifests are created automatically as part of the build process. Every time you build a document-level project, the location of the deployment manifest is embedded in the document as a custom document property. For VSTO Add-ins, the location of the deployment manifest is stored in the registry.  
  
 For more information about the **Publish Wizard**, see [Deploying an Office Solution by Using ClickOnce](../VS_officedev/deploying-an-office-solution-by-using-clickonce.md).  
  
 For more information about how manifests work with Office solutions, see [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md).  
  
## See Also  
 [Architecture of Document-Level Customizations](../VS_officedev/architecture-of-document-level-customizations.md)   
 [Architecture of VSTO Add-ins](../VS_officedev/architecture-of-vsto-add-ins.md)   
 [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md)   
 [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../VS_officedev/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](../Topic/ClickOnce%20Application%20Manifest.md)   
 [ClickOnce Deployment Manifest](../Topic/ClickOnce%20Deployment%20Manifest.md)  
  
  