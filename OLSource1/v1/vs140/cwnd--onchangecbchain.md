---
title: "CWnd::OnChangeCbChain"
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
  - "OnChangeCbChain"
  - "CWnd.OnChangeCbChain"
  - "WM_CHANGECBCHAIN"
  - "CWnd::OnChangeCbChain"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnChangeCbChain method"
  - "WM_CHANGECBCHAIN"
ms.assetid: 592f8b30-cddb-4619-9cec-fc322333383e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnChangeCbChain
The framework calls this member function for each window in the Clipboard-viewer chain to notify it that a window is being removed from the chain.  
  
## Syntax  
  
```  
  
      afx_msg void OnChangeCbChain(  
   HWND hWndRemove,  
   HWND hWndAfter   
);  
```  
  
#### Parameters  
 `hWndRemove`  
 Specifies the window handle that is being removed from the Clipboard-viewer chain.  
  
 `hWndAfter`  
 Specifies the window handle that follows the window being removed from the Clipboard-viewer chain.  
  
## Remarks  
 Each `CWnd` object that receives an `OnChangeCbChain` call should use the [SendMessage](http://msdn.microsoft.com/library/windows/desktop/ms644950) Windows function to send the [WM_CHANGECBCHAIN](http://msdn.microsoft.com/library/windows/desktop/ms649019) message to the next window in the Clipboard-viewer chain (the handle returned by `SetClipboardViewer`). If `hWndRemove` is the next window in the chain, the window specified by `hWndAfter` becomes the next window, and Clipboard messages are passed on to it.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::ChangeClipboardChain](../vs140/cwnd--changeclipboardchain.md)   
 [SendMessage](http://msdn.microsoft.com/library/windows/desktop/ms644950)