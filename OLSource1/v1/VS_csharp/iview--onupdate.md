---
title: "IView::OnUpdate"
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
  - "IView::OnUpdate"
  - "IView.OnUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnUpdate method"
ms.assetid: a5827cbe-a654-4147-8d3c-9b9588b64df1
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IView::OnUpdate
Called by MFC after the view's document has been modified.  
  
## Syntax  
  
```  
void OnUpdate();  
```  
  
## Remarks  
 This function allows the view to update its display to reflect modifications.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [IView Interface](../VS_csharp/iview-interface.md)   
 [CView::OnUpdate](../Topic/CView::OnUpdate.md)   
 [How To: Add Command Routing to the Windows Forms Control](../VS_csharp/how-to--add-command-routing-to-the-windows-forms-control.md)