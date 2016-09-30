---
title: "CAtlArray::IsEmpty"
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
  - "CAtlArray::IsEmpty"
  - "ATL.CAtlArray.IsEmpty"
  - "ATL::CAtlArray::IsEmpty"
  - "CAtlArray.IsEmpty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsEmpty method"
ms.assetid: 5d7e07a5-7a35-4b97-ad99-6735068d4d15
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray::IsEmpty
Call this method to test if the array is empty.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns true if the array is empty, false otherwise.  
  
## Remarks  
 The array is said to be empty if it contains no elements. Therefore, even if the array contains empty elements, it is not empty.  
  
## Example  
 [!code[NVC_ATL_Utilities#10](../vs140/codesnippet/CPP/catlarray--isempty_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAtlArray::AssertValid](../vs140/catlarray--assertvalid.md)