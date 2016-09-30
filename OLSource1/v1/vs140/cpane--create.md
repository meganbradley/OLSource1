---
title: "CPane::Create"
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
  - "CPane.Create"
  - "Create"
  - "CPane::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: ace97db5-cc11-4300-98f8-68d0c7e10797
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::Create
Creates a control bar and attaches it to the [CPane](../vs140/cpane-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the name of the Windows class.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the window style attributes. For more information, see [Window Styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the initial size and position of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> window, in client coordinates.  
  
 [in] [out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the parent window of this pane.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the ID of the pane.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the style for the pane. For more information, see [CBasePane::CreateEx](../vs140/cbasepane--createex.md).  
  
 [in] [out] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies the create context of the pane.  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the pane was created successfully; otherwise, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method creates a Windows pane and attaches it to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
 If you have not explicitly initialized [CPane::m_recentDockInfo](../vs140/cpane--m_recentdockinfo.md) before you call <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the parameter <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> will be used as the rectangle when floating or docking the pane.  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecentDockSiteInfo Class](../vs140/crecentdocksiteinfo-class.md)   
 [CBasePane::CreateEx](../vs140/cbasepane--createex.md)