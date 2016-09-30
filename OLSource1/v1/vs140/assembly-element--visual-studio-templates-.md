---
title: "Assembly Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#Assembly"
helpviewer_keywords: 
  - "Assembly element [Visual Studio templates]"
  - "<Assembly> element [Visual Studio templates]"
ms.assetid: 9242f76a-1273-4b8a-8f26-6606f91829ef
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Assembly Element (Visual Studio Templates)
Specifies information about an assembly, which the template uses to add a reference of that assembly to projects.  
  
 \<VSTemplate>  
 \<TemplateContent>  
 \<References>  
 \<Reference>  
 \<Assembly>  
  
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
|[Reference](../vs140/reference-element--visual-studio-templates-.md)|Specifies the assembly reference to add when the item is added to a project.|  
  
## Text Value  
 A text value is required.  
  
 This text specifies the assembly to add to a project when the item template is instantiated. This assembly name must be specified in one of the following ways:  
  
-   As a full assembly name. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   As simple text reference. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a required child element of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements can only be used in .vstemplate files that have a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Example  
 The following example illustrates the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element of an item template. This XML adds references to the System.dll and System.Data.dll assemblies.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)