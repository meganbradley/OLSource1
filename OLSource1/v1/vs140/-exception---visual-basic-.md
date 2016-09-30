---
title: "&lt;exception&gt; (Visual Basic)"
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
  - "<exception> XML tag"
  - "exception XML tag"
ms.assetid: c0517549-171e-4dae-ab88-a9c1700b6eee
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;exception&gt; (Visual Basic)
Specifies which exceptions can be thrown.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to an exception that is available from the current compilation environment. The compiler checks that the given exception exists and translates <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the canonical element name in the output XML. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> must appear within double quotation marks (" ").  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A description.  
  
## Remarks  
 Use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> tag to specify which exceptions can be thrown. This tag is applied to a method definition.  
  
 Compile with [/doc](../vs140/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> tag to describe an exception that the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function can throw.  
  
 [!code[VbVbcnXmlDocComments#3](../vs140/codesnippet/VisualBasic/-exception---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)