---
title: "Retrieving the Text of the Paragraphs (Visual Basic)"
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
ms.assetid: 095fa0d9-7b1b-4cbb-9c13-e2c9d8923d31
caps.latest.revision: 8
---
# Retrieving the Text of the Paragraphs (Visual Basic)
This example builds on the previous example, [Retrieving the Paragraphs and Their Styles (Visual Basic)](../vs140/retrieving-the-paragraphs-and-their-styles--visual-basic-.md). This new example retrieves the text of each paragraph as a string.  
  
 To retrieve the text, this example adds an additional query that iterates through the collection of anonymous types and projects a new collection of an anonymous type with the addition of a new member, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. It uses the \<xref:System.Linq.Enumerable.Aggregate*> standard query operator to concatenate multiple strings into one string.  
  
 This technique (that is, first projecting to a collection of an anonymous type, then using this collection to project to a new collection of an anonymous type) is a common and useful idiom. This query could have been written without projecting to the first anonymous type. However, because of lazy evaluation, doing so does not use much additional processing power. The idiom creates more short lived objects on the heap, but this does not substantially degrade performance.  
  
 Of course, it would be possible to write a single query that contains the functionality to retrieve the paragraphs, the style of each paragraph, and the text of each paragraph. However, it often is useful to break up a more complicated query into multiple queries because the resulting code is more modular and easier to maintain. Furthermore, if you need to reuse a portion of the query, it is easier to refactor if the queries are written in this manner.  
  
 These queries, which are chained together, use the processing model that is examined in detail in the topic [Tutorial: Deferred Execution (Visual Basic)](../vs140/tutorial--deferred-execution--visual-basic-.md).  
  
## Example  
 This example processes a WordprocessingML document, determining the element node, the style name, and the text of each paragraph. This example builds on the previous examples in this tutorial. The new query is called out in comments in the code below.  
  
 For instructions for creating the source document for this example, see [Creating the Source Office Open XML Document (Visual Basic)](../vs140/creating-the-source-office-open-xml-document--visual-basic-.md).  
  
 This example uses classes from the WindowsBase assembly. It uses types in the \<xref:System.IO.Packaging*?displayProperty=fullName> namespace.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output when applied to the document described in [Creating the Source Office Open XML Document (Visual Basic)](../vs140/creating-the-source-office-open-xml-document--visual-basic-.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Next Steps  
 The next example shows how to use an extension method, instead of \<xref:System.Linq.Enumerable.Aggregate*>, to concatenate multiple strings into a single string.  
  
-   [Refactoring Using an Extension Method (Visual Basic)](../vs140/refactoring-using-an-extension-method--visual-basic-.md)  
  
## See Also  
 [Tutorial: Manipulating Content in a WordprocessingML Document (Visual Basic)](../vs140/tutorial--manipulating-content-in-a-wordprocessingml-document--visual-basic-.md)   
 [Deferred Execution and Lazy Evaluation in LINQ to XML (Visual Basic)](../vs140/deferred-execution-and-lazy-evaluation-in-linq-to-xml--visual-basic-.md)