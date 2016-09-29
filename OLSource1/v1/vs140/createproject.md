---
title: "CreateProject"
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
  - "CreateProject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateProject method"
ms.assetid: b5598b46-fe29-4ad0-8bfe-a4dc789aeebd
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CreateProject
Creates a C++ project.  
  
## Syntax  
  
```  
  
      function CreateProject(   
   strProjectName,   
   strProjectPath    
);  
```  
  
#### Parameters  
 `strProjectName`  
 A string containing the project name.  
  
 *strProjectPath*  
 A string containing the project path.  
  
## Return Value  
 The project object.  
  
## Remarks  
 Call this function to create a C++ project that you can open in Visual Studio. If the wizard's context parameter **WizardType** is specified as **vsWizardAddSubProject**, the project is added as a subproject to the existing project. See [ContextParams Enum](assetId:///051a10f4-9e45-4604-b344-123044f33a24) for more information.  
  
## Example  
 See [AddFilesToProject](../vs140/addfilestoproject.md).  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)