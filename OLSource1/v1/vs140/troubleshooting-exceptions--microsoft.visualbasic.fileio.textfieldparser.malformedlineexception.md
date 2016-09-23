---
title: "Troubleshooting Exceptions: Microsoft.VisualBasic.FileIO.TextFieldParser.MalformedLineException"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - JScript
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - Microsoft.VisualStudio.Tools.Applications.Runtime.ControlNotFoundException exception
ms.assetid: d780b8cc-c3f1-45ed-8f8e-3f8728a4b770
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Troubleshooting Exceptions: Microsoft.VisualBasic.FileIO.TextFieldParser.MalformedLineException
A <xref:Microsoft.VisualBasic.FileIO.MalformedLineException?qualifyHint=False> exception is thrown when a <xref:Microsoft.VisualBasic.FileIO.TextFieldParser?qualifyHint=False> cannot parse a row using the specified format.  
  
 The `Error Line` property of the exception object contains the text of the line causing the error.  
  
## Associated Tips  
 **Check to ensure the TextFieldType and Delimiter parameters are defined properly**  
 The `TextFieldType` (delimited or fixed-width) must match the format of the file. If the `TextFieldType` is `FixedWidth`, check that the `FieldWidths` property has been set correctly. If the `TextFieldType` is `Delimited`, check that the `Delimiters` property has been set correctly.  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileIO.MalformedLineException?qualifyHint=False>   
 [Parsing Text Files with the TextFieldParser Object](../vs140/parsing-text-files-with-the-textfieldparser-object--visual-basic-.md)   
 [How to: Read From a Comma-Delimited Text File in Visual Basic](../vs140/how-to--read-from-comma-delimited-text-files-in-visual-basic.md)   
 [How to: Read From a Fixed-width Text File in Visual Basic](../vs140/how-to--read-from-fixed-width-text-files-in-visual-basic.md)