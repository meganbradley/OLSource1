---
title: "Compiler Error C2195"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C2195
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2195
ms.assetid: 9f9f035c-9c51-4173-a8ea-c6f907fc5c63
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2195
'identifier' : is a data segment  
  
 The `code_seg` pragma uses a segment name used with the `data_seg` pragma.  
  
 The following sample generates C2195:  
  
```  
// C2195.cpp  
#pragma data_seg("MYDATA")  
#pragma code_seg("MYDATA")   // C2195  
#pragma code_seg("MYDATA2")   // OK  
```