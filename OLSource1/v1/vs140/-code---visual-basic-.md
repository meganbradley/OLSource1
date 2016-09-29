---
title: "&lt;code&gt; (Visual Basic)"
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
  - "code XML tag"
  - "<code> XML tag"
ms.assetid: 925e5342-be05-45f2-bf66-7398bbd6710e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
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
 Use the `<code>` tag to indicate multiple lines as code. Use [\<c> (Visual Basic)](../vs140/-c---visual-basic-.md) to indicate that text within a description should be marked as code.  
  
 Compile with [/doc](../vs140/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the \<code> tag to include example code for using the `ID` field.  
  
 [!code[VbVbcnXmlDocComments#2](../vs140/codesnippet/VisualBasic/-code---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended XML Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)