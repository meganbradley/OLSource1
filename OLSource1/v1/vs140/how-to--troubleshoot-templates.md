---
title: "How to: Troubleshoot Templates"
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
  - "Visual Studio templates, troubleshooting"
ms.assetid: 3e577ad2-f725-4c11-93b3-477f2404ec81
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Troubleshoot Templates
If a template fails to load in the development environment, there are several ways to locate the problem.  
  
## Validating the .vstemplate File  
 If the .vstemplate file in a template does not adhere to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] template schema, the template may not appear in the **New Project** dialog box.  
  
#### To validate the .vstemplate file  
  
1.  Locate the .zip file that contains the template.  
  
2.  Extract the .zip file.  
  
3.  On the **File** menu in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], click **Open**, and then click **File**.  
  
4.  Select the .vstemplate file for the template, and click **Open**.  
  
5.  Verify that the XML of the .vstemplate file adheres to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] template schema. For more information on the .vstemplate schema, see [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md).  
  
    > [!NOTE]
    >  To get IntelliSense support while authoring the .vstemplate file, add a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> attribute to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> element and assign it a value of http://schemas.microsoft.com/developer/vstemplate/2005.  
  
6.  Save and close the .vstemplate file.  
  
7.  Select the files included in your template, right-click, select **Send To**, and click **Compressed (zipped) Folder**. The files that you selected are compressed into a .zip file.  
  
8.  Place the new .zip file in the same directory as the old .zip file.  
  
9. Delete the extracted template files and the old template .zip file.  
  
## Monitoring the Event Log  
 [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] logs errors encountered when processing template .zip files. If a template does not show up in the **New Project** dialog box as expected, you can use **Event Viewer** to troubleshoot the issue.  
  
#### To locate template errors in Event Viewer  
  
1.  In Windows, click **Start**, click **Control Panel**, double-click **Administrative Tools**, and then double-click **Event Viewer**.  
  
2.  In the left pane, click **Application**.  
  
3.  Look for events with a **Source** value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
4.  Double-click on a template event to view the error.  
  
## See Also  
 [Customizing Project and Item Templates](../vs140/customizing-project-and-item-templates.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)