---
title: "CMFCToolBarButton::Show"
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
  - "Show"
  - "CMFCToolBarButton.Show"
  - "CMFCToolBarButton::Show"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Show method"
ms.assetid: b9cb98ea-e88c-44d0-bc13-1baf9361912f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::Show
Shows or hides the button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to show or hide the button. If this parameter is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the button is shown. If the parameter is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the button is hidden.  
  
## Remarks  
 The framework calls this method to update the visibility of toolbar buttons when their parent toolbar is resized. The framework calls this method with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> when the button no longer fits within the bounds of the toolbar. The framework calls this method with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> when after resizing the button again fits within the bounds of the toolbar.  
  
 Use the [CMFCToolBarButton::SetVisible](../vs140/cmfctoolbarbutton--setvisible.md) method to set the general visibility of the button.  
  
 This method calls the [CMFCToolBarButton::OnShow](../vs140/cmfctoolbarbutton--onshow.md) method after it updates the visibility state of the button.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnShow](../vs140/cmfctoolbarbutton--onshow.md)