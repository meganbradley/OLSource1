---
title: "Compiler Warning (level 1) C4091"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4091"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4091"
ms.assetid: 3a404967-ab42-49b0-b324-fd7ba1859d78
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4091
'keyword' : ignored on left of 'type' when no variable is declared  
  
 The compiler detected a situation where the user probably intended a variable to be declared, but the compiler was not able to declare the variable.  
  
## Example  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute at the beginning of a user-defined type declaration applies to the variable of that type. C4091 indicates no variable is declared. The following sample generates C4091.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 If an identifier is a typedef, it cannot also be a variable name. The following sample generates C4091.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>