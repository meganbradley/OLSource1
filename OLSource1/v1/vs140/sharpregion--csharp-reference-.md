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
`#region` lets you specify a block of code that you can expand or collapse when using the [outlining](../vs140/outlining.md) feature of the Visual Studio Code Editor. In longer code files, it is convenient to be able to collapse or hide one or more regions so that you can focus on the part of the file that you are currently working on. The following example shows how to define a region:  
  
```  
  
      #region MyClass definition  
public class MyClass   
{  
    static void Main()   
    {  
    }  
}  
#endregion  
```  
  
## Remarks  
 A `#region` block must be terminated with a [#endregion](../vs140/sharpendregion--csharp-reference-.md) directive.  
  
 A `#region` block cannot overlap with a [#if](../vs140/sharpif--csharp-reference-.md) block. However, a `#region` block can be nested in a `#if` block, and a `#if` block can be nested in a `#region` block.  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Preprocessor Directives](../vs140/csharp-preprocessor-directives.md)