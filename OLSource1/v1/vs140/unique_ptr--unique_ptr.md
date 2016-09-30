---
title: "unique_ptr::unique_ptr"
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
  - "memory/std::unique_ptr::unique_ptr"
  - "unique_ptr::unique_ptr"
  - "unique_ptr"
  - "std.unique_ptr.unique_ptr"
  - "unique_ptr.unique_ptr"
  - "std::unique_ptr::unique_ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unique_ptr method, constructor"
ms.assetid: 4c5f6387-7c16-4b7e-a55f-039cb1e59429
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_ptr::unique_ptr
There are seven constructors for <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A pointer to the resource to be assigned to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to be assigned to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|An <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> from which <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> fields are move assigned to the newly constructed <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
  
## Remarks  
 The first two constructors construct an object that manages no resource. The third constructor stores <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The fourth constructor stores <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 The fifth constructor stores <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and moves <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The sixth and seventh constructors store <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and moves <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [unique_ptr](../vs140/unique_ptr-class.md)   
 [\<memory>](../vs140/-memory-.md)   
 [Thread Safety in the C++ Standard Library](../vs140/thread-safety-in-the-c---standard-library.md)