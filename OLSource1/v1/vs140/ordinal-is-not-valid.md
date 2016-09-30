---
title: "Ordinal is not valid"
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
  - "vbrID452"
dev_langs: 
  - "VB"
ms.assetid: 7459562b-cd4f-4590-95e0-6126ae3589a5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Ordinal is not valid
Your call to a dynamic-link library (DLL) indicated to use a number instead of a procedure name, using the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> syntax. This error has the following possible causes:  
  
-   An attempt to convert the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> expression to an ordinal failed.  
  
-   The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> specified does not specify any function in the DLL.  
  
-   A type library has an invalid declaration resulting in internal use of an invalid ordinal number.  
  
### To correct this error  
  
1.  Make sure the expression represents a valid number, or call the procedure by name.  
  
2.  Make sure <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> identifies a valid function in the DLL.  
  
3.  Isolate the procedure call causing the problem by commenting out the code. Write a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement for the procedure, and report the problem to the type library vendor.  
  
## See Also  
 [Declare Statement](../vs140/declare-statement.md)