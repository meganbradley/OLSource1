---
title: "How to: Substitute Parameters in a Template"
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
  - "template parameters, substituting"
  - "Visual Studio templates, using parameters"
ms.assetid: a62924a7-4ba0-413d-b606-fdbe1fcf2807
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Substitute Parameters in a Template
You may replace template parameters such as class names and namespaces when a file based on a template is created. For a complete list of template parameters, see [Parameter Substitution](../vs140/template-parameters.md).  
  
## Procedure  
 You may replace parameters in the files of a template whenever a project based on that template is created. This procedure explains how to create a template that replaces the name of a namespace with the safe project name when a new project is created with the template.  
  
#### To use a parameter to replace namespace name with the project name  
  
1.  Insert the parameter in one or more of the code files in the template. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  Template parameters are written in the format $*parameter*$.  
  
2.  In the .vstemplate file for the template, locate the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element that includes this file.  
  
3.  Set the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [Parameter Substitution](../vs140/template-parameters.md)   
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [ProjectItem Element (Visual Studio Template Content)](../vs140/projectitem-element--visual-studio-item-templates-.md)