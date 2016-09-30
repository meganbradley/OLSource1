---
title: "CAtlArray::InsertAt"
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
  - "CAtlArray.InsertAt"
  - "CAtlArray::InsertAt"
  - "ATL.CAtlArray.InsertAt"
  - "ATL::CAtlArray::InsertAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertAt method"
ms.assetid: b4da3da0-a84e-4e50-a749-1104af7253cd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray::InsertAt
Call this method to insert a new element (or multiple copies of an element) into the array object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index where the element or elements are to be inserted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value of the element or elements to be inserted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of elements to add.  
  
## Remarks  
 Inserts one or more elements into the array, starting at index <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Existing elements are moved to avoid being overwritten.  
  
 In debug builds, an ATLASSERT will be raised if the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object is invalid, the number of elements to be added is zero, or the combined number of elements is too large for the array to contain. In retail builds, passing invalid parameters may cause unpredictable results.  
  
## Example  
 [!code[NVC_ATL_Utilities#9](../vs140/codesnippet/CPP/catlarray--insertat_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAtlArray::Add](../vs140/catlarray--add.md)