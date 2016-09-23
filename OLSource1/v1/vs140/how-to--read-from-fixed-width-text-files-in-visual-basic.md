---
title: "How to: Read From Fixed-width Text Files in Visual Basic"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - fixed-width text file
  - reading text files, fixed-width
  - files, parsing
  - text files, tasks
  - text files, reading
ms.assetid: 99be5692-967a-4e85-993e-cd18139a5a69
caps.latest.revision: 28
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Read From Fixed-width Text Files in Visual Basic
The `TextFieldParser` object provides a way to easily and efficiently parse structured text files, such as logs.  
  
 The `TextFieldType` property defines whether the parsed file is a delimited file or one that has fixed-width fields of text. In a fixed-width text file, the field at the end can have a variable width. To specify that the field at the end has a variable width, define it to have a width less than or equal to zero.  
  
### To parse a fixed-width text file  
  
1.  Create a new `TextFieldParser`. The following code creates the `TextFieldParser` named `Reader` and opens the file `test.log`.  
  
     [!code[VbFileIORead#9](../vs140/codesnippet/VisualBasic/how-to--read-from-fixed-width-text-files-in-visual-basic_1.vb)]
  
  
2.  Define the `TextFieldType` property as `FixedWidth`, defining the width and format. The following code defines the columns of text; the first is 5 characters wide, the second 10, the third 11, and the fourth is of variable width.  
  
     [!code[VbFileIORead#10](../vs140/codesnippet/VisualBasic/how-to--read-from-fixed-width-text-files-in-visual-basic_2.vb)]
  
  
3.  Loop through the fields in the file. If any lines are corrupted, report an error and continue parsing.  
  
     [!code[VbFileIORead#11](../vs140/codesnippet/VisualBasic/how-to--read-from-fixed-width-text-files-in-visual-basic_3.vb)]
  
  
4.  Close the `While` and `Using` blocks with `End While` and `End Using`.  
  
     [!code[VbFileIORead#12](../vs140/codesnippet/VisualBasic/how-to--read-from-fixed-width-text-files-in-visual-basic_4.vb)]
  
  
## Example  
 This example reads from the file `test.log`.  
  
 [!code[VbFileIORead#13](../vs140/codesnippet/VisualBasic/how-to--read-from-fixed-width-text-files-in-visual-basic_5.vb)]
  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   A row cannot be parsed using the specified format (<xref:Microsoft.VisualBasic.FileIO.MalformedLineException?qualifyHint=False>). The exception message specifies the line causing the exception, while the <xref:Microsoft.VisualBasic.FileIO.TextFieldParser.ErrorLine?qualifyHint=False> property is assigned to the text contained in the line.  
  
-   The specified file does not exist (<xref:System.IO.FileNotFoundException?qualifyHint=False>).  
  
-   A partial-trust situation in which the user does not have sufficient permissions to access the file. (<xref:System.Security.SecurityException?qualifyHint=False>).  
  
-   The path is too long (<xref:System.IO.PathTooLongException?qualifyHint=False>).  
  
-   The user does not have sufficient permissions to access the file (<xref:System.UnauthorizedAccessException?qualifyHint=False>).  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileIO.TextFieldParser?qualifyHint=True>   
 [How to: Read From a Comma-Delimited Text File in Visual Basic](../vs140/how-to--read-from-comma-delimited-text-files-in-visual-basic.md)   
 [How to: Read From a Text File with Multiple Formats in Visual Basic](../vs140/how-to--read-from-text-files-with-multiple-formats-in-visual-basic.md)   
 [Parsing Text Files with the TextFieldParser Object](../vs140/parsing-text-files-with-the-textfieldparser-object--visual-basic-.md)   
 [Walkthrough: Manipulating Files and Directories in Visual Basic](../vs140/walkthrough--manipulating-files-and-directories-in-visual-basic.md)   
 [Troubleshooting: Reading from and Writing to Text Files](../vs140/troubleshooting--reading-from-and-writing-to-text-files--visual-basic-.md)   
 [Troubleshooting Exceptions: Microsoft.VisualBasic.FileIO.TextFieldParser.MalformedLineException](../vs140/troubleshooting-exceptions--microsoft.visualbasic.fileio.textfieldparser.malformedlineexception.md)