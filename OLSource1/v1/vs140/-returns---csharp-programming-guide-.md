---
title: "&lt;returns&gt; (C# Programming Guide)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - returns
  - <returns>
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - <returns> C# XML tag
  - returns C# XML tag
ms.assetid: bb2d9958-62fc-47c7-9511-6311171f119f
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &lt;returns&gt; (C# Programming Guide)
## Syntax  
  
```  
<returns>description</returns>  
```  
  
#### Parameters  
 `description`  
 A description of the return value.  
  
## Remarks  
 The <returns\> tag should be used in the comment for a method declaration to describe the return value.  
  
 Compile with [/doc](../vs140/-doc--csharp-compiler-options-.md) to process documentation comments to a file.  
  
## Example  
 [!code[csProgGuideDocComments#10](../vs140/codesnippet/CSharp/-returns---csharp-programming-guide-_1.cs)]
  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Recommended Tags for Documentation Comments](../vs140/recommended-tags-for-documentation-comments--csharp-programming-guide-.md)