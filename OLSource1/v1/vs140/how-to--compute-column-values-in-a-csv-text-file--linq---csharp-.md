---
title: "How to: Compute Column Values in a CSV Text File (LINQ) (C#)"
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
ms.assetid: 4747f37a-a198-4df2-8efe-5b0731e0ea27
caps.latest.revision: 7
---
# How to: Compute Column Values in a CSV Text File (LINQ) (C#)
This example shows how to perform aggregate computations such as Sum, Average, Min, and Max on the columns of a .csv file. The example principles that are shown here can be applied to other types of structured text.  
  
### To create the source file  
  
1.  Copy the following lines into a file that is named scores.csv and save it in your project folder. Assume that the first column represents a student ID, and subsequent columns represent scores from four exams.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The query works by using the \<xref:System.String.Split*> method to convert each line of text into an array. Each array element represents a column. Finally, the text in each column is converted to its numeric representation. If your file is a tab-separated file, just update the argument in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Compiling the Code  
 Create a project that targets the .NET Framework  version 3.5 or higher, with a reference to System.Core.dll and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directives for the System.Linq and System.IO namespaces.  
  
## See Also  
 [LINQ and Strings (C#)](../vs140/linq-and-strings--csharp-.md)   
 [LINQ and File Directories (C#)](../vs140/linq-and-file-directories--csharp-.md)