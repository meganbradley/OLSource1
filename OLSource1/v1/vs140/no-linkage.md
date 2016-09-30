---
title: "No Linkage"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "no linkage"
  - "linkage [C++], none"
ms.assetid: 5a413082-1034-4e04-b76b-8d14668bf434
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# No Linkage
If a declaration for an identifier within a block does not include the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> storage-class specifier, the identifier has no linkage and is unique to the function.  
  
 The following identifiers have no linkage:  
  
-   An identifier declared to be anything other than an object or a function  
  
-   An identifier declared to be a function parameter  
  
-   A block-scope identifier for an object declared without the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> storage-class specifier  
  
 If an identifier has no linkage, declaring the same name again (in a declarator or type specifier) in the same scope level generates a symbol redefinition error.  
  
## See Also  
 [Using extern to Specify Linkage](../vs140/using-extern-to-specify-linkage.md)