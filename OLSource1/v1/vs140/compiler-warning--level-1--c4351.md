---
title: "Compiler Warning (level 1) C4351"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4351"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4351"
ms.assetid: c2e0e34e-fc20-4812-9613-26c387356c92
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4351
new behavior: elements of array 'array' will be default initialized  
  
 When an array is in a constructor's member initialization list, the elements of the array will be default initialized. In previous versions of [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)], when an array was in a constructor's member initialization list, the elements of the array may not have been default initialized in some cases.  
  
 If the array's element type does not have a constructor, the elements of the array will be initialized with the corresponding zero representation for that type.  
  
 C4351 means that you should inspect your code. If you want the compiler's previous behavior, remove the array from the constructor's member initialization list.  
  
 If you want the new behavior, which is likely, because the array was explicitly added to the constructor's member initialization list, use the [warning](../vs140/warning.md) pragma to disable the warning. The new behavior should be fine for most users.  
  
 One situation where the new behavior can result in unexpected behavior is when placement <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is used to construct the object that has the array as a member, and the program depends on the contents that the memory (for the elements of the default initialized array) had before the call to placement <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. In this case, the older compiler would have left the contents of memory unchanged, but the new behavior will cause default initialization of the array elements, overwriting the original contents in memory.  
  
## Example  
 The following sample generates C4351:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>