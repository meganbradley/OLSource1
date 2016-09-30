---
title: "CustomParameter Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#CustomParameter"
helpviewer_keywords: 
  - "CustomParameters element [Visual Studio project templates]"
ms.assetid: 743c4489-74ac-403a-bbaa-eed7d785a3ac
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CustomParameter Element (Visual Studio Templates)
Contains a custom parameter name and value to use when a project or item is created from the template.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required. The name of the parameter. The format for parameters is $*name*$.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Required. The replacement value for the parameter.|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CustomParameters](../vs140/customparameters-element--visual-studio-templates-.md)|Groups the custom parameters that are to be passed to the template wizard when the wizard makes parameter replacements.|  
  
## Remarks  
 When a template contains <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> elements, every instance the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute is replaced with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute in the created project or item files.  
  
## Example  
 The following example shows how to use several custom parameters in a template. When a project or item is created from a template with the following custom parameters, all instances of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the template files will be replaced with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, respectively.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [CustomParameters Element (Visual Studio Project Templates)](../vs140/customparameters-element--visual-studio-templates-.md)   
 [Parameter Substitution](../vs140/template-parameters.md)   
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)