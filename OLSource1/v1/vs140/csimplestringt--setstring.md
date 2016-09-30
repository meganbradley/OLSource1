---
title: "CSimpleStringT::SetString"
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
  - "CSimpleStringT::SetString"
  - "CSimpleStringT<BaseType>::SetString"
  - "ATL::CSimpleStringT<BaseType>::SetString"
  - "ATL::CSimpleStringT::SetString"
  - "ATL.CSimpleStringT<BaseType>.SetString"
  - "CSimpleStringT.SetString"
  - "ATL.CSimpleStringT.SetString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetString method"
ms.assetid: 4c392507-6e14-4b8f-b917-35ad1320d080
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::SetString
Sets the string of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A count of the number of characters in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 Copy a string into the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> overwrites the older string data in the buffer.  
  
 Both versions of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> check whether <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a null pointer, and if it is, throw an **E_INVALIDARG** error.  
  
 The one-parameter version of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> expects <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to point to a null-terminated string.  
  
 The two-parameter version of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> also expects <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to be a null-terminated string. It uses <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> as the string length unless it encounters a null terminator first.  
  
 The two-parameter version of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> also checks whether <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> points to a location in the current buffer in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. In this special case, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> uses a memory copy function that does not overwrite the string data as it copies the string data back to its buffer.  
  
## Example  
 The following example demonstrates the use of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 [!code[NVC_ATLMFC_Utilities#90](../vs140/codesnippet/CPP/csimplestringt--setstring_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)