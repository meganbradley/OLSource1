---
title: "CDHtmlDialog::TranslateUrl"
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
  - "CDHtmlDialog.TranslateUrl"
  - "TranslateUrl"
  - "CDHtmlDialog::TranslateUrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TranslateUrl method"
ms.assetid: 1fae9147-a150-4f70-9c06-0cb095414871
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::TranslateUrl
Called to modify the URL to be loaded.  
  
## Syntax  
  
```  
  
      STDMETHOD(TranslateUrl)(  
   DWORD dwTranslate,  
   OLECHAR * pchURLIn,  
   OLECHAR ** ppchURLOut   
);  
```  
  
#### Parameters  
 `dwTranslate`  
 See `dwTranslate` in [IDocHostUIHandler::TranslateUrl](https://msdn.microsoft.com/en-us/library/aa753267.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `pchURLIn`  
 See `pchURLIn` in **IDocHostUIHandler::TranslateUrl** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `ppchURLOut`  
 See `ppchURLOut` in **IDocHostUIHandler::TranslateUrl** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns **S_FALSE**.  
  
## Remarks  
 This member function is CDHtmlDialog's implementation of [IDocHostUIHandler::TranslateUrl](https://msdn.microsoft.com/en-us/library/aa753267.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IDocHostUIhandler Interface](https://msdn.microsoft.com/en-us/library/aa753260.aspx)