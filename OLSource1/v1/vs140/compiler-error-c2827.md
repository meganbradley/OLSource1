---
title: "Compiler Error C2827"
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
  - C2827
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2827
ms.assetid: cb3e5814-0c92-40e4-b620-98578ae3003a
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2827
'operator operator' cannot be globally overridden with unary form  
  
 The operator cannot have a unary form outside of an object.  
  
### To fix by using the following possible solutions  
  
1.  Make the overloaded operator local to an object.  
  
2.  Choose an appropriate unary operator to overload.