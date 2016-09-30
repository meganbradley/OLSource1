---
title: "CComBSTR::CComBSTR"
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
  - "CComBSTR::CComBSTR"
  - "CComBSTR.CComBSTR"
  - "ATL.CComBSTR.CComBSTR"
  - "ATL::CComBSTR::CComBSTR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComBSTR class, constructor"
  - "CComBSTR constructor"
ms.assetid: 738ade40-31f1-47fc-bae1-303437db310e
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::CComBSTR
The constructor. The default constructor sets the [m_str](../vs140/ccombstr--m_str.md) member to **NULL**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The number of characters to copy from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or the initial size in characters for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] A string to copy. The Unicode version specifies an **LPCOLESTR**; the ANSI version specifies an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] A string to copy. The Unicode version specifies an **LPCOLESTR**; the ANSI version specifies an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 *src*  
 [in] A <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] A reference to a **GUID** structure.  
  
## Remarks  
 The copy constructor sets <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to a copy of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member of *src*. The **REFGUID** constructor converts the **GUID** to a string using **StringFromGUID2** and stores the result.  
  
 The other constructors set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to a copy of the specified string. If you pass a value for <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, then only <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> characters will be copied, followed by a terminating null character.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> supports move semantics. You can use the move constructor (the constructor that takes an rvalue reference (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) to create a new object that uses the same underlying data as the old object you pass in as an argument, without the overhead of copying the object.  
  
 The destructor frees the string pointed to by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_ATL_Utilities#37](../vs140/codesnippet/CPP/ccombstr--ccombstr_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)   
 [ATL and MFC String Conversion Macros](assetId:///6ffb16b0-df9e-4011-a105-f756c3caf3ba)