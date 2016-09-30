---
title: "CAtlArray::GetData"
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
  - "CAtlArray.GetData"
  - "ATL.CAtlArray.GetData"
  - "CAtlArray::GetData"
  - "ATL::CAtlArray::GetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetData method [ATL]"
ms.assetid: c3344ec0-927e-4cb5-9425-38b067061ace
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray::GetData
Call this method to return a pointer to the first element in the array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns a pointer to the memory location storing the first element in the array. If no elements are available, NULL is returned.  
  
## Example  
 [!code[NVC_ATL_Utilities#7](../vs140/codesnippet/CPP/catlarray--getdata_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAtlArray::GetCount](../vs140/catlarray--getcount.md)