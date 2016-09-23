---
title: "CustomParameters Element (Visual Studio Templates)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - http://schemas.microsoft.com/developer/vstemplate/2005#CustomParameters
helpviewer_keywords: 
  - CustomParameters element [Visual Studio project templates]
ms.assetid: cf3efc91-1532-4022-bbb8-a18658424fee
caps.latest.revision: 10
translation.priority.mt: 
  - de-de
  - ja-jp
---
# CustomParameters Element (Visual Studio Templates)
Groups the custom parameters that are to be passed to the template wizard when the wizard makes parameter replacements.  
  
## Syntax  
  
```  
<CustomParameters>  
    <CustomParameter/>  
    <CustomParameter/>  
</CustomParameters>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CustomParameter](../vs140/customparameter-element--visual-studio-templates-.md)|Optional element.<br /><br /> Contains a custom parameter name and value to use when a project or item is created from the template. There may be zero or more `CustomParameter` elements in a `CustomParameters` element.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateContent](../vs140/templatecontent-element--visual-studio-templates-.md)|Specifies the contents of the template.|  
  
## Remarks  
  
## Example  
 The following example shows how to use several custom parameters in a template. When a project or item is created from a template with the following custom parameters, all instances of `$color1$` and `$color2$` in the template files will be replaced with `Red` and `Blue`, respectively.  
  
```  
<CustomParameters>  
    <CustomParameter Name="$color1$" Value="Red"/>  
    <CustomParameter Name="$color2$" Value="Blue "/>  
</CustomParameters>  
```  
  
## See Also  
 [CustomParameter Element (Visual Studio Project Templates)](../vs140/customparameter-element--visual-studio-templates-.md)   
 [Parameter Substitution](../vs140/template-parameters.md)   
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)