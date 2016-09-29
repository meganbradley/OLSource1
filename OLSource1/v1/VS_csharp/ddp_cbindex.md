---
title: "DDP_CBIndex"
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
  - "DDP_CBIndex"
  - "AFXCTL/DDP_CBIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDP_CBIndex function"
ms.assetid: 0073dc1a-35a7-4df4-9110-786a25b15de4
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDP_CBIndex
Call this function in your property page's `DoDataExchange` function to synchronize the value of an integer property with the index of the current selection in a combo box on the property page.  
  
## Syntax  
  
```  
  
      void AFXAPI DDP_CBIndex(  
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
 The resource ID of the combo box control associated with the control property specified by `pszPropName`.  
  
 `member`  
 The member variable associated with the property page control specified by `id` and the property specified by `pszPropName`.  
  
 `pszPropName`  
 The property name of the control property to be exchanged with the combo box control specified by `id`.  
  
## Remarks  
 This function should be called before the corresponding `DDX_CBIndex` function call.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DDP_CBString](../VS_csharp/ddp_cbstring.md)   
 [DDP_Text](../VS_csharp/ddp_text.md)   
 [COleControl::DoPropExchange](../Topic/COleControl::DoPropExchange.md)   
 [DDX_CBIndex](../VS_csharp/ddx_cbindex.md)