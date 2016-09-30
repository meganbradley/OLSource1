---
title: "CDockSite::ShowPane"
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
  - "CDockSite.ShowPane"
  - "CDockSite::ShowPane"
  - "ShowPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowPane method"
ms.assetid: 4e5c2aae-b0b2-410e-ab3d-e0ea29824124
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockSite::ShowPane
Shows the pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the pane to be shown or hidden.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to specify that the pane is to be shown; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to specify that the pane is to be hidden.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to specify that the layout of the pane should be delayed until after the pane is shown; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the pane was shown or hidden successfully. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the specified pane does not belong to this dock site.  
  
## Remarks  
 Call this method to show or hide docked panes. Normally, you do not have to call <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directly, because it is called by the parent frame window or by the base pane.  
  
## Requirements  
 **Header:** afxDockSite.h  
  
## See Also  
 [CDockSite Class](../vs140/cdocksite-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)