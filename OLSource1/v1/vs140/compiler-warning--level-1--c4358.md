---
title: "Compiler Warning (level 1) C4358"
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
  - "C4358"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4358"
ms.assetid: a9848f84-14b3-405e-81bf-ee3e91a51511
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4358
'operator': return type of combined delegates is not 'void'; returned value is undefined  
  
 Two delegates were combined and the return value is not void. If two delegates with non-void return values are combined, the compiler will not be able to do a proper assignment if the return value of the delegate is used.  
  
 The following sample generates C4358:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>