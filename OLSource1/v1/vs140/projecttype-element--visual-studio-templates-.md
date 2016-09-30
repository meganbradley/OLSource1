---
title: "ProjectType Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#ProjectType"
helpviewer_keywords: 
  - "ProjectType element [Visual Studio project templates]"
ms.assetid: ccf9d83f-c7f3-49c7-a31f-e1f22bec004c
caps.latest.revision: 23
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ProjectType Element (Visual Studio Templates)
Categorizes the project template so that it appears under the specified group in the **New Project** or **Add New Item** dialog box.  
  
> [!WARNING]
>  Project templates are supported for C++ starting in Visual Studio 2012. They are not supported for C++ in Visual Studio 2010 and earlier versions.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<ProjectType>  
  
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
|[TemplateData](../vs140/templatedata-element--visual-studio-templates-.md)|Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 This value specifies the type of project the template will create, and must contain one of the following values:  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>: Specifies that the template creates a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] project or item.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>: Specifies that the template creates a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] project or item.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>: Specifies that the template creates a Web project or item. If the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element contains this value, the language of the project or item is defined in the [ProjectSubType Element (Visual Studio Templates)](../vs140/projectsubtype-element--visual-studio-templates-.md).  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a required child element of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 The value of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element specifies where the template is located in the **New Project** or **Add New Item** dialog box. For example, a template with a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> appears under the **Visual C#** node in the **New Project** dialog box.  
  
 A template subtype can be specified by using the [ProjectSubType](../vs140/projectsubtype-element--visual-studio-templates-.md) element.  
  
## Example  
 The following example shows the metadata for a project template for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] application.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [ProjectSubType Element (Visual Studio Templates)](../vs140/projectsubtype-element--visual-studio-templates-.md)