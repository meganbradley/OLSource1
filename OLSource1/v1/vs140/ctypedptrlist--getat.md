---
title: "CTypedPtrList::GetAt"
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
  - "CTypedPtrList.GetAt"
  - "CTypedPtrList::GetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAt method [MFC]"
ms.assetid: d0ae341d-3e74-41d0-bab3-0692517d8ad2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrList::GetAt
A variable of type **POSITION** is a key for the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in the list.  
  
 *position*  
 A **POSITION** value returned by a previous <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or **Find** member function call.  
  
## Return Value  
 If the list is accessed through a pointer to a **const CTypedPtrList**, then <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns a pointer of the type specified by the template parameter *TYPE*. This allows the function to be used only on the right side of an assignment statement and thus protects the list from modification.  
  
 If the list is accessed directly or through a pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a reference to a pointer of the type specified by the template parameter *TYPE*. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
## Remarks  
 It is not the same as an index, and you cannot operate on a **POSITION** value yourself. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> retrieves the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> pointer associated with a given position.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 This inline function calls <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>**::GetAt**.  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrList Class](../vs140/ctypedptrlist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::GetAt](../vs140/coblist--getat.md)