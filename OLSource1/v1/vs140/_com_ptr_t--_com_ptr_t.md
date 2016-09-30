---
title: "_com_ptr_t::_com_ptr_t"
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
  - "_com_ptr_t::_com_ptr_t"
  - "_com_ptr_t._com_ptr_t"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_com_ptr_t method"
ms.assetid: 0c00620a-28d2-4f60-ae4a-1696be36137e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _com_ptr_t::_com_ptr_t
**Microsoft Specific**  
  
 Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A raw interface pointer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If **true**, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is called to increment the reference count of the encapsulated interface pointer.  
  
 *cp*  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A raw interface pointer, its type being different from the smart pointer type of this <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
 *varSrc*  
 A <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The **CLSID** of a coclass.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Context for running executable code.  
  
 *lpcStr*  
 A multibyte string that holds either a **CLSID** (starting with "**{**") or a **ProgID**.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The outer unknown for [aggregation](http://msdn.microsoft.com/library/windows/desktop/ms686558).  
  
## See Also  
 [_com_ptr_t Class](../vs140/_com_ptr_t-class.md)