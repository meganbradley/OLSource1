---
title: "CComBSTR::ByteLength"
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
  - "ATL::CComBSTR::ByteLength"
  - "ATL.CComBSTR.ByteLength"
  - "CComBSTR::ByteLength"
  - "ByteLength"
  - "CComBSTR.ByteLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ByteLength method"
ms.assetid: c0dd0da0-bfc6-4ac6-b5b9-5d0fe2af4a3c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::ByteLength
Returns the number of bytes in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, excluding the terminating null character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The length of the [m_str](../vs140/ccombstr--m_str.md) member in bytes.  
  
## Remarks  
 Returns 0 if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is **NULL**.  
  
## Example  
 [!code[NVC_ATL_Utilities#36](../vs140/codesnippet/CPP/ccombstr--bytelength_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)   
 [CComBSTR::Length](../vs140/ccombstr--length.md)