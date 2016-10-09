---
title: "Guidelines for Importing Reusable Workflows"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, importing items"
  - "SharePoint development in Visual Studio, reusable workflows"
  - "importing items [SharePoint development in Visual Studio]"
  - "reusable workflows [SharePoint development in Visual Studio]"
ms.assetid: 851043dd-ecbe-49ab-b5b7-5ea7b699df12
caps.latest.revision: 13
ms.author: "kempb"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Guidelines for Importing Reusable Workflows
  To import reusable workflows created in SharePoint Designer, use the Import Reusable SharePoint 2010 Workflow project template in [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)]. This template imports a *declarative* *workflow* ([!INCLUDE[TLA2#tla_xml](../VS_officedev/includes/tla2sharptla_xml_md.md)]-only) and converts it into a *code workflow*, which is a workflow that you can enhance with either [!INCLUDE[vbprvb](../VS_officedev/includes/vbprvb_md.md)] or [!INCLUDE[csprcs](../VS_officedev/includes/csprcs_md.md)] code. [!INCLUDE[crdefault](../VS_officedev/includes/crdefault_md.md)] [Walkthrough: Import a SharePoint Designer Reusable Workflow into Visual Studio](../VS_officedev/walkthrough--import-a-sharepoint-designer-reusable-workflow-into-visual-studio.md).  
  
 However, the Import Reusable SharePoint 2010 Workflow template can import only farm solutions. If you want to deploy your workflow as a sandboxed solution, import it with the Import SharePoint 2010 Solution Package template. However, by doing this, you cannot convert it to code workflow and will not be able to modify it as such.  
  
## Importing Reusable Workflows by Using the Import Reusable Workflow Template  
 If you import a reusable workflow by using the Import Reusable SharePoint 2010 Workflow template, you can run or change the solution just like any other [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] SharePoint solution, but you may have to manually fix some items.  
  
### Importing Task Forms  
 The Import Reusable SharePoint 2010 Workflow project template imports all initiation and association forms, but imports only one task form because the code workflow schema only permits one task form. Any additional task forms from the original workflow solution are put into the **Other Imported Files** folder in **Solution Explorer**.  
  
## Importing Reusable Workflows by Using the Import SharePoint 2010 Solution Package Template  
 If you import a reusable workflow by using the Import SharePoint 2010 Solution Package template, you need to consider the following issues:  
  
-   After importing the workflow, you can immediately deploy and run it in [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] by choosing the F5 key. However, if you change anything in the workflow in the imported solution, you may have to manually fix elements in the project before you can deploy and run the workflow.  
  
-   Because the workflow is declarative, code cannot be added to it. To convert the workflow into a code workflow, you must import it into [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] by using the Import Reusable SharePoint 2010 Workflow template.  
  
-   While you can edit the workflow designer (.xoml) file in Design view, it is recommended that you edit it in Source view, because the workflow designer displays false errors.  
  
-   Debugging in the workflow does not work for declarative content. Breakpoints set in the [!INCLUDE[wfd2](../VS_officedev/includes/wfd2_md.md)] are not hit.  
  
## Importing Globally Reusable Workflow Solutions  
 Globally reusable workflows cannot be imported by using the Import Reusable SharePoint 2010 Workflow template. To import a globally reusable workflow, you have to convert it into a non-globally reusable workflow or you have to use the Import SharePoint 2010 Solution Package template.  
  
 To convert the workflow, make a copy of the globally reusable workflow in SharePoint Designer (by opening the shortcut menu for the workflow and then choosing **Save as Copy**). Then import the new reusable workflow with the Import Reusable SharePoint 2010 Workflow template in [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)].  
  
 To import the globally reusable workflow without modifying it, use the Import SharePoint 2010 Solution Package template. If you use this method, the workflow is not converted to a code workflow and remains a declarative workflow.  
  
## See Also  
 [Importing Items from an Existing SharePoint Site](../VS_officedev/importing-items-from-an-existing-sharepoint-site.md)   
 [Walkthrough: Import a SharePoint Designer Reusable Workflow into Visual Studio](../VS_officedev/walkthrough--import-a-sharepoint-designer-reusable-workflow-into-visual-studio.md)  
  
  