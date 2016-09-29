---
title: "AfxSetAmbientActCtx"
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
  - "AfxSetAmbientActCtx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxSetAmbientActCtx function"
ms.assetid: 667211be-2cdb-4b6e-a8e2-d51416a097a7
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxSetAmbientActCtx
Use this function to set the per-module state flag, which affects the WinSxS behavior of MFC.  
  
## Syntax  
  
```  
  
      void AFXAPI AfxSetAmbientActCtx(  
BOOL bSet  
);  
```  
  
#### Parameters  
 `bSet`  
 New value of the module state flag.  
  
## Remarks  
 When the flag is set (which is the default) and a thread enters an MFC module (see [AFX_MANAGE_STATE](../VS_csharp/afx_manage_state.md)), the context of the module is activated.  
  
 If the flag is not set, the context of the module is not activated on entry.  
  
 The context of a module is determined from its manifest, usually embedded in module resources.  
  
## Example  
 [!code[NVC_MFCListView#13](../VS_csharp/codesnippet/CPP/afxsetambientactctx_1.cpp)]  
  
## Requirements  
 **Header:** afxcomctl32.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [AfxGetAmbientActCtx](../VS_csharp/afxgetambientactctx.md)   
 [AFX_MANAGE_STATE](../VS_csharp/afx_manage_state.md)   
 [Managing the State Data of MFC Modules](../VS_csharp/managing-the-state-data-of-mfc-modules.md)