---
title: "How to: Join Content from Dissimilar Files (LINQ) (Visual Basic)"
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
ms.assetid: e7530857-c467-41ea-9730-84e6b1065a4d
caps.latest.revision: 7
---
# How to: Join Content from Dissimilar Files (LINQ) (Visual Basic)
This example shows how to join data from two comma-delimited files that share a common value that is used as a matching key. This technique can be useful if you have to combine data from two spreadsheets, or from a spreadsheet and from a file that has another format, into a new file. You can modify the example to work with any kind of structured text.  
  
### To create the data files  
  
1.  Copy the following lines into a file that is named scores.csv and save it to your project folder. The file represents spreadsheet data. Column 1 is the student's ID, and columns 2 through 5 are test scores.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Copy the following lines into a file that is named names.csv and save it to your project folder. The file represents a spreadsheet that contains the student's last name, first name, and student ID.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Compiling the Code  
 Create a project that targets the .NET Framework version 3.5 or higher with a reference to System.Core.dll and a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement for the System.Linq namespace.  
  
## See Also  
 [LINQ and Strings (Visual Basic)](../vs140/linq-and-strings--visual-basic-.md)   
 [LINQ and File Directories (Visual Basic)](../vs140/linq-and-file-directories--visual-basic-.md)