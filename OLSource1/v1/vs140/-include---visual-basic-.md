---
title: "&lt;include&gt; (Visual Basic)"
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
  - "include XML tag"
  - "<include> XML tag"
ms.assetid: ba8e9173-82cd-460b-8938-a075a2dfb36d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;include&gt; (Visual Basic)
Refers to another file that describes the types and members in your source code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. The name of the file containing the documentation. The file name can be qualified with a path. Enclose <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in double quotation marks (" ").  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Required. The path of the tags in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that leads to the tag <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Enclose the path in double quotation marks (" ").  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Required. The name specifier in the tag that precedes the comments. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> will have an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Required. The ID for the tag that precedes the comments. Enclose the ID in single quotation marks (' ').  
  
## Remarks  
 Use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> tag to refer to comments in another file that describe the types and members in your source code. This is an alternative to placing documentation comments directly in your source code file.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> tag uses the W3C XML Path Language (XPath) Version 1.0 Recommendation. More information for ways to customize your <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> use is available at http://www.w3.org/TR/xpath.  
  
## Example  
 This example uses the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> tag to import member documentation comments from a file called <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 [!code[VbVbcnXmlDocComments#4](../vs140/codesnippet/VisualBasic/-include---visual-basic-_1.vb)]  
  
 The format of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is as follows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Recommended XML Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)