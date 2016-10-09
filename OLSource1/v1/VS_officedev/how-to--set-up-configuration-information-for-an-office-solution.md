---
title: "How to: Set Up Configuration Information for an Office Solution"
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
  - "solutions [Office development in Visual Studio], configuration files"
  - "configuration files [Office development in Visual Studio]"
ms.assetid: f123838f-957a-4cf5-acc0-0cc0f4c2aea2
caps.latest.revision: 33
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
# How to: Set Up Configuration Information for an Office Solution
  You can use configuration files to configure settings that are specific to your Office solutions. You can specify settings such as assembly binding policy, remoting objects, debug, and trace settings.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
### To add a configuration file to your Office project  
  
1.  On the **Project** menu, click **Add New Item**.  
  
2.  In the **Categories** pane, click **General**.  
  
3.  In the **Templates** pane, select **Application Configuration File**.  
  
4.  In the **Name** box, type the same name as the assembly plus the extension .config. For example, a configuration file for an Excel project assembly called ExcelWorkbook1.dll would be named ExcelWorkbook1.dll.config.  
  
5.  Click **Add**.  
  
6.  Create your configuration file according to the application configuration file schema. For more information, see [Configuration File Schema for the .NET Framework](../Topic/Configuration%20File%20Schema%20for%20the%20.NET%20Framework.md).  
  
 There are no special considerations for using configuration files with Office projects.  
  
## See Also  
 [Configuration File Schema for the .NET Framework](../Topic/Configuration%20File%20Schema%20for%20the%20.NET%20Framework.md)   
 [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md)   
 [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md)  
  
  