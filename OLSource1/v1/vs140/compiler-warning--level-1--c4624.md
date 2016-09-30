---
title: "Compiler Warning (level 1) C4624"
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
  - "C4624"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4624"
ms.assetid: 14f61769-d92e-482b-9515-debd87b30a66
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4624
'derived class' : destructor was implicitly defined as deleted because a base class destructor is inaccessible or deleted  
  
 A destructor was not accessible or deleted in a base class and was therefore not generated for a derived class. Any attempt to create an object of this type on the stack will cause a compiler error.  
  
 The following sample generates C4624 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>