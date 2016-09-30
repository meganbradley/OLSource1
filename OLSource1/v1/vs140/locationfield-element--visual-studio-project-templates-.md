---
title: "LocationField Element (Visual Studio Project Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#LocationField"
helpviewer_keywords: 
  - "LocationField element [Visual Studio project templates]"
ms.assetid: 6aaaa155-6ce0-4f7f-aa50-8d63d7a7c992
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# LocationField Element (Visual Studio Project Templates)
Specifies whether or not the **Location** text box in the **New Project** dialog box is enabled, disabled, or hidden for the project template.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<LocationField>  
  
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
|[TemplateData](../vs140/templatedata-element--visual-studio-templates-.md)|Required element.\<br />\<br /> Categorizes the template and defines how it displays in either the **New Project**.|  
  
## Text Value  
 A text value is required.  
  
 Valid text values are:  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, which specifies that the **Location** box of the **New Project** dialog box is enabled.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which specifies that the **Location** box of the **New Project** dialog box is disabled.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which specifies that the **Location** box of the **New Project** dialog box is hidden.  
  
## Remarks  
 The default value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The **Location** text box in the **New Project** dialog box enables users to change the default directory in which new projects are saved.  
  
 The value specified in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element is only honored by the dialog box if the underlying project system supports it.  
  
## Example  
 The following example illustrates the metadata for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] template.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)