---
title: "CMFCToolBarButton::OnDraw"
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
  - "CMFCToolBarButton.OnDraw"
  - "OnDraw"
  - "CMFCToolBarButton::OnDraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDraw method"
ms.assetid: b2a84770-9649-4c76-a673-380155919467
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::OnDraw
Called by the framework to draw the button by using the specified styles and options.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The device context that displays the button.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The bounding rectangle of the button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The collection of toolbar images that is associated with the button.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The dock state of the parent toolbar. This parameter is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> when the button is docked horizontally and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when the button is docked vertically.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies whether the toolbar is in customization mode. This parameter is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when the toolbar is in customization mode and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> when the toolbar is not in customization mode.  
  
 [in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies whether the button is highlighted. This parameter is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> when the button is highlighted and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> when the button is not highlighted.  
  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Specifies whether the button should display its border. This parameter is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> when the button should display its border and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> when the button should not display its border.  
  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Specifies whether to shade disabled buttons or use the disabled images collection. This parameter is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> when disabled buttons should be shaded and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> when this method should use the disabled images collection.  
  
## Remarks  
 Override this method to customize toolbar button drawing.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)