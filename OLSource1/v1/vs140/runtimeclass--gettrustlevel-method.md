---
title: "RuntimeClass::GetTrustLevel Method"
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
  - "implements/Microsoft::WRL::RuntimeClass::GetTrustLevel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTrustLevel method"
ms.assetid: bd90407e-6dd7-41c3-9ea0-c402c276014a
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RuntimeClass::GetTrustLevel Method
Gets the trust level of the current RuntimeClass object.  
  
## Syntax  
  
```  
STDMETHOD(  
   GetTrustLevel  
)(_Out_ TrustLevel* trustLvl);  
```  
  
## Parameters  
 `trustLvl`  
 When this operation completes, the trust level of the current RuntimeClass object.  
  
## Return Value  
 Always S_OK.  
  
## Remarks  
 An assert error is emitted if __WRL_STRICT\__or \__WRL_FORCE_INSPECTABLE_CLASS_MACRO\_\_ isn't defined.  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [RuntimeClass Class](../vs140/runtimeclass-class.md)