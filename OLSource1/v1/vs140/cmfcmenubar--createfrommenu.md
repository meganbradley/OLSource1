---
title: "CMFCMenuBar::CreateFromMenu"
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
  - "CMFCMenuBar.CreateFromMenu"
  - "CreateFromMenu"
  - "CMFCMenuBar::CreateFromMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateFromMenu method"
ms.assetid: bea22436-4b0d-488e-ad58-3290a27a62af
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::CreateFromMenu
Initializes a [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object. This method models the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object after a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A handle to a menu resource. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> uses this resource as a template for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A Boolean that indicates whether the new menu is the default menu.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A Boolean that indicates whether this method forces a menu update.  
  
## Remarks  
 Use this method if you want a menu control to have the same menu items as a menu resource. You call this method after you call either [CMFCMenuBar::Create](../vs140/cmfcmenubar--create.md) or [CMFCMenuBar::CreateEx](../vs140/cmfcmenubar--createex.md).  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)