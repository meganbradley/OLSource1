---
title: "Specifying DLLs to Delay Load"
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
  - "DELAYLOAD linker option"
  - "delayed loading of DLLs"
  - "delayed loading of DLLs, specifying"
  - "/DELAYLOAD linker option"
ms.assetid: 94cbecfe-7a42-40d1-a618-9f2786bac0d8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Specifying DLLs to Delay Load
You can specify which DLLs to delay load with the [/delayload](../vs140/-delayload--delay-load-import-.md):<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> linker option. If you do not plan to use your own version of a helper function, you must also link your program with delayimp.lib (for desktop applications) or dloadhelper.lib (for store apps).  
  
 The following is a simple example of delay loading a DLL:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Build the DEBUG version of the project. Step through the code using the debugger and you will notice that user32.dll is loaded only when you make the call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## See Also  
 [Linker Support for Delay-Loaded DLLs](../vs140/linker-support-for-delay-loaded-dlls.md)