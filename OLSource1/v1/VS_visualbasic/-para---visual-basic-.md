---
title: "&lt;para&gt; (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 9
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
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
 The `<para>` tag is for use inside a tag, such as [\<summary>](../VS_visualbasic/-summary---visual-basic-.md), [\<remarks>](../VS_visualbasic/-remarks---visual-basic-.md), or [\<returns>](../VS_visualbasic/-returns---visual-basic-.md), and lets you add structure to the text.  
  
 Compile with [/doc](../VS_visualbasic/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the `<para>` tag to split the remarks section for the `UpdateRecord` method into two paragraphs.  
  
 [!code[VbVbcnXmlDocComments#6](../VS_visualbasic/codesnippet/VisualBasic/-para---visual-basic-_1.vb)]  
  
## See Also  
 [XML Comment Tags](../VS_visualbasic/recommended-xml-tags-for-documentation-comments--visual-basic-.md)