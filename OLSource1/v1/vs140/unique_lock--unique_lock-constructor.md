---
title: "unique_lock::unique_lock Constructor"
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
  - "mutex/std::unique_lock::unique_lock"
dev_langs: 
  - "C++"
ms.assetid: 7bca5258-64a8-4133-af66-c0f9e2118b9b
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::unique_lock Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A mutex type object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A [chrono::duration](../vs140/duration-class.md) object that specifies the maximum amount of time that the method attempts to obtain ownership of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A point in time that specifies the threshold after which the method no longer attempts to obtain ownership of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The first constructor constructs an object that has an associated mutex pointer value of 0.  
  
 The second constructor moves the associated mutex status from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. After the move, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is no longer associated with a mutex.  
  
 The remaining constructors store &<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> as the stored <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> pointer. Ownership of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is determined by the second argument, if it exists.  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Ownership is obtained by calling the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method on the associated <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Ownership is assumed. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> must be locked when the constructor is called.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|The calling thread is assumed not to own the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> must not be locked when the constructor is called.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Ownership is determined by calling <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> on the associated <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object. The constructor throws nothing.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Ownership is determined by calling <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Ownership is determined by calling <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [unique_lock Class](../vs140/unique_lock-class.md)   
 [\<mutex>](../vs140/-mutex-.md)