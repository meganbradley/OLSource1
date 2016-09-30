---
title: "lock_guard Class"
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
  - "mutex/std::lock_guard"
dev_langs: 
  - "C++"
ms.assetid: 57121f0d-9c50-481c-b971-54e64df864e0
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lock_guard Class
Represents a template that can be instantiated to create an object whose destructor unlocks a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The template argument <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must name a *mutex type*.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Synonym for the template argument <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[lock_guard::lock_guard Constructor](#lock_guard__lock_guard_constructor)|Constructs a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
|[lock_guard::~lock_guard Destructor](#lock_guard___dtorlock_guard_destructor)|Unlocks the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that was passed to the constructor.|  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
##  \<a name="lock_guard__lock_guard_constructor">\</a>  lock_guard::lock_guard Constructor  
 Constructs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A *mutex type* object.  
  
### Remarks  
 The first constructor constructs an object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and locks <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is not a recursive mutex, it must be unlocked when this constructor is called.  
  
 The second constructor does not lock <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> must be locked when this constructor is called. The constructor throws no exceptions.  
  
##  \<a name="lock_guard___dtorlock_guard_destructor">\</a>  lock_guard::~lock_guard Destructor  
 Unlocks the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> that was passed to the constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 If the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> does not exist when the destructor runs, the behavior is undefined.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<mutex>](../vs140/-mutex-.md)