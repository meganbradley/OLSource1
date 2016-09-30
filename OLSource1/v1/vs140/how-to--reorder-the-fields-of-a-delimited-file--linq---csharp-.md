---
title: "How to: Reorder the Fields of a Delimited File (LINQ) (C#)"
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
ms.assetid: 4e62d82c-61b7-4f18-b9a1-86723746d7d2
caps.latest.revision: 7
---
# How to: Reorder the Fields of a Delimited File (LINQ) (C#)
A comma-separated value (CSV) file is a text file that is often used to store spreadsheet data or other tabular data that is represented by rows and columns. By using the \<xref:System.String.Split*> method to separate the fields, it is very easy to query and manipulate CSV files by using LINQ. In fact, the same technique can be used to reorder the parts of any structured line of text; it is not limited to CSV files.  
  
 In the following example, assume that the three columns represent students' "last name," "first name", and "ID." The fields are in alphabetical order based on the students' last names. The query produces a new sequence in which the ID column appears first, followed by a second column that combines the student's first name and last name. The lines are reordered according to the ID field. The results are saved into a new file and the original data is not modified.  
  
### To create the data file  
  
1.  Copy the following lines into a plain text file that is named spreadsheet1.csv. Save the file in your project folder.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Compiling the Code  
 Create a project that targets the .NET Framework  version 3.5 or higher, with a reference to System.Core.dll and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directives for the System.Linq and System.IO namespaces.  
  
## See Also  
 [LINQ and Strings (C#)](../vs140/linq-and-strings--csharp-.md)   
 [LINQ and File Directories (C#)](../vs140/linq-and-file-directories--csharp-.md)   
 [How to: Generate XML from CSV Files](../vs140/how-to--generate-xml-from-csv-files.md)