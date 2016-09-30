---
title: "FullClassName Element (Visual Studio Template Wizard Extension)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#FullClassName"
helpviewer_keywords: 
  - "FullClassName element [Visual Studio project template]"
ms.assetid: 651e1010-d529-4856-85ff-c77ceca5d2ed
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FullClassName Element (Visual Studio Template Wizard Extension)
The fully qualified name of the class that implements the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface.  
  
 \<VSTemplate>  
 \<WizardExtension>  
 ...  
 \<FullClassName>  
  
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
  
 This text specifies the class that implements the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface. The specified class must exist in the assembly specified by the [Assembly](../vs140/assembly-element--visual-studio-template-wizard-extension-.md) element.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a required child element of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
 The following example illustrates the metadata for the standard project template for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] Windows application.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [How to: Use Wizards with Project Templates](../vs140/how-to--use-wizards-with-project-templates.md)