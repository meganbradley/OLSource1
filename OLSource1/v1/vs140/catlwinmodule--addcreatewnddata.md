---
title: "CAtlWinModule::AddCreateWndData"
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
  - "ATL::CAtlWinModule::AddCreateWndData"
  - "ATL.CAtlWinModule.AddCreateWndData"
  - "AddCreateWndData"
  - "CAtlWinModule.AddCreateWndData"
  - "CAtlWinModule::AddCreateWndData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddCreateWndData method"
ms.assetid: dfef9bd1-409c-44bc-aac3-ef86bfc83570
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlWinModule::AddCreateWndData
This method initializes and adds an `_AtlCreateWndData` structure.  
  
## Syntax  
  
```  
  
      void AddCreateWndData(  
   _AtlCreateWndData* pData,  
   void* pObject   
);  
```  
  
#### Parameters  
 `pData`  
 Pointer to the `_AtlCreateWndData` structure to be initialized and added to the current module.  
  
 `pObject`  
 Pointer to an object's **this** pointer.  
  
## Remarks  
 This method calls [AtlWinModuleAddCreateWndData](../vs140/atlwinmoduleaddcreatewnddata.md) which initializes an [_AtlCreateWndData](../vs140/_atlcreatewnddata-structure.md) structure. This structure will store the **this** pointer, used to obtain the class instance in window procedures.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlWinModule Class](../vs140/catlwinmodule-class.md)   
 [CAtlWinModule::ExtractCreateWndData](../vs140/catlwinmodule--extractcreatewnddata.md)