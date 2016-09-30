---
title: "How to: Count Occurrences of a Word in a String (LINQ) (C#)"
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
ms.assetid: f8e6f546-7c14-4aa1-8a75-e8d09f3b8ccd
caps.latest.revision: 8
---
# How to: Count Occurrences of a Word in a String (LINQ) (C#)
This example shows how to use a LINQ query to count the occurrences of a specified word in a string. Note that to perform the count, first the \<xref:System.String.Split*> method is called to create an array of words. There is a performance cost to the \<xref:System.String.Split*> method. If the only operation on the string is to count the words, you should consider using the \<xref:System.Text.RegularExpressions.Regex.Matches*> or \<xref:System.String.IndexOf*> methods instead. However, if performance is not a critical issue, or you have already split the sentence in order to perform other types of queries over it, then it makes sense to use LINQ to count the words or phrases as well.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Compiling the Code  
 Create a project that targets the .NET Framework  version 3.5 or higher, with a reference to System.Core.dll and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directives for the System.Linq and System.IO namespaces.  
  
## See Also  
 [LINQ and Strings (C#)](../vs140/linq-and-strings--csharp-.md)