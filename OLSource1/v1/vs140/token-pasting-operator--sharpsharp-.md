---
title: "Token-Pasting Operator (##)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "##"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "preprocessor, operators"
  - "## preprocessor operator"
ms.assetid: 4f173503-990f-4bff-aef3-ec4d1f1458ef
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Token-Pasting Operator (##)
The double-number-sign or "token-pasting" operator (**##**), which is sometimes called the "merging" operator, is used in both object-like and function-like macros. It permits separate tokens to be joined into a single token and therefore cannot be the first or last token in the macro definition.  
  
 If a formal parameter in a macro definition is preceded or followed by the token-pasting operator, the formal parameter is immediately replaced by the unexpanded actual argument. Macro expansion is not performed on the argument prior to replacement.  
  
 Then, each occurrence of the token-pasting operator in *token-string* is removed, and the tokens preceding and following it are concatenated. The resulting token must be a valid token. If it is, the token is scanned for possible replacement if it represents a macro name. The identifier represents the name by which the concatenated tokens will be known in the program before replacement. Each token represents a token defined elsewhere, either within the program or on the compiler command line. White space preceding or following the operator is optional.  
  
 This example illustrates use of both the stringizing and token-pasting operators in specifying program output:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If a macro is called with a numeric argument like  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 the macro yields  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 which becomes  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **token9 = 9**   
## See Also  
 [Preprocessor Operators](../vs140/preprocessor-operators.md)