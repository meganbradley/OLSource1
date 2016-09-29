---
title: "CHtmlView::OnNavigateError"
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
  - "OnNavigateError"
  - "CHtmlView::OnNavigateError"
  - "CHtmlView.OnNavigateError"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnNavigateError method"
ms.assetid: 129d6f2b-f983-48f0-8e7d-37a669812c74
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnNavigateError
Called by the framework if navigation to a hyperlink fails.  
  
## Syntax  
  
```  
  
      virtual void OnNavigateError(  
   LPCTSTR lpszURL,  
   LPCTSTR lpszFrame,  
   DWORD dwError,  
   BOOL *pbCancel  
);  
```  
  
#### Parameters  
 `lpszURL`  
 The URL for which navigation failed.  
  
 *lpszFrame*  
 The name of the frame in which the resource is to be displayed, or NULL if no named frame was targeted for the resource.  
  
 `dwError`  
 An error status code, if available. For a list of the possible HRESULT and HTTP status codes, see [NavigateError Event Status Codes.](https://msdn.microsoft.com/en-us/library/aa768365.aspx)  
  
 `pbCancel`  
 Specifies whether to cancel the navigation to an error page or any further autosearch. If **TRUE** (the default), continue with navigation to an error page or autosearch; if **FALSE**, cancel navigation to an error page or autosearch.  
  
## Remarks  
 Override this method to provide custom navigation error handling.  
  
 For more information, see [DWebBrowserEvents2::NavigateError](https://msdn.microsoft.com/en-us/library/aa768286.aspx)  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)