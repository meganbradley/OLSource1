---
title: "CAnimationValue::GetValue"
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
  - "GetValue"
  - "afxanimationcontroller/CAnimationValue::GetValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetValue method"
ms.assetid: b36b8851-3700-43bc-be4d-8d04f6c9d815
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationValue::GetValue
Retrieves the current value.  
  
## Syntax  
  
```  
BOOL GetValue(  
   DOUBLE& dblValue  
);  
BOOL GetValue(  
   INT32& nValue  
);  
```  
  
#### Parameters  
 `dblValue`  
 Output. When the function returns it contains a current value of animation variable.  
  
 `nValue`  
 Output. When the function returns it contains a current value of animation variable.  
  
## Return Value  
 TRUE if the current value was retrieved successfully; otherwise FALSE.  
  
## Remarks  
 Call this function to retrieve the current value. This implementation calls the encapsulated COM object, and if the call fails, this method returns the default value that was previously set in constructor or with SetDefaultValue.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationValue Class](../vs140/canimationvalue-class.md)