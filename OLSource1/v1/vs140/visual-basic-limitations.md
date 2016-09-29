---
title: "Visual Basic Limitations"
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
  - "limits"
  - "limitations, Visual Basic"
  - "limitations"
  - "limits, Visual Basic code"
  - "Visual Basic code, limitations"
ms.assetid: cf1646b7-5d24-48c6-9616-bda8a4849d91
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Visual Basic Limitations
Earlier versions of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] enforced boundaries in code, such as the length of variable names, the number of variables allowed in modules, and module size. In [!INCLUDE[vbprvblong](../vs140/includes/vbprvblong_md.md)], these restrictions have been relaxed, giving you greater freedom in writing and arranging your code.  
  
 Physical limits are dependent more on run-time memory than on compile-time considerations. If you use prudent programming practices, and divide large applications into multiple classes and modules, then there is very little chance of encountering an internal [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] limitation.  
  
 The following are some limitations that you might encounter in extreme cases:  
  
-   **Name Length.** There is a maximum number of characters for the name of every declared programming element. This maximum applies to an entire qualification string if the element name is qualified. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
-   **Line Length.** There is a maximum of 65535 characters in a physical line of source code. The logical source code line can be longer if you use line continuation characters. See [How to: Break and Combine Statements in Code](../vs140/how-to--break-and-combine-statements-in-code--visual-basic-.md).  
  
-   **Array Dimensions.** There is a maximum number of dimensions you can declare for an array. This limits how many indexes you can use to specify an array element. See [Array Dimensions in Visual Basic](../vs140/array-dimensions-in-visual-basic.md).  
  
-   **String Length.** There is a maximum number of Unicode characters you can store in a single string. See [String Data Type (Visual Basic)](../vs140/string-data-type--visual-basic-.md).  
  
-   **Environment String Length.** There is a maximum of 32768 characters for any environment string used as a command-line argument. This is a limitation on all platforms.  
  
## See Also  
 [Program Structure and Code Conventions](../vs140/program-structure-and-code-conventions--visual-basic-.md)   
 [Visual Basic Naming Conventions](../vs140/visual-basic-naming-conventions.md)