---
title: "SetWefProcessId Method"
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
ms.assetid: 404eec23-a67e-4f5b-b27d-86651f08be03
caps.latest.revision: 8
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
# SetWefProcessId Method
  Provides the process identifier that will run Web Extensions Framework (WEF) content.  
  
## Syntax  
  
```  
HRESULT SetWefProcessId(  
    [in] DWORD dwProcessId  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|*dwProcessId*|The process identifier that will be used to run WEF content.|  
  
## Return Value  
 An HRESULT value that indicates whether the method completed successfully.  
  
## Remarks  
 This method must be called after the WEF content process is created but before any WEF content runs.  
  
 If you want the development environment to attach a debugger to the WEF content process, the environment must perform this operation in your implementation of this method.  
  
  