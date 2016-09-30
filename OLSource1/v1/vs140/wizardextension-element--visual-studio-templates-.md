---
title: "WizardExtension Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#WizardExtension"
helpviewer_keywords: 
  - "WizardExtension element [Visual Studio Templates]"
  - "<WizardExtension> element [Visual Studio Templates]"
ms.assetid: d54b01c1-50f5-4b65-828c-686e2321cc8c
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WizardExtension Element (Visual Studio Templates)
Contains the registration elements for customizing the template wizard.  
  
 \<VSTemplate>  
 ...  
 \<WizardExtension>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Assembly](../vs140/assembly-element--visual-studio-template-wizard-extension-.md)|Required element.\<br />\<br /> Specifies the name or strong name of an assembly that appears in the global assembly cache. There must be at least one <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element.|  
|[FullClassName](../vs140/fullclassname-element--visual-studio-template-wizard-extension-.md)|Required element.\<br />\<br /> The fully qualified name of the class that implements the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface. There must be at least one <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[VSTemplate](../vs140/vstemplate-element--visual-studio-templates-.md)|Contains all the metadata for the project template, item template, or starter kit.|  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an optional child element of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
 The following example illustrates the metadata for the standard project template for a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] Windows application.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [How to: Use Wizards with Project Templates](../vs140/how-to--use-wizards-with-project-templates.md)