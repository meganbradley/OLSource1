---
title: "CDockablePane::OnBeforeFloat"
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
  - "CDockablePane.OnBeforeFloat"
  - "CDockablePane::OnBeforeFloat"
  - "OnBeforeFloat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnBeforeFloat method"
ms.assetid: 6088127a-f396-4cb0-87be-3776db71448c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::OnBeforeFloat
The framework calls this method before a pane transitions to a floating state.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the position and size of the pane when it is in a floating state.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the docking method. See [CPane::DockPane](../vs140/cpane--dockpane.md) for a list of possible values.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the pane can be floated; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method is called by the framework when a pane is about to float. You can override this method in a derived class if you want to perform any processing before the pane floats.  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPane::OnBeforeFloat](../vs140/cpane--onbeforefloat.md)