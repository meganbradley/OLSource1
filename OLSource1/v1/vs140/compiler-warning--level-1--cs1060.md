---
title: "Compiler Warning (level 1) CS1060"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1060"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1060"
ms.assetid: af389239-672b-449e-84b5-edb52e320013
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1060
Use of possibly unassigned field 'name'. Struct instance variables are initially unassigned if struct is unassigned.  
  
 Struct members are initialized to their default value if you do not explicitly initialize them. The default value for class types (and other reference types) is null. If the class is not initialized before any attempt to access it, a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> will be thrown at runtime. The compiler cannot determine definitively whether the class member will be initialized or not, and so CS1060 is a warning and not an error.  
  
### To correct this error  
  
1.  Provide a constructor for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that initializes all its members.  
  
## Example  
 The following code generates CS1060 because the class type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a member of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> but is never initialized.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Structs (C# Programming Guide)](../vs140/structs--csharp-programming-guide-.md)