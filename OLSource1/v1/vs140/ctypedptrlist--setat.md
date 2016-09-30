---
title: "CTypedPtrList::SetAt"
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
  - "CTypedPtrList::SetAt"
  - "CTypedPtrList.SetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTypedPtrList class, operations"
  - "SetAt method"
ms.assetid: 534cc580-5db4-4d2a-81a9-18785b57b9d5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrList::SetAt
This member function calls <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>**::SetAt**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The **POSITION** of the element to be set.  
  
 *TYPE*  
 Type of the elements stored in the base-class list.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The object pointer to be written to the list.  
  
## Remarks  
 A variable of type **POSITION** is a key for the list. It is not the same as an index, and you cannot operate on a **POSITION** value yourself. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> writes the object pointer to the specified position in the list.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 For more detailed remarks, see [CObList::SetAt](../vs140/coblist--setat.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrArray Class](../vs140/ctypedptrarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)