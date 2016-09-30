---
title: "Compiler Error C3345"
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
  - "C3345"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3345"
ms.assetid: 1dda4c79-73bb-441b-b939-746154c3afba
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3345
'identifier': invalid identifier for module name  
  
 The *identifier* for a module contains one or more unacceptable characters. An identifier is valid if the first character is an alphabetical, underscore, or high ANSI (0x80-FF) character, and any subsequent character is an alphanumeric, underscore, or high ANSI character.  
  
### To correct this error  
  
1.  Ensure that *identifier* does not contain blanks or other unacceptable characters.  
  
## Example  
 The following code example causes error message C3345 because the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute contains a blank.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [__iscsym](../vs140/944dfb99-f2b8-498c-9f55-dbcf370d0a2c.md)   
 [Character Classification](../vs140/character-classification.md)   
 [module (C++)](../vs140/module--c---.md)