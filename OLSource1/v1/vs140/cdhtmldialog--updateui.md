---
title: "CDHtmlDialog::UpdateUI"
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
  - CDHtmlDialog::UpdateUI
  - UpdateUI
  - CDHtmlDialog.UpdateUI
dev_langs: 
  - C++
helpviewer_keywords: 
  - UpdateUI method
ms.assetid: 5ce67b61-5751-4faa-a025-d269139ebfc3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDHtmlDialog::UpdateUI
Called to notify the host that the command state has changed.  
  
## Syntax  
  
```  
  
STDMETHOD(UpdateUI)( void );  
  
```  
  
## Return Value  
 Returns **E_NOTIMPL**.  
  
## Remarks  
 This member function is CDHtmlDialog's implementation of [IDocHostUIHandler::UpdateUI](https://msdn.microsoft.com/en-us/library/aa753268.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IDocHostUIhandler Interface](https://msdn.microsoft.com/en-us/library/aa753260.aspx)