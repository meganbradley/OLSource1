---
title: "RenderAddTemplate"
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
  - "RenderAddTemplate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RenderAddTemplate method"
ms.assetid: 84c898d6-8676-4ae1-9245-c023e1c9ab92
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RenderAddTemplate
Renders a template file and optionally adds it to the project.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *strTemplateFile*  
 The template file name only, excluding path, relative to TEMPLATES_PATH.  
  
 *strProjectFile*  
 The name of new file created. This string may include the path, but relative to PROJECT_PATH.  
  
 *ProjToAddTo*  
 The project object. Provide the project name if the created file must be added to the project; otherwise, disregard or pass **false** if you are not adding the file to the project.  
  
 *bOpen*  
 If **true**, open the file in the default editor after adding it to the project.  
  
## Remarks  
 Call this function to render a template file and optionally adds it to the project.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)