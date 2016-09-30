---
title: "CMFCTabCtrl::OnDragEnter"
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
  - "OnDragEnter"
  - "CMFCTabCtrl.OnDragEnter"
  - "CMFCTabCtrl::OnDragEnter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDragEnter method"
ms.assetid: 7e401c61-df01-4fce-a07e-c3de9ac556bc
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::OnDragEnter
Called by the framework during a drag-and-drop operation when the cursor first enters the window of the current tab control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a data object that contains data that the user drags.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains the state of the modifier keys. This parameter is a bitwise combination (OR) of the following values: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For more information, see the **Message Parameters** section of [About Mouse Input](http://msdn.microsoft.com/library/windows/desktop/ms645601).  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Contains the current location of the cursor in client coordinates.  
  
## Return Value  
 Always <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which means that the drop target cannot accept the data.  
  
## Remarks  
 Use this method to support a drag-and-drop operation. Override this method to implement your own custom behavior.  
  
 By default, this method only calls <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which always returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [About Mouse Input](http://msdn.microsoft.com/library/windows/desktop/ms645601)