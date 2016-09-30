---
title: "How to: Create Project Templates"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VS.ExportTemplateWizard"
helpviewer_keywords: 
  - "Visual Studio templates, creating project templates"
  - "project templates, metadata files"
  - "Visual Studio templates, project templates"
  - "project templates, custom template locations"
  - "project templates, creating"
ms.assetid: a1a6999d-a34c-48a8-b1cf-027eb5c76398
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create Project Templates
This procedure enables you to create a template using the **Export Template** wizard, which packages your template in a .zip file. You can also create templates in the VSIX file format for improved deployment by using the Export Template Wizard extension, or with templates included in the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)], or you can create templates manually.  
  
### To create a custom project template with the standard Export Template wizard  
  
1.  Create a project.  
  
    > [!NOTE]
    >  Use only valid identifier characters when naming a project that will be the source for a template. A template exported from a project named with invalid characters can cause compilation errors in future projects based on the template. For more information on valid identifier characters, see [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
2.  Edit the project until it is ready to be exported as a template.  
  
3.  As appropriate, edit the code files to indicate where parameter replacement should take place. For more information on parameter replacement, see [How to: Use Parameters in Templates](../vs140/how-to--substitute-parameters-in-a-template.md).  
  
4.  On the **File** menu, click **Export Template**. The **Export Template** wizard opens.  
  
5.  Click **Project Template**.  
  
6.  If you have more than one project in your current solution, select the projects you want to export to a template.  
  
7.  Click **Next**.  
  
8.  Select an icon and a preview image for your template. These will appear in the **New Project** dialog box.  
  
9. Enter a template name and description.  
  
10. Click **Finish**. Your project is exported into a .zip file and placed in the specified output location, and, if selected, imported into [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
     If you have the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] installed, you can wrap the finished template in a .vsix file for deployment by using the **VSIX Project** template. For more information, see [Creating Extensions with the VSIX Project Template](../vs140/getting-started-with-the-vsix-project-template.md).  
  
## See Also  
 [Introduction to Visual Studio Template](../vs140/creating-project-and-item-templates.md)   
 [How to: Create Item Templates](../vs140/how-to--create-item-templates.md)