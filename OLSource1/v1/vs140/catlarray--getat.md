---
title: "CAtlArray::GetAt"
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
  - "ATL::CAtlArray::GetAt"
  - "CAtlArray::GetAt"
  - "ATL.CAtlArray.GetAt"
  - "CAtlArray.GetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAt method [ATL]"
ms.assetid: 9e68323e-372b-4556-9f31-4cb072875943
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray::GetAt
Call this method to retrieves a single element from the array object.  
  
## Syntax  
  
```  
  
      const E& GetAt(  
   size_t iElement   
) const throw( );  
E& GetAt(  
   size_t iElement   
) throw( );  
```  
  
#### Parameters  
 `iElement`  
 The index value of the array element to return.  
  
## Return Value  
 Returns a reference to the required array element.  
  
## Remarks  
 In debug builds, an ATLASSERT will be raised if `iElement` exceeds the number of elements in the array. In release builds, an invalid argument may lead to unpredictable behavior.  
  
## Example  
 [!code[NVC_ATL_Utilities#6](../vs140/codesnippet/CPP/catlarray--getat_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAtlArray::SetAt](../vs140/catlarray--setat.md)