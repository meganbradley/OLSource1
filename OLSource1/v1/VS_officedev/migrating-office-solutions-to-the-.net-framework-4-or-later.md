---
title: "Migrating Office Solutions to the .NET Framework 4 or later"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VST.Project.TargetFrameworkWarning"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Office projects [Office development in Visual Studio], migrating to .NET Framework 4"
ms.assetid: 31f6c48b-c086-4362-8629-f644d6083a44
caps.latest.revision: 55
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
# Migrating Office Solutions to the .NET Framework 4 or later
  If the target framework of an Office project is changed to the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or later from an earlier version of the .NET Framework, some additional steps might be required to continue to run the solution on development and end user computers. For more information, see [Required Changes to Run Office Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/e2cd35cc-7731-428e-9046-34fc57a02c48.md).  
  
 In addition, the project might no longer compile. Some features of Office projects have different programming models for different versions of the .NET Framework. When the target framework of an Office project is changed to the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or later from an earlier version of the .NET Framework, you must make the following code changes to the project:  
  
-   [Updating Excel and Word Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/updating-excel-and-word-projects-that-you-migrate-to-the-.net-framework-4-or-the-.net-framework-4.5.md)  
  
-   [Updating Ribbon Customizations in Office Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/3b7c8ad4-a616-4b42-9d62-9658fdefe6a3.md)  
  
-   [Updating Form Regions in Outlook Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/65991e2f-4875-49f0-b21b-6a3d0175d0f4.md)  
  
 The target framework of an Office project changes when you upgrade that project from an earlier version of Visual Studio. For more information, see [Upgrading and Migrating Office Solutions](../VS_officedev/upgrading-and-migrating-office-solutions.md).  
  
 For more information about why some features in Office projects have a different programming model when you target the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or later, see [Changes to the Design of Office Projects that Target the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/changes-to-the-design-of-office-projects-that-target-the-.net-framework-4-or-the-.net-framework-4.5.md) and [Visual Studio Tools for Office Runtime Overview](../VS_officedev/visual-studio-tools-for-office-runtime-overview.md).  
  
## See Also  
 [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md)   
 [How to: Target a Version of the .NET Framework](../Topic/How%20to:%20Target%20a%20Version%20of%20the%20.NET%20Framework.md)   
 [Troubleshooting Errors in Office Solutions](../VS_officedev/troubleshooting-errors-in-office-solutions.md)   
 [Additional Support for Errors in Office Solutions](../VS_officedev/additional-support-for-errors-in-office-solutions.md)  
  
  