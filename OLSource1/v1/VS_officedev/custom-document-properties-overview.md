---
title: "Custom Document Properties Overview"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "documents [Office development in Visual Studio], custom properties"
  - "custom document properties"
  - "document-level customizations [Office development in Visual Studio], custom properties"
  - "Office documents [Office development in Visual Studio], custom properties"
  - "_AssemblyLocation property"
  - "_AssemblyName property"
ms.assetid: 9a215904-b760-4a49-93e8-a1a708ce0526
caps.latest.revision: 36
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Custom Document Properties Overview
  When you build a document-level project, Visual Studio adds two custom properties to the document in the project: _AssemblyLocation and _AssemblyName. When a user opens a document, the Microsoft Office application checks for these custom document properties. If they exist in the document, the application loads the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)], which starts the customization. For more information, see [Architecture of Office Solutions in Visual Studio](../VS_officedev/architecture-of-office-solutions-in-visual-studio.md).  
  
 [!INCLUDE[appliesto_alldoc](../VS_officedev/includes/appliesto_alldoc_md.md)]  
  
## _AssemblyName  
 This property contains the CLSID of an interface in the Office solution loader component of the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)]. The CLSID value is 4E3C66D5-58D4-491E-A7D4-64AF99AF6E8B. You should never change this value.  
  
## _AssemblyLocation  
 This property contains a string that provides details about the deployment manifest for the customization. For more information about manifests, see [Application and Deployment Manifests in Office Solutions](../VS_officedev/application-and-deployment-manifests-in-office-solutions.md).  
  
 The_AssemblyLocation property value can have different formats, depending on how the solution is deployed:  
  
-   If the solution is published to be installed from a Web site, UNC path, or a CD or USB drive, the _AssemblyLocation property has the format *DeploymentManifestPath*|*SolutionID*. The following string is an example:  
  
     file://deployserver/MyShare/ExcelWorkbook1.vsto|74744e4b-e4d6-41eb-84f7-ad20346fe2d9  
  
-   If you are running or debugging the solution from Visual Studio, the _AssemblyLocation property has the format *DeploymentManifestName*|*SolutionID*|vstolocal. The following string is an example:  
  
     ExcelWorkbook1.vsto|74744e4b-e4d6-41eb-84f7-ad20346fe2d9|vstolocal  
  
 The *SolutionID* is a GUID that the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] uses to identify the solution. The *SolutionID* is automatically generated when you build the project. The **vstolocal** term indicates to the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] that the assembly should be loaded from the same folder as the document.  
  
## See Also  
 [Architecture of Office Solutions in Visual Studio](../VS_officedev/architecture-of-office-solutions-in-visual-studio.md)   
 [Architecture of Document-Level Customizations](../VS_officedev/architecture-of-document-level-customizations.md)   
 [Application and Deployment Manifests in Office Solutions](../VS_officedev/application-and-deployment-manifests-in-office-solutions.md)   
 [How to: Publish an Office Solution by Using ClickOnce](assetId:///2b6c247e-bc04-4ce4-bb64-c4e79bb3d5b8)   
 [How to: Create and Modify Custom Document Properties](../VS_officedev/how-to--create-and-modify-custom-document-properties.md)  
  
  