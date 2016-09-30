---
title: "Compiler Error C2536"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2536"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2536"
ms.assetid: b14a60a3-f2cb-4f22-8a2e-a247f0d7db01
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2536
'class::identifier' : cannot specify explicit initializer for arrays  
  
 A member of a class, structure, or union could not be initialized.  Possible causes:  
  
1.  A constructor is not available to initialize one or more members of an array. If the size of the array is greater than the number of initializers, a default constructor must be defined.  
  
2.  A nonstatic array declared with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> specifier. This kind of array cannot be explicitly initialized.  
  
 The following sample generates C2536:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>