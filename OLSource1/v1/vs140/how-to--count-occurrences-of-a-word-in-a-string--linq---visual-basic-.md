---
title: "How to: Count Occurrences of a Word in a String (LINQ) (Visual Basic)"
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
ms.assetid: bc367e46-f7cc-45f9-936f-754e661b7bb9
caps.latest.revision: 8
---
# How to: Count Occurrences of a Word in a String (LINQ) (Visual Basic)
This example shows how to use a LINQ query to count the occurrences of a specified word in a string. Note that to perform the count, first the \<xref:System.String.Split*> method is called to create an array of words. There is a performance cost to the \<xref:System.String.Split*> method. If the only operation on the string is to count the words, you should consider using the \<xref:System.Text.RegularExpressions.Regex.Matches*> or \<xref:System.String.IndexOf*> methods instead. However, if performance is not a critical issue, or you have already split the sentence in order to perform other types of queries over it, then it makes sense to use LINQ to count the words or phrases as well.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Compiling the Code  
 Create a project that targets the .NET Framework version 3.5 or higher with a reference to System.Core.dll and a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement for the System.Linq namespace.  
  
## See Also  
 [LINQ and Strings (Visual Basic)](../vs140/linq-and-strings--visual-basic-.md)