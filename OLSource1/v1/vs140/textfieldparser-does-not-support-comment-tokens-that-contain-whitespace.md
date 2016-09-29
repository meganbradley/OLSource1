---
title: "TextFieldParser does not support comment tokens that contain whitespace"
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
  - "vbrTextFieldParser_WhitespaceInToken"
ms.assetid: 55107656-270e-4bbb-841a-478904df8e07
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TextFieldParser does not support comment tokens that contain whitespace
A comment token that contains white space has been supplied. The `TextFieldParser` does not support comment tokens that contain white space unless the white space occurs at the beginning of the token. White space occurring at the beginning of a token is ignored.  
  
### To correct this error  
  
-   Supply a correct comment token.  
  
## See Also  
 [TextFieldParser.CommentTokens Property](assetId:///2e6b6435-4bee-4c14-a353-e8f2c82e2d61)   
 [Parsing Text Files with the TextFieldParser Object](../vs140/parsing-text-files-with-the-textfieldparser-object--visual-basic-.md)   
 [TextFieldParser Object](../vs140/textfieldparser-object.md)