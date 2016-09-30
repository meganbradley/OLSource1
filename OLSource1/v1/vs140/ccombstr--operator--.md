---
title: "CComBSTR::operator &amp;"
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
  - "CComBSTR::operator&"
  - "CComBSTR.operator&"
  - "ATL::CComBSTR::operator&"
  - "ATL.CComBSTR.operator&"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "& operator, with specific objects"
ms.assetid: 143ad1cf-d83e-4d6d-806e-a04a1712c857
caps.latest.revision: 30
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::operator &amp;
Returns the address of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> stored in the [m_str](../vs140/ccombstr--m_str.md) member.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> has a special assertion associated with it to help identify memory leaks. The program will assert when the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member is initialized. This assertion was created to identify situations where a programmer uses the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to assign a new value to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member without freeing the first allocation of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> equals NULL, the program assumes that m_str wasn't allocated yet. In this case, the program will not assert.  
  
 This assertion is not enabled by default. Define <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to enable this assertion.  
  
## Example  
 [!code[NVC_ATL_Utilities#46](../vs140/codesnippet/CPP/ccombstr--operator--_1.cpp)]  
  
 [!code[NVC_ATL_Utilities#47](../vs140/codesnippet/CPP/ccombstr--operator--_2.cpp)]  
  
## Requirements  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)