---
title: "Retrieving the Paragraphs and Their Styles (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: d9ed2238-d38e-4ad4-b88b-db7859df9bde
caps.latest.revision: 5
---
# Retrieving the Paragraphs and Their Styles (Visual Basic)
In this example, we write a query that retrieves the paragraph nodes from a WordprocessingML document. It also identifies the style of each paragraph.  
  
 This query builds on the query in the previous example, [Finding the Default Paragraph Style (Visual Basic)](../vs140/finding-the-default-paragraph-style--visual-basic-.md), which retrieves the default style from the list of styles. This information is required so that the query can identify the style of paragraphs that do not have a style explicitly set. Paragraph styles are set through the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element; if a paragraph does not contain this element, it is formatted with the default style.  
  
 This topic explains the significance of some pieces of the query, then shows the query as part of a complete, working example.  
  
## Example  
 The source of the query to retrieve all the paragraphs in a document and their styles is as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This expression is similar to the source of the query in the previous example, [Finding the Default Paragraph Style (Visual Basic)](../vs140/finding-the-default-paragraph-style--visual-basic-.md). The main difference is that it uses the \<xref:System.Xml.Linq.XContainer.Descendants*> axis instead of the \<xref:System.Xml.Linq.XContainer.Elements*> axis. The query uses the \<xref:System.Xml.Linq.XContainer.Descendants*> axis because in documents that have sections, the paragraphs will not be the direct children of the body element; rather, the paragraphs will be two levels down in the hierarchy. By using the \<xref:System.Xml.Linq.XContainer.Descendants*> axis, the code will work of whether or not the document uses sections.  
  
## Example  
 The query uses a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause to determine the element that contains the style node. If there is no element, then <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause first uses the \<xref:System.Xml.Linq.XContainer.Elements*> axis to find all elements named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, then uses the \<xref:System.Xml.Linq.Extensions.Elements*> extension method to find all child elements named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and finally uses the \<xref:System.Linq.Enumerable.FirstOrDefault*> standard query operator to convert the collection to a singleton. If the collection is empty, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. This is a useful idiom to look for the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> descendant node. Note that if the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> child node does not exist, the code does nor fail by throwing an exception; instead, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, which is the desired behavior of this <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> clause.  
  
 The query projects a collection of an anonymous type with two members, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Example  
 This example processes a WordprocessingML document, retrieving the paragraph nodes from a WordprocessingML document. It also identifies the style of each paragraph. This example builds on the previous examples in this tutorial. The new query is called out in comments in the code below.  
  
 You can find instructions for creating the source document for this example in [Creating the Source Office Open XML Document (Visual Basic)](../vs140/creating-the-source-office-open-xml-document--visual-basic-.md).  
  
 This example uses classes found in the WindowsBase assembly. It uses types in the \<xref:System.IO.Packaging*?displayProperty=fullName> namespace.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output when applied to the document described in [Creating the Source Office Open XML Document (Visual Basic)](../vs140/creating-the-source-office-open-xml-document--visual-basic-.md).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Next Steps  
 In the next topic, [Retrieving the Text of the Paragraphs (Visual Basic)](../vs140/retrieving-the-text-of-the-paragraphs--visual-basic-.md), you'll create a query to retrieve the text of paragraphs.  
  
## See Also  
 [Tutorial: Manipulating Content in a WordprocessingML Document (Visual Basic)](../vs140/tutorial--manipulating-content-in-a-wordprocessingml-document--visual-basic-.md)