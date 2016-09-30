---
title: "CMFCDropDownFrame::Create"
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
  - "CMFCDropDownFrame.Create"
  - "Create"
  - "CMFCDropDownFrame::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 9f2b5ed0-9571-47cc-9537-b75ce2c7b92e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDropDownFrame::Create
Creates a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The parent window of the drop-down frame.|  
|[in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The horizontal screen coordinate for the location of the down-down frame.|  
|[in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The vertical screen coordinate for the location of the down-down frame.|  
|[in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The toolbar that has the drop-down buttons that this method uses to populate the new drop-down frame object.|  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the drop-down frame was successfully created; otherwise <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method calls the base [CMiniFrameWnd::CreateEx](../vs140/cminiframewnd--createex.md) method to create the drop-down frame window with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> style. The drop-down frame window appears at the specified screen coordinates. This method fails if the [CMiniFrameWnd::CreateEx](../vs140/cminiframewnd--createex.md) method returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class creates a copy of the provided <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter. This method copies the button images and button states from the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> data member.  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
## See Also  
 [CMFCDropDownFrame Class](../vs140/cmfcdropdownframe-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMiniFrameWnd::CreateEx](../vs140/cminiframewnd--createex.md)   
 [CMFCDropDownToolBar Class](../vs140/cmfcdropdowntoolbar-class.md)