---
title: "A double quote is not a valid comment token for delimited fields where EscapeQuote is set to True"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbrTextFieldParser_InvalidComment"
dev_langs: 
  - "VB"
ms.assetid: 636d4b81-00ba-4cfd-98f7-4d57036f494d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A double quote is not a valid comment token for delimited fields where EscapeQuote is set to True
A quotation mark has been supplied as the delimiter for the `TextFieldParser`, but `EscapeQuotes` is set to `True`.  
  
### To correct this error  
  
-   Set `EscapeQuotes` to `False`.  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileIO.TextFieldParser.SetDelimiters*>   
 <xref:Microsoft.VisualBasic.FileIO.TextFieldParser.Delimiters*>   
 <xref:Microsoft.VisualBasic.FileIO.TextFieldParser*>   
 [How to: Read From Comma-Delimited Text Files in Visual Basic](../vs140/how-to--read-from-comma-delimited-text-files-in-visual-basic.md)