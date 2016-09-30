---
title: "CDocTemplate::CreateNewFrame"
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
  - "CreateNewFrame"
  - "CDocTemplate::CreateNewFrame"
  - "CDocTemplate.CreateNewFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateNewFrame method"
  - "frame windows, creating"
  - "CDocTemplate class, operations"
ms.assetid: c695ac24-8515-4a11-b6f9-a83ff95873ca
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocTemplate::CreateNewFrame
Creates a new frame window containing a document and view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The document to which the new frame window should refer. Can be **NULL**.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The frame window on which the new frame window is to be based. Can be **NULL**.  
  
## Return Value  
 A pointer to the newly created frame window, or **NULL** if an error occurs.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> uses the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> objects passed to the constructor to create a new frame window with a view and document attached. If the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter is **NULL**, the framework outputs a TRACE message.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is used to implement the Window New command. It provides a frame window on which to model the new frame window. The new frame window is usually created invisible. Call this function to create frame windows outside the standard framework implementation of File New and File Open.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCreateContext Structure](../vs140/ccreatecontext-structure.md)   
 [CFrameWnd::LoadFrame](../vs140/cframewnd--loadframe.md)   
 [CDocTemplate::InitialUpdateFrame](../vs140/cdoctemplate--initialupdateframe.md)