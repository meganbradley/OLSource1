---
title: "References Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#References"
helpviewer_keywords: 
  - "<References> element [Visual Studio Templates]"
  - "References element [Visual Studio Templates]"
ms.assetid: 1969146d-46bf-422d-8d46-0e9493925003
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# References Element (Visual Studio Templates)
Groups the assembly references that the template adds to projects.  
  
 \<VSTemplate>  
 \<TemplateContent>  
 \<References>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Reference](../vs140/reference-element--visual-studio-templates-.md)|Required element.\<br />\<br /> Specifies the assembly reference to add when the item is added to a project. There must be one or more <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateContent](../vs140/templatecontent-element--visual-studio-templates-.md)|Specifies the contents of the template.|  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is an optional child element of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> elements can only be used in .vstemplate files that have a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
 The following example illustrates the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element of an item template. This XML adds references to the System.dll and System.Data.dll assemblies.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)