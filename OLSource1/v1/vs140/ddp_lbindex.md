---
title: "DDP_LBIndex"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DDP_LBIndex"
  - "AFXCTL/DDP_LBIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDP_LBIndex function"
ms.assetid: e316d783-df93-4bfa-a3c8-7816b5fb9207
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDP_LBIndex
Call this function in your property page's `DoDataExchange` function to synchronize the value of an integer property with the index of the current selection in a list box on the property page.  
  
## Syntax  
  
```  
  
      void AFXAPI DDP_LBIndex(  
   CDataExchange* pDX,  
   int id,  
   int& member,  
   LPCTSTR pszPropName   
);  
```  
  
#### Parameters  
 `pDX`  
 Pointer to a `CDataExchange` object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 `id`  
 The resource ID of the list box control associated with the control property specified by `pszPropName`.  
  
 `member`  
 The member variable associated with the property page control specified by `id` and the property specified by `pszPropName`.  
  
 `pszPropName`  
 The property name of the control property to be exchanged with the list box string specified by `id`.  
  
## Remarks  
 This function should be called before the corresponding `DDX_LBIndex` function call.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDP_LBString](../vs140/ddp_lbstring.md)   
 [DDP_CBIndex](../vs140/ddp_cbindex.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)   
 [DDX_LBIndex](../vs140/ddx_lbindex.md)