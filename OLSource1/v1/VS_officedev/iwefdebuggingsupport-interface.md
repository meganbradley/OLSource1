---
title: "IWefDebuggingSupport Interface"
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
ms.assetid: 0bd1c6a6-67a5-4478-b942-8b937b28f723
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
# IWefDebuggingSupport Interface
  Implemented by a debugging environment, such as Visual Studio, to facilitate debugging of apps for Office. The Office application, such as Word or Excel, obtains this interface from Visual Studio and then calls methods on the interface at certain points during the debugging session.  
  
## Syntax  
  
```  
[  
    uuid(ccaf1a90-ce1c-4199-9cd6-b40c5c57a671),  
    oleautomation  
]  
interface IWefDebuggingSupport : IUnknown  
{  
    HRESULT SetWefProcessId(  
        [in] DWORD dwProcessId);  
    HRESULT GetAutoInsertExtensions(  
        [out, retval] SAFEARRAY(BSTR)* psaExtensionNames);  
}  
```  
  
## Methods  
 The following table lists the methods that the IWefDebuggingSupport interface defines.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAutoInsertExtensions Method](../VS_officedev/getautoinsertextensions-method.md)|Gets information about the apps for Office that are to be automatically inserted during debugging.|  
|[SetWefProcessId Method](../VS_officedev/setwefprocessid-method.md)|Provides the process identifier that will run Web Extensions Framework (WEF) content.|  
  
  