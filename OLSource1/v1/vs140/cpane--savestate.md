---
title: "CPane::SaveState"
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
  - "CPane::SaveState"
  - "CPane.SaveState"
  - "SaveState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveState method"
ms.assetid: b471aa4e-94b9-4d70-9c45-015a91d3e157
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::SaveState
Saves the state of the pane to the registry.  
  
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
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the state was saved successfully; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The framework calls this method when it saves the state of the pane to the registry. Override <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in a derived class to store additional information.  
  
 When you override this method, also call the base method, and return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the base method returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)