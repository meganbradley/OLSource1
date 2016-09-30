---
title: "Threading Models and Critical Sections Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.atl.threads.models"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL, critical sections"
  - "ATL, multithreading"
  - "threading [ATL], models"
  - "critical sections"
ms.assetid: 759f05ef-6285-4be6-a2cc-78572dd75146
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Threading Models and Critical Sections Classes
The following classes define a threading model and critical section:  
  
-   [CAtlAutoThreadModule](../vs140/catlautothreadmodule-class.md) Implements a thread-pooled, apartment-model COM server.  
  
-   [CAtlAutoThreadModuleT](../vs140/catlautothreadmodulet-class.md) Provides methods for implementing a thread-pooled, apartment-model COM server.  
  
-   [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) Provides thread-safe methods for incrementing and decrementing a variable. Provides a critical section.  
  
-   [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) Provides thread-safe methods for incrementing and decrementing a variable. Does not provide a critical section.  
  
-   [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) Provides methods for incrementing and decrementing a variable. Does not provide a critical section.  
  
-   [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md) Determines the appropriate threading-model class for a single object class.  
  
-   [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md) Determines the appropriate threading-model class for an object that is globally available.  
  
-   [CComAutoCriticalSection](../vs140/ccomautocriticalsection-class.md) Contains methods for obtaining and releasing a critical section. The critical section is automatically initialized.  
  
-   [CComCriticalSection](../vs140/ccomcriticalsection-class.md) Contains methods for obtaining and releasing a critical section. The critical section must be explicitly initialized.  
  
-   [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md) Mirrors the methods in `CComCriticalSection` without providing a critical section. The methods in `CComFakeCriticalSection` do nothing.  
  
-   [CRTThreadTraits](../vs140/crtthreadtraits-class.md) Provides the creation function for a CRT thread. Use this class if the thread will use CRT functions.  
  
-   [Win32ThreadTraits](../vs140/win32threadtraits-class.md) Provides the creation function for a Windows thread. Use this class if the thread will not use CRT functions.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)