---
title: "CComBSTR::operator +="
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
  - "CComBSTR.operator+="
  - "ATL.CComBSTR.operator+="
  - "CComBSTR::operator+="
  - "ATL::CComBSTR::operator+="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "+= operator, appending strings"
  - "operator +=, BSTR"
  - "operator+=, BSTR"
ms.assetid: 7383d7c2-f58e-4c18-8a57-17e5b1a3ca74
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::operator +=
Appends a string to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to append.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] A zero-terminated string to append.  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>s are compared textually in the context of the user's default locale. The **LPCOLESTR** comparison is done using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> on the raw data in each string. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> comparison is carried out in the same way once a temporary Unicode copy of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> has been created. The final comparison operator just compares the contained string against **NULL**.  
  
## Example  
 [!code[NVC_ATL_Utilities#48](../vs140/codesnippet/CPP/ccombstr--operator--=_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)   
 [CComBSTR::Append](../vs140/ccombstr--append.md)   
 [CComBSTR::AppendBSTR](../vs140/ccombstr--appendbstr.md)   
 [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md)