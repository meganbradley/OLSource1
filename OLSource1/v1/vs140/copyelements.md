---
title: "CopyElements"
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
  - "AFXTEMPL/CopyElements"
  - "CopyElements"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyElements function"
ms.assetid: 2232a477-19c7-4512-8fd5-d31b8cd87c82
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CopyElements
This function is called directly by [CArray::Append](../vs140/carray--append.md) and [CArray::Copy](../vs140/carray--copy.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements to be copied.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the destination where the elements will be copied.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the source of the elements to be copied.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number of elements to be copied.  
  
## Remarks  
 The default implementation uses the simple assignment operator ( **=** ) to perform the copy operation. If the type being copied does not have an overloaded operator=, then the default implementation performs a bitwise copy.  
  
 For information on implementing this and other helper functions, see the article [Collections: How to Make a Type-Safe Collection](../vs140/how-to--make-a-type-safe-collection.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CArray Class](../vs140/carray-class.md)