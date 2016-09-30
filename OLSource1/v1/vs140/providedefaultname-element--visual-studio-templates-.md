---
title: "ProvideDefaultName Element (Visual Studio Templates)"
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
  - "http://schemas.microsoft.com/developer/vstemplate/2005#ProvideDefaultName"
helpviewer_keywords: 
  - "ProvideDefaultName element [Visual Studio project templates]"
ms.assetid: 7b0e7b20-fd6b-42e2-81d0-e5100cea0528
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ProvideDefaultName Element (Visual Studio Templates)
Specifies whether the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project system will generate a default name for the template in the **Add New Item** or **New Project** dialog box.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<ProvideDefaultName>  
  
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
|[TemplateData](../vs140/templatedata-element--visual-studio-templates-.md)|Required element.\<br />\<br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 The text must be either <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, indicating whether or not to generate a default name for the template in the **Add New Item** or **New Project** dialog box.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is an optional element. The default value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 If the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the **Name** boxes of the **Add New Item** and **New Project** dialog boxes contain the value <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 Use the [DefaultName](../vs140/defaultname-element--visual-studio-templates-.md) element to specify the default name of the project or item in the **Add New Item** and **New Project** dialog boxes.  
  
## Example  
 The following code example sets the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)