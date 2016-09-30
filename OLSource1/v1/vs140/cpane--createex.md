---
title: "CPane::CreateEx"
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
  - "CreateEx"
  - "CPane::CreateEx"
  - "CPane.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: 7a7e9a60-7a92-44bd-868a-65aa856f8329
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::CreateEx
Creates a control bar and attaches it to the [CPane](../vs140/cpane-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies extended window style attributes. For more information, see [Extended Window Styles](../vs140/extended-window-styles.md).  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the name of the Windows class.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies window style attributes. For more information, see [Window Styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the initial size and position of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> window, in client coordinates.  
  
 [in] [out] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the parent window of this pane.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the ID of the pane.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies the style for the pane. For more information, see [CBasePane::CreateEx](../vs140/cbasepane--createex.md).  
  
 [in] [out] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the create context for the pane.  
  
## Return Value  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the pane was created successfully; otherwise, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method creates a Windows pane and attaches it to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
 If you have not explicitly initialized [CPane::m_recentDockInfo](../vs140/cpane--m_recentdockinfo.md) before you call <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the parameter <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> will be used as the rectangle when floating or docking the pane.  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecentDockSiteInfo Class](../vs140/crecentdocksiteinfo-class.md)   
 [CBasePane::CreateEx](../vs140/cbasepane--createex.md)