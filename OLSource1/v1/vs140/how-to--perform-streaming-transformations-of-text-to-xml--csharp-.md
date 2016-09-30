---
title: "How to: Perform Streaming Transformations of Text to XML (C#)"
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
ms.assetid: 9b3bd941-d0ff-4f2d-ae41-7c3b81d8fae6
caps.latest.revision: 7
---
# How to: Perform Streaming Transformations of Text to XML (C#)
One approach to processing a text file is to write an extension method that streams the text file a line at a time using the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> construct. You then can write a LINQ query that processes the text file in a lazy deferred fashion. If you then use \<xref:System.Xml.Linq.XStreamingElement*> to stream output, you then can create a transformation from the text file to XML that uses a minimal amount of memory, regardless of the size of the source text file.  
  
 There are some caveats regarding streaming transformations. A streaming transformation is best applied in situations where you can process the entire file once, and if you can process the lines in the order that they occur in the source document. If you have to process the file more than once, or if you have to sort the lines before you can process them, you will lose many of the benefits of using a streaming technique.  
  
## Example  
 The following text file, People.txt, is the source for this example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following code contains an extension method that streams the lines of the text file in a deferred fashion.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Xml.Linq.XStreamingElement*>   
 [Advanced Query Techniques (LINQ to XML) (C#)](../vs140/advanced-query-techniques--linq-to-xml---csharp-.md)