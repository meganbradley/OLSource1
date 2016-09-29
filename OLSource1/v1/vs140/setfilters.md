---
title: "SetFilters"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "SetFilters"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFilters method"
ms.assetid: ae934e1b-8ead-4c1d-a0f8-e9c80d182340
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SetFilters
Adds source, include, and resource filters for the project folders.  
  
## Syntax  
  
```  
  
      function SetFilters(   
   oProj    
);  
```  
  
#### Parameters  
 `oProj`  
 The selected project.  
  
## Remarks  
 Call this function to add source, include, and resource filters for the project folders. This function finds the following symbols in the project:  
  
-   SOURCE_FILTER  
  
-   INCLUDE_FILTER  
  
-   RESOURCE_FILTER  
  
 These symbols contain the file extensions used in filtering.  
  
## Example  
  
```  
// Create and set the project name and path.  
selProj = CreateProject(strProjectName, strProjectPath);  
// Add the previously-identified configurations to the project.  
AddConfigurations(selProj, strProjectName);  
// Set filters for the project.  
SetFilters (selproj);  
// Indicate that the project is an ATL project.  
selProj.Object.keyword = "AtlProj";  
```  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)