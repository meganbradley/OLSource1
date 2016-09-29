---
title: "DDP_LBStringExact"
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
  - "AFXCTL/DDP_LBStringExact"
  - "DDP_LBStringExact"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDP_LBStringExact function"
ms.assetid: 8fe84ae9-d047-4a2a-a4e3-051498210a2b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDP_LBStringExact
Call this function in your property page's `DoDataExchange` function to synchronize the value of a string property that exactly matches the current selection in a list box on the property page.  
  
## Syntax  
  
```  
  
      void AFXAPI DDP_LBStringExact(  
   CDataExchange* pDX,  
   int id,  
   CString& member,  
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
 This function should be called before the corresponding `DDX_LBStringExact` function call.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DDP_LBString](../VS_csharp/ddp_lbstring.md)   
 [DDP_LBIndex](../VS_csharp/ddp_lbindex.md)   
 [COleControl::DoPropExchange](../Topic/COleControl::DoPropExchange.md)   
 [DDX_LBStringExact](../VS_csharp/ddx_lbstringexact.md)