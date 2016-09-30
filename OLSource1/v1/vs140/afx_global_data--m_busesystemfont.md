---
title: "AFX_GLOBAL_DATA::m_bUseSystemFont"
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
  - "GLOBAL_DATA.m_bUseSystemFont"
  - "GLOBAL_DATA::m_bUseSystemFont"
  - "m_bUseSystemFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GLOBAL_DATA structure, data members"
  - "m_bUseSystemFont"
ms.assetid: 8d24797a-8027-4a6f-94d5-0fcc72a5a4a7
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::m_bUseSystemFont
Indicates whether a system font is used for menus, toolbars, and ribbons.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> specifies to use a system font; otherwise, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> constructor initializes this member to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 Testing this member is not the only way for the framework to determine the font to use. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method also tests default and alternative fonts to determine what visual styles are available to be applied to menus, toolbars, and ribbons.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)