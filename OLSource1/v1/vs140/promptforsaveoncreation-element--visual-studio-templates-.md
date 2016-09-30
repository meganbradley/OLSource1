---
title: "PromptForSaveOnCreation Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#PromptForSaveOnCreation"
helpviewer_keywords: 
  - "PromptForSaveOnCreation element [Visual Studio project templates]"
ms.assetid: 75174674-0c3c-4b57-b2fd-6ea8e817b67d
caps.latest.revision: 22
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PromptForSaveOnCreation Element (Visual Studio Templates)
Specifies whether the user is prompted for a project save location via the **New Project** dialog box when creating a project. If this element is set to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, then the user is prompted for a save location; if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, then they are not prompted. (That is, a temporary project is created.)  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<PromptForSaveOnCreation>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateData](../vs140/templatedata-element--visual-studio-templates-.md)|Required element.\<br />\<br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 The text must be either <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> indicating that the user will be prompted for a save location when creating a new project.  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an optional element. The default value is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 Temporary projects are projects that you can create and modify without saving the contents of that project on disk. For more information, see [NIB Temporary Projects](assetId:///9cf1944c-7045-44cc-8701-7b0eb4099f2b).  
  
## Example  
 The following example sets the value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> equal to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which specifies to allow the project to be created as a temporary project.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)