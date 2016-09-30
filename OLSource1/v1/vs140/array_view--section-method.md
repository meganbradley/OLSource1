---
title: "array_view::section Method"
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
  - "amp/Concurrency::array_view::section"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "section method"
ms.assetid: a10f8914-2726-4b84-9a91-9f8749059630
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array_view::section Method
Returns a subsection of the [array_view](../vs140/array_view-class.md) object that's at the specified origin and, optionally, that has the specified extent.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The most significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The least significant component of the extent of this section.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The [extent](../vs140/extent-class--c---amp-.md) object that specifies the extent of the section. The origin is 0.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The [index](../vs140/index-class.md) object that specifies the location of the origin. The subsection is the rest of the extent.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The most significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The next-to-most-significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The least significant component of the origin of this section.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The rank of the section.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The [extent](../vs140/extent-class--c---amp-.md) object that specifies the extent of the section.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The [index](../vs140/index-class.md) object that specifies the location of the origin.  
  
## Return Value  
 A subsection of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object that's at the specified origin and, optionally, that has the specified extent. When only the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object is specified, the subsection contains all elements in the associated extent that have indexes that are larger than the indexes of the elements in the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array_view Class](../vs140/array_view-class.md)