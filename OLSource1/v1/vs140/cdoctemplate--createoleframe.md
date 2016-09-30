---
title: "CDocTemplate::CreateOleFrame"
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
  - "CDocTemplate::CreateOleFrame"
  - "CDocTemplate.CreateOleFrame"
  - "CreateOleFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE frame windows"
  - "CreateOleFrame method"
  - "CDocTemplate class, operations"
ms.assetid: 018e65a6-7727-4213-a3fd-e1d79afe9027
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocTemplate::CreateOleFrame
Creates an OLE frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the frame's parent window.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the document to which the new OLE frame window should refer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Determines whether a view is created along with the frame.  
  
## Return Value  
 A pointer to a frame window if successful; otherwise **NULL**.  
  
## Remarks  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is zero, an empty frame is created.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::CreateNewFrame](../vs140/cdoctemplate--createnewframe.md)   
 [COleDocument Class](../vs140/coledocument-class.md)   
 [COleIPFrameWnd Class](../vs140/coleipframewnd-class.md)