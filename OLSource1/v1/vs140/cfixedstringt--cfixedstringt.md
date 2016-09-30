---
title: "CFixedStringT::CFixedStringT"
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
  - "ATL.CFixedStringT.CFixedStringT"
  - "CFixedStringT"
  - "ATL::CFixedStringT::CFixedStringT"
  - "CFixedStringT::CFixedStringT"
  - "CFixedStringT.CFixedStringT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFixedStringT class, constructor"
ms.assetid: 6477bb9c-4cd8-4af3-a392-3f5907258799
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFixedStringT::CFixedStringT
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A null-terminated string to be copied into this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object to be copied into this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the memory manager of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object. For more information on <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and memory management for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, see [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md).  
  
## Remarks  
 Because the constructors copy the input data into new allocated storage, you should be aware that memory exceptions may result. Note that some of these constructors act as conversion functions.  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CFixedStringT Class](../vs140/cfixedstringt-class.md)