---
title: "MSBuild Error MSB3128"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - GenerateManifest.ManifestsSignedHashExcluded
helpviewer_keywords: 
  - MSB3128
ms.assetid: e8612a4b-4016-48d2-b5f0-a1091bfe8cb1
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MSBuild Error MSB3128
**MSB3128: The ClickOnce manifests cannot be signed because they contain one or more references that are not hashed.**  
  
 When you publish an application that has a signed manifest, all files must be included in the hash.  
  
### To correct this error  
  
1.  Go to the **Publish** page of the **Project Designer**.  
  
2.  Click **Application Files**.  
  
3.  Set the **Hash** value to **Include** for all files that are to be published.  
  
## See Also  
 [Publish Page, Project Designer](../vs140/publish-page--project-designer.md)