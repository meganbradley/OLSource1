---
title: "Move Constructors and Move Assignment Operators (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "move constructor"
ms.assetid: e75efe0e-4b74-47a9-96ed-4e83cfc4378d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Move Constructors and Move Assignment Operators (C++)
This topic describes how to write a *move constructor* and a move assignment operator for a C++ class. A move constructor enables you to implement move semantics, which can significantly improve the performance of your applications. For more information about move semantics, see [Rvalue Reference Declarator: &&](../vs140/rvalue-reference-declarator----.md).  
  
 This topic builds upon the following C++ class, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, which manages a memory buffer.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following procedures describe how to write a move constructor and a move assignment operator for the example C++ class.  
  
### To create a move constructor for a C++ class  
  
1.  Define an empty constructor method that takes an rvalue reference to the class type as its parameter, as demonstrated in the following example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  In the move constructor, assign the class data members from the source object to the object that is being constructed:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
3.  Assign the data members of the source object to default values. This prevents the destructor from freeing resources (such as memory) multiple times:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### To create a move assignment operator for a C++ class  
  
1.  Define an empty assignment operator that takes an rvalue reference to the class type as its parameter and returns a reference to the class type, as demonstrated in the following example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
2.  In the move assignment operator, add a conditional statement that performs no operation if you try to assign the object to itself.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
3.  In the conditional statement, free any resources (such as memory) from the object that is being assigned to.  
  
     The following example frees the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> member from the object that is being assigned to:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
     Follow steps 2 and 3 in the first procedure to transfer the data members from the source object to the object that is being constructed:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
4.  Return a reference to the current object, as shown in the following example:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Example  
 The following example shows the complete move constructor and move assignment operator for the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Example  
 The following example shows how move semantics can improve the performance of your applications. The example adds two elements to a vector object and then inserts a new element between the two existing elements. In [!INCLUDE[cpp_dev10_long](../vs140/includes/cpp_dev10_long_md.md)], the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class uses move semantics to perform the insertion operation efficiently by moving the elements of the vector instead of copying them.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Before [!INCLUDE[cpp_dev10_long](../vs140/includes/cpp_dev10_long_md.md)], this example produces the following output:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The version of this example that uses move semantics is more efficient than the version that does not use move semantics because it performs fewer copy, memory allocation, and memory deallocation operations.  
  
## Robust Programming  
 To prevent resource leaks, always free resources (such as memory, file handles, and sockets) in the move assignment operator.  
  
 To prevent the unrecoverable destruction of resources, properly handle self-assignment in the move assignment operator.  
  
 If you provide both a move constructor and a move assignment operator for your class, you can eliminate redundant code by writing the move constructor to call the move assignment operator. The following example shows a revised version of the move constructor that calls the move assignment operator:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The [std::move](../vs140/move.md) function preserves the rvalue property of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter.  
  
## See Also  
 [Rvalue Reference Operator: &&](../vs140/rvalue-reference-declarator----.md)   
 [\<utility> move](assetId:///abef7e85-9dd6-4724-85da-d7f7fe95dca9)