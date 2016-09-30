---
title: "_ATL_WIN_MODULE70 Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_ATL_WIN_MODULE70"
  - "ATL::_ATL_WIN_MODULE70"
  - "ATL._ATL_WIN_MODULE70"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_ATL_WIN_MODULE70 structure"
  - "ATL_WIN_MODULE70 structure"
ms.assetid: a0aaf3ea-ca77-46ec-bd53-4dfb61dffbea
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ATL_WIN_MODULE70 Structure
Used by windowing code in ATL.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The size of the structure, used for versioning.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Used to serialize access to window registration code. Used internally by ATL.  
  
 **m_pCreateWndList**  
 Used to bind windows to their objects. Used internally by ATL.  
  
 **m_rgWindowClassAtoms**  
 Used to track window class registrations so that they can be properly unregistered at termination. Used internally by ATL.  
  
## Remarks  
 [_ATL_WIN_MODULE](../vs140/_atl_win_module.md) is defined as a typedef of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Structures](../vs140/atl-structures.md)