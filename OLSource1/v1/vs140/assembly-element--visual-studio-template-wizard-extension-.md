---
title: "Assembly Element (Visual Studio Template Wizard Extension)"
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
  - "Assembly element [Visual Studio Template Wizard Extension]"
  - "<Assembly> element [Visual Studio Template Wizard Extension]"
ms.assetid: 0c3dc280-1753-4ea2-a13c-d31d13b935b2
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Assembly Element (Visual Studio Template Wizard Extension)
Specifies the name or strong name of the assembly that implements the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface.  
  
 \<VSTemplate>  
\<WizardExtension>  
\<Assembly>  
  
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
|[WizardExtension](../vs140/wizardextension-element--visual-studio-templates-.md)|Contains the registration elements for customizing the template wizard.|  
  
## Text Value  
 A text value is required.  
  
 This text specifies the assembly that implements the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface. This assembly name must be specified as a full assembly name. For example, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a required child element of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
 The following example illustrates the metadata for the standard project template for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] Windows application.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [How to: Use Wizards with Project Templates](../vs140/how-to--use-wizards-with-project-templates.md)