---
title: "make_shared (&lt;memory&gt;)"
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
  - "std.make_shared"
  - "memory/std::make_shared"
  - "make_shared"
  - "std::make_shared"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_shared function"
ms.assetid: 6d6015b9-ad9a-4c06-93ce-b07cf6193d23
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_shared (&lt;memory&gt;)
Creates and returns a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that points to the allocated objects that are constructed from zero or more arguments by using the default allocator. Allocates and constructs both an object of the specified type and a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to manage shared ownership of the object, and returns the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Zero or more constructor arguments. The function infers which constructor overload to invoke based on the arguments that are provided.|  
  
## Property Value/Return Value  
 Returns a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that points to the allocated and constructed object.  
  
## Remarks  
 Use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as a simple and more efficient way to create an object and a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to manage shared access to the object at the same time. Semantically, these two statements are equivalent:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 However, the first statement makes two allocations, and if the allocation of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> fails after the allocation of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object has succeeded, then the unnamed <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object is leaked. The statement that uses <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is simpler because there's only one function call involved. It's more efficient because the library can make a single allocation for both the object and the smart pointer. This is both faster and leads to less memory fragmentation, and there is no chance of an exception on one allocation but not the other. Performance is improved by better locality for code that references the object and updates the reference counts in the smart pointer.  
  
 Consider using [make_unique](../vs140/make_unique.md) if you do not need shared access to the object. Use [allocate_shared](../vs140/allocate_shared.md) if you need to specify a custom allocator for the object. You can't use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if your object requires a custom deleter, because there is no way to pass the deleter as an argument.  
  
 The following example shows how to create shared pointers to a type by invoking specific constructor overloads.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The example produces this output:  
  
 **Playing Ode to Joy by Beethoven, use count: 2**  
**Playing Yesterday by The Beatles, use count: 3**  
**Playing Blackbird by The Beatles, use count: 3**  
**Playing Greensleeves by Unknown, use count: 2**  
**Playing Yesterday by The Beatles, use count: 3**  
**Playing Blackbird by The Beatles, use count: 3**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [\<memory>](../vs140/-memory-.md)   
 [shared_ptr Class](../vs140/shared_ptr-class.md)