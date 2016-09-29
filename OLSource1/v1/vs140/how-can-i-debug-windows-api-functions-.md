---
title: "How Can I Debug Windows API Functions?"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.api"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "debugging [C++], Windows API functions"
  - "NT symbols and debugging Windows API functions"
  - "Windows API functions, debugging"
  - "Windows API, debugging API functions"
  - "APIs, debugging"
ms.assetid: 7c126f57-62ab-4d94-9805-632d696ba1f0
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How Can I Debug Windows API Functions?
If you want to debug a Windows API function that has NT symbols loaded, you must do the following.  
  
### To set a breakpoint on a Windows API function with NT symbols loaded  
  
-   Enter the function name together with the name of the DLL where the function resides. In 32-bit code, use the decorated form of the function name. To set a breakpoint on **MessageBeep**, for example, you must enter the following.  
  
    ```  
    {,,USER32.DLL}_MessageBeep@4  
    ```  
  
     To obtain the decorated name, see [Viewing Decorated Names](assetId:///f79e2717-a4db-4d12-a689-69830cce2be0).  
  
## See Also  
 [Debugging Native Code FAQs](../vs140/debugging-native-code-faqs.md)   
 [Debugging Native Code](../vs140/debugging-native-code.md)