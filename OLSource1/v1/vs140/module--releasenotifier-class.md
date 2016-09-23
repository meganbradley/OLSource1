---
title: "Module::ReleaseNotifier Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - module/Microsoft::WRL::Module::ReleaseNotifier
dev_langs: 
  - C++
helpviewer_keywords: 
  - ReleaseNotifier class
ms.assetid: 17249cd1-4d88-42e3-8146-da9e942d12bd
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Module::ReleaseNotifier Class
Invokes an event handler when the last object in a module is released.  
  
## Syntax  
  
```  
class ReleaseNotifier;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[Module::ReleaseNotifier::~ReleaseNotifier Destructor](../vs140/module--releasenotifier--~releasenotifier-destructor.md)|Deinitializes the current instance of the Module::ReleaseNotifier class.|  
|[Module::ReleaseNotifier::ReleaseNotifier Constructor](../vs140/module--releasenotifier--releasenotifier-constructor.md)|Initializes a new instance of the Module::ReleaseNotifier class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[Module::ReleaseNotifier::Invoke Method](../vs140/module--releasenotifier--invoke-method.md)|When implemented, calls an event handler when the last object in a module is released.|  
|[Module::ReleaseNotifier::Release Method](../vs140/module--releasenotifier--release.md)|Deletes the current Module::ReleaseNotifier object if the object was constructed with a parameter of `true`.|  
  
## Inheritance Hierarchy  
 `ReleaseNotifier`  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Module Class](../vs140/module-class.md)