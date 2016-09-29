---
title: "move_iterator::reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "move_iterator.reference"
  - "std.move_iterator.reference"
  - "std::move_iterator::reference"
  - "move_iterator::reference"
  - "reference"
  - "iterator/std::move_iterator::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference typedef"
ms.assetid: fb5a5d3c-b001-4c54-bb1b-f16429a35c42
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# move_iterator::reference
The type `reference` is a `typedef` based on `value_type&&` for `move_iterator`, and can be used interchangeably with `value_type&&`.  
  
## Syntax  
  
```  
typedef value_type&&  
    reference;  
```  
  
## Remarks  
 The type is a synonym for `value_type&&`, which is an .  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [reference typedef](../vs140/move_iterator--reference.md)   
 [move_iterator Class](../vs140/move_iterator-class.md)   
 [\<iterator>](../vs140/-iterator-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [Standard Template Library](../vs140/standard-template-library.md)