---
title: "How to: Create a SharePoint Web Part"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Web Parts [SharePoint development in Visual Studio], adding"
  - "Web Parts [SharePoint development in Visual Studio], creating"
ms.assetid: 0d037522-c25e-4c24-93b7-518db0f791b7
caps.latest.revision: 21
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
# How to: Create a SharePoint Web Part
  You can create and customize a web part by adding a **Web Part** item to any SharePoint project and then editing the code file for the web part or by using a designer. For more information, see [How to: Create a SharePoint Web Part by Using a Designer](../VS_officedev/how-to--create-a-sharepoint-web-part-by-using-a-designer.md).  
  
### To create a SharePoint Web Part  
  
1.  Create or open a SharePoint project.  
  
     For more information, see [SharePoint Project and Project Item Templates](../VS_officedev/sharepoint-project-and-project-item-templates.md).  
  
2.  Choose the SharePoint project node in **Solution Explorer** and then choose **Project**, **Add New Item**.  
  
3.  In the **Add New Item** dialog box, expand the **SharePoint** node, and then choose the **2010** node.  
  
4.  In the list of SharePoint templates, choose **Web Part**.  
  
5.  In the **Name** box, specify a name for the web part, and then choose the **Add** button.  
  
     The web part appears in **Solution Explorer**. For more information about the files that a web part includes, see [Creating Web Parts for SharePoint](../VS_officedev/creating-web-parts-for-sharepoint.md).  
  
6.  In **Solution Explorer**, open the code file for the web part that you just created.  
  
     For example, if the name of your web part is WebPart1, open WebPart1.vb (in Visual Basic) or WebPart1.cs (in C#).  
  
7.  In the code file, add controls to the \<xref:System.Web.UI.Control.CreateChildControls*> method.  
  
     For an example, see [Walkthrough: Creating a Web Part for SharePoint](../VS_officedev/walkthrough--creating-a-web-part-for-sharepoint.md).  
  
## See Also  
 [Creating Web Parts for SharePoint](../VS_officedev/creating-web-parts-for-sharepoint.md)   
 [How to: Create a SharePoint Web Part by Using a Designer](../VS_officedev/how-to--create-a-sharepoint-web-part-by-using-a-designer.md)   
 [Walkthrough: Creating a Web Part for SharePoint](../VS_officedev/walkthrough--creating-a-web-part-for-sharepoint.md)   
 [Walkthrough: Creating a Web Part for SharePoint by Using a Designer](../VS_officedev/walkthrough--creating-a-web-part-for-sharepoint-by-using-a-designer.md)  
  
  