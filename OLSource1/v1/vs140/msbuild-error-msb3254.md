---
title: "MSBuild Error MSB3254"
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
  - "MSB3254"
ms.assetid: cb9636b2-d9b3-466d-959c-14c7c8017a78
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3254
**MSB3254: The file \<name> will be ignored because it cannot be read. This file was either passed in to InstalledAssemblySubsetTables or was found by searching the \<name> folder in the TargetFrameworkDirectories.**  
  
 This error occurs when the [!INCLUDE[net_client_v35_long](../vs140/includes/net_client_v35_long_md.md)] XML file, client.xml, cannot be read. The file is unreadable because of corruption, locking, or some other problem.  
  
 The [!INCLUDE[net_client_v35_long](../vs140/includes/net_client_v35_long_md.md)] is a subset of the full [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] 3.5 run-time library. For more information about the [!INCLUDE[net_client_v35_long](../vs140/includes/net_client_v35_long_md.md)], see [.NET Framework Client Overview](assetId:///f0219919-1f02-4588-8704-327a62fd91f1).  
  
 Procedures  
  
### To correct this error  
  
-   Ensure that you have full permissions and full access to the file, or reinstall the [!INCLUDE[net_client_v35_long](../vs140/includes/net_client_v35_long_md.md)] redistributable run-time library to replace the corrupted file.  
  
## See Also  
 [Project Element (MSBuild)](../vs140/project-element--msbuild-.md)   
 [Resources for Troubleshooting MSBuild Errors](../vs140/additional-msbuild-resources.md)