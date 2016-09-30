---
title: "CPane::UpdateVirtualRect"
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
  - "CPane.UpdateVirtualRect"
  - "CPane::UpdateVirtualRect"
  - "UpdateVirtualRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateVirtualRect method"
ms.assetid: b7a2ea8b-831f-42cc-b892-2c5cbcce2f3e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::UpdateVirtualRect
Updates the virtual rectangle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that specifies an offset by which to shift the pane.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that specifies a new size for the  pane.  
  
## Remarks  
 The first overload sets the virtual rectangle by using the current position and size of the pane.  
  
 The second overload shifts the virtual rectangle by the amount that is specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The third overload sets the virtual rectangle by using the current position of the pane and the size that is specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)