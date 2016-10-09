---
title: "How to: Create a SharePoint Solution Package by Using MSBuild Tasks"
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
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, packages"
ms.assetid: c3880bdd-f0a1-4d53-9a97-5767cb3f7b8e
caps.latest.revision: 17
ms.author: "kempb"
manager: "douge"
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
# How to: Create a SharePoint Solution Package by Using MSBuild Tasks
  You can build, clean, and validate a SharePoint package (.wsp) using command-line MSBuild tasks on a development computer. You can also use these commands to automate the build process by using Team Foundation Server on a build computer.  
  
## Building a SharePoint Package  
  
#### To build a SharePoint package  
  
1.  On the Windows **Start** menu, choose **All Programs**, **Accessories**, **Command Prompt**.  
  
2.  Change to the directory where your SharePoint project is located.  
  
3.  Enter the following command to create a package for the project. Replace *ProjectFileName* with the name of the project.  
  
    ```  
    msbuild /t:Package ProjectFileName  
    ```  
  
     For example, you could run one of the following commands to package a SharePoint project called ListDefinition1.  
  
    ```  
    msbuild /t:Package ListDefinition1.vbproj  
    msbuild /t:Package ListDefinition1.csproj  
    ```  
  
## Cleaning a SharePoint Package  
  
#### To clean a SharePoint package  
  
1.  Open a command prompt window.  
  
2.  Change to the directory where your SharePoint project is located.  
  
3.  Enter the following command to clean a package for the project. Replace *ProjectFileName* with the name of the project.  
  
    ```  
    msbuild /t:CleanPackage ProjectFileName  
    ```  
  
     For example, you could run one of the following commands to clean a SharePoint project called ListDefinition1.  
  
    ```  
    msbuild /t:CleanPackage ListDefinition1.vbproj  
    msbuild /t:CleanPackage ListDefinition1.csproj  
    ```  
  
## Validating a SharePoint Package  
  
#### To validate a SharePoint package  
  
1.  Open a command prompt window.  
  
2.  Change to the directory where your SharePoint project is located.  
  
3.  Enter the following command to validate a package for the project. Replace *ProjectFileName* with the name of the project.  
  
    ```  
    msbuild /t:ValidatePackage ProjectFileName  
    ```  
  
     For example, you could run one of the following commands to validate a SharePoint project called ListDefinition1.  
  
    ```  
    msbuild /t:ValidatePackage ListDefinition1.vbproj  
    msbuild /t:ValidatePackage ListDefinition1.csproj  
    ```  
  
## Setting Properties in a SharePoint Package  
  
#### To set a property in a SharePoint package  
  
1.  Open a command prompt window.  
  
2.  Change to the directory where your SharePoint project is located.  
  
3.  Enter the following command to set a property in a package for the project. Replace *PropertyName* with the property that you want to set.  
  
    ```  
    msbuild /property:PropertyName=Value  
    ```  
  
     For example, you could run the following command to set the warning level.  
  
    ```  
    msbuild /property:WarningLevel = 2  
    ```  
  
## See Also  
 [Creating SharePoint Features](../VS_officedev/creating-sharepoint-features.md)   
 [How to: Customize a SharePoint Feature](../VS_officedev/how-to--customize-a-sharepoint-feature.md)   
 [How to: Add and Remove Items to SharePoint Features](../VS_officedev/how-to--add-and-remove-items-to-sharepoint-features.md)  
  
  