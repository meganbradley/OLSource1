---
title: "IView::OnActivateView"
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
  - "IView.OnActivateView"
  - "IView::OnActivateView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnActivateView method"
ms.assetid: 7855222d-cbba-489a-ab11-56b4dc99a859
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IView::OnActivateView
Called by MFC when a view is activated or deactivated.  
  
## Syntax  
  
```  
void OnActivateView(  
   bool activate  
);  
```  
  
#### Parameters  
 `activate`  
 Indicates whether the view is being activated or deactivated.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [IView Interface](../vs140/iview-interface.md)   
 [CView::OnActivateView](../vs140/cview--onactivateview.md)   
 [How To: Add Command Routing to the Windows Forms Control](../vs140/how-to--add-command-routing-to-the-windows-forms-control.md)