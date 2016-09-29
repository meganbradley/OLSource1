---
title: "SimpleActivationFactory::GetTrustLevel Method"
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
  - "module/Microsoft::WRL::SimpleActivationFactory::GetTrustLevel"
dev_langs: 
  - "C++"
ms.assetid: 99aa9bc9-d954-4a6f-902b-4abe00e43039
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SimpleActivationFactory::GetTrustLevel Method
Gets the trust level of an instance of the class specified by the `Base` class template parameter.  
  
## Syntax  
  
```  
STDMETHOD(  
   GetTrustLevel  
)(_Out_ TrustLevel* trustLvl);  
```  
  
#### Parameters  
 `trustLvl`  
 When this operation completes, the trust level of the current class object.  
  
## Return Value  
 Always S_OK.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [SimpleActivationFactory Class](../vs140/simpleactivationfactory-class.md)