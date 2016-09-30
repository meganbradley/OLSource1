---
title: "CustomDataSignature Element (Visual Studio Templates)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "<CustomDataSignature> Element (Visual Studio Templates)"
  - "CustomDataSignature Element (Visual Studio Templates)"
ms.assetid: 8c3db51d-7014-4484-802a-15aa1353dbdb
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CustomDataSignature Element (Visual Studio Templates)
Specifies the text signature to locate the custom data.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<CustomDataSignature>  
  
## Syntax  
  
```  
<CustomDataSignature>"string"</CustomDataSignature>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateData](../vs140/templatedata-element--visual-studio-templates-.md)|Required element.<br /><br /> Categorizes the template and defines how it is displayed in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 The text is a string that has the text signature that is required to locate the custom data.  
  
## Remarks  
 `CustomDataSignature` is an optional element.  
  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)