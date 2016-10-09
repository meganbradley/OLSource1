---
title: "How to: Read From Comma-Delimited Text Files in Visual Basic"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "files, parsing"
  - "text files, tasks"
  - "reading text files, comma-delimited"
  - "text files, reading"
ms.assetid: a8413fe4-0dba-49c8-8692-44fb67a9ec4f
caps.latest.revision: 19
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Read From Comma-Delimited Text Files in Visual Basic
The `TextFieldParser` object provides a way to easily and efficiently parse structured text files, such as logs. The `TextFieldType` property defines whether it is a delimited file or one with fixed-width fields of text.  
  
### To parse a comma delimited text file  
  
1.  Create a new `TextFieldParser`. The following code creates the `TextFieldParser` named `MyReader` and opens the file `test.txt`.  
  
     [!code[VbFileIORead#15](../VS_visualbasic/codesnippet/VisualBasic/how-to--read-from-comma-delimited-text-files-in-visual-basic_1.vb)]  
  
2.  Define the `TextField` type and delimiter. The following code defines the `TextFieldType` property as `Delimited` and the delimiter as ",".  
  
     [!code[VbFileIORead#16](../VS_visualbasic/codesnippet/VisualBasic/how-to--read-from-comma-delimited-text-files-in-visual-basic_2.vb)]  
  
3.  Loop through the fields in the file. If any lines are corrupt, report an error and continue parsing. The following code loops through the file, displaying each field in turn and reporting any fields that are formatted incorrectly.  
  
     [!code[VbFileIORead#17](../VS_visualbasic/codesnippet/VisualBasic/how-to--read-from-comma-delimited-text-files-in-visual-basic_3.vb)]  
  
4.  Close the `While` and `Using` blocks with `End While` and `End Using`.  
  
     [!code[VbFileIORead#18](../VS_visualbasic/codesnippet/VisualBasic/how-to--read-from-comma-delimited-text-files-in-visual-basic_4.vb)]  
  
## Example  
 This example reads from the file `test.txt`.  
  
 [!code[VbFileIORead#19](../VS_visualbasic/codesnippet/VisualBasic/how-to--read-from-comma-delimited-text-files-in-visual-basic_5.vb)]  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   A row cannot be parsed using the specified format (\<xref:Microsoft.VisualBasic.FileIO.MalformedLineException>). The exception message specifies the line causing the exception, while the \<xref:Microsoft.VisualBasic.FileIO.TextFieldParser.ErrorLine*> property is assigned the text contained in the line.  
  
-   The specified file does not exist (\<xref:System.IO.FileNotFoundException>).  
  
-   A partial-trust situation in which the user does not have sufficient permissions to access the file. (\<xref:System.Security.SecurityException>).  
  
-   The path is too long (\<xref:System.IO.PathTooLongException>).  
  
-   The user does not have sufficient permissions to access the file (\<xref:System.UnauthorizedAccessException>).  
  
## See Also  
 \<xref:Microsoft.VisualBasic.FileIO.TextFieldParser?displayProperty=fullName>   
 [How to: Read From Fixed-width Text Files](../VS_visualbasic/how-to--read-from-fixed-width-text-files-in-visual-basic.md)   
 [How to: Read From Text Files with Multiple Formats](../VS_visualbasic/how-to--read-from-text-files-with-multiple-formats-in-visual-basic.md)   
 [Parsing Text Files with the TextFieldParser Object](../VS_visualbasic/parsing-text-files-with-the-textfieldparser-object--visual-basic-.md)   
 [Walkthrough: Manipulating Files and Directories in Visual Basic](../VS_visualbasic/walkthrough--manipulating-files-and-directories-in-visual-basic.md)   
 [Troubleshooting: Reading from and Writing to Text Files](../VS_visualbasic/troubleshooting--reading-from-and-writing-to-text-files--visual-basic-.md)   
 [Troubleshooting Exceptions: Microsoft.VisualBasic.FileIO.TextFieldParser.MalformedLineException](../Topic/Troubleshooting%20Exceptions:%20Microsoft.VisualBasic.FileIO.TextFieldParser.MalformedLineException.md)