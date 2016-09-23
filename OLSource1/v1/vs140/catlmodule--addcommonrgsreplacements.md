---
title: "CAtlModule::AddCommonRGSReplacements"
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
  - CAtlModule.AddCommonRGSReplacements
  - ATL.CAtlModule.AddCommonRGSReplacements
  - CAtlModule::AddCommonRGSReplacements
  - AddCommonRGSReplacements
  - ATL::CAtlModule::AddCommonRGSReplacements
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddCommonRGSReplacements method
ms.assetid: a8b7e6e0-1121-49e3-8694-c9ad67fd8458
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlModule::AddCommonRGSReplacements
Override this method to add parameters to the ATL Registry Component (Registrar) replacement map.  
  
## Syntax  
  
```  
  
      virtual HRESULT AddCommonRGSReplacements(  
   IRegistrarBase* /*pRegistrar*/  
) throw( ) = 0;  
```  
  
#### Parameters  
 *pRegistrar*  
 Reserved.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 Replaceable parameters allow a Registrar's client to specify run-time data. To do this, the Registrar maintains a replacement map into which it enters the values associated with the replaceable parameters in your script. The Registrar makes these entries at run time.  
  
 See the topic [Using Replaceable Parameters (The Registrar's Preprocessor)](../vs140/using-replaceable-parameters--the-registrar-s-preprocessor-.md) for more details.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlModule Class](../vs140/catlmodule-class.md)   
 [Registry Component (Registrar)](../vs140/atl-registry-component--registrar-.md)