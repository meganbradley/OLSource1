---
title: "T4 Text Template Directives"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "text templates, import directive"
  - "text templates, include directive"
  - "text templates, assembly directive"
  - "text templates, output directive"
  - "text templates, directives"
  - "text templates, template directive"
ms.assetid: 6898ee02-ebb2-4635-a4e9-350774c13cf2
caps.latest.revision: 85
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# T4 Text Template Directives
Directives provide instructions to the text template transformation engine.  
  
 The syntax of directives is as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 All attribute values must be surrounded by double quotation marks. If the value itself contains quotation marks, they must be escaped with the \ character.  
  
 Directives are typically the first elements in a template file or an included file. You should not place them inside a code block <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, nor after a class feature block <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 [Template Directive](../vs140/t4-template-directive.md)  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [Parameter Directive](../vs140/t4-parameter-directive.md)  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [Output Directive](../vs140/t4-output-directive.md)  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [Assembly Directive](../vs140/t4-assembly-directive.md)  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [Import Directive](../vs140/t4-import-directive.md)  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [Include Directive](../vs140/t4-include-directive.md)  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [CleanUpBehavior directive](../vs140/t4-cleanupbehavior-directive.md)  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 In addition, you can create your own directives. For more information, see [Creating a Custom Directive Processor](../vs140/creating-custom-t4-text-template-directive-processors.md). If you use the Visualization and Modeling SDK to create a domain-specific language (DSL), a directive processor will be generated as part of your DSL.