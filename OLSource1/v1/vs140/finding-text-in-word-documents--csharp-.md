---
title: "Finding Text in Word Documents (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 82f86677-560b-49dc-a089-610409939b2a
caps.latest.revision: 7
---
# Finding Text in Word Documents (C#)
This topic extends the previous queries to do something useful: find all occurrences of a string in the document.  
  
## Example  
 This example processes a WordprocessingML document, to find all the occurences of a specific piece of text in the document. To do this, we use a query that finds the string "Hello". This example builds on the previous examples in this tutorial. The new query is called out in comments in the code below.  
  
 For instructions for creating the source document for this example, see [Creating the Source Office Open XML Document (C#)](../vs140/creating-the-source-office-open-xml-document--csharp-.md).  
  
 This example uses classes found in the WindowsBase assembly. It uses types in the \<xref:System.IO.Packaging*?displayProperty=fullName> namespace.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can, of course, modify the search so that it searches for lines with a specific style. The following query finds all blank lines that have the Code style:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Of course, this example could be enhanced in a number of ways. For example, we could use regular expressions to search for text, we could iterate through all the Word files in a particular directory, and so on.  
  
 Note that this example performs approximately as well as if it were written as a single query. Because each query is implemented in a lazy, deferred fashion, each query does not yield its results until the query is iterated. For more information about execution and lazy evaluation, see [Deferred Execution and Lazy Evaluation in LINQ to XML (C#)](../vs140/deferred-execution-and-lazy-evaluation-in-linq-to-xml--csharp-.md).  
  
## Next Steps  
 The next section provides more information about WordprocessingML documents:  
  
-   [Details of Office Open XML WordprocessingML Documents (C#)](../vs140/details-of-office-open-xml-wordprocessingml-documents--csharp-.md)  
  
## See Also  
 [Tutorial: Manipulating Content in a WordprocessingML Document (C#)](../vs140/tutorial--manipulating-content-in-a-wordprocessingml-document--csharp-.md)   
 [Refactoring Using a Pure Function (C#)](../vs140/refactoring-using-a-pure-function--csharp-.md)   
 [Deferred Execution and Lazy Evaluation in LINQ to XML (C#)](../vs140/deferred-execution-and-lazy-evaluation-in-linq-to-xml--csharp-.md)