---
title: "CAxWindow::QueryControl"
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
  - "CAxWindow::QueryControl"
  - "CAxWindow.QueryControl"
  - "QueryControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryControl method"
ms.assetid: 7d919602-347e-49d1-a13d-95384aea41b2
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxWindow::QueryControl
Retrieves the specified interface of the hosted control.  
  
## Syntax  
  
```  
  
      HRESULT QueryControl(  
   REFIID iid,  
   void** ppUnk   
);  
template <class Q>  
HRESULT QueryControl(  
   Q** ppUnk   
);  
```  
  
#### Parameters  
 `iid`  
 [in] Specifies the IID of the control's interface.  
  
 `ppUnk`  
 [out] A pointer to the interface of the control. In the template version of this method, there is no need for a reference ID as long as a typed interface with an associated UUID is passed.  
  
 `Q`  
 [in] The interface that is being queried for.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxWindow Class](../vs140/caxwindow-class.md)   
 [CAxWindow::QueryHost](../vs140/caxwindow--queryhost.md)