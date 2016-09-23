---
title: "CAtlArray::AssertValid"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL::CAtlArray::AssertValid
  - CAtlArray::AssertValid
  - ATL.CAtlArray.AssertValid
  - CAtlArray.AssertValid
dev_langs: 
  - C++
helpviewer_keywords: 
  - AssertValid method
ms.assetid: 77749fcf-85c8-4abf-826d-e9dff30b5d12
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlArray::AssertValid
Call this method to confirm that the array object is valid.  
  
## Syntax  
  
```  
  
void AssertValid( ) const;  
  
```  
  
## Remarks  
 If the array object is not valid, `ATLASSERT` will throw an assertion. This method is available only if _DEBUG is defined.  
  
## Example  
 [!code[NVC_ATL_Utilities#3](../vs140/codesnippet/CPP/catlarray--assertvalid_1.cpp)]
  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAtlArray::IsEmpty](../vs140/catlarray--isempty.md)