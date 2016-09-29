---
title: "DDP_CBString"
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
  - "DDP_CBString"
  - "AFXCTL/DDP_CBString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDP_CBString function"
ms.assetid: d1dc7f53-1012-4a71-80ae-dc5b07649ef2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDP_CBString
Call this function in your property page's `DoDataExchange` function to synchronize the value of a string property with the current selection in a combo box on the property page.  
  
## Syntax  
  
```  
  
      void AFXAPI DDP_CBString(  
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
 This function should be called before the corresponding `DDX_CBString` function call.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDP_CBStringExact](../vs140/ddp_cbstringexact.md)   
 [DDP_CBIndex](../vs140/ddp_cbindex.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)   
 [DDX_CBString](../vs140/ddx_cbstring.md)