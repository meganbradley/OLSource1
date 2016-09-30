---
title: "CDocObjectServer::OnApplyViewState"
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
  - "CDocObjectServer.OnApplyViewState"
  - "CDocObjectServer::OnApplyViewState"
  - "OnApplyViewState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnApplyViewState method"
ms.assetid: b37d6035-fce7-4815-9d9f-7b140301e513
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocObjectServer::OnApplyViewState
Override this function to restore the state of the DocObject view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object from which to serialize the view state.  
  
## Remarks  
 This function is called when the view is being displayed for the first time after its instantiation. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> instructs a view to reinitialize itself according to the data in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object previously saved with [OnSaveViewState](../vs140/cdocobjectserver--onsaveviewstate.md). The view must validate the data in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object because the container does not attempt to interpret the view state data in any way.  
  
 You can use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to store persistent information specific to your view's state. If you override <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to store information, you will want to override <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to read that information and apply it to your view when it is newly activated.  
  
## Requirements  
 **Header:** afxdocob.h  
  
## See Also  
 [CDocObjectServer Class](../vs140/cdocobjectserver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocObjectServer::OnSaveViewState](../vs140/cdocobjectserver--onsaveviewstate.md)