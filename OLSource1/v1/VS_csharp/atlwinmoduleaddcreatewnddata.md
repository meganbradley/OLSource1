---
title: "AtlWinModuleAddCreateWndData"
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
  - "AtlWinModuleAddCreateWndData"
  - "ATL::AtlWinModuleAddCreateWndData"
  - "ATL.AtlWinModuleAddCreateWndData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlWinModuleAddCreateWndData function"
ms.assetid: 8463a6ed-07ea-4aad-92ec-ded681601b32
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlWinModuleAddCreateWndData
This function is used to initialize and add an `_AtlCreateWndData` structure.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      ATLINLINE ATLAPI_(void) AtlWinModuleAddCreateWndData(  
_ATL_WIN_MODULE * pWinModule,  
_AtlCreateWndData* pData,  
void * pObject  
);  
```  
  
#### Parameters  
 `pWinModule`  
 Pointer to a module's [_ATL_WIN_MODULE70](../VS_csharp/_atl_win_module70-structure.md) structure.  
  
 `pData`  
 Pointer to the [_AtlCreateWndData](../VS_csharp/_atlcreatewnddata-structure.md) structure to be initialized and added to the current module.  
  
 `pObject`  
 Pointer to an object's **this** pointer.  
  
## Remarks  
 Initializes an `_AtlCreateWndData` structure, which is used to store the **this** pointer used to refer to class instances, and adds it to the list referenced by a module's `_ATL_WIN_MODULE70` structure. Called by [CAtlWinModule::AddCreateWndData](../Topic/CAtlWinModule::AddCreateWndData.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [WinModule Global Functions](../VS_csharp/winmodule-global-functions.md)   
 [AtlWinModuleExtractCreateWndData](../VS_csharp/atlwinmoduleextractcreatewnddata.md)