---
title: "CPane::OnBeforeChangeParent"
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
  - "OnBeforeChangeParent"
  - "CPane.OnBeforeChangeParent"
  - "CPane::OnBeforeChangeParent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnBeforeChangeParent method"
ms.assetid: e143bf50-a0fe-48cd-afeb-18a61de1b75b
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::OnBeforeChangeParent
Called by the framework when the parent of the pane is about to change.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the new parent window.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to delay the global docking layout adjustment; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method is called by the framework when the parent of the pane is about to change because the pane is being docked or floated.  
  
 By default, the pane is unregistered with the docking pane by calling <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDockSite Class](../vs140/cdocksite-class.md)