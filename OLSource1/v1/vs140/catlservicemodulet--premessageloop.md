---
title: "CAtlServiceModuleT::PreMessageLoop"
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
  - "PreMessageLoop"
  - "ATL::CAtlServiceModuleT::PreMessageLoop"
  - "CAtlServiceModuleT::PreMessageLoop"
  - "ATL.CAtlServiceModuleT.PreMessageLoop"
  - "CAtlServiceModuleT.PreMessageLoop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PreMessageLoop method"
ms.assetid: a8cfacaf-ba6d-4533-b3fa-61fb26fee470
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlServiceModuleT::PreMessageLoop
This method is called immediately before entering the message loop.  
  
## Syntax  
  
```  
  
      HRESULT PreMessageLoop(  
   int nShowCmd   
) throw( );  
```  
  
#### Parameters  
 `nShowCmd`  
 This parameter is passed to [CAtlExeModuleT::PreMessageLoop](../vs140/catlexemodulet--premessageloop.md).  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 Override this method to add custom initialization code for the Service.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlServiceModuleT Class](../vs140/catlservicemodulet-class.md)