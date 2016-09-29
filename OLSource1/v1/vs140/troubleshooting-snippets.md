---
title: "Troubleshooting Snippets"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IntelliSense Code Snippets, troubleshooting"
  - "troubleshooting IntelliSense Code Snippets"
  - "troubleshooting Visual Basic, IntelliSense Code Snippets"
ms.assetid: 7b6dd40e-2f78-4b50-8e68-41fac1bcb81e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Snippets
Problems with IntelliSense code snippets are typically caused by two problems: a corrupt snippet file or bad content in the snippet file.  
  
## Common Problems  
  
### The Snippet Cannot Be Dragged from File Explorer to a Visual Studio Source File  
  
-   The XML in the snippet file may be corrupt. The **XML Editor** in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] can locate problems in the XML structure.  
  
-   The snippet file may not conform to the snippet schema. The **XML Editor** in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] can locate problems in the XML structure.  
  
### The Code Has Compiler Errors That Are Not Highlighted  
  
-   You may be missing a project reference. Examine the documentation about the snippet. If the reference is not found on the computer, you will need to install it. Inserting a snippet should add to the project any references needed. If the snippet is missing the reference information, that can be reported to the snippet creator as an error.  
  
-   A variable may be undefined. Undefined variables in a snippet should be highlighted. If not, that can be reported to the snippet creator as an error.  
  
## See Also  
 [Creating and Using Intellisense Code Snippets](../vs140/code-snippets.md)