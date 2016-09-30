---
title: "How to: Query for Sentences that Contain a Specified Set of Words (LINQ) (C#)"
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
ms.assetid: 0724b429-4b87-4d26-a7b1-409358f3fc20
caps.latest.revision: 7
---
# How to: Query for Sentences that Contain a Specified Set of Words (LINQ) (C#)
This example shows how to find sentences in a text file that contain matches for each of a specified set of words. Although the array of search terms is hard-coded in this example, it could also be populated dynamically at runtime. In this example, the query returns the sentences that contain the words "Historically," "data," and "integrated."  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The query works by first splitting the text into sentences, and then splitting the sentences into an array of strings that hold each word. For each of these arrays, the \<xref:System.Linq.Enumerable.Distinct*> method removes all duplicate words, and then the query performs an \<xref:System.Linq.Enumerable.Intersect*> operation on the word array and the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> array. If the count of the intersection is the same as the count of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> array, all words were found in the words and the original sentence is returned.  
  
 In the call to \<xref:System.String.Split*>, the punctuation marks are used as separators in order to remove them from the string. If you did not do this, for example you could have a string "Historically," that would not match "Historically" in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array. You may have to use additional separators, depending on the types of punctuation found in the source text.  
  
## Compiling the Code  
 Create a project that targets the .NET Framework  version 3.5 or higher, with a reference to System.Core.dll and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directives for the System.Linq and System.IO namespaces.  
  
## See Also  
 [LINQ and Strings (C#)](../vs140/linq-and-strings--csharp-.md)