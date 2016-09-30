---
title: "How to: Create and Use unique_ptr Instances"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 9a373030-e587-452f-b9a5-c5f9d58b7673
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create and Use unique_ptr Instances
A [unique_ptr](../vs140/unique_ptr-class.md) does not share its pointer. It cannot be copied to another <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, passed by value to a function, or used in any Standard Template Library (STL) algorithm that requires copies to be made. A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> can only be moved. This means that the ownership of the memory resource is transferred to another <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and the original <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> no longer owns it. We recommend that you restrict an object to one owner, because multiple ownership adds complexity to the program logic. Therefore, when you need a smart pointer for a plain C++ object, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and when you construct a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, use the [make_unique](../vs140/make_unique.md) helper function.  
  
 The following diagram illustrates the transfer of ownership between two <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> instances.  
  
 ![Moving the ownership of a unique&#95;ptr](../vs140/media/unique_ptr.png "unique_ptr")  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is defined in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> header in the STL. It is exactly is efficient as a raw pointer and can be used in STL containers. The addition of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> instances to STL containers is efficient because the move constructor of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> eliminates the need for a copy operation.  
  
## Example  
 The following example shows how to create <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> instances and pass them between functions.  
  
 [!code[stl_smart_pointers#210](../vs140/codesnippet/CPP/how-to--create-and-use-unique_ptr-instances_1.cpp)]  
  
 These examples demonstrate this basic characteristic of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>: it can be moved, but not copied. "Moving" transfers ownership to a new <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and resets the old <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Example  
 The following example shows how to create <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> instances and use them in a vector.  
  
 [!code[stl_smart_pointers#211](../vs140/codesnippet/CPP/how-to--create-and-use-unique_ptr-instances_2.cpp)]  
  
 In the range for  loop, notice that the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is passed by reference. If you try to pass by value here, the compiler will throw an error because the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> copy constructor is deleted.  
  
## Example  
 The following example shows how to initialize a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> that is a class member.  
  
 [!code[stl_smart_pointers#212](../vs140/codesnippet/CPP/how-to--create-and-use-unique_ptr-instances_3.cpp)]  
  
## Example  
 You can use [make_unique](../vs140/make_unique.md) to create a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to an array, but you cannot use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to initialize the array elements.  
  
 [!code[stl_smart_pointers#213](../vs140/codesnippet/CPP/how-to--create-and-use-unique_ptr-instances_4.cpp)]  
  
 For more examples, see [make_unique](../vs140/make_unique.md).  
  
## See Also  
 [Smart Pointers](../vs140/smart-pointers--modern-c---.md)   
 [make_unique](../vs140/make_unique.md)