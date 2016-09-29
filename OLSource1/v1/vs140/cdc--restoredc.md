---
title: "CDC::RestoreDC"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CDC.RestoreDC"
  - "CDC::RestoreDC"
  - "RestoreDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, device context functions"
  - "RestoreDC method"
ms.assetid: fd8aaceb-712b-4d57-8363-be7586a22cae
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::RestoreDC
Restores the device context to the previous state identified by `nSavedDC`.  
  
## Syntax  
  
```  
  
      virtual BOOL RestoreDC(  
   int nSavedDC   
);  
```  
  
#### Parameters  
 `nSavedDC`  
 Specifies the device context to be restored. It can be a value returned by a previous `SaveDC` function call. If `nSavedDC` is –1, the most recently saved device context is restored.  
  
## Return Value  
 Nonzero if the specified context was restored; otherwise 0.  
  
## Remarks  
 `RestoreDC` restores the device context by popping state information off a stack created by earlier calls to the `SaveDC` member function.  
  
 The stack can contain the state information for several device contexts. If the context specified by `nSavedDC` is not at the top of the stack, `RestoreDC` deletes all state information between the device context specified by `nSavedDC` and the top of the stack. The deleted information is lost.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SaveDC](../vs140/cdc--savedc.md)   
 [RestoreDC](http://msdn.microsoft.com/library/windows/desktop/dd162929)