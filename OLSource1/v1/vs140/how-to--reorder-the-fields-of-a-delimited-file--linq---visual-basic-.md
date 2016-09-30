---
title: "How to: Reorder the Fields of a Delimited File (LINQ) (Visual Basic)"
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
ms.assetid: c451c7db-663b-4daf-b8ba-a2093095d672
caps.latest.revision: 7
---
# How to: Reorder the Fields of a Delimited File (LINQ) (Visual Basic)
A comma-separated value (CSV) file is a text file that is often used to store spreadsheet data or other tabular data that is represented by rows and columns. By using the \<xref:System.String.Split*> method to separate the fields, it is very easy to query and manipulate CSV files by using LINQ. In fact, the same technique can be used to reorder the parts of any structured line of text; it is not limited to CSV files.  
  
 In the following example, assume that the three columns represent students' "last name," "first name", and "ID." The fields are in alphabetical order based on the students' last names. The query produces a new sequence in which the ID column appears first, followed by a second column that combines the student's first name and last name. The lines are reordered according to the ID field. The results are saved into a new file and the original data is not modified.  
  
### To create the data file  
  
1.  Copy the following lines into a plain text file that is named spreadsheet1.csv. Save the file in your project folder.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Compiling the Code  
  
## See Also  
 [LINQ and Strings (Visual Basic)](../vs140/linq-and-strings--visual-basic-.md)   
 [LINQ and File Directories (Visual Basic)](../vs140/linq-and-file-directories--visual-basic-.md)   
 [How to: Generate XML from CSV Files](../vs140/how-to--generate-xml-from-csv-files.md)