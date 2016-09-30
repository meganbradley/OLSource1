---
title: "CAtlArray::SetAt"
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
  - "ATL.CAtlArray.SetAt"
  - "ATL::CAtlArray::SetAt"
  - "CAtlArray.SetAt"
  - "CAtlArray::SetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAt method"
ms.assetid: d9ff1cfa-cdc2-4d91-9aa7-60fa102496f6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray::SetAt
Call this method to set the value of an element in the array object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index pointing to the array element to set.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new value of the specified element.  
  
## Remarks  
 In debug builds, an ATLASSERT will be raised if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> exceeds the number of elements in the array. In retail builds, an invalid parameter may result in unpredictable results.  
  
## Example  
 See the example for [CAtlArray::GetAt](../vs140/catlarray--getat.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAtlArray::GetAt](../vs140/catlarray--getat.md)   
 [CAtlArray::SetAtGrow](../vs140/catlarray--setatgrow.md)