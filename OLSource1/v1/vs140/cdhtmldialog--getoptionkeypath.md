---
title: "CDHtmlDialog::GetOptionKeyPath"
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
  - "GetOptionKeyPath"
  - "CDHtmlDialog.GetOptionKeyPath"
  - "CDHtmlDialog::GetOptionKeyPath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetOptionKeyPath method"
ms.assetid: 4d72ab06-ddf5-484c-b116-5ca97eb44236
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::GetOptionKeyPath
Retrieves the registry key under which user preferences are stored.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetOptionKeyPath)(  
   LPOLESTR * pchKey,  
   DWORD dw   
);  
```  
  
#### Parameters  
 `pchKey`  
 See `pchKey` in [IDocHostUIHandler::GetOptionKeyPath](https://msdn.microsoft.com/en-us/library/aa753258.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `dw`  
 See `dw` in **IDocHostUIHandler::GetOptionKeyPath** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns **E_NOTIMPL**.  
  
## Remarks  
 This member function is CDHtmlDialog's implementation of [IDocHostUIHandler::GetOptionKeyPath](https://msdn.microsoft.com/en-us/library/aa753258.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IDocHostUIhandler Interface](https://msdn.microsoft.com/en-us/library/aa753260.aspx)