---
title: "METHOD_PROLOGUE"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - METHOD_PROLOGUE
  - AFXWIN/METHOD_PROLOGUE
dev_langs: 
  - C++
helpviewer_keywords: 
  - exported interfaces and global state
  - global state
  - METHOD_PROLOGUE macro
ms.assetid: e94c4939-64ea-42de-a501-55594c952828
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# METHOD_PROLOGUE
Maintains the proper global state when calling methods of an exported interface.  
  
## Syntax  
  
```  
  
METHOD_PROLOGUE(  
theClass  
,   
localClass )  
```  
  
#### Parameters  
 `theClass`  
 Specifies the name of the class whose interface map is being implemented.  
  
 *localClass*  
 Specifies the name of the local class that implements the interface map.  
  
## Remarks  
 Typically, member functions of interfaces implemented by `CCmdTarget`-derived objects already use this macro to provide automatic initialization of the `pThis` pointer. For example:  
  
 [!code[NVC_MFCConnectionPoints#11](../vs140/codesnippet/CPP/method_prologue_1.h)]
  
  
 [!code[NVC_MFCConnectionPoints#5](../vs140/codesnippet/CPP/method_prologue_2.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [TN038: MFC/OLE IUnknown Implementation](../vs140/tn038--mfc-ole-iunknown-implementation.md)   
 [Creating New Documents, Windows, and Views](../vs140/creating-new-documents--windows--and-views.md)