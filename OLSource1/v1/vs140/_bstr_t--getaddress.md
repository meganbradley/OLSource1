---
title: "_bstr_t::GetAddress"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "_bstr_t::GetAddress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAddress method"
ms.assetid: 09bc9180-867e-4ee5-b22a-8339dc663142
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _bstr_t::GetAddress
**Microsoft Specific**  
  
 Frees any existing string and returns the address of a newly allocated string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> wrapped by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> affects all <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> objects that share a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. More than one <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can share a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> through the use of the copy constructor and and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
 See [_bstr_t::Assign](../vs140/_bstr_t--assign.md) for a example using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_bstr_t Class](../vs140/_bstr_t-class.md)