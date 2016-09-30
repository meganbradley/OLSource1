---
title: "CStringT::SetSysString"
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
  - "ATL.CStringT.SetSysString"
  - "CStringT::SetSysString"
  - "SetSysString"
  - "ATL::CStringT::SetSysString"
  - "CStringT.SetSysString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSysString method"
ms.assetid: 283d7a05-4bb4-479b-a1c4-8a0ab08d81d0
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::SetSysString
Reallocates the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointed to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and copies the contents of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object into it, including the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to a character string.  
  
## Return Value  
 The new string.  
  
## Remarks  
 Depending on the contents of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object, the value of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> referenced by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can change. The function throws a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if insufficient memory exists.  
  
 This function is normally used to change the value of strings passed by reference for Automation.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#132](../vs140/codesnippet/CPP/cstringt--setsysstring_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)   
 [CMemoryException Class](../vs140/cmemoryexception-class.md)