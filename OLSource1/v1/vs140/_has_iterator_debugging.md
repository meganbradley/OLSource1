---
title: "_HAS_ITERATOR_DEBUGGING"
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
  - "_HAS_ITERATOR_DEBUGGING"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_HAS_ITERATOR_DEBUGGING"
ms.assetid: 90077dbb-8a76-4963-83a6-29f4854007a8
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _HAS_ITERATOR_DEBUGGING
Defines whether the iterator debugging feature is enabled in a debug build. By default, iterator debugging is enabled. For more information, see [Debug Iterator Support](../vs140/debug-iterator-support.md).  
  
> [!IMPORTANT]
>  Use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to control <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. For more information, see [_ITERATOR_DEBUG_LEVEL](../vs140/_iterator_debug_level.md).  
  
## Remarks  
 To enable iterator debugging in debug builds, set **_HAS_ITERATOR_DEBUGGING** to 1:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **_HAS_ITERATOR_DEBUGGING** cannot be set to 1 in retail builds.  
  
 To disable iterator debugging in debug builds, set **_HAS_ITERATOR_DEBUGGING** to 0:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [_ITERATOR_DEBUG_LEVEL](../vs140/_iterator_debug_level.md)   
 [Debug Iterator Support](../vs140/debug-iterator-support.md)   
 [Checked Iterators](../vs140/checked-iterators.md)   
 [Safe Libraries: Standard C++ Library](../vs140/safe-libraries--c---standard-library.md)