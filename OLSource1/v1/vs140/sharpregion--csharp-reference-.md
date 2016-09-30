---
title: "#region (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "#region"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "#region directive [C#]"
ms.assetid: 672c87d1-9771-4f64-ab3f-0ad3d4ffb2b4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #region (C# Reference)
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> lets you specify a block of code that you can expand or collapse when using the [outlining](../vs140/outlining.md) feature of the Visual Studio Code Editor. In longer code files, it is convenient to be able to collapse or hide one or more regions so that you can focus on the part of the file that you are currently working on. The following example shows how to define a region:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block must be terminated with a [#endregion](../vs140/sharpendregion--csharp-reference-.md) directive.  
  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block cannot overlap with a [#if](../vs140/sharpif--csharp-reference-.md) block. However, a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block can be nested in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block, and a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> block can be nested in a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> block.  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Preprocessor Directives](../vs140/csharp-preprocessor-directives.md)