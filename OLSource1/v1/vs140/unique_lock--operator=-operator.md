---
title: "unique_lock::operator= Operator"
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
  - "mutex/std::unique_lock::operator="
dev_langs: 
  - "C++"
ms.assetid: 8d1e7044-19f4-4b87-8a4c-aa329b1e5371
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::operator= Operator
Copies the stored <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointer and associated ownership status from a specified object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Remarks  
 If the calling thread owns the previously associated <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, before this method calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> on the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, it assigns the new values.  
  
 After the copy, this method sets <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to a default-constructed state.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [unique_lock Class](../vs140/unique_lock-class.md)   
 [\<mutex>](../vs140/-mutex-.md)