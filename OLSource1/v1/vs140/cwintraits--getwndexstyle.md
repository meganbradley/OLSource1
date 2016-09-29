---
title: "CWinTraits::GetWndExStyle"
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
  - "CWinTraits::GetWndExStyle"
  - "GetWndExStyle"
  - "ATL.CWinTraits.GetWndExStyle"
  - "CWinTraits.GetWndExStyle"
  - "ATL::CWinTraits::GetWndExStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetWndExStyle method"
ms.assetid: a1b4bd84-cb1f-41ea-8bda-4d5d6bd18782
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinTraits::GetWndExStyle
Call this function to retrieve the extended styles of the `CWinTraits` object.  
  
## Syntax  
  
```  
  
      static DWORD GetWndExStyle(  
   DWORD dwExStyle   
);  
```  
  
#### Parameters  
 `dwExStyle`  
 Extended styles used for creation of a window. If `dwExStyle` is 0, the template style values (`t_dwExStyle`) are returned. If `dwExStyle` is nonzero, `dwExStyle` is returned.  
  
## Return Value  
 The extended window styles of the object.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWinTraits Class](../vs140/cwintraits-class.md)   
 [CWinTraits::GetWndStyle](../vs140/cwintraits--getwndstyle.md)