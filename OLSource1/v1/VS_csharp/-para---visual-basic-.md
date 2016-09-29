---
title: "&lt;para&gt; (Visual Basic)"
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
  - "<para> XML tag"
  - "para XML tag"
ms.assetid: a3a18b6c-6416-4358-94ec-37b22675fd37
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;para&gt; (Visual Basic)
Specifies that the content is formatted as a paragraph.  
  
## Syntax  
  
```  
<para>content</para>  
```  
  
#### Parameters  
 `content`  
 The text of the paragraph.  
  
## Remarks  
 The `<para>` tag is for use inside a tag, such as [<summary\> (Visual Basic)](../VS_csharp/-summary---visual-basic-.md), [<remarks\> (Visual Basic)](../VS_csharp/-remarks---visual-basic-.md), or [<returns\> (Visual Basic)](../VS_csharp/-returns---visual-basic-.md), and lets you add structure to the text.  
  
 Compile with [/doc](../VS_csharp/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the `<para>` tag to split the remarks section for the `UpdateRecord` method into two paragraphs.  
  
 [!code[VbVbcnXmlDocComments#6](../VS_csharp/codesnippet/VisualBasic/-para---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended XML Tags for Documentation Comments (Visual Basic)](../VS_csharp/recommended-xml-tags-for-documentation-comments--visual-basic-.md)