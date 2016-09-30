---
title: "copy_async Function"
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
  - "amp/Concurrency::copy_async"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy_async function"
ms.assetid: 6f06115b-1b85-43f4-a3b7-019af90748ec
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copy_async Function
Copies a C++ AMP object and returns a [completion_future](../vs140/completion_future-class.md) object that can be waited on. You can't copy data when running code on an accelerator.  The general form of this function is `copy(src, dest)`.  
  
## Syntax  
  
```  
template <  
   typename _Value_type,  
   int _Rank  
>  
concurrency::completion_future copy_async(  
   const array<_Value_type, _Rank>& _Src,  
   array<_Value_type, _Rank>& _Dest  
);  
  
template <  
   typename InputIterator,  
   typename _Value_type,  
   int _Rank  
>  
concurrency::completion_future copy_async(  
   InputIterator _SrcFirst,  
   InputIterator _SrcLast,  
   array<_Value_type, _Rank> &_Dest  
);  
  
template <  
   typename InputIterator,  
   typename _Value_type,  
   int _Rank  
>  
concurrency::completion_future copy_async(  
   InputIterator _SrcFirst,  
   array<_Value_type, _Rank> &_Dest  
);  
  
template <  
   typename OutputIterator,  
   typename _Value_type,  
   int _Rank  
>  
concurrency::completion_future copy_async(  
   const array<_Value_type, _Rank> &_Src,  
   OutputIterator _DestIter  
);  
  
template <  
   typename _Value_type,  
   int _Rank  
>  
concurrency::completion_future copy_async(  
   const array<_Value_type, _Rank>& _Src,  
   array_view<_Value_type, _Rank>& _Dest  
);  
  
template <  
   typename _Value_type,  
   int _Rank  
>  
concurrency::completion_future copy_async(  
   const array_view<const _Value_type, _Rank>& _Src,  
   array<_Value_type, _Rank>& _Dest  
);  
  
template <  
   typename _Value_type,  
   int _Rank  
>  
concurrency::completion_future copy_async(  
   const array_view<_Value_type, _Rank>& _Src,  
   array<_Value_type, _Rank>& _Dest  
);  
  
template <  
   typename _Value_type,  
   int _Rank  
>  
concurrency::completion_future copy_async(  
   const array_view<const _Value_type, _Rank>& _Src,  
   array_view<_Value_type, _Rank>& _Dest  
);  
  
template <  
   typename _Value_type,  
   int _Rank  
>  
concurrency::completion_future copy_async(  
   const array_view<_Value_type, _Rank>& _Src,  
   array_view<_Value_type, _Rank>& _Dest  
);  
  
template <  
   typename InputIterator,  
   typename _Value_type,  
   int _Rank  
>  
concurrency::completion_future copy_async(  
   InputIterator _SrcFirst,  
   InputIterator _SrcLast,  
   array_view<_Value_type, _Rank> &_Dest  
);  
  
template <  
   typename InputIterator,  
   typename _Value_type,  
   int _Rank  
>  
concurrency::completion_future copy_async(  
   InputIterator_SrcFirst,  
   array_view<_Value_type, _Rank> &_Dest  
);  
  
template <  
   typename OutputIterator,  
   typename _Value_type,  
   int _Rank  
>  
concurrency::completion_future copy_async(  
   const array_view<_Value_type, _Rank> &_Src,  
   OutputIterator _DestIter  
);  
```  
  
#### Parameters  
 `_Dest`  
 The object to copy to.  
  
 `_DestIter`  
 An output iterator to the beginning position at destination.  
  
 `InputIterator`  
 The type of the input interator.  
  
 `OutputIterator`  
 The type of the output iterator.  
  
 `_Rank`  
 The rank of the object to copy from or the object to copy to.  
  
 `_Src`  
 To object to copy.  
  
 `_SrcFirst`  
 A beginning iterator into the source container.  
  
 `_SrcLast`  
 An ending iterator into the source container.  
  
 `_Value_type`  
 The data type of the elements that are copied.  
  
## Return Value  
 A `future<void>` that can be waited on.  
  
## Remarks  
 The copy operation always performs a deep copy.  
  
 If the extents of the source and destination objects do not match, a [runtime_exception](../vs140/runtime_exception-class.md) is thrown.  
  
 You can copy to [array](../vs140/array-class.md) and [array_view](../vs140/array_view-class.md) objects from the following sources:  
  
-   An `array` or `array_view` that has the same rank and element type as the destination `array` or `array_view`.  
  
-   A standard container whose element type is the same as the destination `array` or `array_view`. Containers that expose `size()` and `data()` members perform more efficiently.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)