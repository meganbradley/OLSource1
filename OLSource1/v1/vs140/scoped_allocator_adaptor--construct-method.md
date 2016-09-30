---
title: "scoped_allocator_adaptor::construct Method"
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
  - "scoped_allocator/std::scoped_allocator_adaptor::construct"
dev_langs: 
  - "C++"
ms.assetid: 01420cc5-8905-4039-af41-6ef3b825cbc6
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# scoped_allocator_adaptor::construct Method
Constructs an object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the memory location where the object is to be constructed.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A list of arguments.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of the first type in a pair.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An object of the second type in a pair.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An existing object to be moved or copied.  
  
## Remarks  
 The first method constructs the object at <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is one of the following.  
  
-   If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> holds false, then <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
-   If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> holds true, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> holds true, then <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
-   If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> holds true, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> holds true, then <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 The second method constructs the pair object at <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> modified as in the above list, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> modified as in the above list.  
  
 The third method behaves the same as <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 The fourth method behaves the same as <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 The fifth method behaves the same as <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 The sixth method behaves the same as <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<scoped_allocator>  
  
 **Namespace:** std  
  
## See Also  
 [scoped_allocator_adaptor Class](../vs140/scoped_allocator_adaptor-class.md)   
 [allocator_traits::construct Method](../vs140/allocator_traits--construct-method.md)