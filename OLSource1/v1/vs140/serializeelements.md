---
title: "SerializeElements"
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
  - "SerializeElements"
  - "AFXTEMPL/SerializeElements"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SerializeElements function"
ms.assetid: a5ccd494-40b5-4a1f-aba2-33748c00b7a0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SerializeElements
[CArray](../vs140/carray-class.md), [CList](../vs140/clist-class.md), and [CMap](../vs140/cmap-class.md) call this function to serialize elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of the elements.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An archive object to archive to or from.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the elements being archived.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number of elements being archived  
  
## Remarks  
 The default implementation does a bitwise read or write.  
  
 For information on implementing this and other helper functions, see the article [Collections: How to Make a Type-Safe Collection](../vs140/how-to--make-a-type-safe-collection.md).  
  
## Example  
 See the example in the article [Collections: How to Make a Type-Safe Collection](../vs140/how-to--make-a-type-safe-collection.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CArchive Class](../vs140/carchive-class.md)