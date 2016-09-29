---
title: "ON_OLEVERB"
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
  - "ON_OLEVERB"
  - "AFXOLE/ON_OLEVERB"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_OLEVERB macro"
ms.assetid: 9e742a83-4a0a-4368-9c26-7b18a08aedfd
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_OLEVERB
This macro defines a message map entry that maps a custom verb to a specific member function of your control.  
  
## Syntax  
  
```  
  
ON_OLEVERB(  
idsVerbName  
,   
memberFxn )  
```  
  
#### Parameters  
 *idsVerbName*  
 The string resource ID of the verb's name.  
  
 `memberFxn`  
 The function called by the framework when the verb is invoked.  
  
## Remarks  
 The resource editor can be used to create custom verb names that are added to your string table.  
  
 The function prototype for `memberFxn` is:  
  
 `BOOL memberFxn(`  
  
 `LPMSG`  `lpMsg` `,`  
  
 `HWND`  `hWndParent` `,`  
  
 `LPCRECT`  `lpRect`  
  
 `);`  
  
 The values of the `lpMsg`, `hWndParent`, and `lpRect` parameters are taken from the corresponding parameters of the **IOleObject::DoVerb** member function.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [ON_STDOLEVERB](../VS_csharp/on_stdoleverb.md)