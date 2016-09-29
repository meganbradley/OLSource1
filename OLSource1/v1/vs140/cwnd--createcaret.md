---
title: "CWnd::CreateCaret"
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
  - "CreateCaret"
  - "CWnd::CreateCaret"
  - "CWnd.CreateCaret"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateCaret method"
ms.assetid: 2b1f8c38-2280-4bda-9dcb-07edf9186055
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::CreateCaret
Creates a new shape for the system caret and claims ownership of the caret.  
  
## Syntax  
  
```  
  
      void CreateCaret(  
   CBitmap* pBitmap   
);  
```  
  
#### Parameters  
 `pBitmap`  
 Identifies the bitmap that defines the caret shape.  
  
## Remarks  
 The bitmap must have previously been created by the [CBitmap::CreateBitmap](../vs140/cbitmap--createbitmap.md) member function, the [CreateDIBitmap](http://msdn.microsoft.com/library/windows/desktop/dd183491) Windows function, or the [CBitmap::LoadBitmap](../vs140/cbitmap--loadbitmap.md) member function.  
  
 `CreateCaret` automatically destroys the previous caret shape, if any, regardless of which window owns the caret. Once created, the caret is initially hidden. To show the caret, the [ShowCaret](../vs140/cwnd--showcaret.md) member function must be called.  
  
 The system caret is a shared resource. `CWnd` should create a caret only when it has the input focus or is active. It should destroy the caret before it loses the input focus or becomes inactive.  
  
## Example  
 [!code[NVC_MFCWindowing#80](../vs140/codesnippet/CPP/cwnd--createcaret_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBitmap::CreateBitmap](../vs140/cbitmap--createbitmap.md)   
 [CreateDIBitmap](http://msdn.microsoft.com/library/windows/desktop/dd183491)   
 [DestroyCaret](http://msdn.microsoft.com/library/windows/desktop/ms648400)   
 [CBitmap::LoadBitmap](../vs140/cbitmap--loadbitmap.md)   
 [CWnd::ShowCaret](../vs140/cwnd--showcaret.md)   
 [CreateCaret](http://msdn.microsoft.com/library/windows/desktop/ms648399)