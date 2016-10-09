---
title: "GetVstoSolutionMetadata Function"
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
ms.assetid: e8195838-fb9f-42b2-bb76-7ae3753f7751
caps.latest.revision: 6
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
# GetVstoSolutionMetadata Function
  This API supports the Office infrastructure and isn't intended to be used directly from your code.  
  
## Syntax  
  
```  
HRESULT WINAPI GetVstoSolutionMetadata(  
    LPCWSTR lpwszSolutionMetadataKey,  
    ISolutionMetadata** ppSolutionInfo  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|*lpwszSolutionMetadataKey*|Don't use.|  
|*ppSolutionInfo*|Don't use.|  
  
## Return Value  
 If the function succeeds, it returns **S_OK**. If the function fails, it returns an error code.  
  
  