---
title: "CAtlArray::Add"
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
  - "ATL::CAtlArray::Add"
  - "CAtlArray::Add"
  - "CAtlArray.Add"
  - "ATL.CAtlArray.Add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Add method [ATL]"
ms.assetid: 2db1f70a-7a9c-4560-aec7-12dcc6396f9e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray::Add
Call this method to add an element to the array object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The element to be added to the array.  
  
## Return Value  
 Returns the index of the added element.  
  
## Remarks  
 The new element is added to the end of the array. If no element is provided, an empty element is added; that is, the array is increased in size as though a real element has been added. If the operation fails, [AtlThrow](../vs140/atlthrow.md) is called with the argument E_OUTOFMEMORY.  
  
## Example  
 [!code[NVC_ATL_Utilities#1](../vs140/codesnippet/CPP/catlarray--add_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAtlArray::InsertAt](../vs140/catlarray--insertat.md)