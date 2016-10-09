---
title: "GetValidCompatibleFramework Function"
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
ms.assetid: dfb365c0-5ffc-4290-ab8b-bd347e0f0db9
caps.latest.revision: 7
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
# GetValidCompatibleFramework Function
  This API supports the Office infrastructure and isn't intended to be used directly from your code.  
  
## Syntax  
  
```  
HRESULT WINAPI GetValidCompatibleFramework(  
    LPCWSTR lpwszCompatibleFrameworksXML,  
    BSTR* pbstrValidFrameworkTag  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|*lpwszCompatibleFrameworksXML*|Don't use.|  
|*pbstrValidFrameworkTag*|Don't use.|  
  
## Return Value  
 If the function succeeds, it returns **S_OK**. If the function fails, it returns an error code.  
  
  