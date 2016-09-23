---
title: "CHtmlView::OnTranslateUrl"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CHtmlView.OnTranslateUrl
  - CHtmlView::OnTranslateUrl
  - OnTranslateUrl
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnTranslateUrl method
ms.assetid: 4940706e-b679-4a76-94cb-c06f9e72c558
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlView::OnTranslateUrl
Called by Internet Explorer or MSHTML to allow the host an opportunity to modify the URL to be loaded.  
  
## Syntax  
  
```  
  
      virtual HRESULT OnTranslateUrl(  
   DWORD dwTranslate,  
   OLECHAR* pchURLIn,  
   OLECHAR** ppchURLOut   
);  
```  
  
#### Parameters  
 `dwTranslate`  
 Reserved for future use.  
  
 `pchURLIn`  
 Address of a string supplied by Internet Explorer or MSHTML that represents the URL to be translated.  
  
 `ppchURLOut`  
 Address of a string pointer that receives the address of the translated URL. The host allocates the buffer using the task memory allocator. The contents of this parameter should always be initialized to **NULL**, even if the URL is not translated or the method fails.  
  
## Return Value  
 `S_OK` if the URL was translated, **S_FALSE** if the URL was not translated, or an OLE-defined error code if an error occurred.  
  
## Remarks  
 Override `OnTranslateUrl` to react to the `TranslateUrl` notification from the Microsoft Web Browser control. See [IDocHostUIHandler::TranslateUrl](https://msdn.microsoft.com/en-us/library/aa753267.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)