---
title: "&lt;c&gt; (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "c XML tag"
  - "<c> XML tag"
ms.assetid: 36ad5d1b-11f7-4012-8932-41962ac327d1
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;c&gt; (Visual Basic)
Indicates that text within a description is code.  
  
## Syntax  
  
```  
<c>text</c>  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`text`|The text you would like to indicate as code.|  
  
## Remarks  
 The `<c>` tag gives you a way to indicate that text within a description should be marked as code. Use [<code\> (Visual Basic)](../VS_csharp/-code---visual-basic-.md) to indicate multiple lines as code.  
  
 Compile with [/doc](../VS_csharp/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the `<c>` tag in the summary section to indicate that `Counter` is code.  
  
 [!code[VbVbcnXmlDocComments#1](../VS_csharp/codesnippet/VisualBasic/-c---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended Tags for Documentation Comments (Visual Basic)](../VS_csharp/recommended-xml-tags-for-documentation-comments--visual-basic-.md)