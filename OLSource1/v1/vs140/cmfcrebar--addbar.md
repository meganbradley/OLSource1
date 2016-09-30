---
title: "CMFCReBar::AddBar"
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
  - "CMFCReBar.AddBar"
  - "CMFCReBar::AddBar"
  - "AddBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddBar method"
ms.assetid: 7a688f8a-45e0-4a4c-857a-e7f75621335a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCReBar::AddBar
Adds a band to a rebar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the child window that is to be inserted into the rebar. The referenced object must have the **WS_CHILD** window style.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the text to appear on the rebar. The text is not part of the child window. Rather, it is displayed on the rebar itself.  
  
 [in] [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the bitmap to be displayed on the rebar background.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Contains the style to apply to the band. For a complete list of band styles, see the description for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in the [REBARBANDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774393) structure in the Windows SDK documentation.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Represents the foreground color of the rebar.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Represents the background color of the rebar.  
  
## Return Value  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the band was successfully added to the rebar; otherwise, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxRebar.h  
  
## See Also  
 [CMFCReBar Class](../vs140/cmfcrebar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)