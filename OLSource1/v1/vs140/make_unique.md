---
title: "make_unique"
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
  - "make_unique"
  - "std::make_unique"
dev_langs: 
  - "C++"
ms.assetid: 4b5fa0d6-fd1b-42b3-a35d-d71c3b6529f8
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_unique
Creates and returns a [unique_ptr](../vs140/unique_ptr-class.md) to an object of the specified type, which is constructed by using the specified arguments.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the object that the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> will point to.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The types of the constructor arguments specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The arguments to be passed to the constructor of the object of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An array of elements of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The number of elements to allocate space for in the new array.  
  
## Return Value  
 A [unique_ptr](../vs140/unique_ptr-class.md) to an object of the specified type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first overload is used for single objects, the second overload is invoked for arrays, and the third overload prevents the prevents you from specifying an array size in the type argument (make_unique\<T[N]>); this construction is not supported by the current standard. When you use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to create a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to an array, you have to initialize the array elements separately. If you are considering this overload, perhaps a better choice is to use a [std::vector](../vs140/vector-class.md).  
  
 Because <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is carefully implemented for exception safety, we recommend that you use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> instead of directly calling <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> constructors.  
  
## Example  
 The following example shows how to use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. For more examples, see [How to: Create and Use unique_ptr Instances](../vs140/how-to--create-and-use-unique_ptr-instances.md).  
  
 [!code[stl_smart_pointers#214](../vs140/codesnippet/CPP/make_unique_1.cpp)]  
  
 When you see error C2280 in connection with a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, it is almost certainly because you are attempting to invoke its copy constructor, which is a deleted function.  
  
## Requirements  
 \<memory>  
  
## See Also  
 [How to: Create and Use unique_ptr Instances](../vs140/how-to--create-and-use-unique_ptr-instances.md)