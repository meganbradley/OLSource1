---
title: "Reference Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#Reference"
helpviewer_keywords: 
  - "Reference element [Visual Studio templates]"
  - "<Reference> element [Visual Studio templates]"
ms.assetid: 852772ea-c324-42e9-8c8a-6d565414a109
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reference Element (Visual Studio Templates)
Specifies the assembly reference to add when the item is added to a project.  
  
 \<VSTemplate>  
 \<TemplateContent>  
 \<References>  
 \<Reference>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Assembly](../vs140/assembly-element--visual-studio-templates-.md)|Required element.\<br />\<br /> Specifies information about an assembly, which the template uses to add a reference of that assembly to projects. There must be one <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element in every <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[References](../vs140/references-element--visual-studio-templates-.md)|Groups the assembly references that the template adds to projects.|  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a required child element of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> elements can only be used in .vstemplate files that have a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
 The following example illustrates the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element of an item template. This XML adds references to the System.dll and System.Data.dll assemblies.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)