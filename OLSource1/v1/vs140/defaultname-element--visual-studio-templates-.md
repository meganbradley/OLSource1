---
title: "DefaultName Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#DefaultName"
helpviewer_keywords: 
  - "DefaultName element [Visual Studio project templates]"
ms.assetid: 0ff056c8-b9d2-4747-9308-92adf1811491
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DefaultName Element (Visual Studio Templates)
Specifies the name that the Visual Studio project system will generate for the project or item when it is created.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<DefaultName>  
  
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
  
 This text specifies the default name of the project or item.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is an optional element.  
  
 For projects, this element specifies the name of the directory that stores the project on disk. For items, it specifies the file name of the source file.  
  
 When you create a project or item, you can modify the default name using the **Name** option, which is available from either the **New Project** dialog box or **Add New Item** dialog box.  
  
 If you do not want the project system to generate the default name for the project or item, then set the [ProvideDefaultName](../vs140/providedefaultname-element--visual-studio-templates-.md) element to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
 The following example illustrates the metadata for the standard item template for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)