---
title: "EnsureVSTOComponent Function"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
ms.assetid: e101fcd5-37a2-4b8c-b9ac-a84624298736
caps.latest.revision: 9
ms.author: "ronpet"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# EnsureVSTOComponent Function
  This API supports the Office infrastructure and isn't intended to be used directly from your code.  
  
## Syntax  
  
```  
HRESULT EnsureVSTOComponent(  
    IVSTProject *pProject  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|*pProject*|Don't use.|  
  
## Return Value  
 If the function succeeds, it returns **S_OK**. If the function fails, it returns an error code.  
  
  