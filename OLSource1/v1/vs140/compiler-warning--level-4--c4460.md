---
title: "Compiler Warning (level 4) C4460"
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
  - "C4460"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4460"
ms.assetid: c97ac1c9-598d-479e-bfff-c993690c4f3d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4460
WinRT or CLR operator 'operator', has parameter passed by reference. WinRT or CLR operator 'operator' has different semantics from C++ operator 'operator', did you intend to pass by value?  
  
 You passed a value by reference to a user-defined Windows Runtime or CLR operator. If the value is changed inside the function, note that the value returned after the function call will be assigned the return value of the function. In standard C++, the changed value is reflected after the function call.  
  
## Example  
 The following sample generates C4460 and shows how to fix it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>