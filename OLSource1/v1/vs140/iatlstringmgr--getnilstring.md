---
title: "IAtlStringMgr::GetNilString"
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
  - "ATL.IAtlStringMgr.GetNilString"
  - "IAtlStringMgr::GetNilString"
  - "GetNilString"
  - "ATL::IAtlStringMgr::GetNilString"
  - "IAtlStringMgr.GetNilString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNilString method"
ms.assetid: 6278a62e-2183-4711-a5fb-82a4c0553bcd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAtlStringMgr::GetNilString
Returns a pointer to a string data structure for an empty string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object used to represent an empty string.  
  
## Remarks  
 Call this function to return a representation of an empty string.  
  
> [!NOTE]
>  When implementing a custom string manager, this function must never fail. You can ensure this by embedding an instance of **CNilStringData** in the string manager class, and return a pointer to that instance.  
  
> [!NOTE]
>  For usage examples, see [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md).  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [IAtlStringMgr Class](../vs140/iatlstringmgr-class.md)