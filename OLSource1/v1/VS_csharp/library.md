---
title: "LIBRARY"
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
  - "LIBRARY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LIBRARY .def file statement"
ms.assetid: 1d7ccc92-e088-4ef7-9ef0-25c3862cc051
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LIBRARY
Tells LINK to create a DLL. At the same time, LINK creates an import library, unless an .exp file is used in the build.  
  
```  
LIBRARY [library][BASE=address]  
```  
  
## Remarks  
 The *library* argument specifies the name of the DLL. You can also use the [/OUT](../VS_csharp/-out--output-file-name-.md) linker option to specify the DLL's output name.  
  
 The BASE=*address* argument sets the base address that the operating system uses to load the DLL. This argument overrides the default DLL location of 0x10000000. See the description of the [/BASE](../VS_csharp/-base--base-address-.md) option for details about base addresses.  
  
 Remember to use the [/DLL](../VS_csharp/-dll--build-a-dll-.md) linker option when you build a DLL.  
  
## See Also  
 [Rules for Module-Definition Statements](../VS_csharp/rules-for-module-definition-statements.md)