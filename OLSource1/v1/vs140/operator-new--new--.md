---
title: "operator new(&lt;new&gt;)"
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
  - "std::operator new[]"
  - "new/std::new[]"
  - "std.operator new[]"
  - "std.new[]"
  - "std::new[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator new[]"
  - "new[] operator"
ms.assetid: c98bb1c9-6d7f-42c2-8366-f2f3eeb71a31
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator new(&lt;new&gt;)
The allocation function called by a new expression to allocate storage for an array of objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of bytes of storage to be allocated for the array object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The pointer to be returned.  
  
## Return Value  
 A pointer to the lowest byte address of the newly-allocated storage. Or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Remarks  
 The first function is called by a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> expression to allocate <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> bytes of storage suitably aligned to represent any array object of that size or smaller. The program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The required behavior is the same as for [operator new](../vs140/operator-new---new--.md)(**size_t**). The default behavior is to return <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
 The second function is called by a placement <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> expression to allocate <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> bytes of storage suitably aligned to represent any array object of that size. The program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The default behavior is to return **operator new**(<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) if that function succeeds. Otherwise, it returns a null pointer.  
  
 The third function is called by a placement <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> expression, of the form **new** (*args*) **T**[**N**]. Here, *args* consists of a single object pointer. The function returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 To free storage allocated by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, call [operator delete&#91;&#93;](../vs140/operator-delete--new--.md).  
  
 For information on throwing or nonthrowing behavior of new, see [The new and delete Operators](../vs140/new-and-delete-operators.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<new>  
  
 **Namespace:** std  
  
## See Also  
 [nothrow_t Class](../vs140/nothrow_t-structure.md)   
 [operator delete&#91;&#93; (\<new>)](../vs140/operator-delete--new--.md)