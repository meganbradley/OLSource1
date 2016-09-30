---
title: "CMFCToolBar::GetButtonInfo"
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
  - "CMFCToolBar.GetButtonInfo"
  - "GetButtonInfo"
  - "CMFCToolBar::GetButtonInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetButtonInfo method"
ms.assetid: 792413fe-93cc-4e8f-9f3f-e5723ba7f4b0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetButtonInfo
Returns the command ID, style, and image index of the button at a specified index.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the index of the button in the list of buttons on the toolbar.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The command ID of a button.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The style of the button.  
  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The index of the image for the button.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method finds a toolbar button at the specified index and retrieves the command ID, style and image index of the button.  
  
 If the button at the specified index does not exist, the framework sets <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to 0, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to -1 when the method returns.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)