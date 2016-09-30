---
title: "AppliesTo Element (Visual Studio Templates)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 8fb1334b-d78c-405f-98b4-786e9f6b58d7
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AppliesTo Element (Visual Studio Templates)
Specifies an optional expression to match one or more capabilities. (see \<xref:Microsoft.VisualStudio.Shell.Interop.VsProjectCapabilityExpressionMatcher*>). Capabilities are exposed by project types via the hierarchy as a property \<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID5.VSHPROPID_ProjectCapabilities*>. In this way, the template can be shared by multiple project types that have common applicable capabilities.  
  
 This element is optional. There can be a maximum of one instance in a template file. This element only enables an item template to opt-in as applicable, based on the capabilities of the currently selected active project. It cannot be used to make an item template not applicable. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is absent or the expression does not successfully opt in, then <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is used to make the template applicable, as with previous versions of the product.  
  
 Introduced in Visual Studio 2013 Update 2. To reference the correct version, see [Referencing Assemblies Delivered in the Visual Studio 2013 SDK Update 2](assetId:///42b65c3e-e42b-4c39-98c8-bea285f25ffb).  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<AppliesTo>  
  
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
|[TemplateData](../vs140/templatedata-element--visual-studio-templates-.md)|Categorizes the template.|  
  
## Text Value  
 A text value is required. This text specifies the capabilities of the project.  
  
 Valid expression syntax is defined as:  
  
-   The capability expression, such as "(VisualC &#124; CSharp) + (MSTest &#124; NUnit)".  
  
-   The "&#124;" is the OR operator.  
  
-   The "&" and "+" characters are both AND operators.  
  
-   The "!" character is the NOT operator.  
  
-   Parentheses force evaluation-precedence order.  
  
-   A null or empty expression is evaluated as a match.  
  
-   Project capabilities may be any character except these reserved characters: "'<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>Template1<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>WindowsAppContainer<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>Template2<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>Template3<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>WindowsAppContainer` projects.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Template Schema Reference](../vs140/visual-studio-template-schema-reference.md)   
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)