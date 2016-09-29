---
title: "MSBuild Error MSB3255"
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
  - "MSB3255"
ms.assetid: baac844e-a662-4421-bed1-2bc98f2e1cdf
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3255
**MSB3255: Could not find any Target Framework Subset files in the Target Framework Directories or at the locations specified in the InstalledAssemblySubsetTables.**  
  
 This error occurs when a name is passed into the <xref:Microsoft.Build.Tasks.ResolveAssemblyReference.FullTargetFrameworkSubsetNames*> property, but a subset with that name cannot be found.  
  
 The [!INCLUDE[net_client_v35_long](../vs140/includes/net_client_v35_long_md.md)] is a subset of the full [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] 3.5 run-time library. For more information about the [!INCLUDE[net_client_v35_long](../vs140/includes/net_client_v35_long_md.md)], see [.NET Framework Client Overview](assetId:///f0219919-1f02-4588-8704-327a62fd91f1).  
  
 Procedures  
  
### To correct this error  
  
-   Put a copy of the subset file in the target framework folder or in one of the locations specified in <xref:Microsoft.Build.Tasks.ResolveAssemblyReference.InstalledAssemblySubsetTables*>.  
  
## See Also  
 [Project Element (MSBuild)](../vs140/project-element--msbuild-.md)   
 [Resources for Troubleshooting MSBuild Errors](../vs140/additional-msbuild-resources.md)