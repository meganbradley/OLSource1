---
title: "WizardData Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#WizardData"
helpviewer_keywords: 
  - "WizardData element [Visual Studio Templates]"
  - "<WizardData> element [Visual Studio Templates]"
ms.assetid: d0403a16-5d07-4fe5-b474-19ae3d9fd3ab
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WizardData Element (Visual Studio Templates)
Specifies custom XML  
  
 \<VSTemplate>  
 \<WizardData>  
  
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
|[VSTemplate](../vs140/vstemplate-element--visual-studio-templates-.md)|Required element.\<br />\<br /> Contains all the metadata for the project template, item template, or starter kit.|  
  
## Text Value  
 A text value is optional.  
  
 This text specifies the custom XML to pass to the custom wizard extension specified in the [WizardExtension](../vs140/wizardextension-element--visual-studio-templates-.md) element.  
  
## Remarks  
 Any XML can be specified in this element. The XML will be passed as a parameter to the custom wizard extension, allowing the extension to use the contents of this element. No validation is done on this data.  
  
 The contents of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element are passed, unchanged, as a parameter inside the string dictionary of parameters in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method. The parameter is named $WizardData$.  
  
## Example  
 The following example illustrates the metadata for the standard project template for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] Windows application.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [WizardExtension Element (Visual Studio Templates)](../vs140/wizardextension-element--visual-studio-templates-.md)   
 [How to: Use Wizards with Project Templates](../vs140/how-to--use-wizards-with-project-templates.md)