---
title: "&lt;paramref&gt; (Visual Basic)"
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
  - "paramref XML tag"
  - "<paramref> XML tag"
ms.assetid: 8979d53b-beb1-41b7-b41e-6bbea1c17a03
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;paramref&gt; (Visual Basic)
Formats a word as a parameter.  
  
## Syntax  
  
```  
<paramref name="name"/>  
```  
  
#### Parameters  
 `name`  
 The name of the parameter to refer to. Enclose the name in double quotation marks (" ").  
  
## Remarks  
 The `<paramref>` tag gives you a way to indicate that a word is a parameter. The XML file can be processed to format this parameter in some distinct way.  
  
 Compile with [/doc](../VS_csharp/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the `<paramref>` tag to refer to the `id` parameter.  
  
 [!code[VbVbcnXmlDocComments#6](../VS_csharp/codesnippet/VisualBasic/-paramref---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended XML Tags for Documentation Comments (Visual Basic)](../VS_csharp/recommended-xml-tags-for-documentation-comments--visual-basic-.md)