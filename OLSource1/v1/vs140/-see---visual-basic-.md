---
title: "&lt;see&gt; (Visual Basic)"
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
  - "see XML tag"
  - "<see> XML tag"
ms.assetid: 7e18f60b-ef4a-4678-a797-5eb918635ca9
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;see&gt; (Visual Basic)
Specifies a link to another member.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a member or field that is available to be called from the current compilation environment. The compiler checks that the given code element exists and passes <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the element name in the output XML. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> must appear within double quotation marks (" ").  
  
## Remarks  
 Use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> tag to specify a link from within text. Use [\<seealso> (Visual Basic)](../vs140/-seealso---visual-basic-.md) to indicate text that you might want to appear in a "See Also" section.  
  
 Compile with [/doc](../vs140/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> tag in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> remarks section to refer to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method.  
  
 [!code[VbVbcnXmlDocComments#6](../vs140/codesnippet/VisualBasic/-see---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended XML Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)