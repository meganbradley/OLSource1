---
title: "How to: Validate Strings That Represent Dates or Times (Visual Basic)"
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
  - "strings [Visual Basic], validating"
  - "String data type, validation"
ms.assetid: ae7d4b29-3436-4032-bdbf-4650eb1c8e19
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Validate Strings That Represent Dates or Times (Visual Basic)
The following code example sets a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> value that indicates whether a string represents a valid date or time.  
  
## Example  
 [!code[VbVbcnRegEx#2](../vs140/codesnippet/VisualBasic/how-to--validate-strings-that-represent-dates-or-times--visual-basic-_1.vb)]  
  
## Compiling the Code  
 Replace <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> with the date and time you want to validate. You can replace the string with another hard-coded string, with a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variable, or with a method that returns a string, such as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Robust Programming  
 Use this method to validate the string before trying to convert the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> variable. By checking the date or time first, you can avoid generating an exception at run time.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Information.IsDate*>   
 \<xref:Microsoft.VisualBasic.Interaction.InputBox*>   
 [Validating Strings in Visual Basic](../vs140/validating-strings-in-visual-basic.md)