---
title: "CDHtmlDialog::CreateControlSite"
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
  - CreateControlSite
  - CDHtmlDialog::CreateControlSite
  - CDHtmlDialog.CreateControlSite
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateControlSite method
ms.assetid: 5ffe6fa3-d1bc-45d9-bab5-53f14cf1496e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDHtmlDialog::CreateControlSite
Overridable used to create a control site instance to host the WebBrowser control on the dialog.  
  
## Syntax  
  
```  
  
      virtual BOOL CreateControlSite(  
   COleControlContainer* pContainer,  
   COleControlSite** ppSite,  
   UINT /* nID */,  
   REFCLSID /* clsid */   
);  
```  
  
#### Parameters  
 `pContainer`  
 A pointer to the [COleControlContainer](../vs140/colecontrolcontainer-class.md) object  
  
 `ppSite`  
 A pointer to a pointer to a [COleControlSite](../vs140/colecontrolsite-class.md).  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 You can override this member function to return an instance of your own control site class.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)