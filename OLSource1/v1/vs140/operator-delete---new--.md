---
title: "operator delete (&lt;new&gt;)"
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
  - "operator delete"
  - "std.operator delete"
  - "std::operator delete"
  - "std.delete"
  - "new/std::delete"
  - "std::delete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator delete"
  - "delete operator"
ms.assetid: 7c45e232-ceb2-4a77-b0af-da2a935d46a2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator delete (&lt;new&gt;)
The function called by a delete expression to deallocate storage for individual of objects.  
  
## Syntax  
  
```  
  
      void operator delete(  
   void* _Ptr  
) throw( );  
void operator delete(  
   void *,   
   void *  
) throw( );  
void operator delete(  
   void* _Ptr,  
   const std::nothrow_t&  
) throw( );  
```  
  
#### Parameters  
 `_Ptr`  
 The pointer whose value is to be rendered invalid by the deletion.  
  
## Remarks  
 The first function is called by a delete expression to render the value of `_Ptr` invalid. The program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The required behavior is to accept a value of `_Ptr` that is null or that was returned by an earlier call to [operator new](../vs140/operator-new---new--.md)(**size_t**).  
  
 The default behavior for a null value of `_Ptr` is to do nothing. Any other value of `_Ptr` must be a value returned earlier by a call as previously described. The default behavior for such a nonnull value of `_Ptr` is to reclaim storage allocated by the earlier call. It is unspecified under what conditions part or all of such reclaimed storage is allocated by a subsequent call to `operator new`(**size_t**), or to any of `calloc`(**size_t**), `malloc`(**size_t**), or `realloc`(**void\***, **size_t**).  
  
 The second function is called by a placement delete expression corresponding to a new expression of the form **new**(**std::size_t**). It does nothing.  
  
 The third function is called by a placement delete expression corresponding to a new expression of the form **new**(**std::size_t**, **const std::nothrow_t&**). The program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The required behavior is to accept a value of `_Ptr` that is null or that was returned by an earlier call to `operator new`(**size_t**). The default behavior is to evaluate **delete**(`_Ptr`).  
  
## Example  
 See [operator new](../vs140/operator-new---new--.md) for an example that use `operator delete`.  
  
## Requirements  
 **Header:** <new\>  
  
 **Namespace:** std