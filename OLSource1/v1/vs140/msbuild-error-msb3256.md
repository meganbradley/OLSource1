---
title: "MSBuild Error MSB3256"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "MSB3256"
ms.assetid: 809ccd0a-78cd-4bf5-83a8-2fb51815ea27
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3256
**MSB3256: No assemblies were read in from the redist lists. A TargetFramework subset exclusion list could not be generated.**  
  
 A list of redistributable items (redist list) could not be found.  
  
 To generate a list of assemblies to exclude from the .NET Framework subset, two files are required: a "redist list" named FrameworkList.xml, which contains the names of redistributable items in the .NET Framework, and a "subset list" named client.xml, which contains the names of items in the .NET Framework. Because the subset definition requires both lists, if the redist list is missing, then the .NET Framework subset cannot be targeted.  
  
 The [!INCLUDE[net_client_v35_long](../vs140/includes/net_client_v35_long_md.md)] is a subset of the full [!INCLUDE[net_v35_short](../vs140/includes/net_v35_short_md.md)] run-time library. For more information about the [!INCLUDE[net_client_v35_long](../vs140/includes/net_client_v35_long_md.md)], see [.NET Framework Client Overview](assetId:///f0219919-1f02-4588-8704-327a62fd91f1).  
  
### To correct this error  
  
-   Either provide a valid redist list named FrameworkList.xml, or target the full [!INCLUDE[net_v35_short](../vs140/includes/net_v35_short_md.md)] redistributable library. For information about how to target the full [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], see [How To: Target a Specific .NET Framework](../vs140/how-to--target-a-version-of-the-.net-framework.md).  
  
## See Also  
 [MSBuild Target Framework and Target Platform](../vs140/msbuild-target-framework-and-target-platform.md)   
 [Project Element (MSBuild)](../vs140/project-element--msbuild-.md)   
 [Resources for Troubleshooting MSBuild Errors](../vs140/additional-msbuild-resources.md)