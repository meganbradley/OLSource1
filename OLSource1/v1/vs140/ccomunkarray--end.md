---
title: "CComUnkArray::end"
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
  - "CComUnkArray::end"
  - "ATL::CComUnkArray<nMaxSize>::end"
  - "ATL.CComUnkArray.end"
  - "ATL::CComUnkArray::end"
  - "ATL.CComUnkArray<nMaxSize>.end"
  - "CComUnkArray<nMaxSize>.end"
  - "CComUnkArray<1>::end"
  - "CComUnkArray<nMaxSize>::end"
  - "ATL.CComUnkArray<1>.end"
  - "CComUnkArray.end"
  - "ATL::CComUnkArray<1>::end"
  - "CComUnkArray<1>.end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end method"
ms.assetid: 6aef126a-581e-4d93-9187-1d4127c53b8c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComUnkArray::end
Returns a pointer to one past the last **IUnknown** pointer in the collection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to an **IUnknown** interface pointer.  
  
## Remarks  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> methods **begin** and **end** can be used to loop through all connection points, for example, when an event is fired.  
  
 [!code[NVC_ATL_COM#44](../vs140/codesnippet/CPP/ccomunkarray--end_1.cpp)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComUnkArray Class](../vs140/ccomunkarray-class.md)   
 [CComUnkArray::begin](../vs140/ccomunkarray--begin.md)   
 [CComDynamicUnkArray::end](../vs140/ccomdynamicunkarray--end.md)