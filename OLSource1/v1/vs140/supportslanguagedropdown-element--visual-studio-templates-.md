---
title: "SupportsLanguageDropDown Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#SupportsLanguageDropDown"
helpviewer_keywords: 
  - "SupportsLanguageDropDown element [Visual Studio Templates]"
  - "<SupportsLanguageDropDown> element [Visual Studio Templates]"
ms.assetid: 641197d5-f724-4c06-bc47-2e22dad3fbfb
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SupportsLanguageDropDown Element (Visual Studio Templates)
Specifies whether the Web item template is identical for multiple languages, and whether the **Language** option is enabled on the **Add New Item** dialog box.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<SupportsLanguageDropDown>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
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
  
 The text must be either <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, indicating whether or not the **Language** option is available from the **Add New Item** dialog box.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is an optional element. The default value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element is only available for Web item templates.  
  
 If the value for this element is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, then the item template is identical for all programming languages and the **Language** option is enabled in the **Add New Item** dialog box. This option enables you to choose the programming language of the new item that you want to create from the template.  
  
## Example  
 The following example specifies to display the **Language** drop down option.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)