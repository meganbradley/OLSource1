---
title: "CBasePane::SaveState"
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
  - "CBasePane::SaveState"
  - "CBasePane.SaveState"
  - "SaveState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveState method"
ms.assetid: b4dd16eb-9a08-4404-9ab3-8cd75b2afda7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::SaveState
Saves the pane's state to the registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Profile name.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Profile index.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pane ID.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the state was saved successfully; otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The framework calls this method when it saves the pane's state to the registry. Override <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in a derived class to store additional information.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBasePane::LoadState](../vs140/cbasepane--loadstate.md)