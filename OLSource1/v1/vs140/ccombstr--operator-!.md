---
title: "CComBSTR::operator !"
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
  - "ATL.CComBSTR.operator!"
  - "CComBSTR.operator!"
  - "CComBSTR::operator!"
  - "ATL::CComBSTR::operator!"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "! operator"
  - "operator!, bstr"
  - "operator !, bstr"
ms.assetid: 69d9b881-cce4-4003-b3ab-34b5b47f0067
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::operator !
Checks whether <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> string is NULL.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns **true** if the [m_str](../vs140/ccombstr--m_str.md) member is **NULL**; otherwise, **false**.  
  
## Remarks  
 This operator only checks for a NULL value, not for an empty string.  
  
## Example  
 [!code[NVC_ATL_Utilities#35](../vs140/codesnippet/CPP/ccombstr--operator-!_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)