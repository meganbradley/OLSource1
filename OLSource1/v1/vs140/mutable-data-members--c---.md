---
title: "Mutable Data Members (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "mutable_cpp"
  - "mutable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mutable keyword [C++]"
ms.assetid: ebe89746-3d36-43a8-8d69-f426af23f551
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Mutable Data Members (C++)
This keyword can only be applied to non-static and non-const data members of a class. If a data member is declared <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, then it is legal to assign a value to this data member from a **const** member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 For example, the following code will compile without error because <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> has been declared to be <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and therefore can be modified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> even though <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a const member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Keywords](../vs140/keywords--c---.md)