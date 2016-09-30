---
title: "Templates.inf File"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "custom wizards, template files"
ms.assetid: 93d60d27-2402-4dc8-a829-e97417ccea49
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Templates.inf File
Templates.inf is a text file that contains a list of templates to render for the project.  
  
 Because Templates.inf is a [template file](../vs140/template-files.md) itself, you can use directives to indicate which files to include in a project, depending on a user's selections. See [Template Directives](../vs140/template-directives.md) for a list of directives that you can use in this file.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **CreateCustomInfFile** renders Templates.inf into a temporary text file, which must then be deleted after processing the files.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 See [The JScript File](../vs140/jscript-file.md) for more information.  
  
## See Also  
 [Files Created for Your Wizard](../vs140/files-created-for-your-wizard.md)   
 [Custom Wizard](../vs140/custom-wizard.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)