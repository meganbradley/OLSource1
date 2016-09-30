---
title: "CComBSTR::CopyTo"
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
  - "CComBSTR::CopyTo"
  - "ATL::CComBSTR::CopyTo"
  - "CComBSTR.CopyTo"
  - "ATL.CComBSTR.CopyTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyTo method"
ms.assetid: 8e687b1b-7c63-4b2b-a056-e0392282c80e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::CopyTo
Allocates and returns a copy of [m_str](../vs140/ccombstr--m_str.md) via the parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pbstr*  
 [out] The address of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in which to return the string allocated by this method.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] The address of a **VARIANT** in which to return the string allocated by this method.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value indicating the success or failure of the copy.  
  
## Remarks  
 After calling this method, the **VARIANT** pointed to by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will be of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_ATL_Utilities#39](../vs140/codesnippet/CPP/ccombstr--copyto_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)   
 [CComBSTR::Copy](../vs140/ccombstr--copy.md)   
 [CComBSTR::operator =](../vs140/ccombstr--operator-=.md)