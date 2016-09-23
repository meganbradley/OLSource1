---
title: "valarray::free"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - valarray/std::valarray::free
  - std.valarray.free
  - valarray.free
  - free
  - std::valarray::free
  - valarray::free
dev_langs: 
  - C++
helpviewer_keywords: 
  - free function
  - free method
ms.assetid: 6c7f0551-f952-4ff0-8a52-3a7ec2de842c
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# valarray::free
Frees the memory used by the valarray.  
  
## Syntax  
  
```  
void free();  
```  
  
## Remarks  
 This nonstandard function is equivalent to assigning an empty valarray. For example:  
  
```  
valarray<T> v;  
v = valarray<T>(); // equivalent to v.free()  
```  
  
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)