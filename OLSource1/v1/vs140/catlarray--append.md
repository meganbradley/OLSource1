---
title: "CAtlArray::Append"
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
  - "CAtlArray.Append"
  - "ATL::CAtlArray::Append"
  - "ATL.CAtlArray.Append"
  - "CAtlArray::Append"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Append method"
ms.assetid: 5d02ac66-b740-4629-926b-15eb4969108e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray::Append
Call this method to add the contents of one array to the end of another.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The array to append.  
  
## Return Value  
 Returns the index of the first appended element.  
  
## Remarks  
 The elements in the supplied array are added to the end of the existing array. If necessary, memory will be allocated to accommodate the new elements.  
  
 The arrays must be of the same type, and it is not possible to append an array to itself.  
  
 In debug builds, an ATLASSERT will be raised if the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> argument is not a valid array or if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> refers to the same object. In release builds, invalid arguments may lead to unpredictable behavior.  
  
## Example  
 [!code[NVC_ATL_Utilities#2](../vs140/codesnippet/CPP/catlarray--append_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAtlArray::InsertArrayAt](../vs140/catlarray--insertarrayat.md)