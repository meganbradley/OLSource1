---
title: "Setting Up a Static Link to the Registrar Code (C++ Only)"
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
  - "statically linking to ATL Registrar code"
  - "linking [C++], to ATL Registrar code"
ms.assetid: 835f5885-87a6-48fa-91e6-60988ee65538
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Setting Up a Static Link to the Registrar Code (C++ Only)
C++ clients can create a static link to the Registrar's code. Static linking of the Registrar's parser adds approximately 5K to a release build.  
  
 The simplest way to set up static linking assumes you have specified [DECLARE_REGISTRY_RESOURCEID](../vs140/declare_registry_resourceid.md) in your object's declaration. (This is the default specification used by the ATL.)  
  
### To create a static link using DECLARE_REGISTRY_RESOURCEID  
  
1.  Specify [/D](../vs140/-d--preprocessor-definitions-.md)<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> instead of /D**_ATL_DLL**.  
  
2.  Recompile.  
  
## See Also  
 [Registry Component (Registrar)](../vs140/atl-registry-component--registrar-.md)