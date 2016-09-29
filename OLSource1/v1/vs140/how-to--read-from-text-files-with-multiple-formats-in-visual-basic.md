---
title: "How to: Read From Text Files with Multiple Formats in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
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
  - "TextFieldParser object, reading from a file"
  - "TextFieldType enumeration"
  - "My.Computer.FileSystem.WriteAllText method, parsing structured text files"
  - "WriteAllText method, parsing structured text files"
  - "PeekChars method, determining format of text"
  - "reading text files, multiple formats"
  - "I/O [Visual Basic], reading text files"
  - "text files, reading"
ms.assetid: 8d185eb2-79ca-42cd-95a7-d3ff44a5a0f8
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Read From Text Files with Multiple Formats in Visual Basic
The <xref:Microsoft.VisualBasic.FileIO.TextFieldParser*> object provides a way to easily and efficiently parse structured text files, such as logs. You can process a file with multiple formats by using the `PeekChars` method to determine the format of each line as you parse through the file.  
  
### To parse a text file with multiple formats  
  
1.  Add a text file named testfile.txt to your project. Add the following content to the text file.  
  
    ```  
    Err  1001 Cannot access resource.  
    Err  2014 Resource not found.  
    Acc  10/03/2009User1      Administrator.  
    Err  0323 Warning: Invalid access attempt.  
    Acc  10/03/2009User2      Standard user.  
    Acc  10/04/2009User2      Standard user.  
    ```  
  
2.  Define the expected format and the format used when an error is reported. The last entry in each array is -1, therefore the last field is assumed to be of variable width. This occurs when the last entry in the array is less than or equal to 0.  
  
     [!code[VbFileIORead#4](../vs140/codesnippet/VisualBasic/how-to--read-from-text-files-with-multiple-formats-in-visual-basic_1.vb)]  
  
3.  Create a new <xref:Microsoft.VisualBasic.FileIO.TextFieldParser*> object, defining the width and format.  
  
     [!code[VbFileIORead#5](../vs140/codesnippet/VisualBasic/how-to--read-from-text-files-with-multiple-formats-in-visual-basic_2.vb)]  
  
4.  Loop through the rows, testing for format before reading.  
  
     [!code[VbFileIORead#6](../vs140/codesnippet/VisualBasic/how-to--read-from-text-files-with-multiple-formats-in-visual-basic_3.vb)]  
  
5.  Write errors to the console.  
  
     [!code[VbFileIORead#7](../vs140/codesnippet/VisualBasic/how-to--read-from-text-files-with-multiple-formats-in-visual-basic_4.vb)]  
  
## Example  
 Following is the complete example that reads from the file `testfile.txt`.  
  
 [!code[VbFileIORead#8](../vs140/codesnippet/VisualBasic/how-to--read-from-text-files-with-multiple-formats-in-visual-basic_5.vb)]  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   A row cannot be parsed using the specified format (<xref:Microsoft.VisualBasic.FileIO.MalformedLineException*>). The exception message specifies the line causing the exception, while the <xref:Microsoft.VisualBasic.FileIO.TextFieldParser.ErrorLine*> property is assigned to the text contained in the line.  
  
-   The specified file does not exist (<xref:System.IO.FileNotFoundException*>).  
  
-   A partial-trust situation in which the user does not have sufficient permissions to access the file. (<xref:System.Security.SecurityException*>).  
  
-   The path is too long (<xref:System.IO.PathTooLongException*>).  
  
-   The user does not have sufficient permissions to access the file (<xref:System.UnauthorizedAccessException*>).  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileIO.TextFieldParser*?displayProperty=fullName>   
 <xref:Microsoft.VisualBasic.FileIO.TextFieldParser.PeekChars*>   
 <xref:Microsoft.VisualBasic.FileIO.MalformedLineException*>   
 <xref:Microsoft.VisualBasic.FileIO.FileSystem.WriteAllText*>   
 <xref:Microsoft.VisualBasic.FileIO.TextFieldParser.EndOfData*>   
 <xref:Microsoft.VisualBasic.FileIO.TextFieldParser.TextFieldType*>   
 [How to: Read From a Comma-Delimited Text File in Visual Basic](../vs140/how-to--read-from-comma-delimited-text-files-in-visual-basic.md)   
 [How to: Read From a Fixed-width Text File in Visual Basic](../vs140/how-to--read-from-fixed-width-text-files-in-visual-basic.md)   
 [Parsing Text Files with the TextFieldParser Object](../vs140/parsing-text-files-with-the-textfieldparser-object--visual-basic-.md)