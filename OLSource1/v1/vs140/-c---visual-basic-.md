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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The text you would like to indicate as code.|  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> tag gives you a way to indicate that text within a description should be marked as code. Use [\<code> (Visual Basic)](../vs140/-code---visual-basic-.md) to indicate multiple lines as code.  
  
 Compile with [/doc](../vs140/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> tag in the summary section to indicate that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is code.  
  
 [!code[VbVbcnXmlDocComments#1](../vs140/codesnippet/VisualBasic/-c---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)