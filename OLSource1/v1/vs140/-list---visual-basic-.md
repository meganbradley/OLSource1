---
title: "&lt;list&gt; (Visual Basic)"
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
  - "listheader XML tag"
  - "<item> XML tag"
  - "<list> XML tag"
  - "<listheader> XML tag"
  - "term XML tag"
  - "list XML tag"
  - "<description> XML tag"
  - "description XML tag"
  - "item XML tag"
  - "<term> XML tag"
ms.assetid: ec35fced-d58e-4520-a764-0691256e014b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;list&gt; (Visual Basic)
Defines a list or table.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the list. Must be a "bullet" for a bulleted list, "number" for a numbered list, or "table" for a two-column table.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Only used when <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is "table." A term to define, which is defined in the description tag.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 When <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is "bullet" or "number," <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is an item in the list When <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is "table," <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is the definition of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> block defines the heading of either a table or definition list. When defining a table, you only have to supply an entry for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in the heading.  
  
 Each item in the list is specified with an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> block. When creating a definition list, you must specify both <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. However, for a table, bulleted list, or numbered list, you only have to supply an entry for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 A list or table can have as many <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> blocks as needed.  
  
 Compile with [/doc](../vs140/-doc.md) to process documentation comments to a file.  
  
## Example  
 This example uses the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> tag to define a bulleted list in the remarks section.  
  
 [!code[VbVbcnXmlDocComments#5](../vs140/codesnippet/VisualBasic/-list---visual-basic-_1.vb)]  
  
## See Also  
 [Recommended Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md)