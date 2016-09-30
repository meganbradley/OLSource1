---
title: "raw_storage_iterator::operator="
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
  - "memory/std::raw_storage_iterator::operator="
  - "raw_storage_iterator.operator="
  - "std.raw_storage_iterator.operator="
  - "std::raw_storage_iterator::operator="
  - "raw_storage_iterator::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=, iterators"
  - "operator =, iterators"
  - "= operator, with specific standard C++ library objects"
ms.assetid: 2bb826a7-dc87-4005-9a33-0d93a7eaef48
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# raw_storage_iterator::operator=
Assignment operator used to implement the raw storage iterator expression \**i* = *x* for storing in memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value of the object of type **Type** to be inserted into memory.  
  
## Return Value  
 The operator inserts <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> into memory, and then returns a reference to the raw storage iterator.  
  
## Remarks  
 The requirements for a **ForwardIterator** state that the raw storage iterator must satisfy require only the expression \**ii* = *t* be valid, and that it says nothing about the **operator** or the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on their own. These member operators return **\*this**.  
  
 The assignment operator constructs the next object in the output sequence using the stored iterator value first, by evaluating the placement new expression **new** ( (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> \*)&\***first**) **Type**(<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Not constructed.**  
**Copying 5**  
**Constructing 5**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [raw_storage_iterator Class](../vs140/raw_storage_iterator-class.md)