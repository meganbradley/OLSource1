---
title: "ON_STDOLEVERB"
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
  - "ON_STDOLEVERB"
  - "AFXOLE/ON_STDOLEVERB"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_STDOLEVERB macro"
ms.assetid: 7e5019b8-8ef6-46ec-9db6-56d610333e10
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_STDOLEVERB
Use this macro to override the default behavior of a standard verb.  
  
## Syntax  
  
```  
  
ON_STDOLEVERB(  
iVerb  
,   
memberFxn )  
```  
  
#### Parameters  
 `iVerb`  
 The standard verb index for the verb being overridden.  
  
 `memberFxn`  
 The function called by the framework when the verb is invoked.  
  
## Remarks  
 The standard verb index is of the form **OLEIVERB_**, followed by an action. `OLEIVERB_SHOW`, `OLEIVERB_HIDE`, and `OLEIVERB_UIACTIVATE` are some examples of standard verbs.  
  
 See [ON_OLEVERB](../vs140/on_oleverb.md) for a description of the function prototype to be used as the `memberFxn` parameter.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_OLEVERB](../vs140/on_oleverb.md)