---
title: "Finding Text in Word Documents (Visual Basic)"
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
ms.assetid: eea9819b-a78a-4552-bf13-8837fc0e7a37
caps.latest.revision: 6
---
# Finding Text in Word Documents (Visual Basic)
This topic extends the previous queries to do something useful: find all occurrences of a string in the document.  
  
## Example  
 This example processes a WordprocessingML document, to find all the occurences of a specific piece of text in the document. To do this, we use a query that finds the string "Hello". This example builds on the previous examples in this tutorial. The new query is called out in comments in the code below.  
  
 For instructions for creating the source document for this example, see [Creating the Source Office Open XML Document (Visual Basic)](../vs140/creating-the-source-office-open-xml-document--visual-basic-.md).  
  
 This example uses classes found in the WindowsBase assembly. It uses types in the \<xref:System.IO.Packaging*?displayProperty=fullName> namespace.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can, of course, modify the search so that it searches for lines with a specific style. The following query finds all blank lines that have the Code style:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Of course, this example could be enhanced in a number of ways. For example, we could use regular expressions to search for text, we could iterate through all the Word files in a particular directory, and so on.  
  
 Note that this example performs approximately as well as if it were written as a single query. Because each query is implemented in a lazy, deferred fashion, each query does not yield its results until the query is iterated. For more information about execution and lazy evaluation, see [Deferred Execution and Lazy Evaluation in LINQ to XML (Visual Basic)](../vs140/deferred-execution-and-lazy-evaluation-in-linq-to-xml--visual-basic-.md).  
  
## Next Steps  
 The next section provides more information about WordprocessingML documents:  
  
-   [Details of Office Open XML WordprocessingML Documents (Visual Basic)](../vs140/details-of-office-open-xml-wordprocessingml-documents--visual-basic-.md)  
  
## See Also  
 [Tutorial: Manipulating Content in a WordprocessingML Document (Visual Basic)](../vs140/tutorial--manipulating-content-in-a-wordprocessingml-document--visual-basic-.md)   
 [Refactoring Using a Pure Function (Visual Basic)](../vs140/refactoring-using-a-pure-function--visual-basic-.md)   
 [Deferred Execution and Lazy Evaluation in LINQ to XML (Visual Basic)](../vs140/deferred-execution-and-lazy-evaluation-in-linq-to-xml--visual-basic-.md)