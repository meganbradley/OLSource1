---
title: "CAtlExeModuleT::PreMessageLoop"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CAtlExeModuleT.PreMessageLoop
  - CAtlExeModuleT::PreMessageLoop
dev_langs: 
  - C++
helpviewer_keywords: 
  - PreMessageLoop method
ms.assetid: 0acafc5f-a037-462e-a49f-25f0d7565947
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlExeModuleT::PreMessageLoop
This method is called immediately before entering the message loop.  
  
## Syntax  
  
```  
  
      HRESULT PreMessageLoop(  
   int nShowCmd  
) throw( );  
```  
  
#### Parameters  
 `nShowCmd`  
 The value passed as the `nShowCmd` parameter in WinMain.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 Override this method to add custom initialization code for the application. The default implementation registers the class objects.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlExeModuleT Class](../vs140/catlexemodulet-class.md)   
 [CAtlExeModuleT::PostMessageLoop](../vs140/catlexemodulet--postmessageloop.md)   
 [CAtlExeModuleT::WinMain](../vs140/catlexemodulet--winmain.md)