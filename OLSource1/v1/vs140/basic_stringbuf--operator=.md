---
title: "basic_stringbuf::operator="
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: 09e57e52-5577-46ac-9968-2bfbaa9c35f8
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_stringbuf::operator=
Assigns the contents of the basic_stringbuf on the right side of the operator to the basic_stringbuf on the left side..  
  
## Syntax  
  
```vb  
basic_stringbuf& basic_stringbuf::operator=(const basic_stringbuf& other)  
```  
  
```c#  
  
```  
  
#### Parameters  
 `other`  
 A basic_stringbuf whose contents, including locale traits, will be assigned to the stringbuf on the left side of the operator.  
  
## Return Value  
 Returns a reference to the left hand side object.  
  
## Remarks  
  
## Requirements  
 **Header**: <sstream\> **Namespace**: std