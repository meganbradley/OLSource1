---
title: "GetAutoInsertExtensions Method"
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
ms.assetid: 78388cce-7aae-4163-8db5-ce00d0a0c331
caps.latest.revision: 12
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
# GetAutoInsertExtensions Method
  Gets information about the apps for Office that are to be automatically inserted during debugging.  
  
 This method is reserved for future use.  
  
## Syntax  
  
```  
HRESULT GetAutoInsertExtensions(  
    [out, retval] SAFEARRAY(BSTR)* psaExtensionNames  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|*psaExtensionNames*|The extension names of the apps for Office.|  
  
## Return Value  
 An HRESULT value that indicates whether the method completed successfully.  
  
## Remarks  
 Each app for Office to be inserted is returned as an Office application extension name, which corresponds to a value under HKEY_CURRENT_USER\Software\Microsoft\Office\WEF\Developer. The host must look up these values in the registry and then automatically insert the extensions.  
  
  