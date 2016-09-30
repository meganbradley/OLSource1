---
title: "AfxOleUnregisterTypeLib"
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
  - "AfxOleUnregisterTypeLib"
  - "AFXDISP/AfxOleUnregisterTypeLib"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxOleUnregisterTypeLib function"
ms.assetid: 21daba2a-69ce-4124-be3c-d4eb9aca97f6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxOleUnregisterTypeLib
Call this function to remove the type library entry from the Windows registration database.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The unique ID of the type library.  
  
## Return Value  
 Nonzero if the type library was successfully unregistered; otherwise 0.  
  
## Example  
 [!code[NVC_MFCAxCtl#13](../vs140/codesnippet/CPP/afxoleunregistertypelib_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxOleUnregisterClass](../vs140/afxoleunregisterclass.md)   
 [AfxOleRegisterTypeLib](../vs140/afxoleregistertypelib.md)