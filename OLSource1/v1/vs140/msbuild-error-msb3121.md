---
title: "MSBuild Error MSB3121"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "GenerateManifest.FileAssociationMissingAttribute"
helpviewer_keywords: 
  - "MSB3121"
ms.assetid: c1e83a2a-515f-412d-b8b7-4821e510a923
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3121
**MSB3121: The file association element in the application manifest is missing one or more of the following required attributes: extension, description, progid, or default icon.**  
  
 The [\<fileAssociation> Element](../vs140/clickonce-deployment-manifest.md) must contain values for all four attributes.  
  
### To correct this error  
  
-   Set each [\<fileAssociation> Element](../vs140/clickonce-deployment-manifest.md) attribute to a valid value.  
  
## See Also  
 [Publish Page, Project Designer](../vs140/publish-page--project-designer.md)   
 [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md)