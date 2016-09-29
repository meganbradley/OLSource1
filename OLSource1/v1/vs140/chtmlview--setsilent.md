---
title: "CHtmlView::SetSilent"
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
  - "CHtmlView::SetSilent"
  - "SetSilent"
  - "CHtmlView.SetSilent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSilent method"
  - "CHtmlView class, properties"
  - "CHtmlView class, attributes"
ms.assetid: 40be4e9a-a5ec-4245-a3ff-476dceb81f99
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::SetSilent
Call this member function to set a value indicating whether any dialog boxes can be shown.  
  
## Syntax  
  
```  
  
      void SetSilent(  
   BOOL bNewValue   
);  
```  
  
#### Parameters  
 `bNewValue`  
 If nonzero, dialog boxes will not be displayed; if zero, dialog boxes will be displayed. The default value is zero.  
  
## Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetSilent](../vs140/chtmlview--getsilent.md)   
 [IWebBrowser2::put_Silent](https://msdn.microsoft.com/en-us/library/aa768269.aspx)