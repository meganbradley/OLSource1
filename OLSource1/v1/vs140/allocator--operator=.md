---
title: "allocator::operator="
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
  - "="
  - "operator="
  - "allocator::operator="
  - "memory/std::allocator::operator="
  - "std::allocator::operator="
  - "allocator.operator="
  - "std.allocator.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=, allocator"
  - "= operator, with specific standard C++ library objects"
  - "operator =, allocator"
ms.assetid: 85246ec0-b3db-4687-8fbc-8a0e7151b6ea
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::operator=
Assigns one allocator object to another allocator object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An allocator object to be assigned to another such object.  
  
## Return Value  
 A reference to the allocator object  
  
## Remarks  
 The template assignment operator does nothing. In general, however, an allocator object assigned to another allocator object should compare equal to it and permit intermixing of object allocation and freeing between the two allocator objects.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)