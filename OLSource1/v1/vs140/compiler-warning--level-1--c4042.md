---
title: "Compiler Warning (level 1) C4042"
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
  - "C4042"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4042"
ms.assetid: e4bd861b-1194-426b-bf79-68c5b021eb0a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4042
'identifier' : has bad storage class  
  
 The specified storage class cannot be used with this identifier in this context. The compiler uses the default storage class instead:  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, if *identifier* is a function.  
  
-   **auto**, if *identifier* is a formal parameter or local variable.  
  
-   No storage class, if *identifier* is a global variable.  
  
 This warning can be caused by specifying a storage class other than **register** in a parameter declaration.  
  
 The following sample generates C4042  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>