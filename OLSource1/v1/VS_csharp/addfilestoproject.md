---
title: "AddFilesToProject"
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
  - "AddFilesToProject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddFilesToProject method"
ms.assetid: 3ff11406-bb4a-4eb7-a8df-c655b964ff76
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AddFilesToProject
Adds to the project all the files listed in Templates.inf.  
  
## Syntax  
  
```  
  
      function AddFilesToProject(   
   oProj,   
   strProjectName,   
   InfFile    
);  
```  
  
#### Parameters  
 `oProj`  
 The selected project.  
  
 `strProjectName`  
 The name of the project.  
  
 *InfFile*  
 The Templates.inf file object. This file contains a list of file names that the wizard creates on completion.  
  
## Remarks  
 Call this function to add to the project all of the files listed in Templates.inf. Using this function, you can add template files, resource files, or help files.  
  
## Example  
  
```  
// Assign the project path and project name.  
var strProjectPath = wizard.FindSymbol("PROJECT_PATH");  
var strProjectName = wizard.FindSymbol("PROJECT_NAME");  
  
// Create the Visual C++ project and call it "MyProj"  
selProj = CreateProject(strProjectName, strProjectPath);  
selProj.Object.Keyword = "MyProj";  
  
// Add common and specific configurations to the project.  
AddCommonConfig(selProj, strProjectName);  
AddSpecificConfig(selProj, strProjectName);  
  
// Set the project filters  
SetFilters(selProj);  
  
// Create the project's Templates.inf file   
var InfFile = CreateInfFile();  
  
// Add the files in Templates.inf to the project.  
AddFilesToProject(selProj, strProjectName, InfFile);  
```  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../VS_csharp/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../VS_csharp/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../VS_csharp/creating-a-custom-wizard.md)   
 [Designing a Wizard](../VS_csharp/designing-a-wizard.md)   
 [CreateInfFile](../VS_csharp/createinffile.md)   
 [SetCommonPchSettings](../VS_csharp/setcommonpchsettings.md)