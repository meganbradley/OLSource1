---
title: "How to: Update Existing Templates"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - item templates, updating existing templates
  - Visual Studio templates, updating existing templates
  - project templates, updating existing templates
ms.assetid: d585e45b-7fe2-45fa-9cf3-7f2bc060f3c4
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Update Existing Templates
After you create a template and compress the files into a .zip file, you may want to modify the template. You can do this by manually changing the files in the template, or by exporting a new template from a project that is based on the template.  
  
## Using the Export Template Wizard to Update an Existing Template  
 [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] provides an **Export Template** wizard that can be used to update an existing template.  
  
#### To use Export Template to update an existing template  
  
1.  On the **File** menu, click **New** and then click **New Project**.  
  
2.  Select the template that you want to update, enter a name and location for your temporary project, and click **OK**.  
  
3.  Modify the project in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
4.  On the **File** menu, click **Export Template**, and use the **Export Template** wizard to create a new template.  
  
5.  After the updated template is compressed into a .zip file, delete the old template .zip file.  
  
## Manually Updating an Existing Template  
 You can update an existing template outside [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] by modifying the files in the compressed .zip file.  
  
#### To manually update an existing template  
  
1.  Locate the .zip file that contains the template. By default, this file is located in \My Documents\Visual Studio *Version*\My Exported Templates\\.  
  
2.  Extract the .zip file.  
  
3.  Modify or delete the current template files, or add new files to the template.  
  
4.  Open, modify, and save the .vstemplate XML file to handle updated behavior or new files. For more information about the .vstemplate schema, see [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md). For more information about what you can parameterize in the source files, see [Template Parameters](../vs140/template-parameters.md)  
  
5.  Select the files in your template, right-click, click **Send To**, and then click **Compressed (zipped) Folder**. The files that you selected are compressed into a .zip file.  
  
6.  Put the new .zip file in the same directory as the old .zip file.  
  
7.  Delete the extracted template files and the old template .zip file.  
  
8.  Start (as administrator) an instance of the Developer Command Prompt (on the start menu, under **Visual Studio 2010 / Visual Studio Tools/Developer Command Prompt**).  
  
9. Run the following command: `devenv /installvstemplates`.  
  
## See Also  
 [Customizing Project and Item Templates](../vs140/customizing-project-and-item-templates.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Template Parameters](../vs140/template-parameters.md)   
 [How to: Create a Basic Starter Kit](../vs140/how-to--create-starter-kits.md)