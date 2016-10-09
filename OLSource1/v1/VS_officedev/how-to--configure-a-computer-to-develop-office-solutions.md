---
title: "How to: Configure a Computer to Develop Office Solutions"
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
  - "prerequisites [Office development in Visual Studio]"
  - "Office development in Visual Studio, installing tools"
ms.assetid: 76b463dc-43f0-47a1-845b-fe0a5e14bd80
caps.latest.revision: 130
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
# How to: Configure a Computer to Develop Office Solutions
  To configure a development computer so that you can use the Microsoft Office developer tools in Visual Studio, follow the instructions in this topic. You must have administrative privileges on the development computer to perform these steps.  
  
### To configure the development computer  
  
1.  Install a version of Visual Studio that includes the Office developer tools. The Office developer tools are installed by default. If you customize the Visual Studio installation by selecting which features to install, make sure that **Microsoft Office Developer Tools** is selected during setup. For more information about the versions of Visual Studio that include the Office developer tools, see [Configuring a Computer to Develop Office Solutions](../VS_officedev/configuring-a-computer-to-develop-office-solutions.md).  
  
2.  Install a version of Office that is supported by the Office developer tools in Visual Studio. For more information, see [Configuring a Computer to Develop Office Solutions](../VS_officedev/configuring-a-computer-to-develop-office-solutions.md).  
  
     Make sure that you also install the PIAs for the version of Office that you install. The PIAs are installed with Office by default. If you modify Office setup, make sure that the **.NET Programmability Support** feature is selected for the applications you want to target.  
  
3.  If you have an English version of Visual Studio but use non-English settings for Windows, you can install the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] language pack to see [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] messages in the same language as Windows. Non-English versions of Visual Studio automatically install the language pack. The language pack is available from the [Microsoft Download Center](http://go.microsoft.com/fwlink/?LinkId=140386).  
  
## See Also  
 [What's New in Office Development](assetId:///bf054af2-c896-4723-aa15-6381145b14bb)   
 [Getting Started &#40;Office Development in Visual Studio&#41;](../VS_officedev/getting-started--office-development-in-visual-studio-.md)   
 [How to: Install the Visual Studio Tools for Office Runtime Redistributable](../VS_officedev/how-to--install-the-visual-studio-tools-for-office-runtime-redistributable.md)   
 [How to: Install Office Primary Interop Assemblies](../VS_officedev/how-to--install-office-primary-interop-assemblies.md)  
  
  