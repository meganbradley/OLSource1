---
title: "Automation in a DLL"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DLLs [C++], Automation"
  - "Automation [C++], DLLs"
ms.assetid: 2728ecd1-14e2-4ae0-a946-e749e11dbb74
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Automation in a DLL
When you choose the Automation option in the MFC DLL Wizard, the wizard provides you with the following:  
  
-   A starter object description language (.ODL) file  
  
-   An include directive in the STDAFX.h file for Afxole.h  
  
-   An implementation of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> function, which calls the **AfxDllGetClassObject** function  
  
-   An implementation of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function, which calls the **AfxDllCanUnloadNow** function  
  
-   An implementation of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function, which calls the [COleObjectFactory::UpdateRegistryAll](../vs140/coleobjectfactory--updateregistryall.md) function  
  
## What do you want to know more about?  
  
-   [Automation Servers](../vs140/automation-servers.md)  
  
## See Also  
 [DLLs in Visual C++](../vs140/dlls-in-visual-c--.md)