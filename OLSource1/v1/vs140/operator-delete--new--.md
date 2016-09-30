---
title: "operator delete(&lt;new&gt;)"
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
  - "operator delete[]"
  - "std.delete[]"
  - "new/std::delete[]"
  - "std::operator delete[]"
  - "std::delete[]"
  - "std.operator delete[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator delete[]"
  - "delete[] operator"
ms.assetid: fa28d7d3-27a0-43e6-880b-4b7c8169b489
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator delete(&lt;new&gt;)
The function called by a delete expression to deallocate storage for an array of objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The pointer whose value is to be rendered invalid by the deletion.  
  
## Remarks  
 The first function is called by an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expression to render the value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> invalid. The function is replaceable because the program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The required behavior is to accept a value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that is null or that was returned by an earlier call to [operator new&#91;&#93;](../vs140/operator-new--new--.md)(**size_t**). The default behavior for a null value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is to do nothing. Any other value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> must be a value returned earlier by a call as previously described. The default behavior for such a nonnull value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is to reclaim storage allocated by the earlier call. It is unspecified under what conditions part or all of such reclaimed storage is allocated by a subsequent call to [operator new](../vs140/operator-new---new--.md)(**size_t**), or to any of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>(**size_t**), <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>(**size_t**), or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>(**void\***, **size_t**).  
  
 The second function is called by a placement <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> expression corresponding to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> expression of the form <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>(**std::size_t**). It does nothing.  
  
 The third function is called by a placement delete expression corresponding to a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> expression of the form <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>(**std::size_t**, **const std::nothrow_t&**). The program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The required behavior is to accept a value of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> that is null or that was returned by an earlier call to operator <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>(**size_t**). The default behavior is to evaluate <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>).  
  
## Example  
 See [operator new&#91;&#93;](../vs140/operator-new--new--.md) for examples of the use of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<new>  
  
 **Namespace:** std