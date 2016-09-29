---
title: "AfxOleUnlockApp"
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
  - "AFXWIN/AfxOleUnlockApp"
  - "AfxOleUnlockApp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxOleUnlockApp function"
  - "application control"
ms.assetid: 17ef1bb2-c355-4c2e-bdd8-a85cefcda4cf
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxOleUnlockApp
Decrements the framework's count of active objects in the application.  
  
## Syntax  
  
```  
  
void AFXAPI AfxOleUnlockApp( );  
```  
  
## Remarks  
 See `AfxOleLockApp` for further information.  
  
 When the number of active objects reaches zero, **AfxOleOnReleaseAllObjects** is called.  
  
## Example  
 See the example for [AfxOleLockApp](../VS_csharp/afxolelockapp.md).  
  
## Requirements  
 **Header:** <afxdisp.h>  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [AfxOleLockApp](../VS_csharp/afxolelockapp.md)   
 [CCmdTarget::OnFinalRelease](../Topic/CCmdTarget::OnFinalRelease.md)