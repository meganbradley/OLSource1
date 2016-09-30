---
title: "enable_shared_from_this Class"
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
  - "tr1.enable_shared_from_this"
  - "enable_shared_from_this"
  - "std.tr1.enable_shared_from_this"
  - "memory/std::tr1::enable_shared_from_this"
  - "std::tr1::enable_shared_from_this"
  - "tr1::enable_shared_from_this"
  - "std.enable_shared_from_this"
  - "memory/std::enable_shared_from_this"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "enable_shared_from_this class"
  - "enable_shared_from_this class [TR1]"
ms.assetid: 9237603d-22e2-421f-b070-838ac006baf5
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# enable_shared_from_this Class
Helps generate a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The type controlled by the shared pointer.  
  
## Remarks  
 Objects derived from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> methods in member functions to create [shared_ptr](../vs140/shared_ptr-class.md) owners of the instance that share ownership with existing <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> owners. Otherwise, if you create a new <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> by using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, it is distinct from existing <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> owners, which can lead to invalid references or cause the object to be deleted more than once.  
  
 The constructors, destructor, and assignment operator are protected to help prevent accidental misuse. The template argument type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> must be the type of the derived class.  
  
 For an example of usage, see [enable_shared_from_this::shared_from_this](#enable_shared_from_this__shared_from_this).  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
##  \<a name="enable_shared_from_this__shared_from_this">\</a>  enable_shared_from_this::shared_from_this  
 Generates a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> that shares ownership of the instance with existing <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> owners.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 When you derive objects from the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> base class, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> template member functions return a [shared_ptr](../vs140/shared_ptr-class.md) object that shares ownership of this instance with existing <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> owners. Otherwise, if you create a new <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, it is distinct from existing <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> owners, which can lead to invalid references or cause the object to be deleted more than once. The  behavior is undefined if you call <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> on an instance that is not already owned by a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **sp2->val == 3**    
## See Also  
 [enable_shared_from_this::shared_from_this](#enable_shared_from_this__shared_from_this)   
 [shared_ptr](../vs140/shared_ptr-class.md)