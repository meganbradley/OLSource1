---
title: "CAsyncMonikerFile::CAsyncMonikerFile"
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
  - CAsyncMonikerFile.CAsyncMonikerFile
  - CAsyncMonikerFile::CAsyncMonikerFile
dev_langs: 
  - C++
helpviewer_keywords: 
  - CAsyncMonikerFile class, constructor
ms.assetid: 03870e69-7a2e-41c9-87e1-6b8622e64826
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAsyncMonikerFile::CAsyncMonikerFile
Constructs a `CAsyncMonikerFile` object.  
  
## Syntax  
  
```  
  
CAsyncMonikerFile( );  
```  
  
## Remarks  
 It does not create the `IBindHost` interface. `IBindHost` is used only if you provide it in the **Open** member function.  
  
 For a description of the `IBindHost` interface, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [CAsyncMonikerFile Class](../vs140/casyncmonikerfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataPathProperty Class](../vs140/cdatapathproperty-class.md)   
 [CAsyncMonikerFile::Open](../vs140/casyncmonikerfile--open.md)