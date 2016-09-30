---
title: "COleServerDoc::OnDocWindowActivate"
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
  - "COleServerDoc.OnDocWindowActivate"
  - "COleServerDoc::OnDocWindowActivate"
  - "OnDocWindowActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, overridables"
  - "OnDocWindowActivate method"
ms.assetid: 2ae5a5c4-b1d8-4eba-9e0a-afbebcb9e0cd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::OnDocWindowActivate
The framework calls this function to activate or deactivate a document window for in-place editing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether the document window is to be activated or deactivated.  
  
## Remarks  
 The default implementation removes or adds the frame-level user interface elements as appropriate. Override this function if you want to perform additional actions when the document containing your item is activated or deactivated.  
  
 For more information, see the article [Activation](../vs140/activation--c---.md)..  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::ActivateInPlace](../vs140/coleserverdoc--activateinplace.md)   
 [COleServerDoc::OnReactivateAndUndo](../vs140/coleserverdoc--onreactivateandundo.md)   
 [COleServerDoc::OnShowControlBars](../vs140/coleserverdoc--onshowcontrolbars.md)   
 [COleServerDoc::OnDeactivateUI](../vs140/coleserverdoc--ondeactivateui.md)   
 [COleServerDoc::OnFrameWindowActivate](../vs140/coleserverdoc--onframewindowactivate.md)   
 [COleIPFrameWnd Class](../vs140/coleipframewnd-class.md)