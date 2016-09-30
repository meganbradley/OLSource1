---
title: "CObList::GetHead"
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
  - "CObList.GetHead"
  - "CObList::GetHead"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, head/tail access"
  - "GetHead method"
ms.assetid: 17e320ed-6e17-4e0b-a4ca-17568585e576
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::GetHead
Gets the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointer that represents the head element of this list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If the list is accessed through a pointer to a **const CObList**, then <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer. This allows the function to be used only on the right side of an assignment statement and thus protects the list from modification.  
  
 If the list is accessed directly or through a pointer to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a reference to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> pointer. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
## Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/coblist--isempty.md) to verify that the list contains elements.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**const void\*& GetHead( ) const; void\*& GetHead( );**|  
|[CStringList](../vs140/cstringlist-class.md)|**const CString& GetHead( ) const; CString& GetHead( );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class.  
  
 The following example illustrates the use of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> on the left side of an assignment statement.  
  
 [!code[NVC_MFCCollections#96](../vs140/codesnippet/CPP/coblist--gethead_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::GetTail](../vs140/coblist--gettail.md)   
 [CObList::GetTailPosition](../vs140/coblist--gettailposition.md)   
 [CObList::AddHead](../vs140/coblist--addhead.md)   
 [CObList::RemoveHead](../vs140/coblist--removehead.md)