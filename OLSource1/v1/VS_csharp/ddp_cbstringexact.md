---
title: "DDP_CBStringExact"
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
  - "AFXCTL/DDP_CBStringExact"
  - "DDP_CBStringExact"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDP_CBStringExact function"
ms.assetid: 3fba7e64-ca8f-4a3b-925a-a7bd09baed1e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDP_CBStringExact
Call this function in your property page's `DoDataExchange` function to synchronize the value of a string property that exactly matches the current selection in a combo box on the property page.  
  
## Syntax  
  
```  
  
      void AFXAPI DDP_CBStringExact(  
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
 The resource ID of the combo box control associated with the control property specified by `pszPropName`.  
  
 `member`  
 The member variable associated with the property page control specified by `id` and the property specified by `pszPropName`.  
  
 `pszPropName`  
 The property name of the control property to be exchanged with the combo box string specified by `id`.  
  
## Remarks  
 This function should be called before the corresponding `DDX_CBStringExact` function call.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DDP_CBString](../VS_csharp/ddp_cbstring.md)   
 [DDP_CBIndex](../VS_csharp/ddp_cbindex.md)   
 [COleControl::DoPropExchange](../Topic/COleControl::DoPropExchange.md)   
 [DDX_CBStringExact](../VS_csharp/ddx_cbstringexact.md)