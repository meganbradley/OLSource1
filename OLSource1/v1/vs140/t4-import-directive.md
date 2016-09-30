---
title: "T4 Import Directive"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 713ca975-b9aa-4210-bf6d-b7660f5b193b
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# T4 Import Directive
In the code blocks of a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] T4 text template, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directive allows you to refer to elements in another namespace without providing a fully-qualified name. It is the equivalent of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in C# or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in [!INCLUDE[vb_current_short](../vs140/includes/vb_current_short_md.md)].  
  
 For a general overview of writing T4 text templates, see [Writing a Text Template](../vs140/writing-a-t4-text-template.md).  
  
## Using the Import Directive  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, template code can omit an explicit namespace for members of System.IO:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Standard Imports  
 The following namespace is imported automatically, so that you do not need to write an import directive for it:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 In addition, if you use a custom directive, the directive processor might import some namespaces automatically.  
  
 For example, if you write templates for a domain-specific language (DSL), you do not need to write import directives for the following namespaces:  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
-   Your DSL’s namespace  
  
## See Also  
 [Assembly Directive](../vs140/t4-assembly-directive.md)