---
title: "Unable to read delimited fields because a double quote is not a legal delimiter when EscapeQuotes is set to True"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbrTextFieldParser_IllegalDelimiter"
ms.assetid: ab8a0c3a-b89c-4617-9e31-7e81f5dca433
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unable to read delimited fields because a double quote is not a legal delimiter when EscapeQuotes is set to True
The `TextFieldParser` cannot read from the file because a quotation mark (") has been supplied as the delimiter and `EscapeQuotes` is set to `True`.  
  
### To correct this error  
  
-   Set `EscapeQuotes` to `False`.  
  
## See Also  
 [TextFieldParser.SetDelimiters Method](assetId:///21fa40ec-5866-4d0e-9fd9-c708a190dcc9)   
 [TextFieldParser.Delimiters Property](assetId:///4eb18f4d-3011-40a9-b668-be93eed0444f)   
 [How to: Read From Comma-Delimited Text Files in Visual Basic](../vs140/how-to--read-from-comma-delimited-text-files-in-visual-basic.md)   
 [TextFieldParser Object](../vs140/textfieldparser-object.md)