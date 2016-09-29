---
title: "IRunnableObjectImpl::Run"
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
  - "IRunnableObjectImpl::Run"
  - "IRunnableObjectImpl.Run"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Run method"
ms.assetid: 11012ede-6679-4c36-a60e-938fe8c2e750
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRunnableObjectImpl::Run
Forces the control to run.  
  
## Syntax  
  
```  
  
      HRESULT Run(  
   LPBINDCTX lpbc  
);  
```  
  
## Return Value  
 The ATL implementation returns `S_OK`.  
  
## Remarks  
 See [IRunnableObject::Run](http://msdn.microsoft.com/library/windows/desktop/ms694517) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IRunnableObjectImpl Class](../vs140/irunnableobjectimpl-class.md)