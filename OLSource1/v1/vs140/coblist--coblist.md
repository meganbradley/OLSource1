---
title: "CObList::CObList"
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
  - "CObList::CObList"
  - "CObList.CObList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, constructor"
ms.assetid: ba0bdf10-7749-416d-9eba-039bfc61299c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::CObList
Constructs an empty <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointer list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The memory-allocation granularity for extending the list.  
  
## Remarks  
 As the list grows, memory is allocated in units of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> entries. If a memory allocation fails, a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is thrown.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**CPtrList( INT_PTR**  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  **= 10 );**|  
|[CStringList](../vs140/cstringlist-class.md)|**CStringList( INT_PTR**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  **= 10 );**|  
  
## Example  
 Below is a listing of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>-derived class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> used in all the collection examples:  
  
 [!code[NVC_MFCCollections#91](../vs140/codesnippet/CPP/coblist--coblist_1.h)]  
  
 Below is an example of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> constructor usage:  
  
 [!code[NVC_MFCCollections#92](../vs140/codesnippet/CPP/coblist--coblist_2.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)