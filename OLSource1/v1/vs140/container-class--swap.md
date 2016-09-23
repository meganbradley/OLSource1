---
title: "Container Class::swap"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - swap method
ms.assetid: 898c219c-bc8e-4d14-a149-6240426c693f
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Container Class::swap
> [!NOTE]
>  This topic is in the Visual C++ documentation as a nonfunctional example of containers used in the Standard C++ Library. For more information, see [STL Containers](../vs140/stl-containers.md).  
  
 Swaps the controlled sequences between **\*this** and `_Right`.  
  
## Syntax  
  
```  
  
      void swap(  
   Container& _Right  
);  
```  
  
## Remarks  
 If **get_allocator ==** `_Right`**.get_allocator**, it does so in constant time. Otherwise, it performs a number of element assignments and constructor calls proportional to the number of elements in the two controlled sequences.  
  
## See Also  
 [Sample Container Class](../vs140/sample-container-class.md)