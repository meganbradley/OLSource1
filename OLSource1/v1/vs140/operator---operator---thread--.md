---
title: "operator&lt;&lt; Operator (&lt;thread&gt;)"
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
  - thread/std::operator<<
dev_langs: 
  - C++
ms.assetid: 705d8280-1379-445d-b924-3fec0cd1dbd7
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator&lt;&lt; Operator (&lt;thread&gt;)
Inserts a text representation of a `thread::id` object into a stream.  
  
## Syntax  
  
```cpp  
template<class Elem, class Tr>  
   basic_ostream<Elem, Tr>& operator<<(  
      basic_ostream<Elem, Tr>& Ostr, thread::id Id);  
```  
  
#### Parameters  
 `Ostr`  
 A [basic_ostream](../vs140/basic_ostream-class.md) object.  
  
 `Id`  
 A `thread::id` object.  
  
## Return Value  
 `Ostr`.  
  
## Remarks  
 This function inserts `Id` into `Ostr`.  
  
 If two `thread::id` objects compare equal, the inserted text representations of those objects are the same.  
  
## Requirements  
 **Header:** thread  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<thread\>](../vs140/-thread-.md)