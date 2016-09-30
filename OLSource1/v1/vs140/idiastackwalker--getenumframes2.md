---
title: "IDiaStackWalker::getEnumFrames2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackWalker2::getEnumFrames2 method"
ms.assetid: 73196d3f-112c-4b3a-997b-7c6b815d4afc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackWalker::getEnumFrames2
Retrieves a stack frame enumerator for a specific platform type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A value from the [CV_CPU_TYPE_e Enumeration](../vs140/cv_cpu_type_e.md) enumeration, specifying the platform type.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The helper [IDiaStackWalkHelper](../vs140/idiastackwalkhelper.md) object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaEnumStackFrames](../vs140/idiaenumstackframes.md) object containing a list of [IDiaStackFrame](../vs140/idiastackframe.md) objects.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 To obtain a stack frame list for just the x86 platform, call the [IDiaStackWalker::getEnumFrames](../vs140/idiastackwalker--getenumframes.md) method.  
  
## See Also  
 [IDiaStackWalker](../vs140/idiastackwalker.md)   
 [CV_CPU_TYPE_e Enumeration](../vs140/cv_cpu_type_e.md)   
 [IDiaStackWalkHelper](../vs140/idiastackwalkhelper.md)   
 [IDiaStackFrame](../vs140/idiastackframe.md)   
 [IDiaStackWalker::getEnumFrames](../vs140/idiastackwalker--getenumframes.md)