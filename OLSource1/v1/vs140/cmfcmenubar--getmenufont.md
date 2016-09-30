---
title: "CMFCMenuBar::GetMenuFont"
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
  - "GetMenuFont"
  - "CMFCMenuBar.GetMenuFont"
  - "CMFCMenuBar::GetMenuFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMenuFont method"
ms.assetid: bcdadbc3-3fd4-4129-8a68-34777bcf33ae
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::GetMenuFont
Retrieves the current menu font.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether to return the horizontal or vertical font. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> indicates the horizontal font.  
  
## Return Value  
 A pointer to a [CFont](../vs140/cfont-class.md) parameter that contains the current menu bar font.  
  
## Remarks  
 The returned font is a global parameter for the application. Two global fonts are maintained for all <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects. These separate fonts are used for horizontal and vertical menu bars.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCMenuBar::SetMenuFont](../vs140/cmfcmenubar--setmenufont.md)