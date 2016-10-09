---
title: "&lt;code&gt; (Visual Basic)"
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
  - "code XML tag"
  - "<code> XML tag"
ms.assetid: 925e5342-be05-45f2-bf66-7398bbd6710e
caps.latest.revision: 10
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
# &lt;code&gt; (Visual Basic)
Indicates that the text is multiple lines of code.  
  
## Syntax  
  
```  
<code>content</code>  
```  
  
#### Parameters  
 `content`  
 The text to mark as code.  
  
## Remarks  
 Use the `<code>` tag to indicate multiple lines as code. Use [\<c>](../VS_visualbasic/-c---visual-basic-.md) to indicate that text within a description should be marked as code.  
  
 Compile with [/doc](../VS_visualbasic/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the \<code> tag to include example code for using the `ID` field.  
  
 [!code[VbVbcnXmlDocComments#2](../VS_visualbasic/codesnippet/VisualBasic/-code---visual-basic-_1.vb)]  
  
## See Also  
 [XML Comment Tags](../VS_visualbasic/recommended-xml-tags-for-documentation-comments--visual-basic-.md)