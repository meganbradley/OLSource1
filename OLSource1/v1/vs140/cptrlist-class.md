---
title: "CPtrList Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CPtrList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lists, generic"
  - "CPtrList class"
  - "generic lists"
ms.assetid: 4139a09c-4338-4f42-9eea-51336120b43c
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPtrList Class
Supports lists of void pointers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
 The member functions of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> are similar to the member functions of class [CObList](../vs140/coblist-class.md). Because of this similarity, you can use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> reference documentation for member function specifics. Wherever you see a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer as a function parameter or return value, substitute a pointer to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 for example, translates to  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> incorporates the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> macro to support run-time type access and dumping to a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. If you need a dump of individual pointer list elements, you must set the depth of the dump context to 1 or greater.  
  
 Pointer lists cannot be serialized.  
  
 When a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object is deleted, or when its elements are removed, only the pointers are removed, not the entities they reference.  
  
 For more information on using <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, see the article [Collections](../vs140/collections.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList](../vs140/coblist-class.md)