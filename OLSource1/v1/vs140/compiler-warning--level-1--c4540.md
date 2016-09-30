---
title: "Compiler Warning (level 1) C4540"
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
  - "C4540"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4540"
ms.assetid: 8085e748-5f4d-43c2-b06d-eaf794edbf72
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4540
dynamic_cast used to convert to inaccessible or ambiguous base; run-time test will fail ('type1' to 'type2')  
  
 You used <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to convert from one type to another. The compiler determined that the cast would always fail (return **NULL**) because a base class is inaccessible (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, for instance) or ambiguous (appears more than once in the class hierarchy, for instance).  
  
 The following shows an example of this warning. Class **B** is derived from class **A**. The program uses <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to cast from class **B** (the derived class) to class **A**, which will always fail because class **B** is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and thus inaccessible. Changing the access of **A** to **public** will resolve the warning.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>