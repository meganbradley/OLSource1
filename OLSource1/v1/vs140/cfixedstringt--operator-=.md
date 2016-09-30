---
title: "CFixedStringT::operator ="
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
  - "ATL.CFixedStringT.operator="
  - "CFixedStringT.operator="
  - "CFixedStringT::operator="
  - "ATL::CFixedStringT::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator =, strings"
  - "operator=, strings"
ms.assetid: deeea72e-be54-4ba1-9cd5-f9054458c5a6
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFixedStringT::operator =
Reinitializes an existing <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object with new data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A null-terminated string to be copied into this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to be copied into this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
## Remarks  
 You should be aware that memory exceptions may occur whenever you use the assignment operator because new storage is often allocated to hold the resulting <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CFixedStringT Class](../vs140/cfixedstringt-class.md)